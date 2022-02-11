using System;

namespace part3a
{
    class Program
    {
        static void Main(string[] args)
        {
            //greeting
            int currentyear = DateTime.Now.Year;
            Console.WriteLine("Hello! What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            int birthYear = currentyear - age;
            Console.WriteLine($"Okay, {name}, that means you were born in {birthYear}.");

            //adder
            Console.WriteLine("INPUT FIRST NUMBER");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("INPUT SECOND NUMBER");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("INPUT THIRD NUMBER");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int total = num1 + num2 + num3;
            Console.WriteLine($"THE TOTAL IS {total}");

            //distance
            Console.WriteLine("First Distance (in km):");
            double dist1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Second Distance (in km):");
            double dist2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Third Distance (in km):");
            double dist3 = Convert.ToDouble(Console.ReadLine());
            double average = (dist1 + dist2 + dist3) / 3;
            Console.WriteLine($"Your average distance is {Math.Round(average, 2)} kilometers.");

            //hypotenuse
            Console.WriteLine("side a length:");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("side b length:");
            double side2 = Convert.ToDouble(Console.ReadLine());
            double side3 = Math.Sqrt(Math.Pow(side1, 2) + Math.Pow(side2, 2));
            Console.WriteLine("the length of the hypotenuse is " + Math.Round(side3, 2));

        }
    }
}
