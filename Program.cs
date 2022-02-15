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

        private static void Exercise1(){
            Console.WriteLine("###   Exercise 1   ### \n");

            List<string> ageVariables = new List<string>{"I", "J", "K", "X", "Y"};
            Dictionary<string, int> ages = new Dictionary<string, int>();
            float avg = 0;

            for(int i = 0; i < ageVariables.Count; i++){

                int age = 0;

                do{                        
                    bool success = int.TryParse(Console.ReadLine(), out age);
                    if(!success)                
                        Console.WriteLine("Value must be a number");
                }while(age <= 0);

                ages.Add(ageVariables[i], age);
                avg = avg + age;
            }

            Console.WriteLine($"The average age is: {avg/ages.Count}");
            Console.ReadLine();

            Exercise2();
        }

        private static void Exercise2(){
             
        }
    }
}
