using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _052_函数的重载 {

    class Program {
        static int MaxValue(params int[] array)
        {
            Console.WriteLine("int类型的maxvalue被调用 ");
            int maxValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
            }
            return maxValue;
        }

        static double MaxValue(params double[] array)
        {
            Console.WriteLine("double类型的maxvalue被调用 ");
            double maxValue = array[0];
            for (int i = 1; i < array.Length; i++) {
                if (array[i] > maxValue) {
                    maxValue = array[i];
                }
            }
            return maxValue;
        }
        static void Main(string[] args)
        {
            int res = MaxValue(234, 23, 4);//编译器会根据你传递过来的实参的类型去判定调用哪一个函数
            double res2 = MaxValue(23.34, 234.5, 234.4);
            Console.WriteLine(res);
            Console.WriteLine(res2);
            Console.ReadKey();
        }
    }
}
