using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _041_字符串处理 {
    class Program {
        static void Main(string[] args)
        {

            string str = "  www. taikr.COM  ";
            //str.Length//可以通过.Length访问到一个字符串的长度
            //for (int i = 0; i < str.Length; i++)
            //{
            //    Console.WriteLine(str[i]);
            //}
            //string res = str.ToLower();//把字符串转化成小写 并返回，对原字符串没有影响
            //string res = str.ToUpper();//把字符串转化成大写 并返回，对原字符串没有影响
            //string res = str.Trim();//去掉字符串前面和后面的空格，对原字符串没有影响
            //string res = str.TrimStart();
            //string res = str.TrimEnd();
            string[] strArray=str.Split('.');//把原字符串按照指定的字符进行拆分 ，得到一个拆分后的字符串数组
            Console.WriteLine(str+"|");
            //Console.WriteLine(res + "|");
            foreach (string temp in strArray)
            {
                Console.WriteLine(temp);
            }
            Console.ReadKey();
        }
    }
}
