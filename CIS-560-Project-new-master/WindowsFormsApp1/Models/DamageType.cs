using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterData.Models
{
    public class DamageType
    {
        //damagetypeid, name, acronym

        public int _damageTypeID { get; }

        public string _name { get; }

        public string _acronym { get; }

        internal DamageType(int damageTypeID, string name, string acronym)
        {
            _damageTypeID = damageTypeID;
            _name = name;
            _acronym = acronym;
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
