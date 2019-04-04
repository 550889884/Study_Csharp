using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _056_练习7_8_9 {
    struct Student
    {
        public string number;
        public string name;
        public bool isGirl;
        public int score;

        public void Show()
        {
            Console.WriteLine("姓名:"+name+" 学号："+number+" 性别："+(isGirl?"女":"男")+" 程序设计成绩:"+score );
        }
    }
    class Program {
        static int Factorial(int n)
        {
            if (n == 1) return 1;
            return n*Factorial(n - 1);
        }


        static void Main(string[] args) {
            //Console.WriteLine(Factorial(5));
            //Student stu1;
            //stu1.name = "siki";
            //stu1.number = "319483909734";
            //stu1.isGirl = false;
            //stu1.score = 100;
            //stu1.Show();

            double number = Convert.ToDouble(Console.ReadLine());
            //int numberInteger =(int) number/1;
            //double numberDouble = number - numberInteger;
            //if (numberDouble >= 0.5f)
            //{
            //    numberInteger++;
            //}
            //Console.WriteLine(numberInteger);
            int res = (int) (number + 0.5f);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
