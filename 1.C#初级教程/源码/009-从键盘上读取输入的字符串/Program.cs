using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_从键盘上读取输入的字符串 {
    class Program {
        static void Main(string[] args)
        {
            //string str  = Console.ReadLine();//用来接收用户输入的一行文本，也叫做一行字符串，按下换行就是回车的时候结束
            //Console.WriteLine(str);

            //string str = "123";
            //int num = Convert.ToInt32(str);//这个方法可以把一个整数的字符串转化成整数 
            //num++;
            //Console.WriteLine(num);

            //string str = Console.ReadLine();
            //int num = Convert.ToInt32(str);
            //Console.WriteLine(num);

            string str = Console.ReadLine();
            double num = Convert.ToDouble(str);//这个可以把用户输入的小数的字符串转化成double浮点类型
            Console.WriteLine(num);

            Console.ReadKey();
        }
    }
}
