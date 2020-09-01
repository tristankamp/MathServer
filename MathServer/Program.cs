using System;
using System.Net.Sockets;

namespace MathServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server();
            server.start();
            Console.ReadLine();
        }
    }
}
