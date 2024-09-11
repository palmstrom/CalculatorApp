using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A C# Calculator App");
            Console.WriteLine("Select an operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.Write("Enter the number of the operation: ");

            if (!int.TryParse(Console.ReadLine(), out int operation) || operation < 1 || operation > 4)
            {
                Console.WriteLine("Invalid operation. Please enter a number between 1 and 4.");
                return;
            }

            Console.Write("Enter the first number: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Invalid number. Please enter a numeric value.");
                return;
            }

            Console.Write("Enter the second number: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Invalid number. Please enter a numeric value.");
                return;
            }

            double result;

            switch (operation)
            {
                case 1:
                    result = Add(num1, num2);
                    Console.WriteLine($"The result of {num1} + {num2} is {result}");
                    break;
                case 2:
                    result = Subtract(num1, num2);
                    Console.WriteLine($"The result of {num1} - {num2} is {result}");
                    break;
                case 3:
                    result = Multiply(num1, num2);
                    Console.WriteLine($"The result of {num1} * {num2} is {result}");
                    break;
                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                    }
                    else
                    {
                        result = Divide(num1, num2);
                        Console.WriteLine($"The result of {num1} / {num2} is {result}");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    break;
            }
        }

        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Divide(double a, double b)
        {
            return a / b;
        }
    }
}

