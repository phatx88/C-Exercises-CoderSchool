// ---------------------------------------------------------------------
// Question: Finding the First Element Meeting a Condition in an Array
// Write a C# program to find and display the first element greater than 50 in an integer array.
// Hint: Use the Array.Find() method with a condition-checking function (Predicate) to find the first element greater than 50 in the array.
// Define a condition-checking function that returns true if the element is greater than 50.

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        int[] numbers = { 20, 35, 45, 55, 65, 75, 85 };

//        // Define the condition-checking function (Predicate)
//        Predicate<int> isGreaterThan50 = delegate (int num)
//        {
//            return num > 50;
//        };

//        // Find the first element greater than 50
//        int firstElementGreaterThan50 = Array.Find(numbers, isGreaterThan50);

//        if (firstElementGreaterThan50 != 0)
//        {
//            Console.WriteLine($"The first element greater than 50 is: {firstElementGreaterThan50}");
//        }
//        else
//        {
//            Console.WriteLine("No element greater than 50 found in the array.");
//        }
//    }
//}


// ---------------------------------------------------------------------
// Question: Find the First Element Greater Than 10
// Write a C# program that finds the first element greater than 10 in an integer array and displays it.
// Hint: Define an array of integers. Use Array.Find() method with a condition-checking function to find the first element greater than 10.
// Define a condition-checking function that returns true if the element is greater than 10.

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        int[] numbers = { 5, 8, 12, 6, 15, 9 };

//        // Define the condition-checking function (Predicate)
//        Predicate<int> isGreaterThan10 = delegate (int num)
//        {
//            return num > 10;
//        };

//        // Find the first element greater than 10
//        int firstElementGreaterThan10 = Array.Find(numbers, isGreaterThan10);

//        if (firstElementGreaterThan10 != 0)
//        {
//            Console.WriteLine($"The first element greater than 10 is: {firstElementGreaterThan10}");
//        }
//        else
//        {
//            Console.WriteLine("No element greater than 10 found in the array.");
//        }
//    }
//}



//---------------------------------------------------------------------
// Question: Find the First Negative Number
// Write a C# program to find the first negative number in an array of integers and display it.
// Hint: Define an array of integers. Use Array.Find() method with a condition-checking function to find the first negative number.
// Define a condition-checking function that returns true if the element is negative.

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        int[] numbers = { 5, -8, 12, -6, 15, -9 };

//        // Define the condition-checking function (Predicate)
//        Predicate<int> isNegative = delegate (int num)
//        {
//            return num < 0;
//        };

//        // Find the first negative number
//        int firstNegativeNumber = Array.Find(numbers, isNegative);

//        if (firstNegativeNumber != 0)
//        {
//            Console.WriteLine($"The first negative number is: {firstNegativeNumber}");
//        }
//        else
//        {
//            Console.WriteLine("No negative number found in the array.");
//        }
//    }
//}
