using DataAccess;
using CharacterData.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CharacterData.DataDelegates
{
    internal class RetrieveArmourTypeDataDelegate : DataReaderDelegate<IReadOnlyList<ArmourType>>
    {
        public RetrieveArmourTypeDataDelegate()
          : base("List.GetAllArmourTypes")
        {

        }

        public override IReadOnlyList<ArmourType> Translate(SqlCommand command, SqlDataReader reader)
        {
            var armourtypes = new List<ArmourType>();

            while (reader.Read())
            {
                armourtypes.Add(new ArmourType(
                   reader.GetInt32(reader.GetOrdinal("ArmourTypeID")),
                   reader.GetString(reader.GetOrdinal("Name"))));
            }

            return armourtypes;
        }
    }
}
