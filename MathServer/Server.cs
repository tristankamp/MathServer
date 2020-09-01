using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace MathServer
{
    class Server
    {
        public void start()
        {
            TcpListener server = new TcpListener(IPAddress.Loopback,3001);
            server.Start();
            while (true)
            {
                TcpClient socket = server.AcceptTcpClient();
                Task.Run(() =>
                {
                    TcpClient tempsocket = socket;
                    DoClient(tempsocket);
                    socket.Close();
                });

            }

            

        }

        public void DoClient(TcpClient socket)
        {
            NetworkStream ns = socket.GetStream();
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            string str = sr.ReadLine();
            string[] splitstr = str.Split('+');
            int firstNumber = int.Parse(splitstr[0]);
            int lastNumber = int.Parse(splitstr[1]);
            int result = firstNumber + lastNumber;
            Console.WriteLine("Resultatet er: " + result);

            string UpperString = str.ToUpper();
            sw.WriteLine(str);
            sw.Flush();
        }
    }
}
