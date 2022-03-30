using System;

namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;

        public Enemy(string name)
        {
            this.name = name;
            health = 100;
            shield = 0;
        }

        public string GetName()
        {
            return name;
        }

        public float GetHealth()
        {
            return health;
        }

        public float GetShield()
        {
            return shield;
        }

        /// <summary>
        /// Decrements given damage value from shield value and, 
        /// if this value is at 0, decrements from health as well.
        /// </summary>
        /// <param name="damage">
        /// The value to decrement from health and shield
        /// </param>
        public void TakeDamage(float damage)
        {
            // Decrement damage value from shield
            shield -= damage;

            // If shield value is lower than 0
            if (shield < 0)
            {
                // Assign negative shield value to new float
                float damageStillToInflict = -shield;

                // Set shield value at 0
                shield = 0;

                // Decrement damage still to inflict from health
                health -= damageStillToInflict;

                // If health value is lower than 0, health is set at 0
                if (health < 0) health = 0;
            }
        }
    }
}