using System;

namespace ConsoleApp
{

    class MainClass
    {
        public static void Main (string[] args) // this is a method called main. it is called when the program starts
        {
            Start:
            double num01;
            double num02;

            Console.Write("INSERT NUMBER --> "); // writella voi kirjottaa samalle linelle
            num01 = Convert.ToDouble (Console.ReadLine()); // converttaa readlinen numeroksi
            Console.Write("Another one -->");
            num02 = Convert.ToDouble (Console.ReadLine());
            Console.Write("Result is " + num01+num02);
            Console.ReadLine();
            Console.WriteLine();
            Console.Clear();
            goto Start;
        }
    }

}