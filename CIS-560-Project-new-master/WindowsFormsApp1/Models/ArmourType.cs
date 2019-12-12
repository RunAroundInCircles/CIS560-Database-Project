using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterData.Models
{
    public class ArmourType
    {
        public int _armourTypeID { get; }

        public string _name { get; }

        internal ArmourType(int armourTypeID, string name)
        {
            _armourTypeID = armourTypeID;
            _name = name;
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
