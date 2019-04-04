using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_运算符的优先级 {
    class Program {
        static void Main(string[] args)
        {
            int num = 12 + 90;
            int num1 = 12 + 90*2/4%4;//在程序中的表达式中，运算符是有优先级的，先进行优先级高 的运算符的运算
            int num2 = (12 + 90) * 2;//我们可以通过（）来改变运算符的优先级，（）内的运算总是最先执行
            Console.WriteLine(num);
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.ReadKey();
        }
    }
}
