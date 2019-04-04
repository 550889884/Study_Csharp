using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _031_练习3和4_for循环练习 {
    class Program {
        static void Main(string[] args)
        {
            //int count = 0;//这个是计数器
            //int sum = 0;//存储和6
            //for (int i = 1; i <= 1000; i++)
            //{
            //    if (i%7 == 0)
            //    {
            //        sum += i;
            //        count++;
            //        Console.WriteLine(i+"可以被7整除");
            //        if (count == 5)
            //        {
            //            Console.WriteLine("这5个的和是："+sum);
            //            sum = 0;//和和计数器从新计算
            //            count = 0;
            //        }
            //    }
            //}
            
            for (int i=1;i<=100;i++)
            {
                int pingfang = i*i;
                double gen = Math.Sqrt(i); // Math.Sqrt()这个方法可以取得一个数字的平方根
                Console.WriteLine("平方为:"+i +" 平方根为："+gen);
            }
            Console.ReadKey();
        }
    }
}
