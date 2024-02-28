using System;
using System.Collections.Generic;
using System.Linq;

namespace Pr2
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1(); 
            Task2(); 
            Task3();
            Task4(10); 
        }

        static void Task1()
        {
            Console.Write("Enter numbers: ");
            string? numberString = Console.ReadLine();
            if(string.IsNullOrEmpty(numberString) )
            {
                Console.WriteLine("Incorrect input");
                return;
            }
            List<int> numbers = ParseInputString(numberString);

            Console.WriteLine(Environment.NewLine + "Numbers in [1;27] = " + string.Join(" ", numbers));
        }

        static List<int> ParseInputString(string input)
        {
            string[] splitNumbers = input.Split(' ');
            List<int> numbers = new List<int>();

            foreach (var n in splitNumbers)
            {
                if (int.TryParse(n, out int number) && number >= 1 && number <= 27)
                {
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Can not parse");
                    return new List<int>();
                }
            }

            return numbers;
        }

        static void Task2()
        {
            Console.WriteLine("Enter a,b,c: ");
            string? input = Console.ReadLine();
            if(string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Incorrect input");
                return;
            }
            if (ParseTriple(input, out int a, out int b, out int c))
            {
                double P = a + b + c;
                double subP = P / 2;
                double S = Math.Sqrt(subP * (subP - a) * (subP - b) * (subP - c));

                string type = GetTriangleType(a, b, c);

                Console.WriteLine($"P = {P}, S = {S}, type = {type}");
            }
        }

        static bool ParseTriple(string input, out int a, out int b, out int c)
        {
            string[] inputArray = input.Split(' ');
            a = b = c = 0;
            if (inputArray.Length != 3 || !int.TryParse(inputArray[0], out a) || !int.TryParse(inputArray[1], out b) || !int.TryParse(inputArray[2], out c))
            {
                Console.WriteLine("Incorrect input");
                return false;
            }

            if (a == 0 || b == 0 || c == 0 || (a + b) <= c)
            {
                Console.WriteLine("Incorrect input: a + b <= c");
                return false;
            }

            return true;
        }

        static string GetTriangleType(int a, int b, int c)
        {
            if (a == b && b == c)
                return "Рівносторонній";
            if (b == c)
                return "Рівнобедренний";
            if (IsRight(a, b, c))
                return "Прямокутний";
            if (IsAcute(a, b, c))
                return "Гострокутний";
            return "Тупокутний";
        }

        static bool IsRight(int a, int b, int c)
        {
            int A = a * a;
            int B = b * b;
            int C = c * c;

            return A == B + C || B == A + C || C == A + B;
        }

        static bool IsAcute(int a, int b, int c)
        {
            int A = a * a;
            int B = b * b;
            int C = c * c;

            return A + B > C && B + A > C && C + A > B;
        }

        static void Task3()
        {
            Console.WriteLine("Enter 27 numbers separated by space:");
            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Incorrect input");
                return;
            }
            List<int> numbers = ParseInputString(input);

            if (numbers.Count == 27)
            {
                int min = numbers.Min();
                int max = numbers.Max();

                Console.WriteLine($"Min = {min}, max = {max}");
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }

        static void Task4(int M)
        {
            int[] X = new int[] { 1, -2, 3, 4, 5, 6, 7, 8, 9, -11, 12, 13, -14, 0, 16, 17, 0, 19, 20, 10, 21, 22, 23, 24, 25, 26, -27 };
            List<int> Y = FilterNumbers(X, M);
            Console.WriteLine(string.Join(" ", Y));
        }

        static List<int> FilterNumbers(int[] numbers, int threshold)
        {
            return numbers.Where(i => Math.Abs(threshold) < Math.Abs(i)).ToList();
        }
    }
}
