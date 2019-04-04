using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_if语句 {
    class Program {
        static void Main(string[] args)
        {
            //bool var = false;
            //if(var==false)
            //    Console.WriteLine("-------");
            //Console.WriteLine("if语句后面的语句");
            string str = Console.ReadLine();
            int score = Convert.ToInt32(str);
            //if(score>50)
            //    Console.WriteLine("您输入的分数大于50分");
            //if(score<=50)
            //    Console.WriteLine("您输入的分数小于等于50");

            // if else 只能执行其中一个分支，而且肯定会执行其中一个分支
            if (score > 50)
            {
                score++;
                Console.WriteLine("您输入的分数大于50"+score);
            }
            else
            {
                score--;
                Console.WriteLine("您输入的分数小于等于50"+score);
            }
                
            Console.ReadKey();
        }
    }
}
