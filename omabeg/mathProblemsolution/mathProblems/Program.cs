using System;
using System.Diagnostics;
using System.Threading;


namespace ConsoleApp
{

    class MainClass
    {
        public static void Main(string[] args) // this is a method called main. it is called when the program starts
        {
        start:
            Stopwatch stopwatch = new Stopwatch();
            Random numberGeberatir = new Random();
            int num1 = numberGeberatir.Next(1, 50);
            int num2 = numberGeberatir.Next(1, 50);
            int num3 = numberGeberatir.Next(1, 50);

            //Console.WriteLine("First numbah");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Second numbah");
            //num2 = Convert.ToInt32(Console.ReadLine());
            stopwatch.Start();
            Console.WriteLine("What is " + num1 + " + " + num2);
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num3 == num1 + num2) {
                int responseIndex = numberGeberatir.Next(1, 4);

                switch (responseIndex) {
                    case 1:
                        Console.WriteLine("Good o'l job");
                        break;
                    case 2:
                        Console.WriteLine("You did GREAT there");
                        break;
                    case 3:
                        Console.WriteLine("WoW");
                        break;
                    default:
                        Console.WriteLine("NOBODY HAS EVER DONE THAT");
                        break;
                }

                Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
                Console.ReadLine();
                Console.Clear();
                goto start;
            } else if (num3 != num1 + num2)  {
                int responseIndex = numberGeberatir.Next(1, 4);

                switch (responseIndex)
                {
                    case 1:
                        Console.WriteLine("Are you even tryin");
                        break;
                    case 2:
                        Console.WriteLine("WTGUCCI CUH");
                        break;
                    default:
                        Console.WriteLine("Naaah");
                        break;
                }

                Console.ReadLine();
                Console.Clear();
                goto start;
            }else{
                Console.WriteLine("WTF U DOIN");
                Console.ReadLine();
                Console.Clear();
                goto start;
            }
        }
    }

}