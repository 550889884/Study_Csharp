using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _050_参数数组__定义一个参数个数不确定的函数_ {
    class Program {
        static int Sum(int[] array)//如果一个函数定义了参数，那么在调用这个函数的时候，一定要传递对应类型的参数，否则无法调用（编译器编译不通过）
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        static int Plus(params int[] array)//这里定义了一个int类型的参数数组，参数数组和数组参数（上面的）的不同，在于函数的调用，调用参数数组的函数的时候，我们可以传递过来任意多个参数，然后编译器会帮我们自动组拼成一个数组，参数如果是上面的数组参数，那么这个数组我们自己去手动创建
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++) {
                sum += array[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int sum = Sum(new int[] {23, 4, 34, 32, 32, 42, 4});
            Console.WriteLine(sum);
            int sum2 = Plus(23, 4, 5, 5, 5, 32, 423, 42, 43,23,42,3);//参数数组就是帮我们 减少了一个创建数组的过程 
            Console.WriteLine(sum2);
            Console.ReadKey();
        }
    }
}
