using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ImportObjClient
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpClient client = new TcpClient();

            IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 3939);
            client.Connect(serverEndPoint);

            NetworkStream tcpStream = client.GetStream();
            byte[] sendBytes = Encoding.UTF8.GetBytes("Hello, UE");
            tcpStream.Write(sendBytes, 0, sendBytes.Length);

            tcpStream.Close();
            client.Close();
        }
    }
}
