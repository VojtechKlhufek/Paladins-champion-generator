using System;
using System.Linq;

namespace Paladins_champion_generator
{
    class Program
    {

        static void Main(string[] args)
        {
            string appName = "Paladins champion generator";
            string appVersion = "1.2.0";
            string appAuthor = "Vojtěch Klhůfek";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();
           
            string[] tanks = { "Ash", "Atlas", "Barik", "Fernando", "Inara", "Khan", "Makoa", "Raum", "Ruckus", "Terminus", "Torvald" };
            string[] damages = { "Bomb King", "Cassie", "Dredge", "Drogoz", "Imani", "Kinessa", "Lian", "Sha Lin", "Strix", "Tyra", "Viktor", "Vivian", "Willo", "Tiberius" };
            string[] supports = { "Furia", "Grohk", "Grover", "IO", "Jenos", "Mal'Damba", "Pip", "Seris", "Ying", "Corvus" };
            string[] flanks = { "Androxus", "Buck", "Evie", "Koga", "Lex", "Maeve", "Moji", "Skye", "Talus", "Zhin" };

            string[] chosenClasses;
            string sameChampion;
            int numOfChamps;
            Random rand = new Random();
            try
            {     
                Console.WriteLine("How many champions do you want to generate?");
                numOfChamps = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("From which classes? (t = tank, d = damage, s = support, f = flank)");
                string classes = Console.ReadLine();
                if (numOfChamps != 1)
                {
                    Console.WriteLine("Can there be two of the same champion? [Y/N]");
                    sameChampion = Console.ReadLine();
                }
                else
                {
                    sameChampion = "N";
                }
                Console.ForegroundColor = ConsoleColor.Magenta;
                if (classes.ToLower().Contains("t") && classes.ToLower().Contains("d") && classes.ToLower().Contains("s") && classes.ToLower().Contains("f"))
                {
                    chosenClasses = tanks.Concat(damages).Concat(supports).Concat(flanks).ToArray();
                    Console.WriteLine();

                    WriteChamps();
                }

                if (classes.ToLower().Contains("t") && classes.ToLower().Contains("s") && classes.ToLower().Contains("f"))
                {
                    chosenClasses = tanks.Concat(supports).Concat(flanks).ToArray();
                    Console.WriteLine();

                    WriteChamps();
                }

                if (classes.ToLower().Contains("t") && classes.ToLower().Contains("d") && classes.ToLower().Contains("f"))
                {
                    chosenClasses = tanks.Concat(damages).Concat(flanks).ToArray();
                    Console.WriteLine();

                    WriteChamps();
                }

                if (classes.ToLower().Contains("t") && classes.ToLower().Contains("d") && classes.ToLower().Contains("s"))
                {
                    chosenClasses = tanks.Concat(damages).Concat(supports).Concat(flanks).ToArray();
                    Console.WriteLine();

                    WriteChamps();
                }

                if (classes.ToLower().Contains("d") && classes.ToLower().Contains("s") && classes.ToLower().Contains("f"))
                {
                    chosenClasses = damages.Concat(supports).Concat(flanks).ToArray();
                    Console.WriteLine();

                    WriteChamps();
                }

                if (classes.ToLower().Contains("t") && classes.ToLower().Contains("d"))
                {
                    chosenClasses = tanks.Concat(damages).ToArray();
                    Console.WriteLine();

                    WriteChamps();
                }

                if (classes.ToLower().Contains("s") && classes.ToLower().Contains("f"))
                {
                    chosenClasses = supports.Concat(flanks).ToArray();
                    Console.WriteLine();

                    WriteChamps();
                }

                if (classes.ToLower().Contains("t") && classes.ToLower().Contains("s"))
                {
                    chosenClasses = tanks.Concat(supports).ToArray();
                    Console.WriteLine();

                    WriteChamps();
                }

                if (classes.ToLower().Contains("t") && classes.ToLower().Contains("f"))
                {
                    chosenClasses = tanks.Concat(flanks).ToArray();
                    Console.WriteLine();

                    WriteChamps();
                }

                if (classes.ToLower().Contains("d") && classes.ToLower().Contains("f"))
                {
                    chosenClasses = damages.Concat(flanks).ToArray();
                    Console.WriteLine();

                    WriteChamps();
                }

                if (classes.ToLower().Contains("t"))
                {
                    chosenClasses = tanks;
                    Console.WriteLine();

                    WriteChamps();
                }

                if (classes.ToLower().Contains("d"))
                {
                    chosenClasses = damages;
                    Console.WriteLine();

                    WriteChamps();
                }

                if (classes.ToLower().Contains("s"))
                {
                    chosenClasses = supports;
                    Console.WriteLine();

                    WriteChamps();
                }

                if (classes.ToLower().Contains("f"))
                {
                    chosenClasses = flanks;
                    Console.WriteLine();

                    WriteChamps();
                }
            }catch(FormatException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("Invalid input");
            }
            Console.ResetColor();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

            void WriteChamps()
            {
                try
                {
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
                catch (IndexOutOfRangeException e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.WriteLine("There is not enough champions in selected classes");
                }
            }


        }
      
    }
}
