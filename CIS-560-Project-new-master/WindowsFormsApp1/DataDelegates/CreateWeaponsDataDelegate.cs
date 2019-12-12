using CharacterData.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace CharacterData.DataDelegates
{
    class CreateWeaponsDataDelegate : NonQueryDataDelegate<Weapons>
    {
        public string _name { get; }

        public int _damageTypeID { get; }

        public string _description { get; }

        public int _attackMod { get; }

        public CreateWeaponsDataDelegate(string name, string description, int damageTypeID, int attackMod) : base("Homebrew.InsertWeapon")
        {
            _name = name;
            _description = description;
            _damageTypeID = damageTypeID;
            _attackMod = attackMod;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("Name", SqlDbType.NVarChar);
            p.Value = _name;

            p = command.Parameters.Add("Description", SqlDbType.NVarChar);
            p.Value = _description;

            p = command.Parameters.Add("DamageTypeId", SqlDbType.Int);
            p.Value = _damageTypeID;

            p = command.Parameters.Add("AttackMod", SqlDbType.Int);
            p.Value = _attackMod;

            p = command.Parameters.Add("WeaponId", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override Weapons Translate(SqlCommand command)
        {
            return new Weapons((int)command.Parameters["WeaponId"].Value, _name,  _damageTypeID, _description,_attackMod);
        }
    }
}
