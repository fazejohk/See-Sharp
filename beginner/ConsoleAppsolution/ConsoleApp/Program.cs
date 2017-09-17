using System;

namespace ConsoleApp
{

    class MainClass
    {
        public static void Main(string[] args) // this is a method called main. it is called when the program starts
        {
            while (true)
            {


                double num01;
                double num02;
                double answer;
                string operation;

                Console.WriteLine("First number");
                num01 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Second number");
                num02 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Operations = X,/,+,-");
                operation = Console.ReadLine();

                if (operation == "X" || operation == "x")
                {
                    answer = num01 * num02;
                    Console.WriteLine(num01 + " X " + num02 + " = " + answer);

                }
                else if (operation == "/")
                {
                    answer = num01 / num02;
                    Console.WriteLine(num01 + " / " + num02 + " = " + answer);
                }
                else if (operation == "+")
                {
                    answer = num01 + num02;
                    Console.WriteLine(num01 + " + " + num02 + " = " + answer);
                }
                else if (operation == "-")
                {
                    answer = num01 - num02;
                    Console.WriteLine(num01 + " - " + num02 + " = " + answer);
                }
                else
                {
                    Console.WriteLine("CUh what chu doin");
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }

}