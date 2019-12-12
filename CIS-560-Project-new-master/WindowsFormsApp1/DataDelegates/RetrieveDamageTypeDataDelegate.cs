using DataAccess;
using CharacterData.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CharacterData.DataDelegates
{
    internal class RetrieveDamageTypeDataDelegate : DataReaderDelegate<IReadOnlyList<DamageType>>
    {
            public RetrieveDamageTypeDataDelegate()
               : base("List.GetAllDamageTypes")
            {

            }

            public override IReadOnlyList<DamageType> Translate(SqlCommand command, SqlDataReader reader)
            {
                var damagetypes = new List<DamageType>();

                while (reader.Read())
                {
                    damagetypes.Add(new DamageType(
                        reader.GetInt32(reader.GetOrdinal("DamageTypeID")),
                        reader.GetString(reader.GetOrdinal("Name")),
                        reader.GetString(reader.GetOrdinal("Acronym"))));
                }

                return damagetypes;
            }
        }

}

