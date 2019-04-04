using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _043_练习3和4_练习for循环和字符串操作 {
    class Program {
        static void Main(string[] args) {
            //Random random = new Random();
            //int number = random.Next(0, 51);
            //Console.WriteLine("我有一个数字，请您猜猜是多少，请您输入一个0-50之间的数");
            //while (true)
            //{
            //    int temp = Convert.ToInt32(Console.ReadLine());
            //    if (temp < number)
            //    {
            //        Console.WriteLine("请猜小了，请继续猜");
            //    }else if (temp > number)
            //    {
            //        Console.WriteLine("请猜大了，请继续猜");
            //    }
            //    else
            //    {
            //        Console.WriteLine("您猜对了，游戏结束");
            //        break;
            //    }
            //}
            string str = Console.ReadLine();
            string tempStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z') { //说明这个字符是一个小写字母
                    int num = str[i];
                    num += 3;
                    char temp = (char)num;//取得字母向后移动三个位置后的字母
                    if (temp > 'z')
                    {
                        temp =(char) (temp - 'z' + 'a' - 1);//如果超出26个字母的范围，就转换到开头'a'
                    }
                    tempStr += temp;
                }else if (str[i] >= 'A' && str[i] <= 'Z')
                {
                    int num = str[i];
                    num += 3;
                    char temp = (char) num; //取得字母向后移动三个位置后的字母
                    if (temp > 'Z') {
                        temp = (char)(temp - 'Z' + 'A' - 1);//如果超出26个字母的范围，就转换到开头'a'
                    }
                    tempStr += temp;
                }
                else
                {
                    tempStr += str[i];
                }
            }
            Console.WriteLine(tempStr);
            Console.ReadKey();
        }
    }
}
