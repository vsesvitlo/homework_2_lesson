using System;
using System.Runtime.ConstrainedExecution;
using Internal;

namespace _2_my_efforts;
class Program
{
    static void Main(string[] args)

    {
        { //switch Statement

            string buildHorizontalX = Console.ReadLine();
            int.TryParse(buildHorizontalX, out int x);
            string buildVerticalY = Console.ReadLine();
            int.TryParse(buildVerticalY, out int y);

            if ((x < -5) || (x > 5) || (y < -5) || (y > 5))
            {
                Console.WriteLine("Please, change the X or the Y value, no less than -5 and no more 5");
            }

            Random randA = new Random();
            int a = randA.Next(-5, 5);
            int b = randA.Next(-5, 5);

            Console.WriteLine(a);
            Console.WriteLine(b);
            if ((a == x) || (b == y))
            {

                Console.WriteLine("ALERT!!! SOS!");

            }
            switch (a, b)
            {
                case ( < 0, > 0):
                    Console.WriteLine("NW");
                    break;
                case (0, > 0):
                    Console.WriteLine("N");
                    break;
                case ( > 0, > 0):
                    Console.WriteLine("NE");
                    break;
                case ( < 0, 0):
                    Console.WriteLine("W");
                    break;
                case ( > 0, 0):
                    Console.WriteLine("E");
                    break;
                case ( < 0, < 0):
                    Console.WriteLine("SW");
                    break;
                case (0, < 0):
                    Console.WriteLine("S");
                    break;
                case ( > 0, < 0):
                    Console.WriteLine("SE");
                    break;
                default:
                    Console.WriteLine("!");
                    break;
            }

        }

    }

    public void Validate(string input)
    {
        if (input == null)
        {
            throw new ArgumentNullException(nameof(input));
        }
        if (input.Length != 0)
        {
            Console.WriteLine(input);
        }
    }
}

/*string horizontalX = Console.ReadLine();
int.TryParse (horizontalX, out int x);
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
else if (x == 0 && y < 0)
    Console.WriteLine("S");
else //(x > 0 && y < 0);
    Console.WriteLine("SE");

}
}*/
// Random randB = new Random();
//for (int ctr = 0; ctr <= 1; ctr++);
//Console.Write("{0,2:N0  }", rand.Next(-5, 5));
// var s = rand.Next(-5, 5);
//Console.Write("{0, 1 }", randA.Next(-5, 5));