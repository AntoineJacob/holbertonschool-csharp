﻿using System;

namespace Enemies
{
    ///<summary>
    ///public class Zombie
    ///</summary>
    public class Zombie
    {
        int health;
        string name = "(No name)";
        /// <summary>
        /// public string Name
        /// </summary>
        public string Name
        {
            get => name;
            set => name = value;
        }
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
        /// <summary>
        /// public int GetHealth()
        /// </summary>
        public int GetHealth()
        {
            return health;
        }
        /// <summary>
        /// public override string ToString()
        /// </summary>
        public override string ToString()
        {
            return string.Format("Zombie Name: {0} / Total Health: {1}", name, health);
        }
    }
}