using DataAccess;
using CharacterData.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CharacterData.DataDelegates
{
    internal class RetrieveRaceDataDelegate : DataReaderDelegate<IReadOnlyList<Race>>
    {
        public RetrieveRaceDataDelegate() : base("List.GetAllRaces")
        {

        }
        public override IReadOnlyList<Race> Translate(SqlCommand command, SqlDataReader reader)
        {
            var races = new List<Race>();

            while (reader.Read())
            {
                races.Add(new Race(
                    reader.GetInt32(reader.GetOrdinal("RaceId")),
                    reader.GetString(reader.GetOrdinal("Name")),
                    reader.GetString(reader.GetOrdinal("Description")),
                    reader.GetInt32(reader.GetOrdinal("DefenseMod")),
                    reader.GetInt32(reader.GetOrdinal("AttackMod"))));
            }

            return races;
        }
    }
}
