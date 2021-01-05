using System;

namespace Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int Susanage= 0;
            Console.Write("Hi Susan, welcome to Oluchi's club. How old are you?");
            Susanage = int.Parse(Console.ReadLine());

            if (Susanage >= 18)
            {
                Console.WriteLine("You are old enough to enter!");
            }
            
            else
            {
                Console.WriteLine("You are too young to enter. Please turn back");
            }

            int Christianaage= 0;
            Console.Write("Hi Christiana, welcome to Oluchi's club. How old are you?");
            Christianaage = int.Parse(Console.ReadLine());

            if (Christianaage >= 18)
            {
                Console.WriteLine("You are old enough to enter!");
            }
            
            else
            {
                Console.WriteLine("You are too young to enter. Please turn back");
            }

            int Jaelage= 0;
            Console.Write("Hi Jael, welcome to Oluchi's club. How old are you?");
            Jaelage = int.Parse(Console.ReadLine());

            if (Jaelage >= 18)
            {
                Console.WriteLine("You are old enough to enter!");
            }
            
            else
            {
                Console.WriteLine("You are too young to enter. Please turn back");
            }
        }
    }
}
