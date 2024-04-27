﻿//---------------------------------------------------------------------
// Question 1: Weekday Enumeration
// Define an enum named "Weekday" to represent the days of the week (Monday to Sunday) in English.
// Hint: Use the provided Vietnamese example as a reference to declare the enum in English.
/* Enums are commonly used to represent a fixed set of values, such as the days of the week, ensuring consistency and preventing invalid values. */

using System;
public enum Weekday
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

//---------------------------------------------------------------------
// Question 2: Enemy State Enumeration
// Define an enum named "EnemyState" to represent the states of an enemy in a game (Idle, Patrol, Attack).
// Hint: Use descriptive terms to indicate the different states of an enemy in a game scenario.
/* Enums can encapsulate the various states of an enemy character in a game, such as when they are idle, patrolling, or attacking. */

// Define an enum named "EnemyState" to represent the states of an enemy in a game (Idle, Patrol, Attack).
public enum EnemyState
{
    Idle,
    Patrol,
    Attack
}


//---------------------------------------------------------------------
// Question 3: Flight Status Enumeration
// Define an enum named "FlightStatus" to represent the status of a character's flight in a 2D platformer game (Ascending, Descending, Stationary).
// Hint: Use descriptive terms to indicate the different states of flight in the enum.
/* Enums are useful for defining and managing various states or conditions within a game, such as character flight status. */

// Define an enum named "FlightStatus" to represent the status of a character's flight in a 2D platformer game (Ascending, Descending, Stationary).
public enum FlightStatus
{
    Ascending,
    Descending,
    Stationary
}


//---------------------------------------------------------------------
// Question 4: Title Rank Enumeration
// Define an enum named "TitleRank" to represent possible ranks or titles (Beginner, Intermediate, Advanced) in English.
// Hint: Apply the same enum declaration principles to define ranks or titles for users or characters in a game or application.
/* Enums facilitate the organization and categorization of ranks or titles, serving as constants within the program. */

// Define an enum named "TitleRank" to represent possible ranks or titles (Beginner, Intermediate, Advanced) in English.
public enum TitleRank
{
    Beginner,
    Intermediate,
    Advanced
}


//---------------------------------------------------------------------
// Question 5: Player Movement Enumeration
// Define an enum named "PlayerMovement" to represent the movement states of a player in a game (Idle, Walk, Run).
// Hint: Use descriptive terms to indicate the different states of player movement in a game scenario.
/* Enums can define various movement states for a player character in a game, simplifying the logic for handling different movement actions and transitions. */

// Define an enum named "PlayerMovement" to represent the movement states of a player in a game (Idle, Walk, Run).
public enum PlayerMovement
{
    Idle,
    Walk,
    Run
}


//---------------------------------------------------------------------
// Question 6: Accessing Enum Data
// Write a C# program to access the enum data representing the days of the week.
// Hint: Use the provided "DayOfWeek" enum and display the names of different days using Console.WriteLine().
/* Enums allow easy access to predefined values, ensuring consistency and preventing errors when working with specific sets of data. */


class Program
{
    enum DayOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    static void Main(string[] args)
    {
        // Accessing enum data representing the days of the week
        Console.WriteLine("Days of the Week:");
        Console.WriteLine(DayOfWeek.Monday);
        Console.WriteLine(DayOfWeek.Tuesday);
        Console.WriteLine(DayOfWeek.Wednesday);
        Console.WriteLine(DayOfWeek.Thursday);
        Console.WriteLine(DayOfWeek.Friday);
        Console.WriteLine(DayOfWeek.Saturday);
        Console.WriteLine(DayOfWeek.Sunday);
    }
}