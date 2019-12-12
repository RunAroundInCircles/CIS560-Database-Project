using DataAccess;
using CharacterData.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace CharacterData.DataDelegates
{
    class GetOptimalClasses: DataReaderDelegate<IReadOnlyList<string>>
    {
        public GetOptimalClasses(): base("Player.GetOptimalClasses")
        {

        }

        public override IReadOnlyList<string> Translate(SqlCommand command, SqlDataReader reader)
        {
            var classes = new List<string>();

            while (reader.Read())
            {
                classes.Add(
                    string.Format("{1,-30}\t{6,-5}\t{3,-5}\t{7,-5}\t{4,-5}\t{8,-5}\t{5,-5}\t{2}",
                    reader.GetInt32(reader.GetOrdinal("ClassId")),
                    reader.GetString(reader.GetOrdinal("Name")),
                    reader.GetString(reader.GetOrdinal("Description")),
                    reader.GetInt32(reader.GetOrdinal("AttackMod")),
                    reader.GetInt32(reader.GetOrdinal("DefenseMod")),
                    reader.GetInt32(reader.GetOrdinal("PowerLevel")),
                    reader.GetInt64(reader.GetOrdinal("AttackRank")),
                    reader.GetInt64(reader.GetOrdinal("DefenseRank")),
                    reader.GetInt64(reader.GetOrdinal("PowerRank"))));
            }
            return classes;
        }
    }
}
