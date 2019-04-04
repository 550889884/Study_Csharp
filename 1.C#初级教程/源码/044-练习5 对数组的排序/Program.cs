using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _044_练习5_对数组的排序 {
    class Program {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] strArray = str.Split(' ');
            int[] numArray = new int[ strArray.Length ];
            for (int i = 0; i < strArray.Length; i++)
            {
                int temp = Convert.ToInt32(strArray[i]);
                numArray[i] = temp;
            }
            //Array.Sort(numArray);//使用CLR给我们提供的方法进行排序（这个方法其实使用了快速排序算法）
            //我们自己使用冒泡排序进行排序
            //for (int j = 1; j <= str.Length-1; j++)//外层for循环用来控制子for循环执行的次数
            //{
            //    //让下面的for循环执行length-1次
            //    for (int i = 0; i < numArray.Length - 1; i++) {
            //        //numArray[i]  numArray[i+1]做比较 把最大的放在后面
            //        if (numArray[i + 1] < numArray[i]) {
            //            int temp = numArray[i];
            //            numArray[i] = numArray[i + 1];
            //            numArray[i + 1] = temp;
            //        }
            //    }
            //}

            //我们自己使用冒泡排序进行排序
            for (int j = 1; j <= str.Length - 1; j++)//外层for循环用来控制子for循环执行的次数
            {
                //让下面的for循环执行length-1次
                for (int i = 0; i < numArray.Length - 1-j+1; i++) {
                    //numArray[i]  numArray[i+1]做比较 把最大的放在后面
                    if (numArray[i + 1] < numArray[i]) {
                        int temp = numArray[i];
                        numArray[i] = numArray[i + 1];
                        numArray[i + 1] = temp;
                    }
                }
            }
           
            for (int i = 0; i < numArray.Length; i++)
            {
                Console.Write(numArray[i] +" " );
            }
            Console.ReadKey();
        }
    }
}
