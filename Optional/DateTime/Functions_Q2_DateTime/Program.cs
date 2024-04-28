

//Part 1
//Write a C# program to add and subtract days from the date.
//Test Data:
//Enter the date: 12/10/2020
//Enter the number of days to add or subtract: 5
//Expected Output:
//Date after 5 days: 17/10/2020
//Date before 5 days: 07/10/2020

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Test Data: Enter the date
//        Console.Write("Enter the date (MM/dd/yyyy): ");
//        DateTime date = DateTime.Parse(Console.ReadLine());

//        // Test Data: Enter the number of days to add or subtract
//        Console.Write("Enter the number of days to add or subtract: ");
//        int days = int.Parse(Console.ReadLine());

//        // Add days to the date
//        DateTime dateAfter = date.AddDays(days);

//        // Subtract days from the date
//        DateTime dateBefore = date.AddDays(-days);

//        // Display the result
//        Console.WriteLine($"Date after {days} days: {dateAfter:MM/dd/yyyy}");
//        Console.WriteLine($"Date before {days} days: {dateBefore:MM/dd/yyyy}");
//    }
//}


//Part 2
//Write a C# program to take input from the user and calculate the age of the user.
//Test Data:
//Enter your date of birth: 12/10/1990
//Expected Output:
//You are 30 years, 1 months, 21 days old

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Prompt the user to enter their date of birth
//        Console.Write("Enter your date of birth (MM/dd/yyyy): ");
//        DateTime dob = DateTime.Parse(Console.ReadLine());

//        // Calculate age
//        TimeSpan ageSpan = DateTime.Now - dob;
//        DateTime ageDateTime = DateTime.MinValue + ageSpan;

//        // Extract years, months, and days from the calculated age
//        int years = ageDateTime.Year - 1;
//        int months = ageDateTime.Month - 1;
//        int days = ageDateTime.Day - 1;

//        // Display the calculated age
//        Console.WriteLine($"You are {years} years, {months} months, {days} days old");
//    }
//}


//Part 3
//Write a C# program to take input from the user and calculate the difference between two dates.
//Test Data:
//Enter the first date: 12/10/2020
//Enter the second date: 16/10/2020
//Expected Output:
//The difference between two dates is: 4 days

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Prompt the user to enter the first date
//        Console.Write("Enter the first date (MM/dd/yyyy): ");
//        DateTime firstDate = DateTime.Parse(Console.ReadLine());

//        // Prompt the user to enter the second date
//        Console.Write("Enter the second date (MM/dd/yyyy): ");
//        DateTime secondDate = DateTime.Parse(Console.ReadLine());

//        // Calculate the difference between the two dates
//        TimeSpan difference = secondDate - firstDate;

//        // Display the difference in days
//        Console.WriteLine($"The difference between two dates is: {difference.Days} days");
//    }
//}


//Part 4
//Write a C# program to take the input (days) from the user and Convert days into years, weeks and days.
//Test Data:
//Enter the number of days: 1329
//Expected Output:
//Years: 3
//Weeks: 33
//Days: 3

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Prompt the user to enter the number of days
//        Console.Write("Enter the number of days: ");
//        int totalDays = int.Parse(Console.ReadLine());

//        // Calculate years, weeks, and remaining days
//        int years = totalDays / 365;
//        int remainingDays = totalDays % 365;
//        int weeks = remainingDays / 7;
//        remainingDays %= 7;

//        // Display the converted values
//        Console.WriteLine($"Years: {years}");
//        Console.WriteLine($"Weeks: {weeks}");
//        Console.WriteLine($"Days: {remainingDays}");
//    }
//}


//Part 5
//Write a C# program to take the input from the user and print day name of week.
//Test Data:
//Enter the number of day: 4
//Expected Output:
//Thursday

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Prompt the user to enter the number of the day
//        Console.Write("Enter the number of the day (1 for Monday, 2 for Tuesday, ..., 7 for Sunday): ");
//        int dayNumber = int.Parse(Console.ReadLine());

//        // Validate the input
//        if (dayNumber < 1 || dayNumber > 7)
//        {
//            Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
//        }
//        else
//        {
//            // Get the day name based on the input
//            string dayName = ((DayOfWeek)(dayNumber - 1)).ToString();

//            // Display the day name
//            Console.WriteLine(dayName);
//        }
//    }
//}



//Part 6
//Write a C# Sharp program to retrieve the current date.
//Expected Output:
//The current date is: 12/10/2020

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Get the current date
//        DateTime currentDate = DateTime.Now;

//        // Display the current date
//        Console.WriteLine($"The current date is: {currentDate:MM/dd/yyyy}");
//    }
//}


//Part 7
//Write a C# program to retrieve the current date and time.
//Expected Output:
//The current date and time is: 12/10/2020 10:30:50

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Get the current date and time
//        DateTime currentDateTime = DateTime.Now;

//        // Display the current date and time
//        Console.WriteLine($"The current date and time is: {currentDateTime:MM/dd/yyyy HH:mm:ss}");
//    }
//}


