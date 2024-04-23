

//Part 1
// Get two inputs from the userds and store them in two variables and use and if statement to check if the two inputs are equal and print out a message to the console.
// Hint: You can use the == operator to check if two values are equal.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Prompt the user to enter the first input
//        Console.Write("Enter the first input: ");
//        string input1 = Console.ReadLine();

//        // Prompt the user to enter the second input
//        Console.Write("Enter the second input: ");
//        string input2 = Console.ReadLine();

//        // Check if the two inputs are equal
//        if (input1 == input2)
//        {
//            Console.WriteLine("The two inputs are equal.");
//        }
//        else
//        {
//            Console.WriteLine("The two inputs are not equal.");
//        }
//    }
//}


//Part 2
// Get two inputs from the user and store them in two variables and use an if statement to check if the first input is greater than the second input and print out a message to the console.
// Hint: You can use the > operator to check if the first input is greater than the second input.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Prompt the user to enter the first input
//        Console.Write("Enter the first input: ");
//        string input1 = Console.ReadLine();

//        // Prompt the user to enter the second input
//        Console.Write("Enter the second input: ");
//        string input2 = Console.ReadLine();

//        // Check if the first input is greater than the second input
//        if (input1.CompareTo(input2) > 0)
//        {
//            Console.WriteLine("The first input is greater than the second input.");
//        }
//        else
//        {
//            Console.WriteLine("The first input is not greater than the second input.");
//        }
//    }
//}



//Part 3
// Get two inputs from the user and store them in two variables and use an if statement to check if the first input is less than the second input and print out a message to the console.
// Hint: You can use the < operator to check if the first input is less than the second input.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Prompt the user to enter the first input
//        Console.Write("Enter the first input: ");
//        string input1 = Console.ReadLine();

//        // Prompt the user to enter the second input
//        Console.Write("Enter the second input: ");
//        string input2 = Console.ReadLine();

//        // Compare the two strings
//        if (input1.CompareTo(input2) < 0)
//        {
//            Console.WriteLine("The first input is less than the second input.");
//        }
//        else
//        {
//            Console.WriteLine("The first input is not less than the second input.");
//        }
//    }
//}



//Part 4
// Get two inputs from the user and store them in two variables and use an if statement to check if the first input is not equal to the second input and print out a message to the console.
// Hint: You can use the != operator to check if two values are not equal.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Prompt the user to enter the first input
//        Console.Write("Enter the first input: ");
//        string input1 = Console.ReadLine();

//        // Prompt the user to enter the second input
//        Console.Write("Enter the second input: ");
//        string input2 = Console.ReadLine();

//        // Check if the first input is not equal to the second input
//        if (input1 != input2)
//        {
//            Console.WriteLine("The first input is not equal to the second input.");
//        }
//        else
//        {
//            Console.WriteLine("The first input is equal to the second input.");
//        }
//    }
//}


//Part 5
// Get two inputs from the user and store them in two variables and use an if statement to check if the first input is greater than or equal to the second input and print out a message to the console.
// Hint: You can use the >= operator to check if the first input is greater than or equal to the second input.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Prompt the user to enter the first input
//        Console.Write("Enter the first input: ");
//        string input1 = Console.ReadLine();

//        // Prompt the user to enter the second input
//        Console.Write("Enter the second input: ");
//        string input2 = Console.ReadLine();

//        // Compare the two strings
//        if (input1.CompareTo(input2) >= 0)
//        {
//            Console.WriteLine("The first input is greater than or equal to the second input.");
//        }
//        else
//        {
//            Console.WriteLine("The first input is not greater than or equal to the second input.");
//        }
//    }
//}


//Part 6
// Get two inputs from the user and store them in two variables and use an if statement to check if the first input is less than or equal to the second input and print out a message to the console.
// Hint: You can use the <= operator to check if the first input is less than or equal to the second input.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Prompt the user to enter the first input
//        Console.Write("Enter the first input: ");
//        string input1 = Console.ReadLine();

//        // Prompt the user to enter the second input
//        Console.Write("Enter the second input: ");
//        string input2 = Console.ReadLine();

//        // Compare the two strings
//        int comparisonResult = string.Compare(input1, input2);

//        // Check if the first input is less than or equal to the second input
//        if (comparisonResult <= 0)
//        {
//            Console.WriteLine("The first input is less than or equal to the second input.");
//        }
//        else
//        {
//            Console.WriteLine("The first input is not less than or equal to the second input.");
//        }
//    }
//}


//Part 7
// Create a math quiz that asks the user a math question and checks if the user's answer is correct. If the user's answer is correct, print out a message to the console. If the user's answer is incorrect, print out a different message to the console.
// Hint: You can use the Console.ReadLine() method to get input from the user and use an if statement to check if the user's answer is correct.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Generate random numbers for the quiz
//        Random random = new Random();
//        int number1 = random.Next(1, 11); // Generates a random number between 1 and 10
//        int number2 = random.Next(1, 11); // Generates a random number between 1 and 10

//        // Display the math question
//        Console.WriteLine($"What is the sum of {number1} and {number2}?");

//        // Get the user's answer
//        Console.Write("Your answer: ");
//        int userAnswer;
//        if (!int.TryParse(Console.ReadLine(), out userAnswer))
//        {
//            Console.WriteLine("Invalid input. Please enter a valid integer.");
//            return;
//        }

//        // Check if the user's answer is correct
//        int correctAnswer = number1 + number2;
//        if (userAnswer == correctAnswer)
//        {
//            Console.WriteLine("Congratulations! Your answer is correct.");
//        }
//        else
//        {
//            Console.WriteLine($"Sorry, your answer is incorrect. The correct answer is {correctAnswer}.");
//        }
//    }
//}



//Part 8
// Create a program that asks the user for their age and checks if the user is old enough to vote. If the user is old enough to vote, print out a message to the console. If the user is not old enough to vote, print out a different message to the console.
// Hint: You can use the Console.ReadLine() method to get input from the user and use an if statement to check if the user is old enough to vote.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Prompt the user to enter their age
//        Console.Write("Enter your age: ");
//        int age;
//        if (!int.TryParse(Console.ReadLine(), out age))
//        {
//            Console.WriteLine("Invalid input. Please enter a valid age.");
//            return;
//        }

//        // Check if the user is old enough to vote
//        if (age >= 18)
//        {
//            Console.WriteLine("You are old enough to vote!");
//        }
//        else
//        {
//            Console.WriteLine("You are not old enough to vote yet.");
//        }
//    }
//}



//Part 9
// Create a program that check whihc state a enemy is in based on their health points. If the enemy has 100 health points, print out a message to the console. If the enemy has 50 health points, print out a different message to the console. If the enemy has 25 health points, print out a different message to the console. If the enemy has 0 health points, print out a different message to the console.
// Hint: You can use an if-else statement to check the enemy's health points and print out a message based on the enemy's health points.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Prompt the user to enter the enemy's health points
//        Console.Write("Enter the enemy's health points: ");
//        int healthPoints;
//        if (!int.TryParse(Console.ReadLine(), out healthPoints))
//        {
//            Console.WriteLine("Invalid input. Please enter a valid integer.");
//            return;
//        }

//        // Check the enemy's state based on their health points
//        if (healthPoints == 100)
//        {
//            Console.WriteLine("The enemy is in full health.");
//        }
//        else if (healthPoints == 50)
//        {
//            Console.WriteLine("The enemy is wounded.");
//        }
//        else if (healthPoints == 25)
//        {
//            Console.WriteLine("The enemy is critically wounded.");
//        }
//        else if (healthPoints == 0)
//        {
//            Console.WriteLine("The enemy is defeated.");
//        }
//        else
//        {
//            Console.WriteLine("The enemy's health points do not match any known state.");
//        }
//    }
//}


//Part 10
// Create a program that checks if a user is eligible for a discount based on their age. If the user is 18 years old or older, print out a message to the console. If the user is younger than 18 years old, print out a different message to the console.
// Hint: You can use an if-else statement to check the user's age and print out a message based on the user's age.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Prompt the user to enter their age
//        Console.Write("Enter your age: ");
//        int age;
//        if (!int.TryParse(Console.ReadLine(), out age))
//        {
//            Console.WriteLine("Invalid input. Please enter a valid age.");
//            return;
//        }

//        // Check if the user is eligible for a discount based on their age
//        if (age >= 18)
//        {
//            Console.WriteLine("You are eligible for a discount!");
//        }
//        else
//        {
//            Console.WriteLine("Sorry, you are not eligible for a discount.");
//        }
//    }
//}





////////////// Break , Continue Statements //////////////


//Part 1
// Create a program that counts from 1 to 20, but skips counting the number 5.
// Hint: Use a for loop to iterate through the numbers and a continue statement to skip the number 5.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Use a for loop to iterate through the numbers
//        for (int i = 1; i <= 20; i++)
//        {
//            // Skip counting the number 5
//            if (i == 5)
//            {
//                continue;
//            }

//            // Print the current number
//            Console.WriteLine(i);
//        }
//    }
//}


//Part 2
// Create a program that prints the numbers from 1 to 10, but breaks the loop if the number 7 is encountered.
// Hint: Use a for loop to iterate through the numbers and a break statement to exit the loop when 7 is encountered.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Use a for loop to iterate through the numbers
//        for (int i = 1; i <= 10; i++)
//        {
//            // Check if the current number is 7
//            if (i == 7)
//            {
//                // Break the loop if 7 is encountered
//                break;
//            }

//            // Print the current number
//            Console.WriteLine(i);
//        }
//    }
//}


//Part 3
// Write a program to print all even numbers from 1 to 20, but skip printing the number 10.
// Hint: Use a for loop to iterate through the numbers and an if statement with a continue statement to skip printing 10.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Use a for loop to iterate through the numbers
//        for (int i = 1; i <= 20; i++)
//        {
//            // Skip printing the number 10
//            if (i == 10)
//            {
//                continue;
//            }

//            // Check if the current number is even
//            if (i % 2 == 0)
//            {
//                // Print the current even number
//                Console.WriteLine(i);
//            }
//        }
//    }
//}


//Part 4
// Create a program that searches for the word "apple" in a list of fruits. If found, print "Apple found!"; otherwise, continue searching.
// Hint: Use a foreach loop to iterate through the list of fruits and an if statement to check if the current fruit is "apple". Use a continue statement to continue searching if "apple" is not found.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Define the list of fruits
//        string[] fruits = { "banana", "apple", "orange", "grape", "kiwi" };

//        // Use a foreach loop to iterate through the list of fruits
//        foreach (string fruit in fruits)
//        {
//            // Check if the current fruit is "apple"
//            if (fruit.ToLower() == "apple")
//            {
//                Console.WriteLine("Apple found!");
//                // Exit the loop if "apple" is found
//                break;
//            }
//        }
//    }
//}


//Part 5
// Write a program to count from 1 to 100, but skip counting by 10s.
// Hint: Use a for loop to iterate through the numbers and an if statement with a continue statement to skip counting by 10s.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Use a for loop to iterate through the numbers
//        for (int i = 1; i <= 100; i++)
//        {
//            // Skip counting by 10s
//            if (i % 10 == 0)
//            {
//                continue;
//            }

//            // Print the current number
//            Console.WriteLine(i);
//        }
//    }
//}


//Part 6
// Create a program to print the letters of the alphabet from A to G, but skip printing the letter 'E'.
// Hint: Use a for loop to iterate through the alphabet and an if statement with a continue statement to skip printing 'E'.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Use a for loop to iterate through the alphabet
//        for (char letter = 'A'; letter <= 'G'; letter++)
//        {
//            // Skip printing the letter 'E'
//            if (letter == 'E')
//            {
//                continue;
//            }

//            // Print the current letter
//            Console.WriteLine(letter);
//        }
//    }
//}


//Part 7
// Write a program to find and print all prime numbers between 1 and 50, skipping non-prime numbers.
// Hint: Use a for loop to iterate through the numbers and an if statement with a continue statement to skip non-prime numbers.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Use a for loop to iterate through the numbers from 1 to 50
//        for (int number = 2; number <= 50; number++)
//        {
//            bool isPrime = true;

//            // Check if the current number is prime
//            for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
//            {
//                if (number % divisor == 0)
//                {
//                    // If the number is divisible by any divisor other than 1 and itself, it's not prime
//                    isPrime = false;
//                    break;
//                }
//            }

//            // If the number is not prime, skip to the next iteration
//            if (!isPrime)
//            {
//                continue;
//            }

//            // Print the prime number
//            Console.WriteLine(number);
//        }
//    }
//}


//Part 8
// Create a program to print the numbers from 1 to 10, but skip printing the number 3.
// Hint: Use a for loop to iterate through the numbers and an if statement with a continue statement to skip printing 3.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Use a for loop to iterate through the numbers from 1 to 10
//        for (int i = 1; i <= 10; i++)
//        {
//            // Skip printing the number 3
//            if (i == 3)
//            {
//                continue;
//            }

//            // Print the current number
//            Console.WriteLine(i);
//        }
//    }
//}


//Part 9
// Write a program to search for the number 20 in an array of integers. If found, print its index; otherwise, continue searching.
// Hint: Use a for loop to iterate through the array and an if statement to check if the current element is 20. Use a continue statement to continue searching if 20 is not found.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Define the array of integers
//        int[] numbers = { 10, 15, 20, 25, 30 };

//        // Use a for loop to iterate through the array
//        for (int i = 0; i < numbers.Length; i++)
//        {
//            // Check if the current element is 20
//            if (numbers[i] == 20)
//            {
//                // Print the index of 20 and exit the loop
//                Console.WriteLine($"The number 20 is found at index {i}.");
//                return;
//            }
//        }

//        // If 20 is not found, print a message
//        Console.WriteLine("The number 20 is not found in the array.");
//    }
//}


//Part 10
// Create a program that prints the names of different fruits, but skips printing the name "banana".
// Hint: Use a foreach loop to iterate through the list of fruits and an if statement with a continue statement to skip printing "banana".

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Define the array of fruits
//        string[] fruits = { "apple", "banana", "orange", "grape", "kiwi" };

//        // Use a foreach loop to iterate through the list of fruits
//        foreach (string fruit in fruits)
//        {
//            // Skip printing the name "banana"
//            if (fruit.ToLower() == "banana")
//            {
//                continue;
//            }

//            // Print the current fruit
//            Console.WriteLine(fruit);
//        }
//    }
//}




////////////// Extra Challenges //////////////

/*
Part 11

ABC Company pays its sales agents on a commission basis. 
Each agent is paid 10% commission for monthly sales above or equal to $10,000 and 5% commission for monthly sales below $10,000.

Write a program to accept the monthly sales of a particular agent and based on the amount, determine and print out the commission earned.

Example:
Enter the monthly sales: 12000
Commission earned: $1200.00

*/


//using System;

//class Program
//{
//    static void Main()
//    {
//        // Prompt the user to enter the monthly sales
//        Console.Write("Enter the monthly sales: ");
//        decimal monthlySales;
//        if (!decimal.TryParse(Console.ReadLine(), out monthlySales))
//        {
//            Console.WriteLine("Invalid input. Please enter a valid number.");
//            return;
//        }

//        // Calculate the commission based on the monthly sales
//        decimal commission;
//        if (monthlySales >= 10000)
//        {
//            // Commission rate for sales above or equal to $10,000 is 10%
//            commission = monthlySales * 0.10m;
//        }
//        else
//        {
//            // Commission rate for sales below $10,000 is 5%
//            commission = monthlySales * 0.05m;
//        }

//        // Print the commission earned
//        Console.WriteLine($"Commission earned: ${commission:F2}");
//    }
//}


/*
Part 12

Write a program that generates two integers between 0 and 100 inclusive and prompts the user to enter the sum of these 2 integers. The program reports if the answer is correct or wrong (program will also print the correct answer if the user's answer is wrong).

Hint: You need to use the random module.

Example:
Enter the sum of 43 and 58: 100
Correct!

 */

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Create a Random object to generate random numbers
//        Random random = new Random();

//        // Generate two random integers between 0 and 100 inclusive
//        int num1 = random.Next(101); // Generates a number between 0 and 100
//        int num2 = random.Next(101); // Generates a number between 0 and 100

//        // Calculate the correct sum
//        int correctSum = num1 + num2;

//        // Prompt the user to enter the sum of the two numbers
//        Console.Write($"Enter the sum of {num1} and {num2}: ");
//        int userSum;
//        if (!int.TryParse(Console.ReadLine(), out userSum))
//        {
//            Console.WriteLine("Invalid input. Please enter a valid integer.");
//            return;
//        }

//        // Check if the user's answer is correct
//        if (userSum == correctSum)
//        {
//            Console.WriteLine("Correct!");
//        }
//        else
//        {
//            Console.WriteLine($"Wrong! The correct sum is: {correctSum}");
//        }
//    }
//}


/*
 Part 13

The grade that you get for a module depends on your marks. The table below shows the grade for each range of marks.

Marks   |   Grade   |   Comment
---------------------------------
>= 85   |     A+    |  Excellent!
>= 80   |     A     |  Well done.
>= 75   |     B+    |
>= 70   |     B     |
>= 65   |     C+    |
>= 60   |     C     |
>= 55   |     D+    |
>= 50   |     D     |
< 50    |     F     |  See me.

Write a program that asks for a student’s marks, then displays the correct grade and the corresponding comment (if any).

Example:
Enter student's marks: 82
Grade: A
Comment: Well done.
 

 
 */

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Prompt the user to enter the student's marks
//        Console.Write("Enter student's marks: ");
//        int marks;
//        if (!int.TryParse(Console.ReadLine(), out marks))
//        {
//            Console.WriteLine("Invalid input. Please enter a valid integer.");
//            return;
//        }

//        // Determine the grade and comment based on the marks
//        string grade;
//        string comment = "";

//        if (marks >= 85)
//        {
//            grade = "A+";
//            comment = "Excellent!";
//        }
//        else if (marks >= 80)
//        {
//            grade = "A";
//            comment = "Well done.";
//        }
//        else if (marks >= 75)
//        {
//            grade = "B+";
//        }
//        else if (marks >= 70)
//        {
//            grade = "B";
//        }
//        else if (marks >= 65)
//        {
//            grade = "C+";
//        }
//        else if (marks >= 60)
//        {
//            grade = "C";
//        }
//        else if (marks >= 55)
//        {
//            grade = "D+";
//        }
//        else if (marks >= 50)
//        {
//            grade = "D";
//        }
//        else
//        {
//            grade = "F";
//            comment = "See me.";
//        }

//        // Print the grade and comment
//        Console.WriteLine($"Grade: {grade}");
//        if (!string.IsNullOrEmpty(comment))
//        {
//            Console.WriteLine($"Comment: {comment}");
//        }
//    }
//}



/*
 Part 14

 A guard in a computer game acts as follows:

If sees_player == False, he will wait

If sees_player == True:
    - If dist_from_player <= 1, he will attack
    - If 2 <= dist_from_player <= 4, he will advance
    - If dist_from_player >= 5, he will wait

Write a program that shows how the guard will act.

Example:
sees_player = True
dist_from_player = 3

The guard will advance.

 
 
 */
//using System;

//class Program
//{
//    static string GuardAction(bool seesPlayer, int distFromPlayer)
//    {
//        if (!seesPlayer)
//        {
//            return "wait";
//        }
//        else if (distFromPlayer <= 1)
//        {
//            return "attack";
//        }
//        else if (distFromPlayer >= 2 && distFromPlayer <= 4)
//        {
//            return "advance";
//        }
//        else
//        {
//            return "wait";
//        }
//    }

//    static void Main()
//    {
//        bool seesPlayer;
//        int distFromPlayer;

//        // Loop until valid input is entered
//        while (true)
//        {
//            // Prompt the user to enter if the guard sees the player
//            Console.Write("Does the guard see the player? (True/False): ");
//            if (!bool.TryParse(Console.ReadLine(), out seesPlayer))
//            {
//                Console.WriteLine("Invalid input. Please enter True or False.");
//                continue; // Prompt again if input is invalid
//            }

//            // Prompt the user to enter the distance from the player
//            Console.Write("Enter the distance from the player: ");
//            if (!int.TryParse(Console.ReadLine(), out distFromPlayer))
//            {
//                Console.WriteLine("Invalid input. Please enter a valid integer.");
//                continue; // Prompt again if input is invalid
//            }

//            // Exit the loop if valid input is entered
//            break;
//        }

//        // Determine the guard's action
//        string action = GuardAction(seesPlayer, distFromPlayer);

//        // Print the guard's action
//        Console.WriteLine($"The guard will {action}.");
//    }
//}

