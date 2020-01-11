using System;
using System.Collections.Generic;
using System.Linq;

namespace Paladins_champion_generator
{
    class Program
    {

        static void Main(string[] args)
        {
            string appName = "Paladins champion generator";
            string appVersion = "1.1.1";
            string appAuthor = "Vojtěch Klhůfek";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();

            string[] tanks = { "Ash", "Atlas", "Barik", "Fernando", "Inara", "Khan", "Makoa", "Raum", "Ruckus", "Terminus", "Torvald" };
            string[] damages = { "Bomb King", "Cassie", "Dredge", "Drogoz", "Imani", "Kinessa", "Lian", "Sha Lin", "Strix", "Tyra", "Viktor", "Vivian", "Willo" };
            string[] supports = { "Furia", "Grohk", "Grover", "IO", "Jenos", "Mal'Damba", "Pip", "Seris", "Ying" };
            string[] flanks = { "Androxus", "Buck", "Evie", "Koga", "Lex", "Maeve", "Moji", "Skye", "Talus", "Zhin" };

            Random rand = new Random();

            Console.WriteLine("How many champions do you want to generate?");
            int numOfChamps = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("From which classes? (t = tank, d = damage, s = support, f = flank)");
            string classes = Console.ReadLine();

            Console.WriteLine("Can there be two of the same champion? [Y/N]");
            string sameChampion = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            if (classes.ToLower().Contains("t") && classes.ToLower().Contains("d") && classes.ToLower().Contains("s") && classes.ToLower().Contains("f"))
            {
                string[] chosenClasses = tanks.Concat(damages).Concat(supports).Concat(flanks).ToArray();
                Console.WriteLine();

                while (numOfChamps > 0)
                {

                    int index = rand.Next(chosenClasses.Length);
                    Console.WriteLine($"{chosenClasses[index]}");
                    if (sameChampion == "N" || sameChampion == "n")
                    {
                        chosenClasses = chosenClasses.Where(w => w != chosenClasses[index]).ToArray();
                    }
                    numOfChamps--;
                }
            
            }

            if (classes.ToLower().Contains("t") && classes.ToLower().Contains("s") && classes.ToLower().Contains("f"))
            {
                string[] chosenClasses = tanks.Concat(supports).Concat(flanks).ToArray();
                Console.WriteLine();

                while (numOfChamps > 0)
                {

                    int index = rand.Next(chosenClasses.Length);
                    Console.WriteLine($"{chosenClasses[index]}");
                    if (sameChampion == "N" || sameChampion == "n")
                    {
                        chosenClasses = chosenClasses.Where(w => w != chosenClasses[index]).ToArray();
                    }
                    numOfChamps--;
                }
           
            }

            if (classes.ToLower().Contains("t") && classes.ToLower().Contains("d") && classes.ToLower().Contains("f"))
            {
                string[] chosenClasses = tanks.Concat(damages).Concat(flanks).ToArray();
                Console.WriteLine();

                while (numOfChamps > 0)
                {

                    int index = rand.Next(chosenClasses.Length);
                    Console.WriteLine($"{chosenClasses[index]}");
                    if (sameChampion == "N" || sameChampion == "n")
                    {
                        chosenClasses = chosenClasses.Where(w => w != chosenClasses[index]).ToArray();
                    }
                    numOfChamps--;
                }
            
            }

            if (classes.ToLower().Contains("t") && classes.ToLower().Contains("d") && classes.ToLower().Contains("s"))
            {
                string[] chosenClasses = tanks.Concat(damages).Concat(supports).Concat(flanks).ToArray();
                Console.WriteLine();

                while (numOfChamps > 0)
                {

                    int index = rand.Next(chosenClasses.Length);
                    Console.WriteLine($"{chosenClasses[index]}");
                    if (sameChampion == "N" || sameChampion == "n")
                    {
                        chosenClasses = chosenClasses.Where(w => w != chosenClasses[index]).ToArray();
                    }
                    numOfChamps--;
                }
             
            }

            if (classes.ToLower().Contains("d") && classes.ToLower().Contains("s") && classes.ToLower().Contains("f"))
            {
                string[] chosenClasses = damages.Concat(supports).Concat(flanks).ToArray();
                Console.WriteLine();

                while (numOfChamps > 0)
                {

                    int index = rand.Next(chosenClasses.Length);
                    Console.WriteLine($"{chosenClasses[index]}");
                    if (sameChampion == "N" || sameChampion == "n")
                    {
                        chosenClasses = chosenClasses.Where(w => w != chosenClasses[index]).ToArray();
                    }
                    numOfChamps--;
                }
               
            }

            if (classes.ToLower().Contains("t") && classes.ToLower().Contains("d"))
            {
                string[] chosenClasses = tanks.Concat(damages).ToArray();
                Console.WriteLine();

                while (numOfChamps > 0)
                {

                    int index = rand.Next(chosenClasses.Length);
                    Console.WriteLine($"{chosenClasses[index]}");
                    if (sameChampion == "N" || sameChampion == "n")
                    {
                        chosenClasses = chosenClasses.Where(w => w != chosenClasses[index]).ToArray();
                    }
                    numOfChamps--;
                }
           
            }

            if (classes.ToLower().Contains("s") && classes.ToLower().Contains("f"))
            {
                string[] chosenClasses = supports.Concat(flanks).ToArray();
                Console.WriteLine();

                while (numOfChamps > 0)
                {

                    int index = rand.Next(chosenClasses.Length);
                    Console.WriteLine($"{chosenClasses[index]}");
                    if (sameChampion == "N" || sameChampion == "n")
                    {
                        chosenClasses = chosenClasses.Where(w => w != chosenClasses[index]).ToArray();
                    }
                    numOfChamps--;
                }
               
            }

            if (classes.ToLower().Contains("t") && classes.ToLower().Contains("s"))
            {
                string[] chosenClasses = tanks.Concat(supports).ToArray();
                Console.WriteLine();

                while (numOfChamps > 0)
                {

                    int index = rand.Next(chosenClasses.Length);
                    Console.WriteLine($"{chosenClasses[index]}");
                    if (sameChampion == "N" || sameChampion == "n")
                    {
                        chosenClasses = chosenClasses.Where(w => w != chosenClasses[index]).ToArray();
                    }
                    numOfChamps--;
                }
              
            }

            if (classes.ToLower().Contains("t") && classes.ToLower().Contains("f"))
            {
                string[] chosenClasses = tanks.Concat(flanks).ToArray();
                Console.WriteLine();

                while (numOfChamps > 0)
                {

                    int index = rand.Next(chosenClasses.Length);
                    Console.WriteLine($"{chosenClasses[index]}");
                    if (sameChampion == "N" || sameChampion == "n")
                    {
                        chosenClasses = chosenClasses.Where(w => w != chosenClasses[index]).ToArray();
                    }
                    numOfChamps--;
                }
            
            }

            if (classes.ToLower().Contains("d") && classes.ToLower().Contains("f"))
            {
                string[] chosenClasses = damages.Concat(flanks).ToArray();
                Console.WriteLine();

                while (numOfChamps > 0)
                {

                    int index = rand.Next(chosenClasses.Length);
                    Console.WriteLine($"{chosenClasses[index]}");
                    if (sameChampion == "N" || sameChampion == "n")
                    {
                        chosenClasses = chosenClasses.Where(w => w != chosenClasses[index]).ToArray();
                    }
                    numOfChamps--;
                }
          
            }

            if (classes.ToLower().Contains("t"))
            {
                Console.WriteLine();
                while (numOfChamps > 0)
                {

                    int index = rand.Next(tanks.Length);
                    Console.WriteLine($"{tanks[index]}");
                    if (sameChampion == "N" || sameChampion == "n")
                    {
                        tanks = tanks.Where(w => w != tanks[index]).ToArray();
                    }
                    numOfChamps--;
                }
           
            }

            if (classes.ToLower().Contains("d"))
            {
                Console.WriteLine();
                while (numOfChamps > 0)
                {
                    int index = rand.Next(damages.Length);
                    Console.WriteLine($"{damages[index]}");
                    if (sameChampion == "N" || sameChampion == "n")
                    {
                        damages = damages.Where(w => w != damages[index]).ToArray();
                    }
                    numOfChamps--;
                }
              
            }

            if (classes.ToLower().Contains("s"))
            {
                Console.WriteLine();
                while (numOfChamps > 0)
                {
                    int index = rand.Next(supports.Length);
                    Console.WriteLine($"{supports[index]}");
                    if (sameChampion == "N" || sameChampion == "n")
                    {
                        supports = supports.Where(w => w != supports[index]).ToArray();
                    }
                    numOfChamps--;
                }
                
            }

            if (classes.ToLower().Contains("f"))
            {
                Console.WriteLine();
                while (numOfChamps > 0)
                {
                    int index = rand.Next(flanks.Length);
                    Console.WriteLine($"{flanks[index]}");
                       if (sameChampion == "N" || sameChampion == "n")
                    {
                        flanks = flanks.Where(w => w != flanks[index]).ToArray();
                    }
                    numOfChamps--;
                }
              
                
            }
            Console.ResetColor();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();



        }
    }
}
