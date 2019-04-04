using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _003_tcpclient {
    class Program {
        static void Main(string[] args) {
            //当我们创建tcpclient对象的时候，就会跟server去建立连接
            TcpClient client = new TcpClient("192.168.0.112",7788);

            NetworkStream stream = client.GetStream();//通过网络流进行数据的交换
            //read用来读取数据，write用来写入数据其实就是发送数据
            //利用一个死循环，重复向服务器端发送数据
            while (true)
            {
                string message = Console.ReadLine();
                byte[] data = Encoding.UTF8.GetBytes(message);
                stream.Write(data, 0, data.Length);
            }
            
            stream.Close();
            client.Close();
            Console.ReadKey();
        }
    }
}
