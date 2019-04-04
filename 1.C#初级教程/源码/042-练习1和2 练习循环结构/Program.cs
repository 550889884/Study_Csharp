using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _042_练习1和2_练习循环结构 {
    class Program {
        static void Main(string[] args) {
            //for (int i = 100; i < 1000; i++)
            //{
            //    int ge = i%10;
            //    int shi = (i/10)%10;
            //    int bai = i/100;
            //    int res = ge*ge*ge + shi*shi*shi + bai*bai*bai;
            //    if (res == i)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            int sum = 364;//表示可以和多少可乐
            int numEmpty = sum;//表示现在有多少个空的瓶子
            while (numEmpty>=3)
            {
                sum += numEmpty/3;
                int newCount = numEmpty/3;//表示可以兑换多少新的可乐
                int remainEmpty = numEmpty%3;//表示剩余几个瓶子没有兑换
                numEmpty = newCount + remainEmpty;//表示兑换之后 还有多少个空的瓶子 
            }
            Console.WriteLine("我们一共喝了"+sum+"瓶可乐，剩余的空瓶子个数是"+numEmpty);

            Console.ReadKey();
        }
    }
}
