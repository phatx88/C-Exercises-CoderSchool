//Part 1
//Create a list of 5 names and then print them out to the console.
//Hint: You can use the Add() method to add items to the list and then use a foreach loop to print them out to the console.

//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        // Create a list of names
//        List<string> names = new List<string>();

//        // Add names to the list
//        names.Add("Alice");
//        names.Add("Bob");
//        names.Add("Charlie");
//        names.Add("David");
//        names.Add("Eve");

//        // Print out the names to the console using a foreach loop
//        Console.WriteLine("List of names:");
//        foreach (string name in names)
//        {
//            Console.WriteLine(name);
//        }
//    }
//}



//Part 2
//Using the list of names and find the name in the 3rd position and print it out to the console.
//Hint: You can use the index of the list to find the name in the 3rd position.

//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        // Create a list of names
//        List<string> names = new List<string>();

//        // Add names to the list
//        names.Add("Alice");
//        names.Add("Bob");
//        names.Add("Charlie");
//        names.Add("David");
//        names.Add("Eve");

//        // Find and print the name in the 3rd position
//        string nameInThirdPosition = names[2]; // Indexing starts from 0
//        Console.WriteLine("Name in the 3rd position: " + nameInThirdPosition);
//    }
//}


//Part 3
//Using the list of names, remove the name in the 2nd position and then print the list out to the console.
//Hint: You can use the RemoveAt() method to remove an item from the list.

//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        // Create a list of names
//        List<string> names = new List<string>();

//        // Add names to the list
//        names.Add("Alice");
//        names.Add("Bob");
//        names.Add("Charlie");
//        names.Add("David");
//        names.Add("Eve");

//        // Remove the name in the 2nd position
//        names.RemoveAt(1); // Indexing starts from 0

//        // Print the updated list
//        Console.WriteLine("Updated list of names:");
//        foreach (string name in names)
//        {
//            Console.WriteLine(name);
//        }
//    }
//}


//Part 4
//Using the list of names, add a new name to the list and then print the list out to the console.
//Hint: You can use the Add() method to add a new name to the list.

//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        // Create a list of names
//        List<string> names = new List<string>();

//        // Add names to the list
//        names.Add("Alice");
//        names.Add("Bob");
//        names.Add("Charlie");
//        names.Add("David");
//        names.Add("Eve");

//        // Add a new name to the list
//        names.Add("Frank");

//        // Print the updated list
//        Console.WriteLine("Updated list of names:");
//        foreach (string name in names)
//        {
//            Console.WriteLine(name);
//        }
//    }
//}


//Part 5
//Using the list of names , find the length of the list and print it out to the console.
//Hint: You can use the Count property to find the length of the list.

//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        // Create a list of names
//        List<string> names = new List<string>();

//        // Add names to the list
//        names.Add("Alice");
//        names.Add("Bob");
//        names.Add("Charlie");
//        names.Add("David");
//        names.Add("Eve");

//        // Find the length of the list
//        int length = names.Count;

//        // Print the length of the list
//        Console.WriteLine("Length of the list of names: " + length);
//    }
//}


//Part 6
//Using the list of names , check if a name exists in the list and print out if it exists or not.
//Hint: You can use the Contains() method to check if a name exists in the list.

//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        // Create a list of names
//        List<string> names = new List<string>();

//        // Add names to the list
//        names.Add("Alice");
//        names.Add("Bob");
//        names.Add("Charlie");
//        names.Add("David");
//        names.Add("Eve");

//        // Get user input for the name to search
//        Console.Write("Enter a name to search: ");
//        string searchName = Console.ReadLine();

//        // Check if the entered name exists in the list
//        bool exists = names.Contains(searchName);

//        // Print the result
//        if (exists)
//        {
//            Console.WriteLine(searchName + " exists in the list.");
//        }
//        else
//        {
//            Console.WriteLine(searchName + " does not exist in the list.");
//        }
//    }
//}



//Part 7
//Using the list of names, find the index of a name in the list and print it out to the console.
//Hint: You can use the IndexOf() method to find the index of a name in the list.

//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        // Create a list of names
//        List<string> names = new List<string>();

//        // Add names to the list
//        names.Add("Alice");
//        names.Add("Bob");
//        names.Add("Charlie");
//        names.Add("David");
//        names.Add("Eve");

//        // Get user input for the name to search
//        Console.Write("Enter a name to search: ");
//        string searchName = Console.ReadLine();

//        // Find the index of the entered name in the list
//        int index = names.IndexOf(searchName);

//        // Print the index
//        if (index != -1)
//        {
//            Console.WriteLine("Index of " + searchName + " is " + index);
//        }
//        else
//        {
//            Console.WriteLine(searchName + " does not exist in the list.");
//        }
//    }
//}



//Part 8
//Using the list of names, insert a new name at the 3rd position and print the list out to the console.
//Hint: You can use the Insert() method to insert a new name at a specific position in the list.

//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David", "Eve" };

//        // Inserting a new name at the 3rd position
//        names.Insert(2, "Frank");

//        // Printing the list to the console
//        foreach (var name in names)
//        {
//            Console.WriteLine(name);
//        }
//    }
//}

//Part 9
//Using the list of names, sort the list and print it out to the console.
//Hint: You can use the Sort() method to sort the list.

//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David", "Eve" };

//        // Sorting the list
//        names.Sort();

//        // Printing the sorted list to the console
//        foreach (var name in names)
//        {
//            Console.WriteLine(name);
//        }
//    }
//}



//Part 10
//Using the list of names , use findlastindex() method to find the last index of a name in the list and print it out to the console.
//Hint: You can use the FindLastIndex() method to find the last index of a name in the list.

//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David", "Eve", "Bob" };

//        // Finding the last index of a name in the list
//        int lastIndex = names.FindLastIndex(name => name == "Bob");

//        // Printing the last index to the console
//        Console.WriteLine("Last index of 'Bob': " + lastIndex);
//    }
//}



//Part 11
//Using the list of names, clear the list and print the list out to the console.
//Hint: You can use the Clear() method to clear the list.


//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David", "Eve" };

//        // Clearing the list
//        names.Clear();

//        // Printing the cleared list to the console
//        Console.WriteLine("Cleared list:");
//        foreach (var name in names)
//        {
//            Console.WriteLine(name);
//        }
//    }
//}


//Part 12
//Create a new list of strings and integers and print them out to the console.
//Hint: You can use the Add() method to add items to the list and then use a foreach loop to print them out to the console.

//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        // Creating a new list of strings and integers
//        List<object> mixedList = new List<object>();

//        // Adding items to the list
//        mixedList.Add("Alice");
//        mixedList.Add(25);
//        mixedList.Add("Bob");
//        mixedList.Add(30);
//        mixedList.Add("Charlie");
//        mixedList.Add(35);

//        // Printing the list to the console
//        Console.WriteLine("Mixed List:");
//        foreach (var item in mixedList)
//        {
//            Console.WriteLine(item);
//        }
//    }
//}



