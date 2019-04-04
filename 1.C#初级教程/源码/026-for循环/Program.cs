using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _026_for循环 {
    class Program {
        static void Main(string[] args)
        {
            //for (;;)//初始化条件 ，和循环的判断条件都不写的话  就是一个死循环
            //{
                
            //}
            //int index = 1;
            //for (;index<=9;)
            //{
            //    Console.WriteLine(index);
            //    index++;
            //}
            for (int index = 1;index<=9;index++)
            {
                Console.WriteLine(index);
            }
            Console.ReadKey();
        }
    }
}
