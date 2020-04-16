using SBEReflection.Classes;
using System.Collections.Generic;
using System.Xml;

namespace SBEReflection.Loaders
{
    public static class SbeLoader
    {
        public static List<string> _Messages = new List<string>();
        public static List<SbeEnum> _Enums = new List<SbeEnum>();
        public static List<SbeType> _SimpleTypes = new List<SbeType>();
        public static List<SbeCompositeType> _CompositeTypes = new List<SbeCompositeType>();
        private static XmlDocument xml = new XmlDocument();

        public static void Load(string file)
        {
            XmlReaderSettings settings = new XmlReaderSettings { NameTable = new NameTable(), DtdProcessing = DtdProcessing.Ignore };
            XmlNamespaceManager xmlns = new XmlNamespaceManager(settings.NameTable);
            xmlns.AddNamespace("sbe", "http://fixprotocol.io/2016/sbe");
            XmlParserContext context = new XmlParserContext(null, xmlns, "", XmlSpace.Default);
            XmlReader reader = XmlReader.Create(file, settings, context);
            xml.Load(reader);

            XmlNodeList enums = xml.SelectNodes("//*[local-name()='enum']");
            if (enums.Count > 0)
            {
                foreach (XmlNode node in enums)
                {
                    SbeEnum sbeenum = new SbeEnum(node);
                    _Enums.Add(sbeenum);
                }
            }

            XmlNodeList types = xml.SelectNodes("//*[local-name()='types']/*[local-name()='type']");
            if (types.Count > 0)
            {
                foreach (XmlNode node in types)
                {
                    SbeType type = new SbeType(node);
                    _SimpleTypes.Add(type);
                }
            }

            XmlNodeList composites = xml.SelectNodes("//*[local-name()='composite']");
            if (composites.Count > 0)
            {
                foreach (XmlNode node in composites)
                {
                    SbeCompositeType composite = new SbeCompositeType(node);
                    _CompositeTypes.Add(composite);
                }
            }

            XmlNodeList msgs = xml.SelectNodes("//*[local-name()='message']");
            if (msgs.Count > 0)
            {
                foreach (XmlNode node in msgs)
                {
                    //	<sbe:message name="NegotiateResponse" id="2" description="Negotiate Response message">
                    SbeMessage msg = new SbeMessage(node);
                    _Messages.Add(msg.Name);
                }
            }
        }

        public static SbeMessage LoadMessageByName(string messageName)
        {
            if (_Messages.Find(x => x == messageName) != null)
            {
                XmlNodeList msgs = xml.SelectNodes("//*[local-name()='message']");
                if (msgs.Count > 0)
                {
                    foreach (XmlNode node in msgs)
                    {
                        //	<sbe:message name="NegotiateResponse" id="2" description="Negotiate Response message">
                        SbeMessage msg = new SbeMessage(node);
                        if (msg.Name.ToLower().Equals(messageName.ToLower()))
                            return msg;
                    }
                }
            }
            return null;
        }

        public static SbeMessage LoadMessageById(string id)
        {
            XmlNodeList msgs = xml.SelectNodes("//*[local-name()='message']");
            if (msgs.Count > 0)
            {
                foreach (XmlNode node in msgs)
                {
                    //	<sbe:message name="NegotiateResponse" id="2" description="Negotiate Response message">
                    SbeMessage msg = new SbeMessage(node);
                    if (msg.Id.ToLower().Equals(id))
                        return msg;
                }
            }
            return null;
        }
    }
}
