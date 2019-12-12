using DataAccess;
using CharacterData.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CharacterData.DataDelegates
{
    internal class RetrieveArmourDataDelegate: DataReaderDelegate<IReadOnlyList<Armour>>
    {
        public RetrieveArmourDataDelegate()
           : base("List.GetAllArmour")
        {

        }

        public override IReadOnlyList<Armour> Translate(SqlCommand command, SqlDataReader reader)
        {
            var armours = new List<Armour>();

            while (reader.Read())
            {
                armours.Add( new Armour(
                   reader.GetInt32(reader.GetOrdinal("ArmourID")),
                   reader.GetString(reader.GetOrdinal("Name")),
                   reader.GetInt32(reader.GetOrdinal("ArmourTypeId")),
                   reader.GetInt32(reader.GetOrdinal("DamageTypeStrong")),
                   reader.GetInt32(reader.GetOrdinal("DamageTypeWeak")),
                   reader.GetString(reader.GetOrdinal("Description")),
                   reader.GetInt32(reader.GetOrdinal("DefenseMod"))));
            }

            return armours;
        }
    }
}
