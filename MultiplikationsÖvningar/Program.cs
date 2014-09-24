using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplikationsÖvningar
{
    class Program
    {
        static void Main(string[] args)
        {
            int point = 0;

            for (int i = 0; i < 10; i++)
            {
                int answer = 0;

                Random random = new Random();
                int nr1 = random.Next(1, 11);
                int nr2 = random.Next(1, 11);

                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Du har {0}/10 poäng", point);
                    Console.Write("{0} * {1} = ", nr1, nr2);
                    Console.ForegroundColor = ConsoleColor.Green;
                    answer = Convert.ToInt32(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Magenta;

                    if (answer == nr1 * nr2)
                    {
                        Console.Clear();
                        point++;
                        if(point == 10)
                        {
                            Console.WriteLine("Du fick alla rätt!");
                            Console.WriteLine("Vill du börja om? Y/N");
                            string restart = Console.ReadLine().ToLower();

                            if (restart == "y")
                            {
                                point = 0;
                                return;
                            }
                            else if (restart == "n")
                                Environment.Exit(0);
                        }
                        Console.WriteLine("Rätt!");
                        break;
                    }

                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Fel!");
                        Console.WriteLine("Try again");
                        point--;
                    }
                }
            }

        }
    }
}
