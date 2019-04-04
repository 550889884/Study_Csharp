 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _039_数组 {
    class Program {
        static void Main(string[] args)
        {
            //第一种 数组的初始化方式
            //int[] scores = {23,43,432,42,34,234,234,2,34} ;//使用这种方式赋值的时候，一定要注意 在数组声明的时候赋值

            //第二种数组创建的方式
            //int[] scores = new int[10];
            //int[] scores;
            //scores = new int[10];

            //int[] scores = new int[10]{3,43,43,242,342,4,234,34,234,5};
            //Console.WriteLine(scores[10]);//当我们访问一个索引不存在的值的时候，会出现异常exception

            //char[] charArray = new char[2]{'a','b'};
            //Console.WriteLine(charArray[1]);

            string[] names = new string[]{"taikr","baidu","google","apple"};
            Console.WriteLine(names[0]);
            Console.ReadKey();
        }
    }
}
