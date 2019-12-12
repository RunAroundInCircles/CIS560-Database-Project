using DataAccess;
using CharacterData.Models;
using System.Data;
using System.Data.SqlClient;

namespace CharacterData.DataDelegates
{
    class GetWeaponsDataDelegate : DataReaderDelegate<Weapons>
    {
        private int _weaponsID { get; }

        public GetWeaponsDataDelegate(int weaponsID) : base("Weapons.GetWeapons")
        {
            _weaponsID = weaponsID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
            var p = command.Parameters.Add("WeaponsId", SqlDbType.Int);
            p.Value = _weaponsID;
        }

        public override Weapons Translate(SqlCommand command, SqlDataReader reader)
        {
            if (!reader.Read())
                return null;

            return new Weapons(_weaponsID,
               reader.GetString(reader.GetOrdinal("Name")),
               reader.GetInt32(reader.GetOrdinal("DamageTypeId")),
               reader.GetString(reader.GetOrdinal("Description")),
               reader.GetInt32(reader.GetOrdinal("AttackMod")));
        }
    }
}
