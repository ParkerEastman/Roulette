using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {

            doWork();
        }


        static void doWork()
        {
            string headerText = "Press 'Space' to generate a spin or 'Escape' to exit\n";
            Console.WriteLine(headerText);
            Random rand = new Random();
            int randSelect = rand.Next(0, 37);

            RouletteWheel rwInst = new RouletteWheel();
            RouletteElement selection = rwInst.rouletteWheel[randSelect];

            ConsoleKeyInfo option = new ConsoleKeyInfo();
            bool quit = false;
            while (!quit)
            {
                option = Console.ReadKey();
                Console.Clear();
                Console.WriteLine(headerText);
                switch (option.Key)
                {
                    case ConsoleKey.Spacebar:
                        selection = rwInst.rouletteWheel[randSelect];
                        randSelect = rand.Next(0, 37);
                        rwInst.WinningBets(selection);
                        break;
                    case ConsoleKey.Escape:
                        quit = true;
                        Console.WriteLine("GoodBye");
                        break;
                }

            }
        }
    }
}


                