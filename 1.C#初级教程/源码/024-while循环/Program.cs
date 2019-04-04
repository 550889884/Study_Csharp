using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _024_while循环 {
    class Program {
        static void Main(string[] args) {
            //while (true)//死循环  一直执行循环体 根本停不下来
            //{
            //    Console.WriteLine("www.taikr.com");
            //}
            int index = 1;
            while (index<=9)
            {
                Console.WriteLine(index);//1 2  3 4 5 6 7 8 9
                index++;
            }
            Console.ReadKey();
        }
    }
}
