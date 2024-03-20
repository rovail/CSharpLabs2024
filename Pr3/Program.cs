using Pr3.Task1;
using Pr3.Task2;

namespace Pr3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task1

            Book myBook = new Book("ASP.NET Core in Action", "Andrew Lock", "Build professional-grade full-stack web applications using C# and ASP.NET Core.");
            myBook.Show();

            #endregion

            Console.WriteLine(Environment.NewLine);

            #region task2

            Point A = new Point(0, 0, "A");
            Point B = new Point(0, 4, "B");
            Point C = new Point(3, 0, "C");

            Figure triangle = new Figure(A, B, C);
            triangle.PerimeterCalculator();
            Console.WriteLine($"AB = {triangle.LengthSide(A, C)}");

            #endregion
        }
    }
}