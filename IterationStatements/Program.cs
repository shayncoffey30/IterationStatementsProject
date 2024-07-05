using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
                
                var numbers = new List<int>();


            //Create a variable of type int and name it num
            //initialize the variable with a value of 0
            var myNumber = 0;


            // Create a do-while loop 

            {
                // Increment your variable by 1
                // Then add your variable to "numbers"
           
            }


            // While your variable is less than 100

            do
            {
                myNumber++; // 2

                numbers.Add(myNumber); //1, 2, 3, 4 100

            } while (myNumber < 100);



            // Create a while loop
            // While your variable is less than 200
            while (myNumber < 200)
            {
                // Increment your variable by 1
                myNumber++;

                // Then add your variable to "numbers"
                numbers.Add(myNumber);

            }
                    

            Console.WriteLine("Increase:");


            // Create a foreach loop using the collection - numbers
            //In the scope of the foreach loop, print each number in numbers
            foreach (var item in numbers)
            {
                Console.WriteLine($"{item}");



                Console.WriteLine("");
                Console.WriteLine("Decrease:");


                // Create a for loop - this will print the numbers in reverse order - from 200 to 1
                // in your initializer set the value of i to 199
                // in your conditional, as long as i is less than or equal to the amount of items in "numbers" - use (numbers.Count)
                // AND as long as i is greater than or equal to 0
                // Decrement i by 1
                for (var i = 199; i >= 0; i--)

                {
                    Console.WriteLine($"{numbers[i]}");
                }

            }
        }
    }
}
