using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _048_函数的定义 {
    class Program {
        static void Write()// void 表示空的返回值,就是不需要返回值
        {
            //这里是函数体也叫做方法体，这里可以写0行 ，一行或者多行语句
            Console.WriteLine("Text output from function");
            return;//这个语句用来结束当前函数
        }

        static int Plus(int num1,int num2)//函数定义的时候，参数我们叫做形式参数（形参）,num1跟num2在这里就是形参，形参的值是不确定的
        {
            int sum = num1 + num2;
            return sum;
        }
        static void Main(string[] args) {
            Write();//函数的调用   函数名加上括号 ，括号内写参数
            int num1 = 45;
            int num2 = 90;
            int res1 = Plus(num1, num2);//当调用函数的时候，这里传递的参数就是实际参数（实参）,实参的值会传递给形参做运算
            int res2 = Plus(45, 20);//这里定义了res1和res2来接受方法的返回值
            Console.WriteLine(res1);
            Console.WriteLine(res2);
            Console.ReadKey();
            
        }
    }
}
