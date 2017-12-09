using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 0, y = 0;
            //for (int i = 2; i < 10; i++)
            //{
            //    if (x == 60)
            //    {
            //        y = 10;
            //        x = 0;
            //    }

            //    for (int j = 2; j < 10; j++)
            //    {
            //        Console.SetCursorPosition(x, y + j);
            //        Console.WriteLine($"{i} x {j} = {i * j,2}");
            //    }
            //    x += 15;
            //}

            //string s;
            //int x = 0, y = 0;
            //for (int i = 0; i <= 255; i++)
            //{
            //    s = Convert.ToString(i, 2);
            //    Console.Write($"\t{i,2} = {s,8}");
            //    if ((i+1) % 5 == 0)      
            //        Console.WriteLine();

            //}

            int x = Console.WindowWidth / 2, y = Console.WindowHeight / 2;
            Console.WriteLine("To continue enter any key. To exit enter Esc.");
            Console.SetCursorPosition(x, y);
            ConsoleKeyInfo key;
           
            key = Console.ReadKey();     
            do
            {      
                Console.SetCursorPosition(x, y);
                Console.WriteLine("*");
                key = Console.ReadKey();

                if (key.Key == ConsoleKey.UpArrow)
                    y -= 1;

                else if (key.Key == ConsoleKey.DownArrow)
                    y += 1;

                else if (key.Key == ConsoleKey.LeftArrow)
                    x -= 1;

                else if (key.Key == ConsoleKey.RightArrow)
                    x += 1;
                                
            } while (key.Key != ConsoleKey.Escape);
            Console.WriteLine();

        }
    }
}
