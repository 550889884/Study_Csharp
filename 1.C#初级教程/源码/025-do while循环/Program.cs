using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _025_do_while循环 {
    class Program {
        static void Main(string[] args)
        {
            //do
            //{
            //    Console.WriteLine("这里是do while的循环体");
            //} while (true);//这个是一个死循环
            int index = 1;
            do
            {
                Console.WriteLine(index);
                index++;
            } while (index <= 9);
            //do while循环会首先执行一次循环体,然后进行条件判断 循环体的执行次数》=1
            //while循环会进行条件判断，然后根据判断的结果去判定是否去执行循环体，循环体的执行次数》=0
            Console.ReadKey();
        }
    }
}
