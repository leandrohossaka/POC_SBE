using Org.SbeTool.Sbe.Dll;
using SBEReflection.Classes;
using SBEReflection.Loaders;
using System;
using System.Reflection;
using System.Text;

namespace SBEReflection
{
    public class SbeReflectionWrapper
    {
        string _SBEFile;
        readonly Assembly _Assembly;
        const string _Header = "MessageHeader";

        public SbeReflectionWrapper(String SbeFile)
        {
            _SBEFile = SbeFile;
            try
            {
                _Assembly = Assembly.LoadFile(_SBEFile);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public byte[] EncodeSBEMessage(SbeMessage Message)
        {
            var byteBuffer = new byte[4096];
            var directBuffer = new DirectBuffer(byteBuffer);
            int bufferOffset = 0;

            Type MessageHeaderType = ReflectionHelper.GetType(_Assembly, _Header);
            var MessageHeaderObj = ReflectionHelper.GetObjectByType(_Assembly, _Header);

            Type MessageBodyType = ReflectionHelper.GetType(_Assembly, Message.Name);
            var MessageBodyObj = ReflectionHelper.GetObjectByType(_Assembly, Message.Name);

            FieldInfo schemaVersion = ReflectionHelper.GetFieldByName(_Assembly, Message.Name, "SchemaVersion");

            //WRAP
            MessageHeaderType.InvokeMember("Wrap", BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.Public,
                null, MessageHeaderObj, new object[] { directBuffer, bufferOffset, schemaVersion.GetValue(MessageBodyObj) });

            #region SET MESSAGE HEADER FIELDS
            //BLOCK LENGTH
            PropertyInfo blockLengthHeader = ReflectionHelper.GetPropertyByName(_Assembly, _Header, "BlockLength");
            FieldInfo blockLengthBody = ReflectionHelper.GetFieldByName(_Assembly, Message.Name, "BlockLength");
            blockLengthHeader.SetValue(MessageHeaderObj, blockLengthBody.GetValue(MessageBodyObj));

            //SCHEMAID
            PropertyInfo schemaIDHeader = ReflectionHelper.GetPropertyByName(_Assembly, _Header, "SchemaId");
            FieldInfo schemaIDBody = ReflectionHelper.GetFieldByName(_Assembly, Message.Name, "SchemaId");
            schemaIDHeader.SetValue(MessageHeaderObj, schemaIDBody.GetValue(MessageBodyObj));

            //TEMPLATEID
            PropertyInfo templateIdHeader = ReflectionHelper.GetPropertyByName(_Assembly, _Header, "TemplateId");
            templateIdHeader.SetValue(MessageHeaderObj, Convert.ChangeType(Message.Id, templateIdHeader.PropertyType));

            //VERSION
            PropertyInfo versionHeader = ReflectionHelper.GetPropertyByName(_Assembly, _Header, "Version");
            FieldInfo schemaVersionBody = ReflectionHelper.GetFieldByName(_Assembly, Message.Name, "SchemaVersion");
            versionHeader.SetValue(MessageHeaderObj, schemaVersionBody.GetValue(MessageBodyObj));
            #endregion

            FieldInfo size = ReflectionHelper.GetFieldByName(_Assembly, _Header, "Size");
            bufferOffset += int.Parse(size.GetValue(MessageHeaderObj).ToString());

            MessageBodyType.InvokeMember("WrapForEncode", BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.Public,
              null, MessageBodyObj, new object[] { directBuffer, bufferOffset });

            foreach (SbeField field in Message.Fields)
            {
                ReflectionHelper.SetField(_Assembly, field, Message.Name, MessageBodyObj);
            }

            PropertyInfo sizeBody = ReflectionHelper.GetPropertyByName(_Assembly, Message.Name, "Size");
            int BodyLength = int.Parse(sizeBody.GetValue(MessageBodyObj).ToString());
            var tempBuffer = new byte[BodyLength];
            directBuffer.GetBytes(0, tempBuffer, 0, BodyLength);
            return tempBuffer;
        }

        public String DecodeSBEMessage(byte[] MessageBytes)
        {
            StringBuilder sb = new StringBuilder();
            var directBuffer = new DirectBuffer(MessageBytes);
            int bufferOffset = 0;
            const short SchemaVersion = 0;

            Type MessageHeaderType = ReflectionHelper.GetType(_Assembly, _Header);
            var MessageHeaderObj = ReflectionHelper.GetObjectByType(_Assembly, _Header);

            //WRAP
            MessageHeaderType.InvokeMember("Wrap", BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.Public,
                null, MessageHeaderObj, new object[] { directBuffer, bufferOffset, SchemaVersion });

            PropertyInfo pi = ReflectionHelper.GetPropertyByName(_Assembly, _Header, "TemplateId");
            string templateId = pi.GetValue(MessageHeaderObj).ToString().Trim();

            Type MessageBodyType = ReflectionHelper.GetMessageTypeByTemplateId(_Assembly, templateId);
            if (MessageBodyType == null)
                throw new Exception(String.Format("TemplateID = {0} not found in the binary!", templateId));

            SbeMessage Message = SbeLoader.LoadMessageById(templateId);
            if (Message == null)
                throw new Exception(String.Format("TemplateID = {0} not found in the protocol!", templateId));

            PropertyInfo blockLength = ReflectionHelper.GetPropertyByName(_Assembly, _Header, "blockLength");
            PropertyInfo schemaId = ReflectionHelper.GetPropertyByName(_Assembly, _Header, "schemaId");
            PropertyInfo version = ReflectionHelper.GetPropertyByName(_Assembly, _Header, "version");

            sb.AppendLine(CrackHelper.CreateLine("Header", "BlockLength", blockLength.GetValue(MessageHeaderObj).ToString().Trim()));
            sb.AppendLine(CrackHelper.CreateLine("Header", "TemplateID", String.Format("{0} ({1})", templateId, Message.Name)));
            sb.AppendLine(CrackHelper.CreateLine("Header", "SchemaId", schemaId.GetValue(MessageHeaderObj).ToString().Trim()));
            sb.AppendLine(CrackHelper.CreateLine("Header", "Version", version.GetValue(MessageHeaderObj).ToString().Trim()));

            var MessageBodyObj = ReflectionHelper.GetObjectByType(_Assembly, MessageBodyType.FullName);
            FieldInfo size = ReflectionHelper.GetFieldByName(_Assembly, _Header, "Size");
            bufferOffset += int.Parse(size.GetValue(MessageHeaderObj).ToString());

            FieldInfo actingBlockLength = ReflectionHelper.GetFieldByName(_Assembly, MessageBodyType.Name, "BlockLength");
            FieldInfo actingVersion = ReflectionHelper.GetFieldByName(_Assembly, MessageBodyType.Name, "Version");

            MessageBodyType.InvokeMember("WrapForDecode", BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.Public,
              null, MessageBodyObj, new object[] {
                  directBuffer,
                  bufferOffset,
                  int.Parse(actingBlockLength.GetValue(MessageHeaderObj).ToString()),
                  int.Parse(actingVersion.GetValue(MessageHeaderObj).ToString())
              });

            Message.FillFields(_Assembly, MessageBodyObj);
            sb.Append(Message.Crack());
            return sb.ToString();
        }
    }
}
