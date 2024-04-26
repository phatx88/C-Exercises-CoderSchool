
//**Arrays unlike lists have a fixed size and cannot be changed once they are created.**//


//---------------------------------------------------------------------
// Part 1: Printing Array Elements
// Create an array of 5 countries and then print them out to the console.
// Hint: Use a foreach loop to print the array elements.

//Array names = new string[5] { "John", "Jane", "Jack", "Jill", "James" };
//foreach (string name in names)
//{
//    Console.WriteLine(name);
//}

//---------------------------------------------------------------------
// Part 2: Accessing Array Elements by Index
// Using the array of countries, find the name in the 3rd position and print it out to the console.
// Hint: Use the index of the array to access the name in the 3rd position.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Array of countries
//        string[] countries = { "USA", "Canada", "UK", "Australia", "Germany" };

//        // Accessing and printing the name in the 3rd position
//        string nameInThirdPosition = countries[2];
//        Console.WriteLine("Name in the 3rd position: " + nameInThirdPosition);
//    }
//}


//---------------------------------------------------------------------
// Part 3: Removing an Element from the Array
// Using the array of countries, remove the name in the 2nd position and then print the array out to the console.
// Hint: Use the RemoveAt() method to remove an item from the array.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Original array of countries
//        string[] countries = { "USA", "Canada", "UK", "Australia", "Germany" };

//        // Removing the name in the 2nd position
//        int positionToRemove = 1; // 0-based index
//        string[] newArray = new string[countries.Length - 1];
//        Array.Copy(countries, 0, newArray, 0, positionToRemove);
//        Array.Copy(countries, positionToRemove + 1, newArray, positionToRemove, countries.Length - positionToRemove - 1);

//        // Printing the updated array to the console
//        Console.WriteLine("Updated array of countries:");
//        foreach (var country in newArray)
//        {
//            Console.WriteLine(country);
//        }
//    }
//}


//---------------------------------------------------------------------
// Part 4: Replacing an Element in the Array
// Using the array of countries, replace the name in the 3rd position with a new name and then print the array out to the console.
// Hint: Use the index of the array to replace the name in the 3rd position with a new name.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Original array of countries
//        string[] countries = { "USA", "Canada", "UK", "Australia", "Germany" };

//        // Replacing the name in the 3rd position with a new name
//        int positionToReplace = 2; // 0-based index
//        string newName = "France";
//        countries[positionToReplace] = newName;

//        // Printing the updated array to the console
//        Console.WriteLine("Updated array of countries:");
//        foreach (var country in countries)
//        {
//            Console.WriteLine(country);
//        }
//    }
//}


//---------------------------------------------------------------------
// Part 5: Finding the Length of the Array
// Using the array of countries, find the length of the array and print it out to the console.
// Hint: Use the Length property to find the length of the array.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Array of countries
//        string[] countries = { "USA", "Canada", "UK", "Australia", "Germany" };

//        // Finding the length of the array
//        int length = countries.Length;

//        // Printing the length of the array to the console
//        Console.WriteLine("Length of the array of countries: " + length);
//    }
//}


//---------------------------------------------------------------------
// Part 6: Checking if an Element Exists in the Array
// Using the array of countries, check if a name exists in the array and print out if it exists or not.
// Hint: Use the Contains() method to check if a name exists in the array.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Array of countries
//        string[] countries = { "USA", "Canada", "UK", "Australia", "Germany" };

//        // Name to check existence
//        string nameToCheck = "Canada";

//        // Checking if the name exists in the array
//        bool exists = Array.Exists(countries, country => country == nameToCheck);

//        // Printing the result
//        if (exists)
//        {
//            Console.WriteLine("'" + nameToCheck + "' exists in the array of countries.");
//        }
//        else
//        {
//            Console.WriteLine("'" + nameToCheck + "' does not exist in the array of countries.");
//        }
//    }
//}


//---------------------------------------------------------------------
// Part 7: Finding the Index of an Element in the Array
// Using the array of countries, find the index of a name in the array and print it out to the console.
// Hint: Use the IndexOf() method to find the index of a name in the array.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Array of countries
//        string[] countries = { "USA", "Canada", "UK", "Australia", "Germany" };

//        // Name to find the index
//        string nameToFind = "Australia";

//        // Finding the index of the name in the array
//        int index = Array.IndexOf(countries, nameToFind);

//        // Printing the index to the console
//        if (index != -1)
//        {
//            Console.WriteLine("Index of '" + nameToFind + "' in the array of countries: " + index);
//        }
//        else
//        {
//            Console.WriteLine("'" + nameToFind + "' does not exist in the array of countries.");
//        }
//    }
//}

