using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DiceRoller
{
    // simulate dice rolls and return results
    public int[] SimulateDiceRolls(int numberOfRolls)
    {
        int[] results = new int[13];

        // generate random numbers
        Random random = new Random();

        for (int i = 0; i < numberOfRolls; i++)
        {
            // roll  two dice
            int dice1 = random.Next(1, 7);
            int dice2 = random.Next(1, 7);
            int sum = dice1 + dice2;

            results[sum]++;
        }

        return results;
    }
}
