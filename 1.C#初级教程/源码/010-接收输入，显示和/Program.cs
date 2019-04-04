using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_接收输入_显示和 {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数字");
            string str1 = Console.ReadLine();
            int num1 = Convert.ToInt32(str1);
            Console.WriteLine("请输入第二个数字");
            string str2 = Console.ReadLine();
            int num2 = Convert.ToInt32(str2);
            int sum = num1 + num2;
            Console.WriteLine("您输入的两个数字的和为");
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
