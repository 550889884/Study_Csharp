using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _036_显示转换和隐式转换 {
    class Program {
        static void Main(string[] args)
        {
            //byte myByte = 123;
            //int myInt = myByte;//把一个小类型的数据复制给大类型的变量的时候，编译器会自动进行类型的转换;
            //myByte = (byte)myInt;//当把一个大类型赋值给一个小类型的变量的时候 ，需要进行显示转换（强制类型转换），就是加上括号，里面写需要转换的类型
            //float myfloat = myInt;
            //myInt = (int)myfloat;
            //char c = 'a';
            //myfloat = c;
            string str = "123.3";
            int num = Convert.ToInt32(str);//当字符串里面存储的是整数的时候，就可以转化成int double类型，否则出现异常
                                                                //当字符串里面是一个小数的时候，就可以转化成double类型
            int mynum = 234234;
            string str2 = Convert.ToString(mynum);//它可以把一个int float double byte类型转换成字符串
            string str3 = mynum + "";//一个int float double类型直接加上一个空的字符串，相当于把这个数字转化成一个字符串 
            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}
