using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPL_Assignment_No_1
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Which question do you want to go ? ");
            int ques = int.Parse(Console.ReadLine());
            switch (ques)
            {
                case 1:
                    QuestionNo1 questionNo1 = new QuestionNo1();
                    questionNo1.solution();

                    break;
                case 2:
                    QuestionNo2 questionNo2 = new QuestionNo2();
                    questionNo2.solution();
                    break;
                case 3:
                    QuestionNo3 questionNo3 = new QuestionNo3();
                    questionNo3.solution();
                    break;
                default:
                    Console.WriteLine("No such thing found");
                    break;
            }

            
            

        }

    }
}
