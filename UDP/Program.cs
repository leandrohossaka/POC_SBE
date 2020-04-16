using System;

namespace UDP
{
    class Program
    {
        static void Main(string[] args)
        {
            UDPSocket s = new UDPSocket();
            Console.WriteLine("Starting server");
            s.Server("127.0.0.1", 27000);

            UDPSocket c = new UDPSocket();
            Console.WriteLine("Starting client");
            c.Client("127.0.0.1", 27000);
            Console.WriteLine("Sending message");
            c.Send("TEST!");

            Console.ReadKey();
        }
    }
}
