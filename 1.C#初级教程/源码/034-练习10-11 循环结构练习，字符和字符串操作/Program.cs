using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace _034_练习10_11_循环结构练习_字符和字符串操作 {
    class Program {
        static void Main(string[] args) {
            //for (int i = 1; i < 6; i++)
            //{
            //    Console.WriteLine(i*i);
            //}
            //int index = 1;
            //while (index < 6)
            //{
            //    Console.WriteLine(index*index);
            //    index++;
            //}
            //int index = 1;
            //do
            //{
            //    Console.WriteLine(index*index);
            //    index++;
            //} while (index < 6);
            //Console.ReadKey();
            //string str = "werwwDDF";
            //char c = str[0];//我们可以通过字符串[index]这种形式来访问字符串中指定的某个字符，默认字符索引index是从0开始的
            //Console.WriteLine(c);
            //char c = 'z';//每个字符相当于一个整数，字符存取的时候使用这个整数存取的，然后我们的字符可以当成一个整数来用
            //int num = c;
            //Console.WriteLine(num);
            while (true)
            {
                string str = Console.ReadLine();
                bool isAllUpperChar = true;
                for (int i = 0; i < 5; i++) {
                    if (str[i] >= 'A' && str[i] <= 'Z') {

                    } else {
                        isAllUpperChar = false; break;
                    }
                }
                if (isAllUpperChar == false)
                {
                    Console.WriteLine("您输入的5个字母，不全是大写字母，请重新输入");
                }
                else
                {
                    break;
                }
            }
            
            Console.ReadKey();
        }
    }
}
