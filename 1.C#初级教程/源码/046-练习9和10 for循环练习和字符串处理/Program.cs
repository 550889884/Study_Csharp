using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _046_练习8_9和10_for循环练习和字符串处理 {
    class Program {
        static void Main(string[] args)
        {
            //int[] numArray = {2, 4, 4, 6, 67, 785, 3244};
            //int num = Convert.ToInt32(Console.ReadLine());
            //int[] numNew = new int[numArray.Length+1];
            //int index = 0;
            //bool isInsert = false;
            //for (int i = 0; i < numNew.Length; i++)
            //{
            //    if (i == numArray.Length && isInsert == false)
            //    {
            //        numNew[i] = num;
            //        isInsert = true;
            //        break;
            //    }
            //    if (num <= numArray[index] &&isInsert==false )
            //    {
            //        numNew[i] = num;
            //        isInsert = true;
            //    }
            //    else
            //    {
            //        numNew[i] = numArray[index];
            //        index++;
            //    }
            //}
            //for (int i = 0; i < numNew.Length; i++)
            //{
            //    Console.Write(numNew[i]+" ");
            //}

            //int num = Convert.ToInt32(Console.ReadLine());
            //int count100 = num/100;
            //int remain = num%100;
            //int count50 = remain/50;
            //remain = remain%50;
            //int count10 = remain/10;
            //remain = remain%10;
            //int count5 = remain/5;
            //remain = remain%5;
            //int count2 = remain/2;
            //remain = remain % 2;
            //Console.WriteLine("100的准备" + count100);
            //Console.WriteLine("50的准备" + count50);
            //Console.WriteLine("10的准备" + count10);
            //Console.WriteLine("5的准备" + count5);
            //Console.WriteLine("2的准备" + count2);
            //Console.WriteLine("1的准备" + remain);
            string str = Console.ReadLine();
            bool isRight = true;
            if ((str[0] >= 'a' && str[0] <= 'z') || (str[0] >= 'A' && str[0] <= 'Z') || str[0] == '_' || str[0] == '@')
            {

            }
            else
            {
                isRight = false;
            }
            for (int i = 1; i < str.Length; i++)
            {
                if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z') || str[i] == '_' ||
                    (str[i] >= '0' && str[i] <= '9'))
                {

                }
                else
                {
                    isRight = false;
                }

            }
            if (isRight == false)
            {
                Console.WriteLine("不是合法标识符");
            }
            else
            {
                Console.WriteLine("是合法标识符");
            }
            Console.ReadKey();
        }
    }
}
