
// Guide to Exceptions in C#:

// System.ArgumentNullException:
// - Thrown when a null argument is passed to a method that does not accept null arguments.

// System.FormatException:
// - Thrown when a method is called with an invalid format for its input arguments.

// System.IndexOutOfRangeException:
// - Thrown when an attempt is made to access an element of an array or collection with an index outside the bounds.

// System.InvalidCastException:
// - Thrown when an invalid type conversion is attempted.

// System.IO.IOException:
// - Thrown when an I/O error occurs, such as when reading from or writing to a file.

// System.DivideByZeroException:
// - Thrown when attempting to divide an integer or decimal number by zero.

// System.NullReferenceException:
// - Thrown when attempting to access a member of a null object reference.

// System.OverflowException:
// - Thrown when an arithmetic operation results in an overflow.

// System.NotImplementedException:
// - Thrown when a method or feature is not yet implemented.

// System.OutOfMemoryException:
// - Thrown when attempting to allocate memory fails due to insufficient available memory.

// System.StackOverflowException:
// - Thrown when the execution stack overflows, typically due to excessive recursion.

// System.TimeoutException:
// - Thrown when an operation times out before completing.

// System.ArgumentException:
// - Thrown when one or more arguments provided to a method are invalid or out of range.

// System.ArithmeticException:
// - Thrown for errors in arithmetic operations.

// System.Security.SecurityException:
// - Thrown when a security violation occurs, such as attempting to perform an operation that requires elevated permissions.



//Part 1
//Write a C# program that prompts the user to input two numbers and divides them. Handle an exception when the user enters non-numeric values.
//Hint: Use the TryParse method to convert the input string to a number.
//Hint:Use FormatException for non-numeric values and DivideByZeroException for division by zero.

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        try
//        {
//            // Prompt the user to input two numbers
//            Console.Write("Enter the first number: ");
//            string input1 = Console.ReadLine();
//            Console.Write("Enter the second number: ");
//            string input2 = Console.ReadLine();

//            // Parse the input strings to numbers
//            if (!double.TryParse(input1, out double number1) || !double.TryParse(input2, out double number2))
//            {
//                throw new FormatException("Non-numeric input detected.");
//            }

//            // Check if the second number is zero
//            if (number2 == 0)
//            {
//                throw new DivideByZeroException("Division by zero is not allowed.");
//            }

//            // Perform the division
//            double result = number1 / number2;
//            Console.WriteLine($"Result of division: {result}");
//        }
//        catch (FormatException ex)
//        {
//            Console.WriteLine($"Error: {ex.Message}");
//        }
//        catch (DivideByZeroException ex)
//        {
//            Console.WriteLine($"Error: {ex.Message}");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"An error occurred: {ex.Message}");
//        }
//    }
//}



//Part 2
// Write a C# program that reads a string from the user and converts it to an integer. Handle the exception if the input cannot be parsed into an integer.
//Hint: Use the TryParse method to convert the input string to an integer.
//Hint: Use FormatException for invalid input.

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        try
//        {
//            // Prompt the user to enter a string
//            Console.Write("Enter a string to convert to an integer: ");
//            string input = Console.ReadLine();

//            // Parse the input string to an integer
//            if (!int.TryParse(input, out int number))
//            {
//                throw new FormatException("Invalid input. Please enter a valid integer.");
//            }

//            // Print the converted integer
//            Console.WriteLine($"Converted integer: {number}");
//        }
//        catch (FormatException ex)
//        {
//            Console.WriteLine($"Error: {ex.Message}");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"An error occurred: {ex.Message}");
//        }
//    }
//}



//Part 3
//Write a C# program that implements a method that divides two numbers. Handle the DivideByZeroException that occurs if the denominator is 0.
//Hint: Use a try-catch block to catch the DivideByZeroException.


//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        try
//        {
//            // Prompt the user to enter two numbers
//            Console.Write("Enter the numerator: ");
//            double numerator = double.Parse(Console.ReadLine());
//            Console.Write("Enter the denominator: ");
//            double denominator = double.Parse(Console.ReadLine());

//            // Perform division
//            double result = DivideNumbers(numerator, denominator);
//            Console.WriteLine($"Result of division: {result}");
//        }
//        catch (DivideByZeroException ex)
//        {
//            Console.WriteLine($"Error: {ex.Message}");
//        }
//        catch (FormatException ex)
//        {
//            Console.WriteLine($"Error: {ex.Message}. Please enter valid numeric values.");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"An error occurred: {ex.Message}");
//        }
//    }

//    static double DivideNumbers(double numerator, double denominator)
//    {
//        if (denominator == 0)
//        {
//            throw new DivideByZeroException("Cannot divide by zero.");
//        }

//        return numerator / denominator;
//    }
//}


//Part 4
//Write a C# program that creates a method that takes a string as input and converts it to uppercase. Handle the NullReferenceException that occurs if the input string is null.
//Hint: Use a try-catch block to catch the NullReferenceException.

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        try
//        {
//            // Prompt the user to enter a string
//            Console.Write("Enter a string: ");
//            string input = Console.ReadLine();

//            // Convert the string to uppercase
//            string result = ConvertToUpperCase(input);
//            Console.WriteLine($"Uppercase string: {result}");
//        }
//        catch (NullReferenceException ex)
//        {
//            Console.WriteLine($"Error: {ex.Message}. Input string is null.");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"An error occurred: {ex.Message}");
//        }
//    }

//    static string ConvertToUpperCase(string input)
//    {
//        if (input == null)
//        {
//            throw new NullReferenceException("Input string cannot be null.");
//        }

//        return input.ToUpper();
//    }
//}

