using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_布尔运算符 {
    class Program {
        static void Main(string[] args)
        {
            int num1 = 34;
            int num2 = 67;
            bool res1 = num1 == num2;//false
            bool res2 = num1 != num2;//true
            bool res3 = num1 < num2;//true
            bool res4 = num1 > num2;//false
            bool res5 = num1 <= num2;//true;
            bool res6 = num1 >= num2;//false
            Console.WriteLine(res1);
            Console.WriteLine(res2);
            Console.WriteLine(res3);
            Console.WriteLine(res4);
            Console.WriteLine(res5);
            Console.WriteLine(res6);
            Console.ReadKey();
        }
    }
}
