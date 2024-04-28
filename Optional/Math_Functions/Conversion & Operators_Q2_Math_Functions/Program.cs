//Console.WriteLine("Enter the first number: ");
//Part 1
// Use the Math class to calculate the minimum of two numbers.
// Hint: Use the Min method of the Math class.
// Test Data:
// Enter the first number: 5
// Enter the second number: 10
// Expected Output:
// The minimum of 5 and 10 is 5

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Prompt the user to enter two numbers
//        Console.Write("Enter the first number: ");
//        double num1 = double.Parse(Console.ReadLine());

//        Console.Write("Enter the second number: ");
//        double num2 = double.Parse(Console.ReadLine());

//        // Calculate the minimum of the two numbers
//        double min = Math.Min(num1, num2);

//        // Display the result
//        Console.WriteLine($"The minimum of {num1} and {num2} is {min}");
//    }
//}


//Part 2
// Use the Math class to calculate the maximum of two numbers.
// Hint: Use the Max method of the Math class.
// Test Data:
// Enter the first number: 15
// Enter the second number: 8
// Expected Output:
// The maximum of 15 and 8 is 15

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Prompt the user to enter two numbers
//        Console.Write("Enter the first number: ");
//        double num1 = double.Parse(Console.ReadLine());

//        Console.Write("Enter the second number: ");
//        double num2 = double.Parse(Console.ReadLine());

//        // Calculate the maximum of the two numbers
//        double max = Math.Max(num1, num2);

//        // Display the result
//        Console.WriteLine($"The maximum of {num1} and {num2} is {max}");
//    }
//}


//Part 3
// Use the Math class to calculate the square root of a number.
// Hint: Use the Sqrt method of the Math class.
// Test Data:
// Enter a number: 144
// Expected Output:
// The square root of 144 is 12

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Prompt the user to enter a number
//        Console.Write("Enter a number: ");
//        double number = double.Parse(Console.ReadLine());

//        // Calculate the square root of the number
//        double squareRoot = Math.Sqrt(number);

//        // Display the result
//        Console.WriteLine($"The square root of {number} is {squareRoot}");
//    }
//}


//Part 4
// Use the Math class to calculate the absolute value of a number.
// Hint: Use the Abs method of the Math class.
// Test Data:
// Enter a number: -5
// Expected Output:
// The absolute value of -5 is 5

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Prompt the user to enter a number
//        Console.Write("Enter a number: ");
//        double number = double.Parse(Console.ReadLine());

//        // Calculate the absolute value of the number
//        double absoluteValue = Math.Abs(number);

//        // Display the result
//        Console.WriteLine($"The absolute value of {number} is {absoluteValue}");
//    }
//}


//Part 5
// Use the Math class to calculate the power of a number.
// Hint: Use the Pow method of the Math class.
// Test Data:
// Enter the base number: 2
// Enter the exponent: 5
// Expected Output:
// 2 raised to the power of 5 is 32

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Prompt the user to enter the base number
//        Console.Write("Enter the base number: ");
//        double baseNumber = double.Parse(Console.ReadLine());

//        // Prompt the user to enter the exponent
//        Console.Write("Enter the exponent: ");
//        double exponent = double.Parse(Console.ReadLine());

//        // Calculate the power of the base number raised to the exponent
//        double result = Math.Pow(baseNumber, exponent);

//        // Display the result
//        Console.WriteLine($"{baseNumber} raised to the power of {exponent} is {result}");
//    }
//}


//Part 6
// Use the Math class to round a number to the nearest integer.
// Hint: Use the Round method of the Math class.
// Test Data:
// Enter a number: 4.6
// Expected Output:
// 4.6 rounded to the nearest integer is 5

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Prompt the user to enter a number
//        Console.Write("Enter a number: ");
//        double number = double.Parse(Console.ReadLine());

//        // Round the number to the nearest integer
//        int roundedNumber = (int)Math.Round(number);

//        // Display the result
//        Console.WriteLine($"{number} rounded to the nearest integer is {roundedNumber}");
//    }
//}


//Part 7
// Use the Math class to find the smallest integer greater than or equal to a number.
// Hint: Use the Ceiling method of the Math class.
// Test Data:
// Enter a number: 3.14
// Expected Output:
// The smallest integer greater than or equal to 3.14 is 4

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Prompt the user to enter a number
//        Console.Write("Enter a number: ");
//        double number = double.Parse(Console.ReadLine());

//        // Find the smallest integer greater than or equal to the number
//        double ceilingNumber = Math.Ceiling(number);

//        // Display the result
//        Console.WriteLine($"The smallest integer greater than or equal to {number} is {ceilingNumber}");
//    }
//}


//Part 8
// Use the Math class to find the largest integer less than or equal to a number.
// Hint: Use the Floor method of the Math class.
// Test Data:
// Enter a number: 3.14
// Expected Output:
// The largest integer less than or equal to 3.14 is 3

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Prompt the user to enter a number
//        Console.Write("Enter a number: ");
//        double number = double.Parse(Console.ReadLine());

//        // Find the largest integer less than or equal to the number
//        double floorNumber = Math.Floor(number);

//        // Display the result
//        Console.WriteLine($"The largest integer less than or equal to {number} is {floorNumber}");
//    }
//}


//Part 9
// Use the Math class to calculate e raised to the power of a number.
// Hint: Use the Exp method of the Math class.
// Test Data:
// Enter a number: 2
// Expected Output:
// e raised to the power of 2 is 7.38905609893065

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Prompt the user to enter a number
//        Console.Write("Enter a number: ");
//        double number = double.Parse(Console.ReadLine());

//        // Calculate e raised to the power of the number
//        double result = Math.Exp(number);

//        // Display the result
//        Console.WriteLine($"e raised to the power of {number} is {result}");
//    }
//}


//Part 10
// Use the Math class to calculate the natural logarithm of a number.
// Hint: Use the Log method of the Math class.
// Test Data:
// Enter a number: 100
// Expected Output:
// The natural logarithm of 100 is 4.60517018598809

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Prompt the user to enter a number
//        Console.Write("Enter a number: ");
//        double number = double.Parse(Console.ReadLine());

//        // Calculate the natural logarithm of the number
//        double result = Math.Log(number);

//        // Display the result
//        Console.WriteLine($"The natural logarithm of {number} is {result}");
//    }
//}


//Part 11
// Generate a random number between 1 and 100 using the Math class.
// Hint: Use the Random method of the Math class.
// Expected Output:
// A random number between 1 and 100 is 56

using System;

class Program
{
    static void Main(string[] args)
    {
        // Generate a random number between 1 and 100
        Random random = new Random();
        int randomNumber = random.Next(1, 101);

        // Display the result
        Console.WriteLine($"A random number between 1 and 100 is {randomNumber}");
    }
}
