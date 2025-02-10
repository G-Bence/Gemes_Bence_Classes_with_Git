using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_250207
{
    internal class Spy_Mission
    {
        private string code_name;
        private string country;
        private int danger_level;
        private int chance_of_success;


        public Spy_Mission(string code_name, string country, int danger_level, int chance_of_success)
        {
            this.code_name = code_name;
            this.country = country;
            this.danger_level = danger_level;
            this.chance_of_success = chance_of_success;
        }

        public Spy_Mission(string code_name, string country)
        {
            this.code_name = code_name;
            this.country = country;
            this.danger_level = 5;
            this.chance_of_success = 50;
        }

        public string Code_Name
        {
            get { return this.code_name; }
            set { this.code_name = value; }
        }

        public string Country
        {
            get { return this.country; }
            set { this.country = value; }
        }

        public int Danger_Level
        {
            get { return this.danger_level; }
            set { this.danger_level = value; }
        }

        public int Chance_Of_Success
        {
            get { return this.chance_of_success; }
            set { this.chance_of_success = value; }
        }

        public string Start_Mission()
        {
            return this.code_name + " has started the mission in " + this.country + " with a danger level of " + this.danger_level + " and a chance of success of " + this.chance_of_success + ".";
        }

        public string Increase_Danger_Level(int danger_level)
        {
            this.danger_level += danger_level;
            return this.code_name + " has increased the danger level to " + this.danger_level + ".";
        }

        public string Increase_Chance_Of_Success(int chance_of_success)
        {
            this.chance_of_success += (this.chance_of_success/100*chance_of_success);
            return this.code_name + " has increased the chance of success to " + this.chance_of_success + ".";
        }

    }
}
