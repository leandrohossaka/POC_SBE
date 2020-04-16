using Org.SbeTool.Sbe.Dll;
using System;
using System.Reflection;

namespace SBEReflection
{
    class Program
    {
        static Assembly assembly;
        const string _sbe_file = @"C:\Users\Akio\source\repos\POC_SBE\fixp-entrypoint-messages-1.2\bin\Debug\fixp-entrypoint-messages-1.2.dll";
        static void Main(string[] args)
        {
            assembly = Assembly.LoadFile(_sbe_file);
            GenerateNewOrderSingle();
            Console.ReadLine();
        }

        static Type GetType(string TypeName)
        {
            foreach (System.Type t in assembly.GetTypes())
            {
                if (t.FullName.Contains(TypeName))
                {
                    return t;
                }
            }
            return null;
        }

        static object GetObjectByType(string TypeName)
        {
            Type type = GetType(TypeName);
            if (type != null)
                return Activator.CreateInstance(type);
            return null;
        }

        static PropertyInfo GetPropertyByName(string TypeName, string Property)
        {
            Type type = GetType(TypeName);
            if (type != null)
            {
                PropertyInfo[] properties = type.GetProperties();
                foreach (PropertyInfo pi in properties)
                {
                    if (pi.Name.Contains(Property))
                        return pi;
                }
            }
            return null;
        }

        static FieldInfo GetFieldByName(string TypeName, string Field)
        {
            Type type = GetType(TypeName);
            if (type != null)
            {
                FieldInfo[] fields = type.GetFields();
                foreach (FieldInfo fi in fields)
                {
                    if (fi.Name.Contains(Field))
                        return fi;
                }
            }
            return null;
        }

        static byte[] GenerateNewOrderSingle()
        {
            var byteBuffer = new byte[4096];
            var directBuffer = new DirectBuffer(byteBuffer);
            int bufferOffset = 0;

            Type MessageHeaderType = GetType("MessageHeader");
            var MessageHeaderObj = GetObjectByType("MessageHeader");

            Type SimpleNewOrderType = GetType("SimpleNewOrder");
            var SimpleNewOrderObject = GetObjectByType("SimpleNewOrder");

            FieldInfo schemaVersion = GetFieldByName("SimpleNewOrder", "SchemaVersion");

            MessageHeaderType.InvokeMember("Wrap", BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.Public,
                null, MessageHeaderObj, new object[] { directBuffer, bufferOffset, schemaVersion.GetValue(SimpleNewOrderObject) });

            FieldInfo size = GetFieldByName("MessageHeader", "Size");
            bufferOffset += int.Parse(size.GetValue(MessageHeaderObj).ToString());

            SimpleNewOrderType.InvokeMember("WrapForEncode", BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.Public,
                null, SimpleNewOrderObject, new object[] { directBuffer, bufferOffset });

            PropertyInfo clOrdId = GetPropertyByName("SimpleNewOrder", "ClOrdID");
            clOrdId.SetValue(SimpleNewOrderObject, 1234567890);



            FieldInfo sizeSimpleNewOrder = GetFieldByName("SimpleNewOrder", "Size");


            int SimpleNewOrderLength = int.Parse(sizeSimpleNewOrder.GetValue(SimpleNewOrderObject).ToString()); //NewOrderSingleExample.Encode(sno, directBuffer, bufferOffset);
            var byteBuffer2 = new byte[SimpleNewOrderLength];
            directBuffer.GetBytes(0, byteBuffer2, 0, SimpleNewOrderLength);
            return byteBuffer;
        }

        /*public static int Encode(SimpleNewOrder sno, DirectBuffer directBuffer, int bufferOffset)
        {
            // we position the car encoder on the direct buffer, at the correct offset (ie. just after the header)
            sno.ClOrdID = 1234567890;
            sno.Account = 111;
            sno.SecurityID = 48;
            sno.OrderQty = 100;
            sno.MarketSegmentID = 70;
            sno.Side = Side.BUY;
            sno.OrdType = OrdType.LIMIT;
            sno.TimeInForce = TimeInForce.DAY;
            sno.InvestorID = 1;
            byte[] trder = Encoding.GetEncoding(SimpleNewOrder.EnteringTraderCharacterEncoding).GetBytes("1234");
            sno.SetEnteringTrader(trder, 0);
            return sno.Size;
        }*/
    }
}
