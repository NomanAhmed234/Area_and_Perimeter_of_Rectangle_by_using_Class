/*Create a rectangle class with two data members’ length and width Provide member
functions to calculate the perimeter and area of the rectangle and a function square
which returns true if the rectangle is a square otherwise it returns false.*/

namespace Lab_5q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.area(6,7);
            rect.perimeter(6,6);
            Console.WriteLine(rect.square());
        }
    }
}