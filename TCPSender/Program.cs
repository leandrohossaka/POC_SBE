using Org.SbeTool.Sbe.Dll;
using Sbe;
using SbeFIX;
using System;
using System.Net.Sockets;
using System.Reflection;

namespace TCPSender
{
    class Program
    {
        static string _Server = "127.0.0.1";
        static Int32 _Port = 13000;
        static Assembly assembly;
        const string _sbe_file = @"C:\Users\Akio\source\repos\POC_SBE\fixp-entrypoint-messages-1.2\bin\Debug\fixp-entrypoint-messages-1.2.dll";

        static void Main(string[] args)
        {
            assembly = Assembly.LoadFile(_sbe_file);

            while (true)
            {
                try
                {
                    Console.WriteLine("ENTER para enviar");
                    Console.ReadLine();
                    using (TcpClient client = new TcpClient(_Server, _Port))
                    {
                        string type = "cross";

                        NetworkStream stream = client.GetStream();

                        switch (type)
                        {
                            case "car":
                                byte[] car = GenerateCar();
                                stream.Write(car, 0, car.Length);
                                Console.WriteLine("Sent: car");
                                break;
                            case "fix":
                                byte[] nos = GenerateNewOrderSingle();
                                stream.Write(nos, 0, nos.Length);
                                Console.WriteLine("Sent: SimpleNewOrder");
                                break;
                            case "cross":
                                byte[] cr = GenerateNewOrderCross();
                                stream.Write(cr, 0, cr.Length);
                                Console.WriteLine("Sent: NewOrderCross");
                                break;
                            case "reflection":
                                byte[] reflection = GenerateByReflection();
                                stream.Write(reflection, 0, reflection.Length);
                                Console.WriteLine("Sent: Reflection");
                                break;
                        }

                        // Close everything.
                        stream.Close();
                        client.Close();
                    }
                }
                catch (ArgumentNullException e)
                {
                    Console.WriteLine("ArgumentNullException: {0}", e);
                }
                catch (SocketException e)
                {
                    Console.WriteLine("SocketException: {0}", e);
                }
            }
        }

        static byte[] GenerateCar()
        {
            // This byte array is used for encoding and decoding, this is what you would send on the wire or save to disk
            var byteBuffer = new byte[4096];
            // You need to "wrap" the array with a DirectBuffer, this class is used by the generated code to read and write efficiently to the underlying byte array
            var directBuffer = new DirectBuffer(byteBuffer);
            int bufferOffset = 0;

            var MessageHeader = new Sbe.MessageHeader();
            var Car = new Car();

            // Before encoding a message we need to create a SBE header which specify what we are going to encode (this will allow the decoder to detect that it's an encoded 'car' object)
            // We will probably simplify this part soon, so the header gets applied automatically, but for now it's manual
            MessageHeader.Wrap(directBuffer, bufferOffset, Car.SchemaVersion); // position the MessageHeader on the DirectBuffer, at the correct position
            MessageHeader.BlockLength = Car.BlockLength; // size that a car takes on the wire
            MessageHeader.SchemaId = Car.SchemaId;
            MessageHeader.TemplateId = Car.TemplateId;   // identifier for the car object (SBE template ID)
            MessageHeader.Version = Car.SchemaVersion; // this can be overriden if we want to support different versions of the car object (advanced functionality)

            // Now that we have encoded the header in the byte array we can encode the car object itself
            bufferOffset += Sbe.MessageHeader.Size;
            int carLength = CarExample.Encode(Car, directBuffer, bufferOffset);

            var byteBuffer2 = new byte[carLength];
            directBuffer.GetBytes(0, byteBuffer2, 0, carLength);
            return byteBuffer2;
        }

        static byte[] GenerateNewOrderSingle()
        {
            // This byte array is used for encoding and decoding, this is what you would send on the wire or save to disk
            var byteBuffer = new byte[4096];
            // You need to "wrap" the array with a DirectBuffer, this class is used by the generated code to read and write efficiently to the underlying byte array
            var directBuffer = new DirectBuffer(byteBuffer);
            int bufferOffset = 0;

            var MessageHeader = new SbeFIX.MessageHeader();
            var sno = new SimpleNewOrder();

            // Before encoding a message we need to create a SBE header which specify what we are going to encode (this will allow the decoder to detect that it's an encoded 'car' object)
            // We will probably simplify this part soon, so the header gets applied automatically, but for now it's manual
            MessageHeader.Wrap(directBuffer, bufferOffset, SimpleNewOrder.SchemaVersion); // position the MessageHeader on the DirectBuffer, at the correct position
            MessageHeader.BlockLength = SimpleNewOrder.BlockLength; // size that a car takes on the wire
            MessageHeader.SchemaId = SimpleNewOrder.SchemaId;
            MessageHeader.TemplateId = SimpleNewOrder.TemplateId;   // identifier for the car object (SBE template ID)
            MessageHeader.Version = SimpleNewOrder.SchemaVersion; // this can be overriden if we want to support different versions of the car object (advanced functionality)

            // Now that we have encoded the header in the byte array we can encode the car object itself
            bufferOffset += SbeFIX.MessageHeader.Size;

            int carLength = NewOrderSingleExample.Encode(sno, directBuffer, bufferOffset);

            var byteBuffer2 = new byte[carLength];
            directBuffer.GetBytes(0, byteBuffer2, 0, carLength);
            return byteBuffer2;
        }

        static byte[] GenerateNewOrderCross()
        {
            // This byte array is used for encoding and decoding, this is what you would send on the wire or save to disk
            var byteBuffer = new byte[4096];
            // You need to "wrap" the array with a DirectBuffer, this class is used by the generated code to read and write efficiently to the underlying byte array
            var directBuffer = new DirectBuffer(byteBuffer);
            int bufferOffset = 0;

            var MessageHeader = new SbeFIX.MessageHeader();
            var sno = new Negotiate();

            // Before encoding a message we need to create a SBE header which specify what we are going to encode (this will allow the decoder to detect that it's an encoded 'car' object)
            // We will probably simplify this part soon, so the header gets applied automatically, but for now it's manual
            MessageHeader.Wrap(directBuffer, bufferOffset, Negotiate.SchemaVersion); // position the MessageHeader on the DirectBuffer, at the correct position
            MessageHeader.BlockLength = Negotiate.BlockLength; // size that a car takes on the wire
            MessageHeader.SchemaId = Negotiate.SchemaId;
            MessageHeader.TemplateId = Negotiate.TemplateId;   // identifier for the car object (SBE template ID)
            MessageHeader.Version = Negotiate.SchemaVersion; // this can be overriden if we want to support different versions of the car object (advanced functionality)

            // Now that we have encoded the header in the byte array we can encode the car object itself
            bufferOffset += SbeFIX.MessageHeader.Size;

            int carLength = NewOrderSingleExample.Encode(sno, directBuffer, bufferOffset);

            var byteBuffer2 = new byte[carLength];
            directBuffer.GetBytes(0, byteBuffer2, 0, carLength);
            return byteBuffer2;
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

        static byte[] GenerateByReflection()
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
            clOrdId.SetValue(SimpleNewOrderObject, (UInt64)1234567890);


            PropertyInfo sizeSimpleNewOrder = GetPropertyByName("SimpleNewOrder", "Size");

            int SimpleNewOrderLength = int.Parse(sizeSimpleNewOrder.GetValue(SimpleNewOrderObject).ToString()); //NewOrderSingleExample.Encode(sno, directBuffer, bufferOffset);
            var byteBuffer2 = new byte[SimpleNewOrderLength];
            directBuffer.GetBytes(0, byteBuffer2, 0, SimpleNewOrderLength);
            return byteBuffer2;
        }
    }
}