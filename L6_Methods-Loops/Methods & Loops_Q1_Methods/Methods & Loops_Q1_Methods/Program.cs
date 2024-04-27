//---------------------------------------------------------------------
// Part 1: Displaying a Welcome Message
// Create a user-defined function to display a welcome message.
// Hint: Define a function named DisplayWelcomeMessage() that prints the welcome message to the console.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Call the DisplayWelcomeMessage function
//        DisplayWelcomeMessage();
//    }

//    // User-defined function to display a welcome message
//    static void DisplayWelcomeMessage()
//    {
//        Console.WriteLine("Welcome to our program!");
//    }
//}

//---------------------------------------------------------------------
// Part 2: Personalized Welcome Message
// Create a user-defined function with parameters to personalize a welcome message.
// Hint: Define a function named PersonalizedWelcomeMessage() that takes a name as a parameter and prints a personalized welcome message to the console.

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Prompt the user to enter their name
//        Console.Write("Enter your name: ");
//        string name = Console.ReadLine();

//        // Call the function to display a personalized welcome message
//        PersonalizedWelcomeMessage(name);
//    }

//    // User-defined function to print a personalized welcome message
//    static void PersonalizedWelcomeMessage(string name)
//    {
//        Console.WriteLine($"Welcome, {name}! Have a great day!");
//    }
//}



//---------------------------------------------------------------------
// Part 3: Calculating the Sum of Two Numbers
// Create a user-defined function to calculate the sum of two numbers.
// Hint: Define a function named CalculateSum() that takes two parameters, adds them, and returns the result.

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Prompt the user to enter two numbers
//        Console.Write("Enter the first number: ");
//        int num1 = int.Parse(Console.ReadLine());

//        Console.Write("Enter the second number: ");
//        int num2 = int.Parse(Console.ReadLine());

//        // Call the function to calculate the sum of the entered numbers
//        int sum = CalculateSum(num1, num2);
//        Console.WriteLine($"The sum of the numbers is: {sum}");
//    }

//    // User-defined function to calculate the sum of two numbers
//    static int CalculateSum(int num1, int num2)
//    {
//        return num1 + num2;
//    }
//}


//---------------------------------------------------------------------
// Part 4: Counting Spaces in a String
// Create a user-defined function to count the number of spaces in a string.
// Hint: Define a function named CountSpaces() that takes a string as a parameter, counts the number of spaces, and returns the count.

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Prompt the user to enter a string
//        Console.Write("Enter a string: ");
//        string inputString = Console.ReadLine();

//        // Call the function to count spaces in the string
//        int spaceCount = CountSpaces(inputString);
//        Console.WriteLine($"Number of spaces in the string: {spaceCount}");
//    }

//    // User-defined function to count spaces in a string
//    static int CountSpaces(string input)
//    {
//        int count = 0;
//        foreach (char c in input)
//        {
//            if (c == ' ')
//            {
//                count++;
//            }
//        }
//        return count;
//    }
//}


//---------------------------------------------------------------------
// Part 5: Calculating the Sum of Elements in an Array
// Create a user-defined function to calculate the sum of elements in an array.
// Hint: Define a function named CalculateArraySum() that takes an array as a parameter, calculates the sum of its elements, and returns the sum.

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Prompt the user to enter the size of the array
//        Console.Write("Enter the size of the array: ");
//        int size = int.Parse(Console.ReadLine());

//        // Create an array of the specified size
//        int[] numbers = new int[size];

//        // Prompt the user to enter the elements of the array
//        for (int i = 0; i < size; i++)
//        {
//            Console.Write($"Enter element {i + 1}: ");
//            numbers[i] = int.Parse(Console.ReadLine());
//        }

//        // Call the function to calculate the sum of elements in the array
//        int sum = CalculateArraySum(numbers);
//        Console.WriteLine($"Sum of elements in the array: {sum}");
//    }

//    // User-defined function to calculate the sum of elements in an array
//    static int CalculateArraySum(int[] arr)
//    {
//        int sum = 0;
//        foreach (int num in arr)
//        {
//            sum += num;
//        }
//        return sum;
//    }
//}



//---------------------------------------------------------------------
// Part 6: Swapping Two Integer Numbers
// Create a user-defined function to swap two integer numbers.
// Hint: Define a function named SwapNumbers() that takes two integer parameters, swaps their values, and prints the updated values to the console.

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Prompt the user to enter two numbers
//        Console.Write("Enter the first number: ");
//        int num1 = int.Parse(Console.ReadLine());

//        Console.Write("Enter the second number: ");
//        int num2 = int.Parse(Console.ReadLine());

//        // Call the function to swap the numbers
//        SwapNumbers(ref num1, ref num2);

//        // Display the swapped numbers
//        Console.WriteLine($"After swapping:");
//        Console.WriteLine($"First number: {num1}");
//        Console.WriteLine($"Second number: {num2}");
//    }

//    // User-defined function to swap two integer numbers
//    static void SwapNumbers(ref int num1, ref int num2)
//    {
//        int temp = num1;
//        num1 = num2;
//        num2 = temp;
//    }
//}


//---------------------------------------------------------------------
// Part 7: Calculating Exponentiation
// Create a user-defined function to calculate the result of raising an integer number to another.
// Hint: Define a function named CalculateExponent() that takes two integer parameters (base and exponent), calculates the result, and prints it to the console.

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Prompt the user to enter the base and exponent
//        Console.Write("Enter the base: ");
//        int baseNum = int.Parse(Console.ReadLine());

//        Console.Write("Enter the exponent: ");
//        int exponent = int.Parse(Console.ReadLine());

//        // Call the function to calculate exponentiation
//        int result = CalculateExponent(baseNum, exponent);

//        // Display the result
//        Console.WriteLine($"Result of raising {baseNum} to the power of {exponent}: {result}");
//    }

//    // User-defined function to calculate exponentiation
//    static int CalculateExponent(int baseNum, int exponent)
//    {
//        // Handle special cases where exponent is 0 or 1
//        if (exponent == 0)
//        {
//            return 1;
//        }
//        else if (exponent == 1)
//        {
//            return baseNum;
//        }

//        // Calculate the result by multiplying baseNum by itself exponent times
//        int result = 1;
//        for (int i = 0; i < exponent; i++)
//        {
//            result *= baseNum;
//        }
//        return result;
//    }
//}


//---------------------------------------------------------------------
// Part 8: Displaying the Fibonacci Sequence
// Create a user-defined function to display the Fibonacci sequence up to a specified number of terms.
// Hint: Define a function named DisplayFibonacciSequence() that takes an integer parameter (number of terms), calculates and prints the Fibonacci sequence to the console.

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Prompt the user to enter the number of terms
//        Console.Write("Enter the number of terms in the Fibonacci sequence: ");
//        int numOfTerms = int.Parse(Console.ReadLine());

//        // Call the function to display the Fibonacci sequence
//        DisplayFibonacciSequence(numOfTerms);
//    }

//    // User-defined function to display the Fibonacci sequence
//    static void DisplayFibonacciSequence(int numOfTerms)
//    {
//        int firstNum = 0, secondNum = 1;

//        Console.WriteLine("Fibonacci sequence:");

//        // Display the first two terms of the sequence
//        Console.Write($"{firstNum}, {secondNum}");

//        // Display subsequent terms of the sequence
//        for (int i = 2; i < numOfTerms; i++)
//        {
//            int nextNum = firstNum + secondNum;
//            Console.Write($", {nextNum}");
//            firstNum = secondNum;
//            secondNum = nextNum;
//        }

//        Console.WriteLine();
//    }
//}


//---------------------------------------------------------------------
// Part 9: Checking Prime Numbers
// Create a user-defined function to check whether a number is prime or not.
// Hint: Define a function named CheckPrimeNumber() that takes an integer parameter, checks if it's prime, and prints the result to the console.
//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Prompt the user to enter a number
//        Console.Write("Enter a number to check if it's prime: ");
//        int number = int.Parse(Console.ReadLine());

//        // Call the function to check if the number is prime
//        CheckPrimeNumber(number);
//    }

//    // User-defined function to check if a number is prime
//    static void CheckPrimeNumber(int number)
//    {
//        bool isPrime = true;

//        // Corner cases
//        if (number <= 1)
//        {
//            isPrime = false;
//        }
//        else
//        {
//            // Check for factors from 2 to sqrt(number)
//            for (int i = 2; i * i <= number; i++)
//            {
//                if (number % i == 0)
//                {
//                    isPrime = false;
//                    break;
//                }
//            }
//        }

//        // Display the result
//        if (isPrime)
//        {
//            Console.WriteLine($"{number} is a prime number.");
//        }
//        else
//        {
//            Console.WriteLine($"{number} is not a prime number.");
//        }
//    }
//}



//---------------------------------------------------------------------
// Part 10: Calculating the Sum of Individual Digits
// Create a user-defined function to calculate the sum of individual digits of a given number.
// Hint: Define a function named CalculateDigitSum() that takes an integer parameter, calculates the sum of its digits, and prints the result to the console.

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Prompt the user to enter a number
//        Console.Write("Enter a number to calculate the sum of its digits: ");
//        int number = int.Parse(Console.ReadLine());

//        // Call the function to calculate the sum of digits
//        CalculateDigitSum(number);
//    }

//    // User-defined function to calculate the sum of individual digits of a number
//    static void CalculateDigitSum(int number)
//    {
//        int sum = 0;
//        int originalNumber = number;

//        // Iterate through each digit of the number and add it to the sum
//        while (number != 0)
//        {
//            int digit = number % 10;
//            sum += digit;
//            number /= 10;
//        }

//        // Display the result
//        Console.WriteLine($"Sum of individual digits of {originalNumber}: {sum}");
//    }
//}


//---------------------------------------------------------------------
// Part 11: Testing Named Parameters in C#
// Write a C# program that defines a method called "DisplayInfo" that takes two parameters: "name" and "age".
// Use named parameters to call the "DisplayInfo" method with the parameter values "name"="John" and "age"=30.
// Hint: Define the method "DisplayInfo" with parameters "name" and "age", then call it using named parameters.

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Call the DisplayInfo method using named parameters
//        DisplayInfo(name: "John", age: 30);
//    }

//    // Method to display information
//    static void DisplayInfo(string name, int age)
//    {
//        Console.WriteLine($"Name: {name}, Age: {age}");
//    }
//}



//---------------------------------------------------------------------
// Part 12: Testing Out Parameters in C#
// Write a C# program that defines a method called "GetSquareRoot" that calculates the square root of a number.
// Use an out parameter to return the square root of a given number.
// Hint: Define the method "GetSquareRoot" with an out parameter to store the result.

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Define a number for which square root needs to be calculated
//        double number = 25;

//        // Call the GetSquareRoot method with out parameter
//        double result;
//        GetSquareRoot(number, out result);

//        // Display the result
//        Console.WriteLine($"Square root of {number} is: {result}");
//    }

//    // Method to calculate square root with an out parameter
//    static void GetSquareRoot(double number, out double result)
//    {
//        result = Math.Sqrt(number);
//    }
//}


//---------------------------------------------------------------------
// Part 13: Testing Default or Optional Parameters in C#
// Write a C# program that defines a method called "GreetUser" with two parameters: "name" and "greetingMessage".
// Set the default value of "greetingMessage" to "Hello".
// Call the "GreetUser" method with only the "name" parameter provided.
// Hint: Define the method "GreetUser" with a default value for one of its parameters.

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Call the GreetUser method with only the "name" parameter provided
//        GreetUser("John");
//    }

//    // Method to greet the user with a default greeting message
//    static void GreetUser(string name, string greetingMessage = "Hello")
//    {
//        Console.WriteLine($"{greetingMessage}, {name}!");
//    }
//}
