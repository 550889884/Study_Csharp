using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_练习一和二 {
    class Program {
        static void Main(string[] args)
        {
            //int hp;
            //float x, y, z;
            //float speed = 12;
            string str1 = Console.ReadLine();
            int num1 = Convert.ToInt32(str1);
            string str2 = Console.ReadLine();
            int num2 = Convert.ToInt32(str2);
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine(num1+":"+num2);
            Console.ReadKey();
        }
    }
}
