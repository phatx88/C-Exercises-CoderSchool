//Example of Try-Catch Block:

//try
//{
//    // Code that might throw an exception
//}
//catch (ExceptionType1 ex)
//{
//    // Code to handle ExceptionType1
//}
//catch (ExceptionType2 ex)
//{
//    // Code to handle ExceptionType2
//}
//finally
//{
//    // Code that always runs, regardless of exceptions
//}




// Question 1
// Write a C# program that attempts to divide two numbers and prints any exceptions that may occur.
// Hint: Use a try block to perform the division and a catch block to print any exceptions.
// Test Data: Dividing 10 by 0

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        try
//        {
//            // Prompt the user to enter the dividend
//            Console.Write("Enter the dividend: ");
//            int dividend = int.Parse(Console.ReadLine());

//            // Prompt the user to enter the divisor
//            Console.Write("Enter the divisor: ");
//            int divisor = int.Parse(Console.ReadLine());

//            // Perform the division
//            int result = dividend / divisor;
//            Console.WriteLine($"Result of division: {result}");
//        }
//        catch (DivideByZeroException ex)
//        {
//            Console.WriteLine($"Error: {ex.Message}");
//        }
//        catch (FormatException ex)
//        {
//            Console.WriteLine($"Error: {ex.Message}. Please enter valid integer values.");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"An error occurred: {ex.Message}");
//        }
//    }
//}


// Question 2
// Create a program that converts a string to an integer and prints any exceptions that may occur.
// Hint: Use a try block to convert the string to an integer and a catch block to print any exceptions.
// Test Data: Converting 'abc' to an integer

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

//            // Convert the string to an integer
//            int number = int.Parse(input);

//            // Print the converted integer
//            Console.WriteLine($"Converted integer: {number}");
//        }
//        catch (FormatException ex)
//        {
//            Console.WriteLine($"Error: {ex.Message}. Input string was not in the correct format.");
//        }
//        catch (OverflowException ex)
//        {
//            Console.WriteLine($"Error: {ex.Message}. Input string represents a number that is outside the range of integers.");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"An error occurred: {ex.Message}");
//        }
//    }
//}


// Question 3
// Write a C# program that opens a file and prints any exceptions that may occur.
// Hint: Use a try block to open the file and a catch block to print any exceptions.
// Test Data: Opening a non-existent file

//using System;
//using System.IO;

//class Program
//{
//    static void Main(string[] args)
//    {
//        try
//        {
//            // Prompt the user to enter the file path
//            Console.Write("Enter the file path: ");
//            string filePath = Console.ReadLine();

//            // Open the file
//            FileStream fileStream = File.Open(filePath, FileMode.Open);

//            // Close the file stream
//            fileStream.Close();

//            Console.WriteLine("File opened successfully.");
//        }
//        catch (FileNotFoundException ex)
//        {
//            Console.WriteLine($"Error: {ex.Message}. File not found.");
//        }
//        catch (ArgumentException ex)
//        {
//            Console.WriteLine($"Error: {ex.Message}. Invalid file path.");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"An error occurred: {ex.Message}");
//        }
//    }
//}


// Question 4
// Create a program that reads input from the user and prints any exceptions that may occur.
// Hint: Use a try block to read input from the user and a catch block to print any exceptions.
// Test Data: Reading input from the user

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        try
//        {
//            // Prompt the user to enter input
//            Console.Write("Enter input: ");
//            string input = Console.ReadLine();

//            // Print the input
//            Console.WriteLine($"Input: {input}");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"An error occurred: {ex.Message}");
//        }
//    }
//}


// Question 5
// Write a C# program that performs a calculation and prints any exceptions that may occur.
// Hint: Use a try block to perform the calculation and a catch block to print any exceptions.
// Test Data: Performing a calculation with invalid operands
using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Prompt the user to enter the operands
            Console.Write("Enter the first operand: ");
            int operand1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second operand: ");
            int operand2 = int.Parse(Console.ReadLine());

            // Perform the calculation
            int result = operand1 / operand2;
            Console.WriteLine($"Result of calculation: {result}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Error: {ex.Message}. Please enter valid integer operands.");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Error: {ex.Message}. Attempted to divide by zero.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}

