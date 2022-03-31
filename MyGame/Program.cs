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

            // New instance of Random class
            Random rand = new Random();

            // Loop for each  number of enemies
            for (int i = 0; i < numOfEnemies; i++)
            {
                // Name for each enemy
                string enemyName;

                // Request current enemy name
                Console.Write($"Name for enemy {i + 1}: ");

                // Store user input as name
                enemyName = Console.ReadLine();

                // Assign name for current enemy
                enemies[i] = new Enemy(enemyName);
            }

            // Loop for each enemy in array
            for (int i = 0; i < enemies.Length; i++)
            {
                // Extra space before next enemy's information
                Console.WriteLine();

                // Pickup health power up with random value
                enemies[i].PickupPowerUp(PowerUp.Health, rand.Next(0, 20));

                // Pickup shield power up with random value
                enemies[i].PickupPowerUp(PowerUp.Shield, rand.Next(0, 20));

                // Print name for current enemy
                Console.WriteLine(
                    $"Enemy {i + 1} name: {enemies[i].GetName()}");
                
                // Print health and shield values for current enemy
                Console.WriteLine($"-Health: {enemies[i].GetHealth()}");
                Console.WriteLine($"-Shield: {enemies[i].GetShield()}");
            }

            // Extra space before printing more information
            Console.WriteLine();

            // Print amount of power ups for all enemies
            Console.WriteLine($"Total power ups: {Enemy.GetTotalPowerUps()}");
        }
    }
}
