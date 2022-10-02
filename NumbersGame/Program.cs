// Elias Hammou, NET22
using System;

namespace NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randNum = rand.Next(0, 25);

            int countTries = 0;

            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");
            int guessRand;

            do
            {
                countTries += 1;

                guessRand = Int32.Parse(Console.ReadLine());

                checkGuess(randNum, guessRand, countTries);

            } while (countTries < 5);

        }

        static void checkGuess(int randNum, int guessRand, int countTries) 
        {

            if (randNum.Equals(guessRand))
            {

                Console.WriteLine("Grattis, du hade rätt! De tog dig bara {0} försök.", countTries);

            }
            else if (countTries == 5 && guessRand != randNum)
            {
                Console.WriteLine("Tyvärr du lyckades inte gissa talet på fem försök!");
            }
            else if (guessRand > randNum)
            {

                Console.WriteLine("Din gissning är större än talet");

            }
            else if (guessRand < randNum)
            {

                Console.WriteLine("Din gissning är mindre än talet");

            }

        }
    }
}
