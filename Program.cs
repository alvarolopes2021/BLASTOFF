using System;
using System.Collections.Generic;

namespace Blastoff
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("###   TOODOO - BLASTOFF ###   \n \n");

            Exercise1();
        }

        private static void Exercise1()
        {
            Console.WriteLine("###   Exercise 1   ### \n");

            List<string> ageVariables = new List<string> { "I", "J", "K", "X", "Y" };
            Dictionary<string, int> ages = new Dictionary<string, int>();
            float avg = 0;

            for (int i = 0; i < ageVariables.Count; i++)
            {

                int age = 0;

                do
                {
                    Console.Write("Type an age: ");
                    bool success = int.TryParse(Console.ReadLine(), out age);
                    if (!success)
                        Console.WriteLine("Value must be a number");
                    else if (age <= 0)
                        Console.WriteLine("The age must be higher than 0");

                } while (age <= 0);

                ages.Add(ageVariables[i], age);
                avg = avg + age;
            }

            Console.WriteLine($"The average age is: {avg / ages.Count}");
            Console.ReadLine();

            Exercise2();
        }

        private static void Exercise2()
        {
            Console.WriteLine("###   Exercise 2   ### \n");

            bool success = false;
            float A = 0, B = 0;
            do
            {
                Console.Write("Type the distance: ");
                success = float.TryParse(Console.ReadLine(), out A);

                if (!success)
                    Console.WriteLine("The value must be a number");

            } while (!success);

            do
            {
                Console.Write("Type the gas consumption: ");
                success = float.TryParse(Console.ReadLine(), out B);

                if (success)
                    Console.WriteLine($"The avarage comsumption is: {A / B}");

                else
                    Console.WriteLine("The value must be a number");
            } while (!success);

            Console.ReadLine();

            Exercise3();
        }

        private static void Exercise3()
        {
            Console.WriteLine("###   Exercise 3   ### \n");

            List<string> numberVariables = new List<string> { "a", "b", "c" };
            Dictionary<string, float> numbers = new Dictionary<string, float>();

            for (int i = 0; i < numberVariables.Count; i++)
            {
                bool success = false;

                do
                {
                    Console.Write("Type a number: ");

                    success = float.TryParse(Console.ReadLine(), out float num);

                    if (success)
                        numbers.Add(numberVariables[i], num);
                    else
                        Console.WriteLine("Wrong character");

                } while (!success);

            }
            float smallest = float.MaxValue;
            int k = 0, pos = -1;

            foreach (var item in numbers.Values)
            {
                if (item < smallest)
                {
                    smallest = item;
                    pos = k;
                }

                k++;
            }
            Console.WriteLine($"The smallest number is '{numberVariables[pos]}' with the value: {smallest}");

            Console.ReadLine();

            Exercise4();
        }

        private static void Exercise4()
        {
            Console.WriteLine("###   Exercise 4   ### \n");

            double tempCelcius = 0;

            do
            {
                Console.Write("Type the temperature in Celcius: ");

                bool success = double.TryParse(Console.ReadLine(), out tempCelcius);
                if (!success)
                    Console.WriteLine("The temperature must be a number!");
                else if (tempCelcius < -273.15)
                    Console.WriteLine("Impossible temperature");

            } while (tempCelcius < -273.15);

            double tempF = 32 + tempCelcius;

            Console.WriteLine($"The temperature in fahrenheit is: {tempF}");

            Console.ReadLine();

            Exercise5();

        }


        private static void Exercise5()
        {
            Console.WriteLine("###   Exercise 5   ### \n");

            double num1, num2;

            bool success = false;
            do
            {
                Console.Write("Type a number: ");
                success = double.TryParse(Console.ReadLine(), out num1);
            } while (!success);

            do
            {
                Console.Write("Type a number: ");
                success = double.TryParse(Console.ReadLine(), out num2);
            } while (!success);

            bool areMultiple = (num1 % num2 == 0);

            if (areMultiple)
                Console.WriteLine($"{num1} and {num2} are multiple");
            else
                Console.WriteLine($"{num1} and {num2} are not multiple");

            Console.ReadLine();

            Exercise7();
        }

        private static void Exercise7()
        {
            Console.WriteLine("###   Exercise 7   ### \n");
            List<double> numbers = new List<double>();

            List<double> pairs = new List<double>();

            string op = "n";
            do
            {
                Console.Write("Type a number: ");
                bool success = double.TryParse(Console.ReadLine(), out double num);

                if (success)
                    numbers.Add(num);
                else
                {
                    Console.WriteLine("Character mus be a number!");
                }
                Console.Write("Want to stop adding numbers? y - yes | n - no");

                op = Console.ReadLine();

            } while (!op.Equals("y"));

            foreach (var item in numbers)
            {
                if(item % 2 == 0)
                    pairs.Add(item);
            }
            
        }
    }
}
