using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _047_练习11和12_循环练习和字符串处理 {
    class Program {
        static void Main(string[] args)
        {
            //string str = Console.ReadLine();
            //bool isHui = true;
            //for (int i = 0; i < str.Length/2; i++)
            //{
            //    //i str.length-1-i;
            //    if (str[i] != str[str.Length - 1 - i])
            //    {
            //        isHui = false; break;
            //    }
            //}
            //if (isHui)
            //{
            //    Console.WriteLine("是回文串");
            //}
            //else
            //{
            //    Console.WriteLine("不是回文串");
            //}
            string str = Console.ReadLine();
            if (str.Length >= 8 && str.Length <= 16)
            {
                bool isHaveUpper = false;
                bool isHaveLower = false;
                bool isHaveNumber = false;
                bool isHaveSpecial = false;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] >= 'A' && str[i] <= 'Z')
                    {
                        isHaveUpper = true;
                    }
                    if (str[i] >= 'a' && str[i] <= 'z')
                    {
                        isHaveLower = true;
                    }
                    if (str[i] >= '0' && str[i] <= '9')
                    {
                        isHaveNumber = true;
                    }
                    //~,!,@,#,$,%,^;
                    if (str[i] == '~' || str[i] == '!' || str[i] == '@' || str[i] == '#' || str[i] == '$' ||
                        str[i] == '%' || str[i] == '^')
                    {
                        isHaveSpecial = true;
                    }
                }
                int count = 0;
                if (isHaveUpper) count++;
                if (isHaveLower) count++;
                if (isHaveSpecial) count++;
                if (isHaveNumber) count++;
                if (count >= 3)
                {
                    Console.WriteLine("这个是安全密码");
                }
                else {
                    Console.WriteLine("这个密码不安全");
                }
            }
            else
            {
                Console.WriteLine("这个密码不安全 长度不符合规则");
            }
            Console.ReadKey();
        }
    }
}
