using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
class Player
{
    // Properties
    public string Name { get; set; }
    public int Level { get; private set; }
    public int HP { get; set; }
    public int MaxHP { get; set; }
    public int XP { get; private set; }
    public int AttackPower { get; set; }
    public int Defense { get; set; }
    private int xpToNextLevel; // XP required for the next level

    // Constructor
    public Player(string name, int level, int hp, int maxHp, int xp, int attackPower, int defense)
    {
        Name = name;
        Level = level;
        HP = hp;
        MaxHP = maxHp;
        XP = xp;
        AttackPower = attackPower;
        Defense = defense;
        xpToNextLevel = 100 * level; // Set initial XP required for the next level
    }

    // Method to level up the player
    public void LevelUp()
    {
        Level++;
        Console.WriteLine($"{Name} has leveled up to level {Level}!");
        xpToNextLevel += 100 * Level; // Increase XP required for the next level
    }

    // Method to heal the player
    public void Heal(int amount)
    {
        HP += amount;
        // Apply the potion and update player's health
        HP = Math.Min(HP, MaxHP); // Ensure HP does not exceed MaxHP
        Console.WriteLine($"{Name} has been healed for {amount} HP.");
    }

    // Method to gain experience points
    public void GainXP(int amount)
    {
        XP += amount;
        Console.WriteLine($"{Name} has gained {amount} experience points.");

        // Check if player levels up
        while (XP >= xpToNextLevel)
        {
            XP -= xpToNextLevel; // Carry over excess XP to the next level
            LevelUp();
        }
    }
}




class Enemy
{
    // Properties
    public string Name { get; set; }
    public int HP { get; private set; }

    
    public int AttackPower { get; set; }
    public int Defense { get; set; }

    // Constructor
    public Enemy(string name, int hp, int attackPower, int defense)
    {
        Name = name;
        HP = hp;
        AttackPower = attackPower;
        Defense = defense;
    }

    // Method to calculate damage inflicted by the enemy
    public int CalculateDamage(int playerDefense)
    {
        // Calculate damage using enemy's attack power and player's defense
        int damage = Math.Max(AttackPower - playerDefense, 0);
        return damage;
    }

    // Method to update enemy's HP after receiving damage
    public void ReceiveDamage(int damage)
    {
        // Reduce HP by the amount of damage received
        HP -= damage;
        // Ensure HP does not go below 0
        HP = Math.Max(HP, 0);
    }
}

class Inventory
{
    // Properties
    public int Capacity { get; private set; }
    private List<Item> items;

    // Constructor
    public Inventory(int capacity)
    {
        Capacity = capacity;
        items = new List<Item>();
    }

    // Method to add an item to the inventory
    public void AddItem(Item item)
    {
        if (items.Count < Capacity)
        {
            items.Add(item);
            Console.WriteLine($"Added {item.Name} to the inventory.");
        }
        else
        {
            Console.WriteLine("Inventory is full. Cannot add more items.");
        }
    }

    // Method to remove an item from the inventory
    public void RemoveItem(Item item)
    {
        if (items.Contains(item))
        {
            items.Remove(item);
            Console.WriteLine($"Removed {item.Name} from the inventory.");
        }
        else
        {
            Console.WriteLine($"{item.Name} is not in the inventory.");
        }
    }

    // Method to check if an item exists in the inventory
    public bool HasItem(string itemName)
    {
        return items.Any(item => item.Name.ToLower() == itemName.ToLower());
    }

    // Method to display details of an item in the inventory
    public void DisplayItemDetails(string itemName)
    {
        var item = items.FirstOrDefault(i => i.Name.ToLower() == itemName.ToLower());
        if (item != null)
        {
            Console.WriteLine($"Name: {item.Name}");
            Console.WriteLine($"Description: {item.Description}");
            Console.WriteLine($"Quantity: {item.Quantity}");
        }
        else
        {
            Console.WriteLine($"Item '{itemName}' not found in the inventory.");
        }
    }


}

// Item class representing items that can be stored in the inventory
class Item
{
    // Properties
    public string Name { get; set; }
    public string Description { get; set; }
    public int Quantity { get; set; }

    // Constructor
    public Item(string name, string description, int quantity)
    {
        Name = name;
        Description = description;
        Quantity = quantity;
    }
}

class Potion
{
    // Properties
    public string Name { get; set; }
    public int HealingPower { get; set; }
    public int Quantity { get; set; }

    // Constructor
    public Potion(string name, int healingPower, int quantity)
    {
        Name = name;
        HealingPower = healingPower;
        Quantity = quantity;
    }

    // Method to apply the potion to a player character and restore their health
    public void ApplyPotion(Player player)
    {

        // Calculate the amount of health restored by the potion
        int restoredHealth = Math.Min(HealingPower, player.MaxHP - player.HP);
        
        // Display message
        Console.WriteLine($"{player.Name} consumes {Name} and restores {restoredHealth} HP.");


        // Calculate the amount of health restored by the potion
        player.Heal(restoredHealth);

        // Decrease the quantity of the potion in inventory
        Quantity--;
        
    }
}




class Quest
{
    private string name;
    private string description;
    private string reward;
    private bool completed;
    private int goblinsKilled;

    public Quest(string name, string description, string reward)
    {
        this.name = name;
        this.description = description;
        this.reward = reward;
        completed = false;
        goblinsKilled = 0;
    }

    public void StartQuest()
    {
        Console.WriteLine($"Quest '{name}' started!");
        Console.WriteLine($"Description: {description}");
    }

    public void GoblinKilled()
    {
        goblinsKilled++;
        Console.WriteLine($"Goblin killed! Total goblins killed: {goblinsKilled}");

        // Check if quest is completed
        if (goblinsKilled >= 10)
        {
            completed = true;
            Console.WriteLine($"Quest '{name}' completed!");
        }
    }

    public void ClaimReward()
    {
        if (completed)
        {
            Console.WriteLine($"Claimed reward: {reward}");
        }
        else
        {
            Console.WriteLine("Cannot claim reward until the quest is completed.");
        }
    }
}




//------------------------ Class program to run above classes ---------------------------------------------//
class Program
{
    static void Main()
    {
        // Creating a Player object
        Player player = new Player("John", 1, 100, 100, 0, 50, 25);

        // Creating a Quest object
        Quest goblinQuest = new Quest("Goblin Slayer", "Kill 10 goblins", "Title: Goblin Slayer");

        // Creating a Potion object
        Potion potion = new Potion("Healing Potion", 20, 5); // Increase the healing power for demonstration

        // Gold for player
        int gold = 0;

        bool gameActive = true;
        while (gameActive)
        {
            //Start Quest or Visit Merchant
            Console.WriteLine($"Start Quest");
            Console.WriteLine("Options:");
            Console.WriteLine("1. Take Quest");
            Console.WriteLine("2. Go to merchant");
            Console.WriteLine("3. Exit game");
            Console.Write("Enter your choice: ");
            string questOption = Console.ReadLine();

            switch (questOption)
            {
                case "1":
                    goblinQuest.StartQuest();
                    // Simulating killing goblins
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine("****************************************************************");
                        Console.WriteLine($"Turn {i + 1}: A goblin appears!");

                        // Create a new goblin for each turn
                        Enemy goblin = new Enemy("Goblin", 50, 30, 5);

                        // Simulate player's and enemy's actions
                        bool goblinDefeated = false;
                        bool playerDefeated = false;
                        while (!goblinDefeated && !playerDefeated)
                        {
                            // Player's turn
                            // Displaying player's HP after consuming the potion
                            Console.WriteLine($"{player.Name}'s HP: {player.HP} - Healing Potion: {potion.Quantity}");
                            Console.WriteLine($"Enter 'attack' to attack the goblin or 'potion' to take a potion:");
                            string input = Console.ReadLine();

                            if (input.ToLower() == "attack")
                            {
                                // Determine if it's a critical hit
                                bool isCritical = new Random().Next(100) < 10; // Assuming a 10% chance for critical hit

                                // Calculate damage
                                int baseDamage = player.AttackPower - goblin.Defense;
                                int damage = isCritical ? baseDamage * 2 : baseDamage;

                                // Apply damage to goblin
                                goblin.ReceiveDamage(Math.Max(damage, 0));

                                if (goblin.HP > 0)
                                {
                                    // Goblin is still alive
                                    Console.WriteLine($"You hit the goblin for {(isCritical ? "critical " : "")}{damage} damage. Goblin's HP: {goblin.HP}");
                                }
                                else
                                {
                                    // Goblin is defeated
                                    Console.WriteLine($"You hit the goblin for {(isCritical ? "critical " : "")}{damage} damage. You defeated the goblin!");
                                    goblinDefeated = true;
                                    gold += 10;
                                    player.GainXP(30); // Gain 30 XP for defeating the goblin
                                    goblinQuest.GoblinKilled(); // Progress the quest
                                }
                            }
                            else if (input.ToLower() == "potion")
                            {
                                if (potion.Quantity > 0)
                                {
                                    // Apply the potion to the player character
                                    potion.ApplyPotion(player);

                                    // Displaying player's HP after consuming the potion
                                    Console.WriteLine($"{player.Name}'s HP: {player.HP}");
                                }
                                else
                                {
                                    Console.WriteLine("You don't have any potions left!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter 'attack' to attack the goblin or 'potion' to take a potion.");
                            }

                            // Check if player is defeated after taking their turn
                            if (player.HP <= 0)
                            {
                                Console.WriteLine("You have been defeated by the goblin.");
                                playerDefeated = true;
                            }

                            // Enemy's turn (if player is still alive)
                            if (!goblinDefeated && !playerDefeated)
                            {
                                // Simulate enemy's attack
                                if (new Random().Next(100) < 30) // 30% chance to miss
                                {
                                    Console.WriteLine("The goblin's attack missed!");
                                }
                                else
                                {
                                    int damage = Math.Max(goblin.AttackPower - player.Defense, 0);
                                    player.HP -= damage;
                                    Console.WriteLine($"The goblin hits you for {damage} damage. {player.Name}'s HP: {player.HP}");
                                }

                                // Check if player is defeated after enemy's attack
                                if (player.HP <= 0)
                                {
                                    Console.WriteLine("You have been defeated by the goblin.");
                                    playerDefeated = true;
                                }
                            }
                        }
                    }

                    // Claim the reward if quest is completed
                    goblinQuest.ClaimReward();
                    break;
                case "2":
                    VisitMerchant();
                    break;
                case "3":
                    gameActive = false;
                    Console.WriteLine("Exiting game...");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }

        // Merchant function
        void VisitMerchant()
        {
            bool merchantActive = true;
            while (merchantActive)
            {
                Console.WriteLine("Merchant's Shop");
                Console.WriteLine($"Player Gold: {gold} . Healing Potion: {potion.Quantity}");
                Console.WriteLine("1. Buy Potion (20 gold)");
                Console.WriteLine("2. Sell Potion (10 gold)");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");
                string merchantChoice = Console.ReadLine();

                switch (merchantChoice)
                {
                    case "1":
                        BuyPotion();
                        break;
                    case "2":
                        SellPotion();
                        break;
                    case "3":
                        merchantActive = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        void BuyPotion()
        {
            if (gold >= 20)
            {
                gold -= 20;
                potion.Quantity++;
                Console.WriteLine($"You bought a potion. You now have {potion.Quantity} potions.");
            }
            else
            {
                Console.WriteLine("Not enough gold to buy a potion.");
            }
        }

        void SellPotion()
        {
            if (potion.Quantity > 0)
            {
                gold += 10;
                potion.Quantity--;
                Console.WriteLine($"You sold a potion. You now have {potion.Quantity} potions.");
            }
            else
            {
                Console.WriteLine("You don't have any potions to sell.");
            }
        }

       
    }


}


//---------------------------------------------------------------------
// Question 1: Player Class
// Create a class named "Player" to represent a character in a role-playing game.
// Include attributes for the player's name, level, health points (HP), and experience points (XP).
// Implement methods to level up the player, heal the player, and gain experience points.
// Hint: Declare a class with properties for name, level, HP, and XP. Implement methods to increase level, heal HP, and gain XP.
/* Think about how players progress in a typical RPG game. Consider what actions a player can take and how they affect the player's attributes. */

//---------------------------------------------------------------------
// Question 2: Enemy Class
// Develop a class called "Enemy" to represent adversaries in a video game.
// Include properties for the enemy's name, health points (HP), attack power, and defense.
// Implement methods to calculate damage inflicted by the enemy and to update their HP.
// Hint: Define a class with attributes for name, HP, attack power, and defense. Create methods to calculate damage and update HP.
/* Consider the role enemies play in games. They typically attack players and can be defeated by reducing their HP to zero. */

//---------------------------------------------------------------------
// Question 3: Potion Class
// Design a class named "Potion" to model health-restoring items in an adventure game.
// Include properties for the potion's name, healing power, and quantity in inventory.
// Implement a method to apply the potion to a player character and restore their health.
// Hint: Define a class with attributes for name, healing power, and quantity. Create a method to apply the potion and heal the player.
/* Think about how healing items function in games. They typically restore a portion of a player's health when consumed. */

//---------------------------------------------------------------------
// Question 4: Quest Class
// Create a class called "Quest" to represent tasks or missions in a quest-based game.
// Include properties for the quest's name, description, reward, and completion status.
// Implement methods to start the quest, complete the quest, and claim the reward.
// Hint: Define a class with attributes for name, description, reward, and completion status. Implement methods to manage quest progress.
/* Consider the structure of quests in games. They often involve objectives, rewards, and tracking completion status. */

//---------------------------------------------------------------------
// Question 5: Inventory Class
// Develop a class named "Inventory" to manage a player's items in a role-playing game.
// Include properties for the inventory's capacity, list of items, and methods to add/remove items.
// Implement functionality to check if an item exists in the inventory and display its details.
// Hint: Define a class with attributes for capacity and a list of items. Create methods to add, remove, and search for items.
/* Think about how inventories work in games. Players can store and manage various items they collect during their adventures. */

//---------------------------------------------------------------------
// Question 6: Spell Class
// Design a class called "Spell" to represent magical abilities or spells in a fantasy game.
// Include properties for the spell's name, damage, mana cost, and description.
// Implement methods to cast the spell, consume mana, and display spell details.
// Hint: Define a class with attributes for name, damage, mana cost, and description. Implement methods to cast and describe the spell.
/* Consider the mechanics of spellcasting in fantasy games. Spells often have different effects, costs, and descriptions. */