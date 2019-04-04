using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _029_goto和return来跳出循环 {
    class Program {
        static void Main(string[] args) {
            //while (true)
            //{
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    if (num == 0)
            //    {
            //        goto myLabel;
            //    }
            //}
            //myLabel:
            //Console.WriteLine("跳出循环了");

            while (true)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == 0)
                {
                    return;//用来终止方法的，表示方法运行结束，剩余的代码不执行了
                }
            }
            Console.WriteLine("跳出循环了");
            Console.ReadKey();
        }
    }
}
