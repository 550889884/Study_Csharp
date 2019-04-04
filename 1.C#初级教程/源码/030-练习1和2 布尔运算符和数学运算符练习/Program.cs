using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _030_练习1和2_布尔运算符和数学运算符练习 {
    class Program {
        static void Main(string[] args) {
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //int num3 = Convert.ToInt32(Console.ReadLine());
            //int num4 = Convert.ToInt32(Console.ReadLine());
            //int max, min;
            //if (num1 > num2)
            //{
            //    max = num1;
            //}
            //else
            //{
            //    max = num2;
            //}
            //if (num3 > max)
            //{
            //    max = num3;
            //}
            //if (num4 > max)
            //{
            //    max = num4;
            //}
            //if (num1 > num2)
            //{
            //    min = num2;
            //}
            //else
            //{
            //    min = num1;
            //}
            //if (num3 < min)
            //{
            //    min = num3;
            //}
            //if (num4 < min)
            //{
            //    min = num4;
            //}
            //Console.WriteLine("最大值是："+max+" 最小值是："+min );

            Console.WriteLine("Player enter first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入0-3之间的数字");
            int operation = Convert.ToInt32(Console.ReadLine());
            int res = 0;
            switch (operation)
            {
                case 0:
                    res = num1 + num2;
                    break;
                case 1:
                    res = num1 - num2;
                    break;
                case 2:
                    res = num1*num2;
                    break;
                case 3:
                    res = num1/num2;
                    break;
            }
            Console.WriteLine("The result is :"+res);
            Console.ReadKey();
        }
    }
}
