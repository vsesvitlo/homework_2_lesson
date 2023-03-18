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
            else if (x == 0 && y > 0)
                Console.WriteLine("N");
            else if (x > 0 && y > 0)
                Console.WriteLine("NE");
            else if (x < 0 && y == 0)
                Console.WriteLine("W");
            else if (x == 0 && y == 0)
                Console.WriteLine("!");
            else if (x > 0 && y == 0)
                Console.WriteLine("E");
            else if (x < 0 && y < 0)
                Console.WriteLine("SW");
            else if (x == 0 && y < 0)//jj
                Console.WriteLine("S");
            else //(x > 0 && y < 0);
                Console.WriteLine("SE");
        }
    }
}