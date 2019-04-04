using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _054_函数的递归调用 {
    class Program {
        static int F(int n)
        {
            if (n == 0) return 2;//这两个是函数终止递归的条件
            if (n == 1) return 3;
            return F(n - 1) + F(n - 2);//函数调用自身 叫做递归调用
        }
        static void Main(string[] args)
        {
            int res = F(40);
            Console.WriteLine(res);
            int res2 = F(2);
            Console.WriteLine(res2);
        }
    }
}
