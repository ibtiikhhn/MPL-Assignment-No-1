using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPL_Assignment_No_1
{
    class QuestionNo3
    {
        public void solution()
        {
            Console.Write("Enter size of array : ");
            int arraySize = int.Parse(Console.ReadLine());
            Console.WriteLine("Now enter values for array : ");
            int[] array = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(array);
            Console.WriteLine("Now printing the sorted array");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            Console.Read();

        }
    }
}
