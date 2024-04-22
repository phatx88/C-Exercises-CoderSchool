// To test out your code , comment the other parts and uncomment the part you want to test.
//To comment a part, select the part and press Ctrl + K + C
//To uncomment a part, select the part and press Ctrl + K + U
//Press Ctrl + F5 to run the code.

//////////////5 Syntax Example Questions://///////////



//Part 1

//Declare an integer variable named "num" and assign it the value 10. Print the value of "num" to the console.
//Hint: Use the Console.WriteLine() method to print the value of "num".
//Test Data:
//Expected Output:
//The value of num is: 10

//// Declare an integer variable named "num" and assign it the value 10
//int num = 10;

//// Print the value of "num" to the console
//Console.WriteLine("The value of num is: " + num);


//Part 2

//Concatenate two strings, "firstName" and "lastName", and print the result.
//Hint: Use the + operator to concatenate strings and the Console.WriteLine() method to print the result.
//Test Data:
//firstName = "John"
//lastName = "Doe"
//Expected Output:
//The full name is: John Doe


//// Test data
//string firstName = "John";
//string lastName = "Doe";

//// Concatenate the strings and print the result
//Console.WriteLine("The full name is: " + firstName + " " + lastName);

//Part 3

//Get the user's age as input and print it to the console.
//Hint: Use the Console.ReadLine() method to get the user's input and the Console.WriteLine() method to print the result.
//Test Data:
//Enter your age: 25
//Expected Output:
//Your age is: 25

//// Prompt the user to enter their age
//Console.Write("Enter your age: ");

//// Read the user's input as a string
//string ageInput = Console.ReadLine();

//// Convert the string input to an integer
//int age = Convert.ToInt32(ageInput);

//// Print the user's age to the console
//Console.WriteLine("Your age is: " + age);

//Part 4

//Calculate the sum of two integers, 5 and 7, and print the result.
//Hint: Use the + operator to add integers and the Console.WriteLine() method to print the result.
//Test Data:
//Expected Output:
//The sum of 5 and 7 is: 12

//// Declare two integer variables and initialize them with values
//int num1 = 5;
//int num2 = 7;

//// Calculate the sum of the two integers
//int sum = num1 + num2;

//// Print the result to the console
//Console.WriteLine("The sum of {0} and {1} is: {2}", num1, num2, sum);


//Part 5

//Convert the temperature from Celsius to Fahrenheit. Given Celsius value = 25, print the Fahrenheit equivalent.
//Hint: Use the formula (Celsius * 9/5) + 32 to convert Celsius to Fahrenheit and the Console.WriteLine() method to print the result.
//Test Data:
//Celsius temperature: 25
//Expected Output:
//The Fahrenheit equivalent is: 77

//// Given Celsius temperature
//double celsius = 25;

//// Convert Celsius to Fahrenheit
//double fahrenheit = (celsius * 9 / 5) + 32;

//// Print the Fahrenheit equivalent
//Console.WriteLine("The Fahrenheit equivalent is: " + fahrenheit);



//////////////5 Questions with Game Context://////////////////





//Part 6

//In a game, declare an integer variable named "playerHealth" and set it to 100. Print the player's health.
//Hint: Use the Console.WriteLine() method to print the value of "playerHealth".
//Test Data:
//Expected Output:
//Player's health: 100


//// Declare an integer variable named "playerHealth" and set it to 100
//int playerHealth = 100;

//// Print the player's health
//Console.WriteLine("Player's health: " + playerHealth);

//Part 7

//Get the player's name as input and concatenate it with the game's title. Print the result.
//Hint: Use the Console.ReadLine() method to get the player's name, concatenate it with the game's title using the + operator, and print the result using the Console.WriteLine() method.
//Test Data:
//Enter your name: Alice
//Expected Output:
//Welcome to the game, Alice!

// Prompt the user to enter their name
//Console.Write("Enter your name: ");

//// Read the user's input as a string
//string playerName = Console.ReadLine();

//// Concatenate the player's name with the game's title
//string gameTitle = "game";
//string welcomeMessage = "Welcome to the " + gameTitle + ", " + playerName + "!";

//// Print the welcome message
//Console.WriteLine(welcomeMessage);

//Part 8

//Calculate the area of a rectangular movement space in a game. Given length = 10 and width = 5, print the area.
//Hint: Use the formula area = length * width and the Console.WriteLine() method to print the result.
//Test Data:
//Length: 10
//Width: 5
//Expected Output:
//The area of the rectangular movement space is: 50

//// Given length and width of the rectangular movement space
//int length = 10;
//int width = 5;

//// Calculate the area of the rectangular movement space
//int area = length * width;

//// Print the area
//Console.WriteLine("The area of the rectangular movement space is: " + area);

//Part 9


//In a game, the player's level is stored as a string (e.g., "Level 5"), but you need to extract the numeric part to perform calculations. Convert the player's level from a string to an integer and print the result.

//Test Data
//Player's Level: Level 10
//Player's Level as an integer: 10

//// Player's level stored as a string
//string playerLevelString = "Level 10";

//// Extract the numeric part of the player's level using substring method to extract starting string index 6th
//string numericPart = playerLevelString.Substring(6);

//// Convert the numeric part to an integer
//int playerLevel = Convert.ToInt32(numericPart);

//// Print the player's level as an integer
//Console.WriteLine("Player's Level as an integer: " + playerLevel);


//Part 10

//In a game, calculate the total score. Given points for killing an enemy = 100 and points for collecting a bonus = 50, print the total score.
//Hint: Add the points together and use the Console.WriteLine() method to print the total score.
//Test Data:
//Expected Output:
//The total score is: 150

//// Points for killing an enemy and collecting a bonus
//int pointsForKillingEnemy = 100;
//int pointsForCollectingBonus = 50;

//// Calculate the total score
//int totalScore = pointsForKillingEnemy + pointsForCollectingBonus;

//// Print the total score
//Console.WriteLine("The total score is: " + totalScore);


//////////////////5 Harder Questions://///////////////





//Part 11

//In this C# program, we will take the input string from the user and change it to 1)Upper Case 2)Lower Case 3)Title Case.

//Test Data:
//Enter the string: welcome to the world of C#
//Expected Output:
//The string in upper case: WELCOME TO THE WORLD OF C#
//The string in lower case: welcome to the world of c#
//The string in title case: Welcome To The World Of C#

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Prompt the user to enter a string
//        Console.Write("Enter the string: ");

//        // Read the user's input
//        string inputString = Console.ReadLine();

//        // Convert the string to upper case and print
//        string upperCaseString = inputString.ToUpper();
//        Console.WriteLine("The string in upper case: " + upperCaseString);

//        // Convert the string to lower case and print
//        string lowerCaseString = inputString.ToLower();
//        Console.WriteLine("The string in lower case: " + lowerCaseString);

//        // Convert the string to title case and print
//        string titleCaseString = ToTitleCase(inputString);
//        Console.WriteLine("The string in title case: " + titleCaseString);
//    }

//    // Function to convert string to title case by looping thorugh each words, add each word to array, convert first char to upper case, then add into new string
//    static string ToTitleCase(string str)
//    {
//        string[] words = str.Split(' ');

//        for (int i = 0; i < words.Length; i++)
//        {
//            if (!string.IsNullOrEmpty(words[i]))
//            {
//                char[] letters = words[i].ToCharArray();
//                letters[0] = char.ToUpper(letters[0]);
//                words[i] = new string(letters);
//            }
//        }

//        return string.Join(" ", words);
//    }
//}





//Part 12

//Calculate the compound interest for a game currency. Given principal amount = 1000, interest rate = 5%, and time period = 3 years, print the compound interest.
//Hint: Use the formula compoundInterest = principalAmount * (1 + interestRate/100)^timePeriod - principalAmount and the Console.WriteLine() method to print the result.
//Test Data:
//Enter the principal amount: 1000
//Enter the interest rate: 5
//Enter the time period: 3
//Expected Output:
//The compound interest is: 157.63

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Prompt the user to enter the principal amount
//        Console.Write("Enter the principal amount: ");
//        double principalAmount = Convert.ToDouble(Console.ReadLine());

//        // Prompt the user to enter the interest rate
//        Console.Write("Enter the interest rate: ");
//        double interestRate = Convert.ToDouble(Console.ReadLine());

//        // Prompt the user to enter the time period
//        Console.Write("Enter the time period: ");
//        int timePeriod = Convert.ToInt32(Console.ReadLine());

//        // Calculate the compound interest
//        double compoundInterest = CalculateCompoundInterest(principalAmount, interestRate, timePeriod);

//        // Print the compound interest
//        Console.WriteLine("The compound interest is: " + compoundInterest.ToString("0.00"));
//    }

//    // Function to calculate compound interest
//    static double CalculateCompoundInterest(double principalAmount, double interestRate, int timePeriod)
//    {
//        double compoundInterest = principalAmount * Math.Pow(1 + interestRate / 100, timePeriod) - principalAmount;
//        return compoundInterest;
//    }
//}


//Part 13

// Write a  program to swap two numbers.
//Given numbers = 5 and 10, swap them and print the result.
//Hint: Use a temporary variable to swap the numbers and the Console.WriteLine() method to print the result.
//Test Data:
//Enter the first number: 5
//Enter the second number: 10
//Expected Output:
//After swapping:
//First number: 10
//Second number: 5

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Prompt the user to enter the first number
//        Console.Write("Enter the first number: ");
//        int firstNumber = Convert.ToInt32(Console.ReadLine());

//        // Prompt the user to enter the second number
//        Console.Write("Enter the second number: ");
//        int secondNumber = Convert.ToInt32(Console.ReadLine());

//        // Swap the numbers using a temporary variable
//        int temp = firstNumber;
//        firstNumber = secondNumber;
//        secondNumber = temp;

//        // Print the numbers after swapping
//        Console.WriteLine("After swapping:");
//        Console.WriteLine("First number: " + firstNumber);
//        Console.WriteLine("Second number: " + secondNumber);
//    }
//}



//Part 14
//Write a C# program to find the largest of three numbers.
//Test Data:
//Enter the first number: 25
//Enter the second number: 78
//Enter the third number: 87
//Expected Output:
//The 3 numbers are: 25 78 87
//The greatest number is: 87


//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Prompt the user to enter three numbers
//        Console.Write("Enter the first number: ");
//        int firstNumber = Convert.ToInt32(Console.ReadLine());

//        Console.Write("Enter the second number: ");
//        int secondNumber = Convert.ToInt32(Console.ReadLine());

//        Console.Write("Enter the third number: ");
//        int thirdNumber = Convert.ToInt32(Console.ReadLine());

//        // Print the entered numbers
//        Console.WriteLine("The 3 numbers are: " + firstNumber + " " + secondNumber + " " + thirdNumber);

//        // Find the largest number among the three
//        int largestNumber = FindLargestNumber(firstNumber, secondNumber, thirdNumber);

//        // Print the greatest number
//        Console.WriteLine("The greatest number is: " + largestNumber);
//    }

//    // Function to find the largest number among three numbers
//    static int FindLargestNumber(int num1, int num2, int num3)
//    {
//        int largest = num1;
//        if (num2 > largest)
//            largest = num2;
//        if (num3 > largest)
//            largest = num3;
//        return largest;
//    }
//}



//Part 15

//Determine the greatest common divisor (GCD) of two numbers. Given numbers = 12 and 18, print their GCD.
//Hint: Use the Euclidean algorithm to find the GCD and the Console.WriteLine() method to print the result.
//Test Data:
//Enter the first number: 12
//Enter the second number: 18
//Expected Output:
//The GCD of 12 and 18 is: 6


//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Prompt the user to enter the first number
//        Console.Write("Enter the first number: ");
//        int num1 = Convert.ToInt32(Console.ReadLine());

//        // Prompt the user to enter the second number
//        Console.Write("Enter the second number: ");
//        int num2 = Convert.ToInt32(Console.ReadLine());

//        // Find the GCD of the two numbers
//        int gcd = FindGCD(num1, num2);

//        // Print the GCD
//        Console.WriteLine("The GCD of " + num1 + " and " + num2 + " is: " + gcd);
//    }

//    // Function to find the GCD using the Euclidean algorithm
//    static int FindGCD(int num1, int num2)
//    {
//        while (num2 != 0)
//        {
//            int temp = num2;
//            num2 = num1 % num2;
//            num1 = temp;
//        }
//        return num1;
//    }
//}





////////////5 Even Harder Questions://///////////////




//Part 16

//Write a program to calculate the volume of a sphere. Given radius = 3, print the volume.
//Hint: Use the formula volume = (4/3) * π * radius^3 and the Console.WriteLine() method to print the result.
//Test Data:
//Enter the radius of the sphere: 3
//Expected Output:
//The volume of the sphere is: 113.09733552923255


//Part 17

//Find the index of a character in a string starting from a specified position. Given string = "hello world", character = 'o', starting position = 5, print the index.
//Hint: Use the IndexOf() method with the starting position parameter and the Console.WriteLine() method to print the index.
//Test Data:
//Enter the string: hello world
//Enter the character to find: o
//Enter the starting position: 5
//Expected Output:
//The index of 'o' starting from position 5 is: 7


//Part 18

//Remove a specific character from a string. Given string = "apple", remove the character 'p' and print the result.
//Hint: Use the Remove() method to remove the character and the Console.WriteLine() method to print the result.
//Test Data:
//Enter the string: apple
//Enter the character to remove: p
//Expected Output:
//The string after removing 'p' is: ale


//Part 19

//Replace all occurrences of a character in a string with another character. Given string = "banana", replace 'a' with 'o' and print the result.
//Hint: Use the Replace() method to replace the character and the Console.WriteLine() method to print the result.
//Test Data:
//Enter the string: banana
//Enter the character to replace: a
//Enter the character to replace with: o
//Expected Output:
//The string after replacing 'a' with 'o' is: bonono


//Part 20

//Extract a substring from a string. Given string = "hello world", extract the substring from index 3 to 7 and print the result
//Hint: Use the Substring() method with the start index and length parameters and the Console.WriteLine() method to print the result.
//Test Data:
//Enter the string: hello world
//Enter the start index: 3
//Enter the end index: 7
//Expected Output:
//The substring from index 3 to 7 is: lo w

