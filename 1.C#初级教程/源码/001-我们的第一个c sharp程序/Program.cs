// 这里是注释 下面的是引入命名空间
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//定义命名空间 从{开始，到}结束
namespace _001_我们的第一个c_sharp程序 {
    //定义类
    class Program {
        //定义一个Main方法
        static void Main() {
            //方法体 
            Console.Write("Hello world1!");
            Console.Write("Hello world2!");
            Console.Write("Hello world3!");
            Console.WriteLine("Hello 1");
            Console.WriteLine("Hello 2");
            Console.WriteLine("Hello 3");
            Console.WriteLine("两个数相加{0}+{1}={2}", 3, 34, 34);
            Console.WriteLine("Three integers are {1},{0} and {1}", 3, 5);

            Console.ReadKey();
        }
    }
}
