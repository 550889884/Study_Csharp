using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _055_练习5和6_循环练习和函数练习 {
    class Program {
        static int Factorial(int n)
        {
            int res = 1;
            for (int i = 1; i <= n; i++)
            {
                res *= i;
            }
            return res;
        }
        static void Main(string[] args)
        {
            //float height = 100;
            //float distance = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    distance += height;
            //    height /= 2;
            //}
            //Console.WriteLine("经过了"+distance+"米,第10次反弹"+height/2+"米");

            int sum = 0;
            for (int i = 1; i <= 20; i++)
            {
                sum += Factorial(i);
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
