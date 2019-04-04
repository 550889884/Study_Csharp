using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _033_for循环的嵌套调用 {
    class Program {
        static void Main(string[] args) {
            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = i; j < 10; j++)
            //    {
            //        Console.Write(i+"*"+j+"="+(i*j)+" ");// i = 1 j= 1 2 3 4 5 6 7 8 9 
            //                                                                   //i = 2 j = 2 3 4 5 6 7 8 9
            //    }
            //    Console.WriteLine();
            //}

            //怎么生成随机数
            //Random random = new Random(); //创建一个可以生成随机数的对象
            //int num =random.Next(1, 7);
            //Console.WriteLine(num);
            int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0;
            Random random = new Random(); 
            for (int i = 0; i < 100; i++)
            {
                int num = random.Next(1, 7);
                switch (num)
                {
                    case 1:
                        num1++;
                        break;
                    case 2:
                        num2++;
                        break;
                    case 3:
                        num3++;
                        break;
                    case 4:
                        num4++;
                        break;
                    case 5:
                        num5++;
                        break;
                    case 6:
                        num6++;
                        break;
                }
            }
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num4);
            Console.WriteLine(num5);
            Console.WriteLine(num6);
            Console.ReadKey();
        }
    }
}
