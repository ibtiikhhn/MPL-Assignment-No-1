using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPL_Assignment_No_1
{
    class QuestionNo2
    {

        public void solution()
        {
            string userId = "Batman";
            string password = "BruceWayne";

            int totalInputs = 3;
            int currentTrys = 0;
            string user = "";
            string pass = "";

            while (!(String.Equals(user,userId)) && !(String.Equals(pass,password)))
            {
                if (currentTrys == totalInputs)
                {
                    Console.WriteLine("Too many wrong inputs, try again later");
                    Console.Read();
                    break;
                }
                else
                {
                    if (currentTrys != 0)
                    {
                        Console.WriteLine("Wrong userId or password, try again");
                    }

                    Console.WriteLine();
                    Console.Write("Enter user Id : ");
                    user = Console.ReadLine();

                    Console.Write("Enter user Password : ");
                    pass = Console.ReadLine();
                    
                }

                currentTrys++;

            }



        }
    }
}
