
/*
Question 1:
BMI Calculation

The Body Mass Index (BMI) of a person is calculated based on the following formula: 
BMI = weight / (height x height)

Note:
- weight is in kilograms (e.g. 65.0)
- height is in metres (e.g. 1.70)

Write a C# program to:
- prompt the user to enter his/her weight and height
- calculate the BMI (body mass index)
- display the BMI and the health category according to the table below:

BMI Health category
Below 18.5    Underweight
18.5 - 23     Normal weight
23 - 27.5     Overweight
Above 27.5    Obese
*/
//Console.WriteLine("Enter your Weight (in Kg): ");
//float weight = float.Parse(Console.ReadLine());
//Console.WriteLine("Enter your Height (meter): ");
//float height = float.Parse(Console.ReadLine());
//float BMI = weight / (height * height);
//string healthCategory = "unknown";
//if (BMI < 18.5) healthCategory = "Underweight";
//if (BMI >= 18.5 && BMI < 23) healthCategory = "Normal weight";
//if (BMI >= 23 && BMI < 27.5) healthCategory = "Overweight";
//if (BMI > 27.5) healthCategory = "Obese";

//Console.WriteLine($"Your weight is {weight}\nYour height is {height}\nYour BMI is: {BMI}\nAnd Your are: {healthCategory}");













/*
Question 2:
Discount Calculation [using if..else]

The discount rate given by a shopping mall is shown below:
----------------------------------------------
| Amount spent ($)      |  Discount Rate (%) |
| 100 and below         |        0           |
| 100 < amount <= 500   |        5           |
| 500 < amount <= 1000  |       10           |
| Above 1000            |       20           |
----------------------------------------------
Write a C# program to:
- prompt the user to enter the amount spent 
- calculate and display the discount given (in percentage)
- calculate and display the discount amount
*/
//Console.Write("Enter the amount spent ($): ");
//double amountSpent = Convert.ToDouble(Console.ReadLine());

//// Calculate discount rate
//double discountRate;
//if (amountSpent <= 100)
//{
//    discountRate = 0;
//}
//else if (amountSpent <= 500)
//{
//    discountRate = 5;
//}
//else if (amountSpent <= 1000)
//{
//    discountRate = 10;
//}
//else
//{
//    discountRate = 20;
//}

//// Calculate discount amount
//double discountAmount = (amountSpent * discountRate) / 100;

//// Display discount rate and discount amount
//Console.WriteLine($"Discount rate: {discountRate}%");
//Console.WriteLine($"Discount amount: ${discountAmount:F2}");








/*
Question 3:
Multiplication Table [using repetition structure]

Write a C# program to display the multiplication table for a given number from 1 to 12.

Example:
Enter a number : 8
1  8
2  16
3  24
4  32
5  40
6  48
7  56
8  64
9  72
10 80
11 88
12 96
*/
//Console.WriteLine("enter a number:");
//int number = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("multiplication table for " + number + ":");

//for (int i = 1; i <= 12; i++)
//{
//    Console.WriteLine(i + "  " + (number * i));
//}

//Console.ReadLine(); //keep console open



/*
Question 4:
Admin Menu [using methods, loop & nested if]

Write a C# program that displays the main menu and allows the user to select options to perform BMI calculation, discount calculation, or display a multiplication table. The program should repeatedly display the menu until the user chooses to exit.

Example:
------------- MENU --------------
[1] Calculate Body Mass Index
[2] Calculate Discount
[3] Display Multiplication Table
[0] Exit
---------------------------------
*/
//int i = 1;
//while (i != 0 ) {
//Console.WriteLine("------------- MENU --------------\n[1] Calculate Body Mass Index\n[2] Calculate Discount\n[3] Display Multiplication Table\n[0] Exit\n---------------------------------");
//Console.WriteLine("Enter a option (1-4): ");
//i = Convert.ToInt32(Console.ReadLine());
//    if (i == 1) Console.WriteLine("Calculate Body Mass Index ");
//    else if (i == 2) Console.WriteLine("Calculate Discount");
//    else if (i == 3) Console.WriteLine("Display Multiplication Table");
//    else if (i == 0) Console.WriteLine("Exiting program, thank you for using! ");
//    else { Console.WriteLine("Invalid option !"); }
//}




/*
Question 5:
Write a program that adds up to 5 unique words to a list. 
The user can enter ‘x’ to stop adding words. 
Once either 5 words are added or the user stops the program early, 
the words are listed and the total number of letters in the words are displayed.

Example:
Enter a word (or 'x' to stop): apple
Enter a word (or 'x' to stop): banana
Enter a word (or 'x' to stop): orange
Enter a word (or 'x' to stop): x

List of words:
- apple
- banana
- orange

Total number of letters: 16
*/

//string word;
//string Words = null;

//for (int i = 1; i <= 5; i++)
//{
//    Console.WriteLine("Enter a word (or 'x' to stop): ");
//    word = Console.ReadLine();
//    if (word == "x") break;
//    Words += word;

//}

//Console.WriteLine($"Total number of letters: {Words.Count()}");



/*
Question 6:
Write a program that simulates a number guessing game. 
It first generates a random number between 1 and 100. 
It then prompts the user to guess the correct number. 
The user can enter -1 to end the game, or the game will end after 5 tries.


Example:
Guess the number (between 1 and 100, or enter -1 to quit): 50
Too high!
Guess the number (between 1 and 100, or enter -1 to quit): 25
Too low!
Guess the number (between 1 and 100, or enter -1 to quit): 37
Too high!
Guess the number (between 1 and 100, or enter -1 to quit): 30
Congratulations! You guessed the correct number in 4 tries.

*/

int guessNumber;
Int32 playerGuessNumber = 0;
int i;

guessNumber = new Random().Next(1, 100);
for (i = 1; i <= 5; i++)
{
    Console.WriteLine("Guess the number (between 1 and 100, or enter -1 to quit): ");
    playerGuessNumber = Convert.ToInt32(Console.ReadLine());
    if (playerGuessNumber < 0)
    {
        Console.WriteLine($"Exiting");
        return;
    }
    else if (playerGuessNumber == guessNumber)
    {
        Console.WriteLine($"Congratulations! You guessed the correct number in {i} tries.");
        return;
    }
    else if (playerGuessNumber > guessNumber)
    {
        Console.WriteLine($"Too high!");
    }
    else if (playerGuessNumber < guessNumber)
    {
        Console.WriteLine($"Too low!");
    }
    //Console.WriteLine($"Cheat! it's {guessNumber}");
}
Console.WriteLine($"5 tries is up, you can't find the number, Game Over !!! Exiting");
return;


