using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _035_练习12和13_循环练习 {
    class Program {
        static void Main(string[] args)
        {
            //while (true)
            //{
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    if (num > 0) {
            //        for (int i = 1; i <= num; i++) {
            //            Console.Write(i + " ");
            //        }
            //        Console.WriteLine();
            //    } else if (num < 0) {
            //        return;
            //    }
            //}
            for (int i = 1; i < 1001; i++)
            {
                string str = "1";
                int sum = 1;
                for (int j = 2; j < i; j++)
                {
                    if (i%j==0)
                    {
                        str += "+" + j;
                        sum += j;
                    }
                }
                if (sum == i)
                {
                    Console.WriteLine(i+"是完数"+str);
                }
            }
            Console.ReadKey();
        }
    }
}
