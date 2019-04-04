using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_练习5和6 {
    class Program {
        static void Main(string[] args) {
            //Console.WriteLine("请输入上底");
            //string str1 = Console.ReadLine();
            //double num1 = Convert.ToDouble(str1);
            //Console.WriteLine("请输入下底");
            //string str2 = Console.ReadLine();
            //double num2 = Convert.ToDouble(str2);
            //Console.WriteLine("请输入梯形的高");
            //string str3 = Console.ReadLine();
            //double num3 = Convert.ToDouble(str3);
            //Console.WriteLine("梯形的面积是：");
            //double res = ((num1 + num2)*num3)/2;
            //Console.WriteLine(res);

            Console.WriteLine("请输入圆的半径");
            string str = Console.ReadLine();
            double n = Convert.ToDouble(str);
            Console.WriteLine("圆的周长是:" + (2 * n * 3.14));
            Console.WriteLine("圆的面积是:" + (n * n * 3.14));

            Console.ReadKey();
        }
    }
}
