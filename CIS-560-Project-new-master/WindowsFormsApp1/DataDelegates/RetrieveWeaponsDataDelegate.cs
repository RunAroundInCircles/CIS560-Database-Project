using DataAccess;
using CharacterData.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CharacterData.DataDelegates
{
    internal class RetrieveWeaponsDataDelegate : DataReaderDelegate<IReadOnlyList<Weapons>>
    {
        
        public RetrieveWeaponsDataDelegate()
          : base("List.GetAllWeapons")
        {

        }

        public override IReadOnlyList<Weapons> Translate(SqlCommand command, SqlDataReader reader)
        {
            var weapons = new List<Weapons>();

            while (reader.Read())
            {
                weapons.Add(new Weapons(
                    reader.GetInt32(reader.GetOrdinal("WeaponId")),
                    reader.GetString(reader.GetOrdinal("Name")),
                    reader.GetInt32(reader.GetOrdinal("DamageTypeId")),
                    reader.GetString(reader.GetOrdinal("Description")),
                    reader.GetInt32(reader.GetOrdinal("AttackMod"))));
            }

            return weapons;
        }
    }
}
