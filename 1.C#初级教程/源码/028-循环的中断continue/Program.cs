using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _028_循环的中断continue {
    class Program {
        static void Main(string[] args)
        {
            //int index = 1;
            //while (true)
            //{
            //    index++;
            //    if (index == 5)
            //    {
            //        continue;
            //    }
            //    if (index == 10)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(index);//当index==5的时候，使用了continue关键字，那么continue后面的代码不会去执行了，直接会进行循环的条件判断，根据判断结果判定是否执行下一次循环
            //}
            int sum = 0;
            while (true)
            {
                //string str = Console.ReadLine();
                //int num = Convert.ToInt32(str);
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == 0)
                {
                    break;
                }
                if (num%2 == 1)
                {
                    continue;
                }
                sum += num;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
