using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterData.Models
{
    public class Class
    {
        // Class ID, Name, Description, Level, DefenseMod, AttackMod

        public int _classID { get; }

        public string _name { get; set; }

        public string _description { get; set; }



        public int _defenseMod { get; set; }

        public int _attackMod { get; set; }

        internal Class(int classID, string name, string description, int defenseMod, int attackMod)
        {
            _classID = classID;
            _name = name;
            _description = description;
            _defenseMod = defenseMod;
            _attackMod = attackMod;
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
