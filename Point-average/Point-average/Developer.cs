using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_average
{
    class Developer
    {
        private double sumPoint = 0;
        private int sumVahed = 0;
        private string history;
        public void informationUser()
        {
            Console.Write("How many lessons do you have? : ");
            int count = Convert.ToInt32(Console.ReadLine());

            ShowList[] showLists = new ShowList[count];
            for (int i = 0; i < count; i++)
            {
                Console.Write("\nEnter lesson name(" + (i + 1) + "): ");
                string lesson = Console.ReadLine();

                Console.Write("Enter number Vahed: ");
                int vahed = Convert.ToInt32(Console.ReadLine());
                sumVahed += vahed;

                Console.Write("Enter your point: ");
                double point = Convert.ToDouble(Console.ReadLine());

                sumPoint += point * vahed;
                showLists[i] = new ShowList(lesson, vahed, point);

                history += "Lesson: " + lesson + "    Vahed: " + vahed + "    Point: " + point + "\n";
            }

            Console.WriteLine("your lessons:");
            for (int i = 0; i < count; i++)
            {
                showLists[i].Show();
            }
        }

        public double Result()
        {
            Console.WriteLine(history);
            double result = sumPoint / sumVahed;
            return result;
        }
    }
}
