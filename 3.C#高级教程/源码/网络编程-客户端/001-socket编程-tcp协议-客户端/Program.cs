﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _001_socket编程_tcp协议_客户端 {
    class Program {
        static void Main(string[] args) {
            //1,创建socket
            Socket tcpClient = new Socket(AddressFamily.InterNetwork,SocketType.Stream, ProtocolType.Tcp);

            //2,发起建立连接的请求
            IPAddress  ipaddress = IPAddress.Parse("192.168.0.112");//可以把一个字符串的ip地址转化成一个ipaddress的对象
            EndPoint point = new IPEndPoint(ipaddress,7788);
            tcpClient.Connect(point);//通过ip：端口号 定位一个要连接到的服务器端
            byte[] data = new byte[1024];
            int length = tcpClient.Receive(data);//这里传递一个byte数组，实际上这个data数组用来接收数据
            //length返回值表示接收了多少字节的数据
            string message = Encoding.UTF8.GetString(data,0,length);//只把接收到的数据做一个转化
            Console.WriteLine(message);

            //向服务器端发送消息
            string message2 = Console.ReadLine();//读取用户的输入 把输入发送到服务器端
            tcpClient.Send( Encoding.UTF8.GetBytes(message2) );//把字符串转化成字节数组，然后发送到服务器端 

            Console.ReadKey();
        }
    }
}
