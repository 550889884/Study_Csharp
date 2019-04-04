using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _027_循环的终止break {
    class Program {
        static void Main(string[] args)
        {
            //int index = 1;
            //while (true)
            //{
            //    Console.WriteLine(index);
            //    if (index == 9)
            //    {
            //        break;//跳出最近的循环结构，执行下一行代码
            //    }
            //    index++;
            //}

            while (true)
            {
                string str = Console.ReadLine();
                if (str == "0")
                {
                    break;
                }
                else
                {
                    Console.WriteLine(str);
                }
            }

            //Console.ReadKey();
        }
    }
}
