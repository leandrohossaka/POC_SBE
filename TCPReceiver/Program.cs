using Org.SbeTool.Sbe.Dll;
using SbeFIX;
using SBEReflection;
using SBEReflection.Classes;
using SBEReflection.Loaders;
using System;
using System.Net;
using System.Net.Sockets;
using TCPSender;

namespace TCPReceiver
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener server = null;
            try
            {
                // Set the TcpListener on port 13000.
                Int32 port = 13000;
                IPAddress localAddr = IPAddress.Parse("127.0.0.1");

                // TcpListener server = new TcpListener(port);
                server = new TcpListener(localAddr, port);

                // Start listening for client requests.
                server.Start();

                // Buffer for reading data
                Byte[] bytes = new Byte[256];

                // Enter the listening loop.
                while (true)
                {
                    Console.Write("Waiting for a connection... ");

                    // Perform a blocking call to accept requests.
                    // You could also user server.AcceptSocket() here.
                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine("Connected!");


                    // Get a stream object for reading and writing
                    NetworkStream stream = client.GetStream();

                    int i;

                    // Loop to receive all the data sent by the client.
                    while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        var byteBuffer = new byte[4096];
                        // You need to "wrap" the array with a DirectBuffer, this class is used by the generated code to read and write efficiently to the underlying byte array
                        var directBuffer = new DirectBuffer(bytes);
                        int bufferOffset = 0;
                        const short SchemaVersion = 0;

                        string type = "qatsbeengine";
                        switch (type)
                        {
                            #region car
                            case "car":
                                var MessageHeader = new Sbe.MessageHeader();
                                var Car = new Sbe.Car();

                                // position the MessageHeader object at the beginning of the array
                                MessageHeader.Wrap(directBuffer, bufferOffset, SchemaVersion);

                                Console.WriteLine("MessageHeader.BlockLength=" + MessageHeader.BlockLength);
                                Console.WriteLine("MessageHeader.TemplateId=" + MessageHeader.TemplateId);
                                Console.WriteLine("MessageHeader.SchemaId=" + MessageHeader.SchemaId);
                                Console.WriteLine("MessageHeader.Version=" + MessageHeader.Version);

                                // Extract info from the header
                                // In a real app you would use that to lookup the applicable flyweight to decode this type of message based on templateId and version.
                                int actingBlockLength = MessageHeader.BlockLength;
                                int actingVersion = MessageHeader.Version;

                                bufferOffset += Sbe.MessageHeader.Size;
                                // now we decode the message
                                CarExample.Decode(Car, directBuffer, bufferOffset, actingBlockLength, actingVersion);
                                break;
                            #endregion
                            case "fix":
                                var MessageHeaderFix = new SbeFIX.MessageHeader();
                                var sno = new NegotiateResponse();

                                // position the MessageHeader object at the beginning of the array
                                MessageHeaderFix.Wrap(directBuffer, bufferOffset, SchemaVersion);

                                Console.WriteLine("MessageHeader.BlockLength=" + MessageHeaderFix.BlockLength);
                                Console.WriteLine("MessageHeader.TemplateId=" + MessageHeaderFix.TemplateId);
                                Console.WriteLine("MessageHeader.SchemaId=" + MessageHeaderFix.SchemaId);
                                Console.WriteLine("MessageHeader.Version=" + MessageHeaderFix.Version);

                                // Extract info from the header
                                // In a real app you would use that to lookup the applicable flyweight to decode this type of message based on templateId and version.
                                int actingBlockLengthFix = MessageHeaderFix.BlockLength;
                                int actingVersionFix = MessageHeaderFix.Version;

                                bufferOffset += SbeFIX.MessageHeader.Size;
                                 
                                // now we decode the message
                                NewOrderSingleExample.Decode(sno, directBuffer, bufferOffset, actingBlockLengthFix, actingVersionFix);
                                break;
                            case "qatsbeengine":
                                try
                                {
                                    SbeReflectionWrapper _Wrapper = new SBEReflection.SbeReflectionWrapper();
                                    SbeLoader.Load(@"C:\Users\Akio\source\repos\POC_SBE\packages\sbe-tool.1.17.0\tools\fixp-entrypoint-messages-1.2.xml");
                                    Console.WriteLine(_Wrapper.DecodeSBEMessageQATEngine(bytes));
                                }
                                catch(Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                                break;
                            case "reflection":
                                try
                                {
                                    SbeReflectionWrapper _Wrapper = new SBEReflection.SbeReflectionWrapper(@"C:\Users\Akio\source\repos\POC_SBE\fixp-entrypoint-messages-1.2\bin\Debug\fixp-entrypoint-messages-1.2.dll");
                                    SbeLoader.Load(@"C:\Users\Akio\source\repos\POC_SBE\packages\sbe-tool.1.17.0\tools\fixp-entrypoint-messages-1.2.xml");
                                    Console.WriteLine(_Wrapper.DecodeSBEMessage(bytes));
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                                break;

                        }
                    }

                    // Shutdown and end connection
                    client.Close();
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            finally
            {
                // Stop listening for new clients.
                server.Stop();
            }

            Console.WriteLine("\nHit enter to continue...");
            Console.Read();
        }
    }
}
