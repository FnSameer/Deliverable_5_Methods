

using System;

namespace Deliverable_5_Methods
{
    class Program
    {

        static int[] RandomArray(int array_len)
        { 


            Random random = new Random();
            int[] randomArray = new int[array_len];
            for (int i = 0; i<array_len; i++)
            {
                randomArray[i] = random.Next(10, 50);

            }

            return randomArray;
        }


        static int sum(int[] randomArray)
        {
            int sum = 0;
            foreach (int element in randomArray)
            {
                sum = sum + element;

            }

            return sum;

        }

        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enter an integer between 5 and 15");

                int input = int.Parse(Console.ReadLine());

                Console.WriteLine(" ");

                if (input >= 5 && input <= 15)
                {
                    int[] randomArray = RandomArray(input);
                    Console.Write("The elements of the array are: ");
                    foreach (int number in randomArray)
                    {
                        Console.Write(number + " ");
                    }

                    Console.WriteLine(" ");
                    Console.WriteLine("The sum is: " + sum(randomArray));

                }

                else
                {
                    Console.WriteLine("Integer must be between 5 and 15");

                }
            }
            catch 
            {
                Console.WriteLine("Please enter an integer between 5 and 15");
                    
            }
        }

          




    }

       

     



    

    


    
}