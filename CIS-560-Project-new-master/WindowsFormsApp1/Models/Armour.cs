using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterData.Models
{
    public class Armour
    {
        public int _armourID { get; set; }

        public string _name { get; set; }

        public int _type { get; set; }

        public int _weakness { get; set; }

        public int _strength { get; set; }

        public string _description { get; set; }

        public int _defenseMod { get; set; }


        internal Armour(int armourID, string name, int type, int weakness, int strength, string description, int defenseMod)
        {
            _armourID = armourID;
            _name = name;
            _type = type;
            _weakness = weakness;
            _strength = strength;
            _description = description;
            _defenseMod = defenseMod;
        }
    }
}
