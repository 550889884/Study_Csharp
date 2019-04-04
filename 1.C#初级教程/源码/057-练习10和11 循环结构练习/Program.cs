using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _057_练习10和11_循环结构练习 {
    class Program {
        static void Main(string[] args)
        {
            //int sum = 0;
            //int k = 0;
            //while (sum<2000) {
            //    k++;
            //    sum += k*k;
            //}
            //Console.WriteLine(k-1);

            for (int i = 0; i <= 100/5; i++)
            {
                for (int j = 0; j <= (100 - i*5)/3; j++)
                {
                    int remainMoney = 100 - 5*i - 3*j;
                    int number = remainMoney*3;
                    if ( (i + j + number) == 100)
                    {
                        Console.WriteLine("公鸡"+i+" 母鸡"+j+" 小鸡"+number);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
