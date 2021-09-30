using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbri 1 - 10;
            //kasuutaja peb seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud;
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme katsega numbrit ära arvata
            //siis mängu võidab arvuti.
            //*programm genereerib juhuslikku numbrit ühte korda.

            Random rnd = new Random();
            int cpuRandom = rnd.Next(1, 11);

            int i = 0;

            while (i < 3)

            {
                Console.WriteLine("Sisesta number 1-10:");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                if (userNumber == cpuRandom )
                {
                    Console.WriteLine("Sa võitsid!");
                    break;
                   
                }
                else
                {
                    i = i + 1;
                    Console.WriteLine($"Sa kaotasid. {3 - i} katset on jäänud.");
                }




            }

            }
        }
    }   
