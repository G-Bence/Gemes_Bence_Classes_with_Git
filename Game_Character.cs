using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_250207
{
    internal class Game_Character
    {
        private string name;
        private int level;
        private int health;
        private int demage;

        public Game_Character(string name, int level, int health, int demage)
        {
            this.name = name;
            this.level = level;
            this.health = health;
            this.demage = demage;
        }

        public Game_Character(string name, int demage)
        {
            this.name = name;
            this.level = 1;
            this.health = 100;
            this.demage = demage;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }


        public int Level
        {
            get { return this.level; }
            set { this.level = value; }
        }

        public int Health
        {
            get { return this.health; }
            set { this.health = value; }
        }

        public int Demage
        {
            get { return this.demage; }
            set { this.demage = value; }
        }


        public string Attack()
        {
            return this.name + " attacked with " + this.demage + " demage.";
        }

        public int Heal(int heal)
        {
            return this.health += heal;
        }

        public string LevelUp()
        {
            return $"{this.level+= 1}, {this.demage+=5}";
           
        }

    }

}
