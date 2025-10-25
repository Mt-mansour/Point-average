using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first name and last name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your National code or student number: ");
            int Code = Convert.ToInt32(Console.ReadLine());

            Developer developer = new Developer();
            while (true)
            {
                Console.Write("\n1: Add and show Lessons \n2: Show your average \n3: Exist \nSelect a number: ");
                int selectNumber = Convert.ToInt32(Console.ReadLine());

                if (selectNumber == 1)
                {
                    developer.informationUser();
                }

                if (selectNumber == 2)
                {
                    Console.WriteLine("Your lessons: ");
                    double result = developer.Result();
                    Console.WriteLine("Average: " + result);
                }

                if (selectNumber == 3)
                {
                    break;
                }

                else continue;
            }

            Console.ReadKey();
        }
    }
}
