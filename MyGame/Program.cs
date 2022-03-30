using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable to store number of enemies
            int numOfEnemies;

            // Array to store enemy instances
            Enemy[] enemies;

            // Request number of enemies
            Console.Write("Insert number of enemies: ");

            // Store user input in variable
            numOfEnemies = Convert.ToInt32(Console.ReadLine());

            // Set array size as number of enemies
            enemies = new Enemy[numOfEnemies];
        }
    }
}
