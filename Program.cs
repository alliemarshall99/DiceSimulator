using System;
// Allie Marshall
// Section 3-3
// January 17, 2024
class DiceSimulator
{
    static void Main()
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.Write("How many dice rolls would you like to simulate? ");

        // user inputs number of dice rolls
        int numberOfRolls = int.Parse(Console.ReadLine());

        // create an instance of the DiceRoller class
        DiceRoller diceRoller = new DiceRoller();

        // roll dice with results
        int[] results = diceRoller.SimulateDiceRolls(numberOfRolls);

        // display dice rolls
        DisplayDice(results, numberOfRolls);

        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }

    static void DisplayDice(int[] results, int totalRolls)
    {
        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {totalRolls}.");

        for (int i = 2; i <= 12; i++)
        {
            int percentage = results[i] * 100 / totalRolls;
            Console.WriteLine($"{i}: {new string('*', percentage)}");
        }
    }
}
