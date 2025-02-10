using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_250207
{
    internal class Space_Craft
    {
        private string name;
        private int speed;
        private int passanger_cpacity;
        private int fuel_level;


        public Space_Craft(string name, int speed, int passanger_cpacity, int fuel_level)
        {
            this.name = name;
            this.speed = speed;
            this.passanger_cpacity = passanger_cpacity;
            this.fuel_level = fuel_level;
        }

        public Space_Craft(string name, int passanger_cpacity)
        {
            this.name = name;
            this.speed = 0;
            this.passanger_cpacity = passanger_cpacity;
            this.fuel_level = 100;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Speed
        {
            get { return this.speed; }
            set { this.speed = value; }
        }

        public int Passanger_Capacity
        {
            get { return this.passanger_cpacity; }
            set { this.passanger_cpacity = value; }
        }

        public int Fuel_Level
        {
            get { return this.fuel_level; }
            set { this.fuel_level = value; }
        }

        public string Start()
        {
            int oroginal_fuel = this.fuel_level;
            this.speed += 750;
            this.fuel_level -= 10;
            return this.name + " has increased its speed by " + speed + " km/h.\nThe fule level has decreased by " + (oroginal_fuel-this.fuel_level);
        }

        public string Refuel(int fuel)
        {
            this.fuel_level += fuel;
            return this.name + " has been refueled with " + fuel + " fuel.";
        }

        public string Landing()
        {
            this.speed = 0;
            return this.name + " has landed.";
        }

        public override string ToString()
        {
            return $"Name: {this.name}, Speed: {this.speed}, Passanger Capacity: {this.passanger_cpacity}, Fuel Level: {this.fuel_level}";
        }
    }
}
