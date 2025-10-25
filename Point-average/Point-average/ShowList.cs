using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_average
{
    class ShowList
    {
        private string Lesson;
        private int Vahed;
        private double Point;
        public ShowList(string lesson, int vahed, double point)
        {
            Lesson = lesson;
            Vahed = vahed;
            Point = point;
        }

        public void Show()
        {
            Console.WriteLine($"\nLesson: {Lesson}    Vahed: {Vahed}    Point: {Point}");
        }
    }
}
