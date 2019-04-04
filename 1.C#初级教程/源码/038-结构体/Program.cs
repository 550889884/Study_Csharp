using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _038_结构体 {
    //我们可以把结构体当成，几个类型组成了一个新的类型
    //比如下面的这个就是使用了3个float类型的变量，来表示一个坐标类型
    struct Position
    {
        public float x;
        public float y;
        public float z;
    }

    enum Direction
    {
        West,
        North,
        East,
        South
    }

    struct Path
    {
        public float distance;
        public Direction dir;
    }
    class Program {
        static void Main(string[] args)
        {
            //通过三个float类型的变量来表示一个敌人的坐标
            //float enemy1X = 34;
            //float enemy1Y = 1;
            //float enemy1Z = 34;


            //float enemy2X = 34;
            //float enemy2Y = 1;
            //float enemy2Z = 34;

            //当使用结构体声明变量的时候，相当于使用结构体中所有的变量去声明
            //Position enemy1Position;
            //enemy1Position.x = 34;//可以通过.加上属性名来访问结构体中指定的变量
            ////使用结构体让程序变得更清晰
            //Position enemy2Position;

            Path path1;
            path1.dir = Direction.East;
            path1.distance = 1000;
        }
    }
}
