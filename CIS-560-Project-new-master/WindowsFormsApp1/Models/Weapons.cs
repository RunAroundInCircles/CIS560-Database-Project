
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterData.Models
{
    public class Weapons
    {
        //WeaponId, name, damagetypeid, description, attackmod
        
        public int _weaponID { get; set; }

        public string _name { get; set; }

        public int _damageTypeID { get; set; }

        public string _description { get; set; }

        public int _attackMod { get; set; }

        internal Weapons(int weaponID, string name, int damageTypeID, string description, int attackMod)
        {
            _weaponID = weaponID;
            _name = name;
            _damageTypeID = damageTypeID;
            _description = description;
            _attackMod = attackMod;
        }
    }
}
