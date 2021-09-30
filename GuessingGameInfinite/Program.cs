using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbri 1 - 10;
            //kasuutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud;
            //katsete arv on piiramatu.
            //*programm genereerib juhuslikku numbrit ühte kohta

            Random rnd = new Random();
            int cpuRandom = rnd.Next(1, 11);
            bool loopActive = true;
            

            while (loopActive)
            {
                Console.WriteLine("Sisesta numbrit 1-10:");
                int  userNumber= Convert.ToInt32(Console.ReadLine());

                if (cpuRandom == userNumber)
                {
                    Console.WriteLine("Sa võitsid!");
                    loopActive = false;
                }
                else
                {
                    Console.WriteLine("Sa kaotasid. Proovi uuesti!");
                }
            }
        }
    }
}
