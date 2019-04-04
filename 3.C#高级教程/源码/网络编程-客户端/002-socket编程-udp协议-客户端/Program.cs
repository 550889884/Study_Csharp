using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _002_socket编程_udp协议_客户端 {
    class Program {
        static void Main(string[] args) {
            //创建socket
            Socket udpClient = new Socket(AddressFamily.InterNetwork,SocketType.Dgram, ProtocolType.Udp);

            while (true)
            {
                //发送数据
                EndPoint serverPoint = new IPEndPoint(IPAddress.Parse("192.168.0.112"), 7788);
                string message = Console.ReadLine();
                byte[] data = Encoding.UTF8.GetBytes(message);
                udpClient.SendTo(data, serverPoint);
            }


            udpClient.Close();
            Console.ReadKey();
        }
    }
}
