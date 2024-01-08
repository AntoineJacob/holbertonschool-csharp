using System;

namespace Enemies
{
    ///<summary>
    ///public class Zombie
    ///</summary>
    public class Zombie
    {
        ///<summary>
        ///public int health;
        ///</summary>
        public int health;
        /// <summary>
        /// public Zombie()
        /// </summary>
        public Zombie()
        {
            health = 0;
        }
        /// <summary>
        /// Zombie
        /// </summary>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            else
            {
                health = value;
            }
        }
    }
}