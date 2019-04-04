using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023_switch语句 {
    class Program {
        static void Main(string[] args)
        {
            int state = 5;
            switch (state)
            {
                case 0:
                    Console.WriteLine("当前是开始界面");
                    break;
                case 1:
                    Console.WriteLine("当时是战斗中");
                    break;
                case 2:
                    Console.WriteLine("游戏暂停");
                    break;
                case 3:
                    Console.WriteLine("游戏胜利");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("游戏失败");
                    break;
                default:
                    Console.WriteLine("当前state超出了游戏状态的取值范围");
                    break;
            }
            Console.ReadKey();
        }
    }
}
