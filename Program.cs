using System;
using Internal;

namespace hello_world_lesson1
{
    public class Program
    {

        static void Main(string[] args)
        {
            int horizontalX = Console.ReadLine();
            int x = Convert.ToInt32(horizontalX);
            int verticalY = Console.ReadLine();
            int y = Convert.ToInt32(verticalY);
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