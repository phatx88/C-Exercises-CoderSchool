// To test out your code , comment the other parts and uncomment the part you want to test.
//To comment a part, select the part and press Ctrl + K + C
//To uncomment a part, select the part and press Ctrl + K + U
//Press Ctrl + F5 to run the code.




//Part 1
//Create a program so that it concatenates three strings and then outputs the result in uppercase.
//Hint: You can use the ToUpper() method to convert a string to uppercase.
//Hint: You can use the Console.WriteLine() method to output the result.


//using System;

//class Program
//{
//    static void Main()
//    {
//        // Three strings to concatenate
//        string string1 = "Hello";
//        string string2 = " ";
//        string string3 = "World";

//        // Concatenating the strings and converting the result to uppercase
//        string result = string1 + string2 + string3;
//        string uppercaseResult = result.ToUpper();

//        // Outputting the result in uppercase
//        Console.WriteLine(uppercaseResult);
//    }
//}


//Part 2
//Create a program so that it concatenates three strings and then outputs the result in lowercase.
//Hint: You can use the ToLower() method to convert a string to lowercase.
//Hint: You can use the Console.WriteLine() method to output the result.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Three strings to concatenate
//        string string1 = "Hello";
//        string string2 = " ";
//        string string3 = "World";

//        // Concatenating the strings and converting the result to lowercase
//        string result = string1 + string2 + string3;
//        string lowercaseResult = result.ToLower();

//        // Outputting the result in lowercase
//        Console.WriteLine(lowercaseResult);
//    }
//}


//Part 3
//Write a program to find the length of a string.
//Hint: You can use the Length property to find the length of a string.
//Hint: You can use the Console.WriteLine() method to output the result.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Input string
//        string inputString = "Hello, World!";

//        // Finding the length of the string
//        int length = inputString.Length;

//        // Outputting the length of the string
//        Console.WriteLine("Length of the string: " + length);
//    }
//}


//Part 4
//Write a program to find the index of a character in a string.
//Hint: You can use the IndexOf() method to find the index of a character in a string.
//Hint: You can use the Console.WriteLine() method to output the result.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Input string
//        string inputString = "Hello, World!";

//        // Character to find
//        char charToFind = 'o';

//        // Finding the index of the character in the string
//        int index = inputString.IndexOf(charToFind);

//        // Outputting the index of the character
//        Console.WriteLine("Index of '" + charToFind + "' in the string: " + index);
//    }
//}


//Part 5
//Write a program to find the index of a character in a string starting from a specified position.
//Hint: You can use the IndexOf() method to find the index of a character in a string starting from a specified position.
//Hint: You can use the Console.WriteLine() method to output the result.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Input string
//        string inputString = "Hello, World!";

//        // Character to find
//        char charToFind = 'o';

//        // Starting position
//        int startingPosition = 5;

//        // Finding the index of the character in the string starting from the specified position
//        int index = inputString.IndexOf(charToFind, startingPosition);

//        // Outputting the index of the character
//        Console.WriteLine("Index of '" + charToFind + "' in the string starting from position " + startingPosition + ": " + index);
//    }
//}


//Part 6
//Write a program to count the occurrences of a specific character in a string.
//Hint: You can use the Count() method to count the occurrences of a specific character in a string.
//Hint: You can use the Console.WriteLine() method to output the result.

//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        // Input string
//        string inputString = "Hello, World!";

//        // Character to count occurrences
//        char charToCount = 'o';

//        // Counting occurrences of the character in the string
//        int occurrences = inputString.Count(c => c == charToCount);

//        // Outputting the occurrences of the character
//        Console.WriteLine("Occurrences of '" + charToCount + "' in the string: " + occurrences);
//    }
//}


//Part 7
//Write a program to replace a character in a string with another character.
//Hint: You can use the Replace() method to replace a character in a string with another character.
//Hint: You can use the Console.WriteLine() method to output the result.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Input string
//        string inputString = "Hello, World!";

//        // Character to replace
//        char charToReplace = 'o';

//        // Character to replace with
//        char replacementChar = '*';

//        // Replacing the character in the string
//        string replacedString = inputString.Replace(charToReplace, replacementChar);

//        // Outputting the replaced string
//        Console.WriteLine("String after replacing '" + charToReplace + "' with '" + replacementChar + "': " + replacedString);
//    }
//}


//Part 8
//Write a program to remove a character from a string.
//Hint: You can use the Remove() method to remove a character from a string.
//Hint: You can use the Console.WriteLine() method to output the result.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Input string
//        string inputString = "Hello, World!";

//        // Character to remove
//        char charToRemove = 'o';

//        // Removing the character from the string
//        string removedString = RemoveCharacter(inputString, charToRemove);

//        // Outputting the string after removing the character
//        Console.WriteLine("String after removing '" + charToRemove + "': " + removedString);
//    }

//    static string RemoveCharacter(string input, char charToRemove)
//    {
//        // Replacing all occurrences of the character with an empty string
//        return input.Replace(charToRemove.ToString(), "");
//    }
//}


//Part 9
//Write a program to replace all occurrences of a specific character in a string with another character.
//Hint: You can use the Replace() method to remove all occurrences of a specific character from a string.
//Hint: You can use the Console.WriteLine() method to output the result.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Input string
//        string inputString = "Hello, World!";

//        // Character to replace
//        char charToReplace = 'o';

//        // Character to replace with
//        char replacementChar = '*';

//        // Replacing all occurrences of the character in the string
//        string replacedString = inputString.Replace(charToReplace, replacementChar);

//        // Outputting the string after replacement
//        Console.WriteLine("String after replacing all occurrences of '" + charToReplace + "' with '" + replacementChar + "': " + replacedString);
//    }
//}


//Part 10
//Write a program to extract a substring from a string.
//Hint: You can use the Substring() method to extract a substring from a string.
//Hint: You can use the Console.WriteLine() method to output the result.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Input string
//        string inputString = "Hello, World!";

//        // Starting index of the substring
//        int startIndex = 7;

//        // Length of the substring
//        int length = 5;

//        // Extracting the substring from the input string
//        string substring = inputString.Substring(startIndex, length);

//        // Outputting the extracted substring
//        Console.WriteLine("Substring extracted from index " + startIndex + " with length " + length + ": " + substring);
//    }
//}


//Part 11
//Write a program to extract a substring from a string starting from a specified position.
//Hint: You can use the Substring() method to extract a substring from a string starting from a specified position.
//Hint: You can use the Console.WriteLine() method to output the result.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Input string
//        string inputString = "Hello, World!";

//        // Starting index of the substring
//        int startIndex = 7;

//        // Extracting the substring from the input string starting from the specified position
//        string substring = inputString.Substring(startIndex);

//        // Outputting the extracted substring
//        Console.WriteLine("Substring extracted starting from index " + startIndex + ": " + substring);
//    }
//}


//Part 12
//Write a program to remove leading and trailing whitespace from a string.
//Hint: You can use the Trim() method to remove leading and trailing whitespace from a string.
//Hint: You can use the Console.WriteLine() method to output the result.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Input string with leading and trailing whitespace
//        string inputString = "   Hello, World!   ";

//        // Removing leading and trailing whitespace from the string
//        string trimmedString = inputString.Trim();

//        // Outputting the string after removing leading and trailing whitespace
//        Console.WriteLine("String after removing leading and trailing whitespace: '" + trimmedString + "'");
//    }
//}


//Part 13 
//Write a program to parse a string to a number.
//Hint: You can use the Parse() method to parse a string to a number.
//Hint: You can use the Console.WriteLine() method to output the result.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Input string representing a number
//        string inputString = "12345";

//        // Parsing the string to an integer
//        int parsedNumber = int.Parse(inputString);

//        // Outputting the parsed number
//        Console.WriteLine("Parsed number: " + parsedNumber);
//    }
//}


//Part 14
//Write a program to convert a number to a string.
//Hint: You can use the ToString() method to convert a number to a string.
//Hint: You can use the Console.WriteLine() method to output the result.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Input number
//        int inputNumber = 12345;

//        // Converting the number to a string
//        string convertedString = inputNumber.ToString();

//        // Outputting the converted string
//        Console.WriteLine("Converted string: " + convertedString);
//    }
//}








//////////////////Formating////////////////////





// Part 1

// You're organizing a team outing and need to print personalized event invitations.
// Develop a C# program that uses placeholders to create customized invitations.
// Replace the placeholders with the recipient's name, event date, and current time.
// Hint: Use composite formatting with placeholders to create personalized invitations.
// Test Data:
// Recipient's name: Alice
// Event date: January 15, 2025
// Expected Output:
// Hello, Alice! You're invited to our team outing on January 15, 2025. The event starts at 09:00.


//using System;

//class Program
//{
//    static void Main()
//    {
//        // Test data
//        string recipientName = "Alice";
//        DateTime eventDate = new DateTime(2025, 1, 15);
//        TimeSpan eventTime = new TimeSpan(9, 0, 0);

//        // Generating personalized invitation
//        string invitation = $"Hello, {recipientName}! You're invited to our team outing on {eventDate:MMMM d, yyyy}. The event starts at {eventTime:hh\\:mm}.";

//        // Outputting the invitation
//        Console.WriteLine(invitation);
//    }
//}






// Part 2

// Imagine you're managing an online store and need to send order confirmation emails.
// Write a C# program that utilizes placeholders to generate order confirmation emails.
// Fill in the placeholders with the customer's name, order ID, and purchase details.
// Hint: Use composite formatting with placeholders to generate order confirmation emails.
// Test Data:
// Customer's name: John Doe
// Order ID: 123456
// Purchase details: 2 x T-shirts, 3 x Jeans
// Expected Output:
// Dear John Doe, your order (ID: 123456) has been confirmed. You've purchased: 2 x T-shirts, 3 x Jeans.



//using System;

//class Program
//{
//    static void Main()
//    {
//        // Test data
//        string customerName = "John Doe";
//        int orderID = 123456;
//        string purchaseDetails = "2 x T-shirts, 3 x Jeans";

//        // Generating order confirmation email
//        string confirmationEmail = $"Dear {customerName}, your order (ID: {orderID}) has been confirmed. You've purchased: {purchaseDetails}.";

//        // Outputting the order confirmation email
//        Console.WriteLine(confirmationEmail);
//    }
//}






// Part 3

// Picture yourself developing a task management application and need to display task reminders.
// Create a C# program that employs placeholders to format task reminder messages.
// Populate the placeholders with the task name, due date, and priority level.
// Hint: Use composite formatting with placeholders to format task reminder messages.
// Test Data:
// Task name: Complete Project Proposal
// Due date: May 10, 2025
// Priority level: High
// Expected Output:
// Reminder: Complete Project Proposal is due on May 10, 2025. Priority: High.


//using System;

//class Program
//{
//    static void Main()
//    {
//        // Test data
//        string taskName = "Complete Project Proposal";
//        DateTime dueDate = new DateTime(2025, 5, 10);
//        string priorityLevel = "High";

//        // Generating task reminder message
//        string reminderMessage = $"Reminder: {taskName} is due on {dueDate:MMMM d, yyyy}. Priority: {priorityLevel}.";

//        // Outputting the task reminder message
//        Console.WriteLine(reminderMessage);
//    }
//}







// Part 4

// You're working on a scheduling application and need to generate event reminders.
// Develop a C# program that utilizes placeholders to format event reminder notifications.
// Fill in the placeholders with the event title, location, and start time.
// Hint: Use composite formatting with placeholders to format event reminder notifications.
// Test Data:
// Event title: Team Meeting
// Location: Conference Room A
// Start time: 10:00 AM
// Expected Output:
// Reminder: Team Meeting at Conference Room A starts at 10:00 AM.



//using System;

//class Program
//{
//    static void Main()
//    {
//        // Test data
//        string eventTitle = "Team Meeting";
//        string location = "Conference Room A";
//        string startTime = "10:00 AM";

//        // Generating event reminder notification
//        string reminderNotification = $"Reminder: {eventTitle} at {location} starts at {startTime}.";

//        // Outputting the event reminder notification
//        Console.WriteLine(reminderNotification);
//    }
//}









// Part 5

// Imagine you're designing a travel app and need to provide flight departure information.
// Write a C# program that employs placeholders to format flight departure notifications.
// Populate the placeholders with the flight number, departure airport, and scheduled time.
// Hint: Use composite formatting with placeholders to format flight departure notifications.
// Test Data:
// Flight number: ABC123
// Departure airport: JFK International Airport
// Scheduled time: 08:30 AM
// Expected Output:
// Flight ABC123 departing from JFK International Airport is scheduled for 08:30 AM.














// Part 6

// You're developing a messaging application and want to greet the user.
// Write a C# program that asks the user to enter their name.
// Then, use interpolation to display a personalized greeting message.
// Hint: Use the Console.ReadLine() method to get user input and string interpolation to format the message.
// Test Data:
// Enter your name: Alice
// Expected Output:
// Hello, Alice! Welcome to our messaging app.


//using System;

//class Program
//{
//    static void Main()
//    {
//        // Test data
//        string flightNumber = "ABC123";
//        string departureAirport = "JFK International Airport";
//        string scheduledTime = "08:30 AM";

//        // Generating flight departure notification
//        string departureNotification = $"Flight {flightNumber} departing from {departureAirport} is scheduled for {scheduledTime}.";

//        // Outputting the flight departure notification
//        Console.WriteLine(departureNotification);
//    }
//}










// Part 7

// You're organizing a fantasy-themed event and need to print custom badges for the participants.
// Develop a C# program that prompts the user to enter their character's name and class.
// Then, concatenate the name and class, and print the result.
// Hint: Use the + operator to concatenate strings and the Console.WriteLine() method to print the result.
// Test Data:
// Character's name: Legolas
// Character's class: Archer
// Expected Output:
// Custom Badge: Legolas the Archer


//using System;

//class Program
//{
//    static void Main()
//    {
//        // Prompting the user to enter character's name
//        Console.Write("Enter character's name: ");
//        string characterName = Console.ReadLine();

//        // Prompting the user to enter character's class
//        Console.Write("Enter character's class: ");
//        string characterClass = Console.ReadLine();

//        // Concatenating name and class to create custom badge
//        string customBadge = $"{characterName} the {characterClass}";

//        // Printing the custom badge
//        Console.WriteLine($"Custom Badge: {customBadge}");
//    }
//}










// Part 8

// Picture yourself managing a music playlist and need to display the total duration of a song.
// Write a C# program that calculates and formats the total duration of a song in minutes and seconds.
// Prompt the user to enter the song's duration in seconds.
// Then, calculate the minutes and seconds and display the formatted duration.
// Hint: Use integer division and modulus to separate minutes and seconds, and composite formatting to display them.
// Test Data:
// Enter the song's duration in seconds: 245
// Expected Output:
// Song Duration: 4 minutes 5 seconds








// Part 9

// Imagine you're developing a recipe app and want to display the serving size.
// Create a C# program that formats and displays the serving size of a recipe.
// Prompt the user to enter the number of servings.
// Then, display the serving size aligned to the right with a width of 5 characters.
// Hint: Use composite formatting with alignment to display the serving size.
// Test Data:
// Enter the number of servings: 8
// Expected Output:
// Serving Size:     8










// Part 10

// You're designing a finance application and need to show the current account balance.
// Develop a C# program that formats and displays the account balance.
// Prompt the user to enter the account balance.
// Then, display the balance aligned to the right with two decimal places.
// Hint: Use composite formatting with alignment and precision to display the account balance.
// Test Data:
// Enter the account balance: 1050.75
// Expected Output:
// Account Balance: 1050.75









// Part 11

// You're building a movie ticket booking system and need to present the ticket price.
// Write a C# program that calculates and formats the ticket price with discounts.
// Prompt the user to enter the ticket price and discount percentage.
// Then, calculate the discounted price and display it aligned to the right with two decimal places.
// Hint: Use composite formatting with alignment and precision to display the discounted price.
// Test Data:
// Enter the ticket price: 25.50
// Enter the discount percentage: 15
// Expected Output:
// Discounted Price: 21.68









// Part 12

// Picture yourself developing a gaming platform and need to display the player's score.
// Create a C# program that formats and displays the player's score.
// Prompt the user to enter the player's score.
// Then, display the score aligned to the right with a width of 8 characters.
// Hint: Use composite formatting with alignment to display the player's score.
// Test Data:
// Enter the player's score: 10325
// Expected Output:
// Player's Score:   10325








// Part 13

// You're working on a data analysis tool and need to present the statistical results.
// Develop a C# program that formats and displays the average value of a dataset.
// Prompt the user to enter a series of numbers separated by spaces.
// Then, calculate the average value and display it aligned to the right with two decimal places.
// Hint: Use composite formatting with alignment and precision to display the average value.
// Test Data:
// Enter a series of numbers: 10 15 20 25 30
// Expected Output:
// Average Value: 20.00










// Part 14

// Imagine you're designing a weather app and need to show the temperature forecast.
// Write a C# program that calculates and formats the average temperature.
// Prompt the user to enter the temperatures for three days separated by spaces.
// Then, calculate the average temperature and display it aligned to the right with one decimal place.
// Hint: Use composite formatting with alignment and precision to display the average temperature.
// Test Data:
// Enter temperatures for 3 days: 25.5 28.7 22.3
// Expected Output:
// Average Temperature: 25.5


//using System;

//class Program
//{
//    static void Main()
//    {
//        // Prompting the user to enter the song's duration in seconds
//        Console.Write("Enter the song's duration in seconds: ");
//        int totalSeconds = int.Parse(Console.ReadLine());

//        // Calculating minutes and seconds
//        int minutes = totalSeconds / 60;
//        int seconds = totalSeconds % 60;

//        // Displaying the formatted duration
//        Console.WriteLine($"Song Duration: {minutes} minutes {seconds} seconds");
//    }
//}








// Part 15

// You're building a fitness tracker and need to present the daily step count.
// Create a C# program that formats and displays the total steps for a day.
// Prompt the user to enter the steps taken.
// Then, display the step count aligned to the right with a width of 6 characters.
// Hint: Use composite formatting with alignment to display the step count.
// Test Data:
// Enter the steps taken: 12345
// Expected Output:
// Step Count:  12345


//using System;

//class Program
//{
//    static void Main()
//    {
//        // Prompting the user to enter the steps taken
//        Console.Write("Enter the steps taken: ");
//        int stepCount = int.Parse(Console.ReadLine());

//        // Displaying the step count aligned to the right with a width of 6 characters
//        Console.WriteLine($"Step Count: {stepCount,6}");
//    }
//}



