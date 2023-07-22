using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5q4
{
    internal class Rectangle
    {
        public int width;
        public int length;

        public void perimeter(int w, int l)
        {
            this.width = w;
            this.length = l;
            int perimeter = (2 * width) + (2 * length);
            Console.WriteLine("The Perimeter of Rectangle is: {0}.",perimeter);
        }

        public void area(int w, int l)
        {
            this.width = w;
            this.length = l;
            int area = width * length;
            Console.WriteLine("The Area of Rectangle is: {0}.",area);
        }

        public bool square()
        {
            if (length == width)
            {
                return true;
            }else { return false; }
        }
    }
}
