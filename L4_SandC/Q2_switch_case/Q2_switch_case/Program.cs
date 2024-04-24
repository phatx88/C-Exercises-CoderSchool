//---------------------------------------------------------------------
// Question 1: Basic Switch Case
// Write a C# program that prompts the user to enter a number between 1 and 3. Using a switch-case statement,
// display a message based on the number entered. If the number is 1, print "One"; if the number is 2, print "Two"; if the number is 3, print "Three".
// If the number does not match any of these, display a default message.
// Hint: Use Console.ReadLine() to get user input and Convert.ToInt32() to convert the input to an integer.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Prompt the user to enter a number
//        Console.Write("Enter a number between 1 and 3: ");

//        // Read user input and convert it to an integer
//        int number;
//        if (!int.TryParse(Console.ReadLine(), out number))
//        {
//            Console.WriteLine("Invalid input. Please enter a valid number.");
//            return;
//        }

//        // Use switch-case to display a message based on the number entered
//        switch (number)
//        {
//            case 1:
//                Console.WriteLine("One");
//                break;
//            case 2:
//                Console.WriteLine("Two");
//                break;
//            case 3:
//                Console.WriteLine("Three");
//                break;
//            default:
//                Console.WriteLine("Number out of range.");
//                break;
//        }
//        Console.ReadLine();
//    }
//}


//---------------------------------------------------------------------
// Question 2: Game Character Selection
// In a game, the player can select a character class using numbers 1 to 3.
// Write a C# program that prompts the player to choose a character class.
// Based on the chosen number, display a message indicating the selected class: 1 for Warrior, 2 for Mage, and 3 for Archer.
// If the number does not match any of these, display a default message.
// Hint: Utilize switch-case statements to handle different cases of character selection.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Prompt the player to choose a character class
//        Console.WriteLine("Choose a character class:");
//        Console.WriteLine("1. Warrior");
//        Console.WriteLine("2. Mage");
//        Console.WriteLine("3. Archer");
//        Console.Write("Enter the number corresponding to your choice: ");

//        // Read player's input and convert it to an integer
//        int choice;
//        if (!int.TryParse(Console.ReadLine(), out choice))
//        {
//            Console.WriteLine("Invalid input. Please enter a valid number.");
//            return;
//        }

//        // Display the selected character class based on the choice
//        switch (choice)
//        {
//            case 1:
//                Console.WriteLine("You selected Warrior.");
//                break;
//            case 2:
//                Console.WriteLine("You selected Mage.");
//                break;
//            case 3:
//                Console.WriteLine("You selected Archer.");
//                break;
//            default:
//                Console.WriteLine("Invalid choice. Please choose a number between 1 and 3.");
//                break;
//        }

//        Console.ReadLine(); 
//    }
//}


//---------------------------------------------------------------------
// Question 3: Directional Movement
// In a game, the player can move in four cardinal directions: North, South, East, and West.
// Write a C# program that prompts the player to enter a direction using numbers 1 to 4.
// Based on the chosen number, display a message indicating the direction: 1 for North, 2 for South, 3 for East, and 4 for West.
// If the number does not match any of these, display a default message.
// Hint: Implement a switch-case statement to handle different directional inputs.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Prompt the player to enter a direction
//        Console.WriteLine("Choose a direction:");
//        Console.WriteLine("1. North");
//        Console.WriteLine("2. South");
//        Console.WriteLine("3. East");
//        Console.WriteLine("4. West");
//        Console.Write("Enter the number corresponding to your choice: ");

//        // Read player's input and convert it to an integer
//        int choice;
//        if (!int.TryParse(Console.ReadLine(), out choice))
//        {
//            Console.WriteLine("Invalid input. Please enter a valid number.");
//            return;
//        }

//        // Display the selected direction based on the choice
//        switch (choice)
//        {
//            case 1:
//                Console.WriteLine("You chose North.");
//                break;
//            case 2:
//                Console.WriteLine("You chose South.");
//                break;
//            case 3:
//                Console.WriteLine("You chose East.");
//                break;
//            case 4:
//                Console.WriteLine("You chose West.");
//                break;
//            default:
//                Console.WriteLine("Invalid choice. Please choose a number between 1 and 4.");
//                break;
//        }

//        Console.ReadLine();
//    }
//}


//---------------------------------------------------------------------
// Question 4: Day of the Week
// Write a C# program that prompts the user to enter a number between 1 and 7 representing a day of the week.
// Use a switch-case statement to display the name of the corresponding day.
// For example, if the user enters 1, print "Monday"; if 2, print "Tuesday", and so on. If the number does not match any of these, display a default message.
// Hint: Map each number input to a specific day of the week using a switch-case statement.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Prompt the user to enter a number representing a day of the week
//        Console.Write("Enter a number between 1 and 7 representing a day of the week: ");

//        // Read user input and convert it to an integer
//        int dayNumber;
//        if (!int.TryParse(Console.ReadLine(), out dayNumber))
//        {
//            Console.WriteLine("Invalid input. Please enter a valid number.");
//            return;
//        }

//        // Display the name of the corresponding day based on the input number
//        switch (dayNumber)
//        {
//            case 1:
//                Console.WriteLine("Monday");
//                break;
//            case 2:
//                Console.WriteLine("Tuesday");
//                break;
//            case 3:
//                Console.WriteLine("Wednesday");
//                break;
//            case 4:
//                Console.WriteLine("Thursday");
//                break;
//            case 5:
//                Console.WriteLine("Friday");
//                break;
//            case 6:
//                Console.WriteLine("Saturday");
//                break;
//            case 7:
//                Console.WriteLine("Sunday");
//                break;
//            default:
//                Console.WriteLine("Invalid number. Please enter a number between 1 and 7.");
//                break;
//        }

//        Console.ReadLine(); 
//    }
//}


//---------------------------------------------------------------------
// Question 5: Weapon Selection
// In a game, the player can select a weapon using numbers 1 to 4.
// Write a C# program that prompts the player to choose a weapon. Based on the chosen number, display a message indicating the selected weapon: 1 for Sword, 2 for Bow, 3 for Staff, and 4 for Axe.
// If the number does not match any of these, display a default message.
// Hint: Use switch-case statements to handle different weapon choices.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Prompt the player to choose a weapon
//        Console.WriteLine("Choose a weapon:");
//        Console.WriteLine("1. Sword");
//        Console.WriteLine("2. Bow");
//        Console.WriteLine("3. Staff");
//        Console.WriteLine("4. Axe");
//        Console.Write("Enter the number corresponding to your choice: ");

//        // Read the player's input and convert it to an integer
//        int weaponNumber;
//        if (!int.TryParse(Console.ReadLine(), out weaponNumber))
//        {
//            Console.WriteLine("Invalid input. Please enter a valid number.");
//            return;
//        }

//        // Display the selected weapon based on the chosen number
//        switch (weaponNumber)
//        {
//            case 1:
//                Console.WriteLine("You selected Sword.");
//                break;
//            case 2:
//                Console.WriteLine("You selected Bow.");
//                break;
//            case 3:
//                Console.WriteLine("You selected Staff.");
//                break;
//            case 4:
//                Console.WriteLine("You selected Axe.");
//                break;
//            default:
//                Console.WriteLine("Invalid choice. Please choose a number between 1 and 4.");
//                break;
//        }

//        Console.ReadLine();
//    }
//}




//---------------------------------------------------------------------
// Question 6: Elemental Magic
// In a fantasy game, the player can cast elemental magic spells using numbers 1 to 5.
// Write a C# program that prompts the player to select a magic spell. Based on the chosen number, display a message indicating the selected spell element: 1 for Fire, 2 for Water, 3 for Earth, 4 for Air, and 5 for Lightning.
// If the number does not match any of these, display a default message.
// Hint: Implement a switch-case statement to handle different spell selections.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Prompt the player to select a magic spell
//        Console.WriteLine("Select a magic spell:");
//        Console.WriteLine("1. Fire");
//        Console.WriteLine("2. Water");
//        Console.WriteLine("3. Earth");
//        Console.WriteLine("4. Air");
//        Console.WriteLine("5. Lightning");
//        Console.Write("Enter the number corresponding to your choice: ");

//        // Read the player's input and convert it to an integer
//        int spellNumber;
//        if (!int.TryParse(Console.ReadLine(), out spellNumber))
//        {
//            Console.WriteLine("Invalid input. Please enter a valid number.");
//            return;
//        }

//        // Display the selected spell element based on the chosen number
//        switch (spellNumber)
//        {
//            case 1:
//                Console.WriteLine("You selected Fire.");
//                break;
//            case 2:
//                Console.WriteLine("You selected Water.");
//                break;
//            case 3:
//                Console.WriteLine("You selected Earth.");
//                break;
//            case 4:
//                Console.WriteLine("You selected Air.");
//                break;
//            case 5:
//                Console.WriteLine("You selected Lightning.");
//                break;
//            default:
//                Console.WriteLine("Invalid choice. Please choose a number between 1 and 5.");
//                break;
//        }

//        Console.ReadLine();
//    }
//}


//---------------------------------------------------------------------
// Question 7: Menu Navigation
// Write a C# program that simulates a menu navigation system for a game.
// The user can enter numbers 1 to 4 to navigate through different menu options: 1 for Start Game, 2 for Options, 3 for Load Game, and 4 for Exit.
// If the number does not match any of these, display a default message.
// Hint: Utilize switch-case statements to handle user input and navigate between menu options.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Display the menu options
//        Console.WriteLine("Menu:");
//        Console.WriteLine("1. Start Game");
//        Console.WriteLine("2. Options");
//        Console.WriteLine("3. Load Game");
//        Console.WriteLine("4. Exit");

//        // Prompt the user to enter a choice
//        Console.Write("Enter the number corresponding to your choice: ");

//        // Read the user's input and convert it to an integer
//        int choice;
//        if (!int.TryParse(Console.ReadLine(), out choice))
//        {
//            Console.WriteLine("Invalid input. Please enter a valid number.");
//            return;
//        }

//        // Navigate through different menu options based on the user's choice
//        switch (choice)
//        {
//            case 1:
//                Console.WriteLine("Starting the game...");
//                break;
//            case 2:
//                Console.WriteLine("Opening options menu...");
//                break;
//            case 3:
//                Console.WriteLine("Loading game...");
//                break;
//            case 4:
//                Console.WriteLine("Exiting the game...");
//                break;
//            default:
//                Console.WriteLine("Invalid choice. Please choose a number between 1 and 4.");
//                break;
//        }

//        Console.ReadLine();
//    }
//}


//---------------------------------------------------------------------
// Question 8: NPC Interaction
// In an RPG game, the player can interact with non-player characters (NPCs) using numbers 1 to 3.
// Write a C# program that prompts the player to choose an interaction option with an NPC. Based on the chosen number, display a message indicating the selected interaction: 1 for Talk, 2 for Trade, and 3 for Quest.
// If the number does not match any of these, display a default message.
// Hint: Implement a switch-case statement to handle different interaction options with NPCs.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Display the interaction options with NPCs
//        Console.WriteLine("NPC Interaction:");
//        Console.WriteLine("1. Talk");
//        Console.WriteLine("2. Trade");
//        Console.WriteLine("3. Quest");

//        // Prompt the player to choose an interaction option
//        Console.Write("Enter the number corresponding to your choice: ");

//        // Read the player's input and convert it to an integer
//        int interactionOption;
//        if (!int.TryParse(Console.ReadLine(), out interactionOption))
//        {
//            Console.WriteLine("Invalid input. Please enter a valid number.");
//            return;
//        }

//        // Display the selected interaction based on the chosen number
//        switch (interactionOption)
//        {
//            case 1:
//                Console.WriteLine("You selected Talk.");
//                break;
//            case 2:
//                Console.WriteLine("You selected Trade.");
//                break;
//            case 3:
//                Console.WriteLine("You selected Quest.");
//                break;
//            default:
//                Console.WriteLine("Invalid choice. Please choose a number between 1 and 3.");
//                break;
//        }

//        Console.ReadLine();
//    }
//}


//---------------------------------------------------------------------
// Question 9: Puzzle Solutions
// In a puzzle-solving game, the player can choose from different solutions using numbers 1 to 5.
// Write a C# program that prompts the player to select a solution for a puzzle. Based on the chosen number, display a message indicating the selected solution option.
// If the number does not match any of these, display a default message.
// Hint: Use switch-case statements to handle different puzzle solution choices.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Display the puzzle solution options
//        Console.WriteLine("Puzzle Solutions:");
//        Console.WriteLine("1. Solution 1");
//        Console.WriteLine("2. Solution 2");
//        Console.WriteLine("3. Solution 3");
//        Console.WriteLine("4. Solution 4");
//        Console.WriteLine("5. Solution 5");

//        // Prompt the player to choose a puzzle solution
//        Console.Write("Enter the number corresponding to your choice: ");

//        // Read the player's input and convert it to an integer
//        int solutionOption;
//        if (!int.TryParse(Console.ReadLine(), out solutionOption))
//        {
//            Console.WriteLine("Invalid input. Please enter a valid number.");
//            return;
//        }

//        // Display the selected solution option based on the chosen number
//        switch (solutionOption)
//        {
//            case 1:
//                Console.WriteLine("You selected Solution 1.");
//                break;
//            case 2:
//                Console.WriteLine("You selected Solution 2.");
//                break;
//            case 3:
//                Console.WriteLine("You selected Solution 3.");
//                break;
//            case 4:
//                Console.WriteLine("You selected Solution 4.");
//                break;
//            case 5:
//                Console.WriteLine("You selected Solution 5.");
//                break;
//            default:
//                Console.WriteLine("Invalid choice. Please choose a number between 1 and 5.");
//                break;
//        }

//        Console.ReadLine();
//    }
//}


//---------------------------------------------------------------------
// Question 10: Dialogue Choices
// Write a C# program that simulates dialogue choices in a game. The player can select dialogue options using numbers 1 to 4.
// Based on the chosen number, display a message indicating the selected dialogue choice. If the number does not match any of these, display a default message.
// Hint: Implement switch-case statements to handle different dialogue options presented to the player.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Display the dialogue options
//        Console.WriteLine("Dialogue Choices:");
//        Console.WriteLine("1. Option 1");
//        Console.WriteLine("2. Option 2");
//        Console.WriteLine("3. Option 3");
//        Console.WriteLine("4. Option 4");

//        // Prompt the player to choose a dialogue option
//        Console.Write("Enter the number corresponding to your choice: ");

//        // Read the player's input and convert it to an integer
//        int dialogueOption;
//        if (!int.TryParse(Console.ReadLine(), out dialogueOption))
//        {
//            Console.WriteLine("Invalid input. Please enter a valid number.");
//            return;
//        }

//        // Display the selected dialogue choice based on the chosen number
//        switch (dialogueOption)
//        {
//            case 1:
//                Console.WriteLine("You selected Option 1.");
//                break;
//            case 2:
//                Console.WriteLine("You selected Option 2.");
//                break;
//            case 3:
//                Console.WriteLine("You selected Option 3.");
//                break;
//            case 4:
//                Console.WriteLine("You selected Option 4.");
//                break;
//            default:
//                Console.WriteLine("Invalid choice. Please choose a number between 1 and 4.");
//                break;
//        }

//        Console.ReadLine(); 
//    }
//}


//---------------------------------------------------------------------
// Question 11: Crafting Items
// In a crafting system, the player can select crafting recipes using numbers 1 to 3.
// Write a C# program that prompts the player to choose a crafting recipe.
// Based on the chosen number, display a message indicating the selected recipe: 1 for Potion, 2 for Weapon, and 3 for Armor. If the number does not match any of these, display a default message.
// Hint: Utilize switch-case statements to handle different crafting recipe selections.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Display the crafting recipe options
//        Console.WriteLine("Crafting Items:");
//        Console.WriteLine("1. Potion");
//        Console.WriteLine("2. Weapon");
//        Console.WriteLine("3. Armor");

//        // Prompt the player to choose a crafting recipe
//        Console.Write("Enter the number corresponding to your choice: ");

//        // Read the player's input and convert it to an integer
//        int recipeOption;
//        if (!int.TryParse(Console.ReadLine(), out recipeOption))
//        {
//            Console.WriteLine("Invalid input. Please enter a valid number.");
//            return;
//        }

//        // Display the selected crafting recipe based on the chosen number
//        switch (recipeOption)
//        {
//            case 1:
//                Console.WriteLine("You selected Potion.");
//                break;
//            case 2:
//                Console.WriteLine("You selected Weapon.");
//                break;
//            case 3:
//                Console.WriteLine("You selected Armor.");
//                break;
//            default:
//                Console.WriteLine("Invalid choice. Please choose a number between 1 and 3.");
//                break;
//        }
//        Console.ReadLine();
//    }
//}


//---------------------------------------------------------------------
// Question 12: Scene Selection
// Write a C# program that simulates scene selection in a game.
// The player can choose scenes using numbers 1 to 5. Based on the chosen number, display a message indicating the selected scene.
// If the number does not match any of these, display a default message.
// Hint: Implement switch-case statements to handle different scene selections.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Display the scene options
//        Console.WriteLine("Scene Selection:");
//        Console.WriteLine("1. Scene 1");
//        Console.WriteLine("2. Scene 2");
//        Console.WriteLine("3. Scene 3");
//        Console.WriteLine("4. Scene 4");
//        Console.WriteLine("5. Scene 5");

//        // Prompt the player to choose a scene
//        Console.Write("Enter the number corresponding to your choice: ");

//        // Read the player's input and convert it to an integer
//        int sceneOption;
//        if (!int.TryParse(Console.ReadLine(), out sceneOption))
//        {
//            Console.WriteLine("Invalid input. Please enter a valid number.");
//            return;
//        }

//        // Display the selected scene based on the chosen number
//        switch (sceneOption)
//        {
//            case 1:
//                Console.WriteLine("You selected Scene 1.");
//                break;
//            case 2:
//                Console.WriteLine("You selected Scene 2.");
//                break;
//            case 3:
//                Console.WriteLine("You selected Scene 3.");
//                break;
//            case 4:
//                Console.WriteLine("You selected Scene 4.");
//                break;
//            case 5:
//                Console.WriteLine("You selected Scene 5.");
//                break;
//            default:
//                Console.WriteLine("Invalid choice. Please choose a number between 1 and 5.");
//                break;
//        }
//        Console.ReadLine();
//    }
//}


//---------------------------------------------------------------------
// Question 13: Quest Progression
// In an adventure game, the player can progress through quests using numbers 1 to 4.
// Write a C# program that prompts the player to select a quest. Based on the chosen number, display a message indicating the selected quest.
// If the number does not match any of these, display a default message.
// Hint: Use switch-case statements to handle different quest selections and progression

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Display the quest options
//        Console.WriteLine("Quest Progression:");
//        Console.WriteLine("1. Quest 1");
//        Console.WriteLine("2. Quest 2");
//        Console.WriteLine("3. Quest 3");
//        Console.WriteLine("4. Quest 4");

//        // Prompt the player to choose a quest
//        Console.Write("Enter the number corresponding to your choice: ");

//        // Read the player's input and convert it to an integer
//        int questOption;
//        if (!int.TryParse(Console.ReadLine(), out questOption))
//        {
//            Console.WriteLine("Invalid input. Please enter a valid number.");
//            return;
//        }

//        // Display the selected quest based on the chosen number
//        switch (questOption)
//        {
//            case 1:
//                Console.WriteLine("You selected Quest 1.");
//                break;
//            case 2:
//                Console.WriteLine("You selected Quest 2.");
//                break;
//            case 3:
//                Console.WriteLine("You selected Quest 3.");
//                break;
//            case 4:
//                Console.WriteLine("You selected Quest 4.");
//                break;
//            default:
//                Console.WriteLine("Invalid choice. Please choose a number between 1 and 4.");
//                break;
//        }
//        Console.ReadLine();
//    }
//}



//---------------------------------------------------------------------
// Question 14: Potion Brewing
// In an alchemy system, the player can brew potions using numbers 1 to 3.
// Write a C# program that prompts the player to choose a potion to brew. Based on the chosen number, display a message indicating the selected potion: 1 for Health Potion, 2 for Mana Potion, and 3 for Stamina Potion.
// If the number does not match any of these, display a default message.
// Hint: Implement switch-case statements to handle different potion brewing choices.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Display the potion options
//        Console.WriteLine("Potion Brewing:");
//        Console.WriteLine("1. Health Potion");
//        Console.WriteLine("2. Mana Potion");
//        Console.WriteLine("3. Stamina Potion");

//        // Prompt the player to choose a potion
//        Console.Write("Enter the number corresponding to the potion you want to brew: ");

//        // Read the player's input and convert it to an integer
//        int potionOption;
//        if (!int.TryParse(Console.ReadLine(), out potionOption))
//        {
//            Console.WriteLine("Invalid input. Please enter a valid number.");
//            return;
//        }

//        // Display the selected potion based on the chosen number
//        switch (potionOption)
//        {
//            case 1:
//                Console.WriteLine("You selected Health Potion.");
//                break;
//            case 2:
//                Console.WriteLine("You selected Mana Potion.");
//                break;
//            case 3:
//                Console.WriteLine("You selected Stamina Potion.");
//                break;
//            default:
//                Console.WriteLine("Invalid choice. Please choose a number between 1 and 3.");
//                break;
//        }
//        Console.ReadLine();
//    }
//}


//---------------------------------------------------------------------
// Question 15: Platform Movement
// In a platformer game, the player can move the character using numbers 1 to 4 for directional controls.
// Write a C# program that prompts the player to enter a movement direction. Based on the chosen number, display a message indicating the movement direction: 1 for Left, 2 for Right, 3 for Jump, and 4 for Crouch.
// If the number does not match any of these, display a default message.
// Hint: Utilize switch-case statements to handle different movement directions, including a default case.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Display the movement options
//        Console.WriteLine("Platform Movement:");
//        Console.WriteLine("1. Left");
//        Console.WriteLine("2. Right");
//        Console.WriteLine("3. Jump");
//        Console.WriteLine("4. Crouch");

//        // Prompt the player to choose a movement direction
//        Console.Write("Enter the number corresponding to the movement direction: ");

//        // Read the player's input and convert it to an integer
//        int movementOption;
//        if (!int.TryParse(Console.ReadLine(), out movementOption))
//        {
//            Console.WriteLine("Invalid input. Please enter a valid number.");
//            return;
//        }

//        // Display the selected movement direction based on the chosen number
//        switch (movementOption)
//        {
//            case 1:
//                Console.WriteLine("You moved Left.");
//                break;
//            case 2:
//                Console.WriteLine("You moved Right.");
//                break;
//            case 3:
//                Console.WriteLine("You Jumped.");
//                break;
//            case 4:
//                Console.WriteLine("You Crouched.");
//                break;
//            default:
//                Console.WriteLine("Invalid choice. Please choose a number between 1 and 4.");
//                break;
//        }
//        Console.ReadLine();
//    }
//}



//////////////////////Break Statements//////////////////////

//---------------------------------------------------------------------
// Question 16: Weapon Upgrades
// In a game, the player can upgrade their weapon using different materials.
// Write a C# program that prompts the player to choose a material for weapon upgrade.
// Based on the chosen number, display a message indicating the selected material. Use a switch-case statement to handle the different material choices: 1 for Iron, 2 for Steel, 3 for Gold, and 4 for Diamond.
// After displaying the selected material, include a break statement to terminate the switch-case block.
// Hint: Implement switch-case statements to handle different material choices and use break statements to exit the switch-case block.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Display the material options for weapon upgrade
//        Console.WriteLine("Weapon Upgrade Materials:");
//        Console.WriteLine("1. Iron");
//        Console.WriteLine("2. Steel");
//        Console.WriteLine("3. Gold");
//        Console.WriteLine("4. Diamond");

//        // Prompt the player to choose a material for weapon upgrade
//        Console.Write("Enter the number corresponding to the material choice: ");

//        // Read the player's input and convert it to an integer
//        int materialChoice;
//        if (!int.TryParse(Console.ReadLine(), out materialChoice))
//        {
//            Console.WriteLine("Invalid input. Please enter a valid number.");
//            return;
//        }

//        // Display the selected material based on the chosen number
//        switch (materialChoice)
//        {
//            case 1:
//                Console.WriteLine("You selected Iron for weapon upgrade.");
//                break;
//            case 2:
//                Console.WriteLine("You selected Steel for weapon upgrade.");
//                break;
//            case 3:
//                Console.WriteLine("You selected Gold for weapon upgrade.");
//                break;
//            case 4:
//                Console.WriteLine("You selected Diamond for weapon upgrade.");
//                break;
//            default:
//                Console.WriteLine("Invalid choice. Please choose a number between 1 and 4.");
//                break;
//        }

//        Console.ReadLine();
//    }
//}


//---------------------------------------------------------------------
// Question 17: Spell Casting
// In a fantasy game, the player can cast spells using different magic elements.
// Write a C# program that prompts the player to select a spell element. Based on the chosen number, display a message indicating the selected spell element: 1 for Fire, 2 for Water, 3 for Earth, and 4 for Air.
// After displaying the selected element, include a break statement to terminate the switch-case block.
// Hint: Utilize switch-case statements to handle different spell elements and use break statements to exit the switch-case block.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Display the spell element options for spell casting
//        Console.WriteLine("Spell Elements:");
//        Console.WriteLine("1. Fire");
//        Console.WriteLine("2. Water");
//        Console.WriteLine("3. Earth");
//        Console.WriteLine("4. Air");

//        // Prompt the player to choose a spell element
//        Console.Write("Enter the number corresponding to the spell element choice: ");

//        // Read the player's input and convert it to an integer
//        int spellElementChoice;
//        if (!int.TryParse(Console.ReadLine(), out spellElementChoice))
//        {
//            Console.WriteLine("Invalid input. Please enter a valid number.");
//            return;
//        }

//        // Display the selected spell element based on the chosen number
//        switch (spellElementChoice)
//        {
//            case 1:
//                Console.WriteLine("You selected Fire for spell casting.");
//                break;
//            case 2:
//                Console.WriteLine("You selected Water for spell casting.");
//                break;
//            case 3:
//                Console.WriteLine("You selected Earth for spell casting.");
//                break;
//            case 4:
//                Console.WriteLine("You selected Air for spell casting.");
//                break;
//            default:
//                Console.WriteLine("Invalid choice. Please choose a number between 1 and 4.");
//                break;
//        }

//        Console.ReadLine();
//    }
//}


//---------------------------------------------------------------------
// Question 18: Skill Selection
// In a role-playing game (RPG), the player can choose skills to improve their character's abilities.
// Write a C# program that prompts the player to select a skill for enhancement. Based on the chosen number, display a message indicating the selected skill: 1 for Strength, 2 for Agility, 3 for Intelligence, and 4 for Vitality.
// After displaying the selected skill, include a break statement to terminate the switch-case block.
// Hint: Implement switch-case statements to handle different skill selections and use break statements to exit the switch-case block.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Display the skill options for enhancement
//        Console.WriteLine("Skill Selection:");
//        Console.WriteLine("1. Strength");
//        Console.WriteLine("2. Agility");
//        Console.WriteLine("3. Intelligence");
//        Console.WriteLine("4. Vitality");

//        // Prompt the player to choose a skill for enhancement
//        Console.Write("Enter the number corresponding to the skill choice: ");

//        // Read the player's input and convert it to an integer
//        int skillChoice;
//        if (!int.TryParse(Console.ReadLine(), out skillChoice))
//        {
//            Console.WriteLine("Invalid input. Please enter a valid number.");
//            return;
//        }

//        // Display the selected skill based on the chosen number
//        switch (skillChoice)
//        {
//            case 1:
//                Console.WriteLine("You selected Strength for enhancement.");
//                break;
//            case 2:
//                Console.WriteLine("You selected Agility for enhancement.");
//                break;
//            case 3:
//                Console.WriteLine("You selected Intelligence for enhancement.");
//                break;
//            case 4:
//                Console.WriteLine("You selected Vitality for enhancement.");
//                break;
//            default:
//                Console.WriteLine("Invalid choice. Please choose a number between 1 and 4.");
//                break;
//        }

//        Console.ReadLine();
//    }
//}


//---------------------------------------------------------------------
// Question 19: Puzzle Solutions
// In a puzzle-solving game, the player can choose from different solutions to progress through the game.
// Write a C# program that prompts the player to select a solution for a puzzle. Based on the chosen number, display a message indicating the selected solution option.
// After displaying the selected solution, include a break statement to terminate the switch-case block.
// Hint: Use switch-case statements to handle different puzzle solution choices and use break statements to exit the switch-case block.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Display the puzzle solution options
//        Console.WriteLine("Puzzle Solutions:");
//        Console.WriteLine("1. Solution A");
//        Console.WriteLine("2. Solution B");
//        Console.WriteLine("3. Solution C");
//        Console.WriteLine("4. Solution D");

//        // Prompt the player to choose a solution for the puzzle
//        Console.Write("Enter the number corresponding to the solution choice: ");

//        // Read the player's input and convert it to an integer
//        int solutionChoice;
//        if (!int.TryParse(Console.ReadLine(), out solutionChoice))
//        {
//            Console.WriteLine("Invalid input. Please enter a valid number.");
//            return;
//        }

//        // Display the selected puzzle solution based on the chosen number
//        switch (solutionChoice)
//        {
//            case 1:
//                Console.WriteLine("You selected Solution A.");
//                break;
//            case 2:
//                Console.WriteLine("You selected Solution B.");
//                break;
//            case 3:
//                Console.WriteLine("You selected Solution C.");
//                break;
//            case 4:
//                Console.WriteLine("You selected Solution D.");
//                break;
//            default:
//                Console.WriteLine("Invalid choice. Please choose a number between 1 and 4.");
//                break;
//        }

//        Console.ReadLine();
//    }
//}


//---------------------------------------------------------------------
// Question 20: Potion Brewing
// In an alchemy system, the player can brew potions using different ingredients.
// Write a C# program that prompts the player to choose an ingredient for potion brewing. Based on the chosen number, display a message indicating the selected ingredient: 1 for Herb, 2 for Mushroom, 3 for Flower, and 4 for Crystal.
// After displaying the selected ingredient, include a break statement to terminate the switch-case block.
// Hint: Implement switch-case statements to handle different ingredient choices and use break statements to exit the switch-case block.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Display the potion ingredient options
//        Console.WriteLine("Potion Ingredients:");
//        Console.WriteLine("1. Herb");
//        Console.WriteLine("2. Mushroom");
//        Console.WriteLine("3. Flower");
//        Console.WriteLine("4. Crystal");

//        // Prompt the player to choose an ingredient for potion brewing
//        Console.Write("Enter the number corresponding to the ingredient choice: ");

//        // Read the player's input and convert it to an integer
//        int ingredientChoice;
//        if (!int.TryParse(Console.ReadLine(), out ingredientChoice))
//        {
//            Console.WriteLine("Invalid input. Please enter a valid number.");
//            return;
//        }

//        // Display the selected ingredient for potion brewing based on the chosen number
//        switch (ingredientChoice)
//        {
//            case 1:
//                Console.WriteLine("You selected Herb.");
//                break;
//            case 2:
//                Console.WriteLine("You selected Mushroom.");
//                break;
//            case 3:
//                Console.WriteLine("You selected Flower.");
//                break;
//            case 4:
//                Console.WriteLine("You selected Crystal.");
//                break;
//            default:
//                Console.WriteLine("Invalid choice. Please choose a number between 1 and 4.");
//                break;
//        }
//        Console.ReadLine();
//    }
//}


//---------------------------------------------------------------------
// Question 21: NPC Interactions
// In a game world, the player can interact with non-player characters (NPCs) in various ways.
// Write a C# program that simulates NPC interactions based on player input. Prompt the player to choose an interaction option with an NPC using numbers 1 to 3: 1 for Talk, 2 for Trade, and 3 for Quest.
// After displaying the selected interaction, include a break statement to terminate the switch-case block.
// Hint: Utilize switch-case statements to handle different NPC interaction options and use break statements to exit the switch-case block.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Display the NPC interaction options
//        Console.WriteLine("NPC Interaction Options:");
//        Console.WriteLine("1. Talk");
//        Console.WriteLine("2. Trade");
//        Console.WriteLine("3. Quest");

//        // Prompt the player to choose an interaction option with an NPC
//        Console.Write("Enter the number corresponding to the interaction option: ");

//        // Read the player's input and convert it to an integer
//        int interactionOption;
//        if (!int.TryParse(Console.ReadLine(), out interactionOption))
//        {
//            Console.WriteLine("Invalid input. Please enter a valid number.");
//            return;
//        }

//        // Display the selected NPC interaction option based on the chosen number
//        switch (interactionOption)
//        {
//            case 1:
//                Console.WriteLine("You selected Talk.");
//                break;
//            case 2:
//                Console.WriteLine("You selected Trade.");
//                break;
//            case 3:
//                Console.WriteLine("You selected Quest.");
//                break;
//            default:
//                Console.WriteLine("Invalid choice. Please choose a number between 1 and 3.");
//                break;
//        }
//        Console.ReadLine();
//    }
//}


//---------------------------------------------------------------------
// Question 22: Scene Navigation
// Write a C# program that simulates scene navigation in a game.
// The player can choose scenes using numbers 1 to 5 to navigate through different game environments.
// After displaying the selected scene, include a break statement to terminate the switch-case block.
// Hint: Implement switch-case statements to handle different scene selections and use break statements to exit the switch-case block.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Display the scene options
//        Console.WriteLine("Scene Navigation Options:");
//        Console.WriteLine("1. Forest");
//        Console.WriteLine("2. Desert");
//        Console.WriteLine("3. Mountains");
//        Console.WriteLine("4. City");
//        Console.WriteLine("5. Dungeon");

//        // Prompt the player to choose a scene
//        Console.Write("Enter the number corresponding to the scene: ");

//        // Read the player's input and convert it to an integer
//        int sceneNumber;
//        if (!int.TryParse(Console.ReadLine(), out sceneNumber))
//        {
//            Console.WriteLine("Invalid input. Please enter a valid number.");
//            return;
//        }

//        // Display the selected scene based on the chosen number
//        switch (sceneNumber)
//        {
//            case 1:
//                Console.WriteLine("You entered the Forest scene.");
//                break;
//            case 2:
//                Console.WriteLine("You entered the Desert scene.");
//                break;
//            case 3:
//                Console.WriteLine("You entered the Mountains scene.");
//                break;
//            case 4:
//                Console.WriteLine("You entered the City scene.");
//                break;
//            case 5:
//                Console.WriteLine("You entered the Dungeon scene.");
//                break;
//            default:
//                Console.WriteLine("Invalid choice. Please choose a number between 1 and 5.");
//                break;
//        }
//        Console.ReadLine();
//    }
//}


//---------------------------------------------------------------------
// Question 23: Quest Progression
// In an adventure game, the player can progress through quests using different options.
// Write a C# program that prompts the player to select a quest option. After displaying the selected quest option, include a break statement to terminate the switch-case block.
// Hint: Use switch-case statements to handle different quest options and use break statements to exit the switch-case block.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Display the quest options
//        Console.WriteLine("Quest Progression Options:");
//        Console.WriteLine("1. Explore the Forest");
//        Console.WriteLine("2. Investigate the Cave");
//        Console.WriteLine("3. Rescue the Villagers");
//        Console.WriteLine("4. Retrieve the Artifact");
//        Console.WriteLine("5. Defeat the Boss");

//        // Prompt the player to choose a quest option
//        Console.Write("Enter the number corresponding to the quest option: ");

//        // Read the player's input and convert it to an integer
//        int questOption;
//        if (!int.TryParse(Console.ReadLine(), out questOption))
//        {
//            Console.WriteLine("Invalid input. Please enter a valid number.");
//            return;
//        }

//        // Display the selected quest option based on the chosen number
//        switch (questOption)
//        {
//            case 1:
//                Console.WriteLine("You chose to explore the Forest.");
//                break;
//            case 2:
//                Console.WriteLine("You chose to investigate the Cave.");
//                break;
//            case 3:
//                Console.WriteLine("You chose to rescue the Villagers.");
//                break;
//            case 4:
//                Console.WriteLine("You chose to retrieve the Artifact.");
//                break;
//            case 5:
//                Console.WriteLine("You chose to defeat the Boss.");
//                break;
//            default:
//                Console.WriteLine("Invalid choice. Please choose a number between 1 and 5.");
//                break;
//        }
//        Console.ReadLine();
//    }
//}


//---------------------------------------------------------------------
// Question 24: Menu Navigation
// Write a C# program that simulates menu navigation in a game.
// The player can navigate through menu options using numbers 1 to 4: 1 for Start, 2 for Options, 3 for Load Game, and 4 for Exit.
// After displaying the selected menu option, include a break statement to terminate the switch-case block.
// Hint: Utilize switch-case statements to handle different menu options and use break statements to exit the switch-case block.

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Display the menu options
//        Console.WriteLine("Menu Options:");
//        Console.WriteLine("1. Start");
//        Console.WriteLine("2. Options");
//        Console.WriteLine("3. Load Game");
//        Console.WriteLine("4. Exit");

//        // Prompt the player to choose a menu option
//        Console.Write("Enter the number corresponding to the menu option: ");

//        // Read the player's input and convert it to an integer
//        int menuOption;
//        if (!int.TryParse(Console.ReadLine(), out menuOption))
//        {
//            Console.WriteLine("Invalid input. Please enter a valid number.");
//            return;
//        }

//        // Display the selected menu option based on the chosen number
//        switch (menuOption)
//        {
//            case 1:
//                Console.WriteLine("You selected Start.");
//                break;
//            case 2:
//                Console.WriteLine("You selected Options.");
//                break;
//            case 3:
//                Console.WriteLine("You selected Load Game.");
//                break;
//            case 4:
//                Console.WriteLine("You selected Exit.");
//                break;
//            default:
//                Console.WriteLine("Invalid choice. Please choose a number between 1 and 4.");
//                break;
//        }
//        Console.ReadLine();
//    }
//}
