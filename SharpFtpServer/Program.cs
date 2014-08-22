using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace SharpFtpServer
{
    class Program
    {
        static void Main(string[] args)
        {
            var ip = IPAddress.Parse("127.0.0.1");
            using (FtpServer server = new FtpServer(ip, 21))
            {
                server.Start();

                Console.WriteLine("Press any key to stop...");
                Console.ReadKey(true);
            }
        }
    }
}
