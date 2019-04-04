using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_布尔运算 {
    class Program {
        static void Main(string[] args)
        {
            int score = 30;
            bool res = score >= 50;// 在这里>=就是一个比较运算符，用来比较score是否大于等于50，如果是的话返回true，如果不是的话返回false
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
