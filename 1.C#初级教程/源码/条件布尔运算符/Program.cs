using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 条件布尔运算符 {
    class Program {
        static void Main(string[] args)
        {
            bool var1 = true;
            bool var2 = false;
            //bool res = !var1;//!是取反操作 当var1为true、的时候，返回false，当var1为false的时候，var1返回true
            //bool res1 = var1 & var2;//false;
            //bool res2=var1 | var2;//true;
            //bool res3 = var1 ^ var2;//true;
            //Console.WriteLine(res);
            //Console.WriteLine(res1);
            //Console.WriteLine(res2);
            //Console.WriteLine(res3);
            // && ||
            bool res = var1 && var2;//false;  &&:而且
            bool res2 = var1 || var2;//treu  ||:或
            Console.ReadKey();
        }
    }
}
