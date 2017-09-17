using System;


namespace ConsoleApp
{

    class MainClass
    {
        public static void Main(string[] args) // this is a method called main. it is called when the program starts
        {
            start:
            Random numberGen = new Random();
            int numberOfAttempts = 0;
            int attempt = 0;

            while (attempt != 100)
            {
                attempt = numberGen.Next(1, 101);
                Console.WriteLine("Tom rolled: " + attempt + ".");
                numberOfAttempts++;
            }

            Console.WriteLine("It took tom " + numberOfAttempts + " attempts to roll a six.");

            Console.ReadKey();
            Console.Clear();
            goto start;
        }
    }

}