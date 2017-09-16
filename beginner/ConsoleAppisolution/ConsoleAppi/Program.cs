using System;

namespace ConsoleApp
{

    class MainClass
    {
        public static void Main(string[] args) // this is a method called main. it is called when the program starts
        {
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            if(age < 18){
                Console.WriteLine("Thats too bad CUH");
            }else if (age == 18){
                Console.WriteLine("Cuh you made it");
            }
            else {
                Console.WriteLine("You are allowed to enter.");
            }
            Console.ReadKey();
        }
    }

}