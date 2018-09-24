using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPL_Assignment_No_1
{
    class QuestionNo1
    {

        public void solution()
        {
            //initializing two arrays and arraysize
            int[] sourceArray;
            int[] targetArray;
            int totalValues = 0;

            char check = 'y';


            do
            {
                Console.Write("How many values you want to enter : ");
                while (!int.TryParse(Console.ReadLine(), out totalValues))
                {
                    Console.WriteLine("Please Enter a valid numerical value!");
                }


                sourceArray = new int[totalValues];
                targetArray = new int[totalValues];

                Console.WriteLine("Enter " + totalValues + " values now");
                for (int i = 0; i < totalValues; i++)
                {
                    int value;
                    while (!int.TryParse(Console.ReadLine(), out value))
                    {
                        Console.WriteLine("Please Enter a valid numerical value!");
                    }
                    sourceArray[i] = value;

                }


                Array.Copy(sourceArray, targetArray, totalValues);

                Console.WriteLine("Now printing the original array");
                for (int i = 0; i < totalValues; i++)
                {
                    Console.WriteLine(sourceArray[i]);
                }

                Console.WriteLine("Now printing the copied array");
                for (int i = 0; i < totalValues; i++)
                {
                    Console.WriteLine(targetArray[i]);
                }

                Console.WriteLine("Do you want to try again? Press \"y\" to continue : ");


                check = Console.ReadKey().KeyChar;

            } while (check == 'y');
        }


    }
}
