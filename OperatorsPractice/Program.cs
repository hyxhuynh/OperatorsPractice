using System.ComponentModel;

namespace OperatorsPractice
{
    internal class Program
    {
        // EXERCISE 1
        public static int Addition (int a, int b) 
        {
            int sum = a + b;
            return sum;
        }

        public static int Subtraction(int a, int b)
        {
            int difference = a - b;
            return difference;
        }
        public static int Multiplication(int a, int b)
        {
            int product = a * b;
            return product;
        }
        public static int Division(int a, int b)
        {
            int quotient = a / b;
            return quotient;
        }
        public static int Modulus(int a, int b)
        {
            int remainder = a % b;
            return remainder;
        }

        // EXERCISE 2
        public static double AreaOfCircle (double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }
        static void Main(string[] args)
        {
            // EXERCISE 1
            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the first number:");
            int num2 = int.Parse(Console.ReadLine());

            int userSum = Addition(num1, num2);
            int userDifference = Subtraction(num1, num2);
            int userProduct = Multiplication(num1, num2);
            int userQuotient = Division(num1, num2);
            int userRemainder = Modulus(num1, num2);


            Console.WriteLine($"{num1} + {num2} is {userSum}");
            Console.WriteLine($"{num1} - {num2} is {userDifference}");
            Console.WriteLine($"{num1} * {num2} is {userProduct}");
            Console.WriteLine($"{num1} / {num2} is {userQuotient} remainder {userRemainder}");

            // EXERCISE 2
            Console.WriteLine("\nWhat is the radius of your circle?");
            double userRadius = double.Parse(Console.ReadLine());
            double userArea = Math.Round(AreaOfCircle(userRadius), 3);
            
            Console.WriteLine($"The area of a circle with radius of {userRadius} is {userArea}.");
        }
    }
}
