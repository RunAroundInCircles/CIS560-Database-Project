using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CharacterData.Models
{
    public class Race
    {
        //raceId, name, description, attackMod, DefenseMod

        public int _raceID { get; }

        public string _name { get; set; }

        public string _description { get; set; }

        public int _attackMod { get; set; }

        public int _defenseMod { get; set;  }

        internal Race(int raceID, string name, string description, int attackMod, int defenseMod)
        {
            _raceID = raceID;
            _name = name;
            _description = description;
            _attackMod = attackMod;
            _defenseMod = defenseMod;
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
