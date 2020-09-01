using System;
using System.Net.Http;

namespace MathRequest
{
    class Program
    {
        static void Main(string[] args)
        {
            Client TheOneClient = new Client();
            TheOneClient.start();
        }
    }
}
