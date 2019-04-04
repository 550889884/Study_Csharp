using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_练习_定义变量存储主角的信息 {
    class Program {
        static void Main(string[] args)
        {
            string name = "siki";
            int hp = 100;
            int level = 34;
            float exp = 345.3f;
            long l = 10000000000000l;
            Console.WriteLine("主角的名字是:\t\\\"{0}\" \n血量:{1} \n等级:{2} \n经验值:{3}", name, hp, level, exp);
            Console.ReadKey();
        }
    }
}
