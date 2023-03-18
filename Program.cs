using System;
using Internal;

namespace hello_world_lesson1
{
    public class Program
    {

        static void Main(string[] args)
        {
            string horizontalX = Console.ReadLine();
            int.TryParse(horizontalX, out int x);
            string verticalY = Console.ReadLine();
            int.TryParse(verticalY, out int y);
            if (x < 0 && y > 0)
                Console.WriteLine("NW");
            if (x == 0 && y > 0)
                Console.WriteLine("N");
            if (x > 0 && y > 0)
                Console.WriteLine("NE");
            if (x < 0 && y == 0)
                Console.WriteLine("W");
            if (x == 0 && y == 0)
                Console.WriteLine("!");
            if (x > 0 && y == 0)
                Console.WriteLine("E");
            if (x < 0 && y < 0)
                Console.WriteLine("SW");
            if (x == 0 && y < 0)//jj
                Console.WriteLine("S");
            if (x > 0 && y < 0)
                Console.WriteLine("SE");
        }
    }
}