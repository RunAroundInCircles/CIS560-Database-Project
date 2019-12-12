using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterData.Models;

namespace CharacterData.Models
{
    public class Player
    {
        public string _name { get; set; }
        public int _level { get; set; }

        public string _race { get; set; }

        public string _raceSkills { get; set; }

        public string _class { get; set; }

        public string _classSkills { get; set; }

        public string[] _skills { get; set; }

        public string _armour { get; set; }

        public string _weapons { get; set; }

        public string _description { get; set; }

        public Player(string name, int level, string race, string raceSkills, string @class, string classSkills, string[] skills, string armour, string weapons, string description)
        {
            _name = name;
            _level = level;
            _race = race;
            _raceSkills = raceSkills;
            _class = @class;
            _classSkills = classSkills;
            _skills = skills;
            _armour = armour;
            _weapons = weapons;
            _description = description;
        }
    }
}
