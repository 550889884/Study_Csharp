using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _049_函数的定义和使用_案例学习 {
    class Program {
        static int[] GetDivisor(int number)
        {
            int count = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number%i == 0)
                {
                    count++;
                }
            }
            int[] array = new int[count];
            int index = 0;
            for (int i = 1; i <= number; i++) {
                if (number % i == 0)
                {
                    array[index] = i;
                    index++;
                }
            }
            return array;
        }

        static int Max(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            //int num = Convert.ToInt32(Console.ReadLine());
            //int[] array = GetDivisor(num);
            //foreach (int temp in array)
            //{
            //    Console.Write(temp+" ");
            //}

            int[] array = {234, 4, 5, 435, 35, 3, 53, 5, 345, 35, 2342343, 45};
            Console.WriteLine( Max(array) );
            Console.ReadKey();
        }
    }
}
