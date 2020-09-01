using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace MathRequest
{
    class Client
    {
        public void start()
        {
            TcpClient socket = new TcpClient("localhost", 3001);
            NetworkStream ns = socket.GetStream();
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            sw.WriteLine("420+69");
            sw.Flush();
            string line = sr.ReadLine();
            Console.WriteLine(line);
            Console.ReadLine();

        }
    }
}
