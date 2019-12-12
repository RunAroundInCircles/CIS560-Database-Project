using CharacterData.Models;
using DataAccess;
using System.Data.SqlClient;
using System.Data;

namespace CharacterData.DataDelegates
{
    class SaveWeaponsDataDelegate : DataDelegate
    {
        private readonly int _weaponsID;
        private readonly string _name;
        private readonly string _description;
        private readonly int _damageTypeID;
        private readonly int _attackMod;

        public SaveWeaponsDataDelegate(int weaponsID, string name, string description, int damageTypeID, int attackMod) : base("Weapons.SaveWeapons")
        {
            _weaponsID = weaponsID;
            _name = name;
            _description = description;
            _damageTypeID = damageTypeID;
            _attackMod = attackMod;
        }
        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("WeaponsId", SqlDbType.Int);
            p.Value = _weaponsID;

            p = command.Parameters.Add("Name", SqlDbType.NVarChar);
            p.Value = _name;

            p = command.Parameters.Add("Description", SqlDbType.NVarChar);
            p.Value = _description;

            p = command.Parameters.Add("DamageTypeID", SqlDbType.Int);
            p.Value = _damageTypeID;

            p = command.Parameters.Add("AttackMod", SqlDbType.Int);
            p.Value = _attackMod;
        }
    }
}
