using DataAccess;
using CharacterData.Models;
using System.Data;
using System.Data.SqlClient;

namespace CharacterData.DataDelegates
{
    class GetRaceDataDelegate : DataReaderDelegate<Race>
    {
        private int _raceID { get; }

        public GetRaceDataDelegate(int raceID): base("Player.GetRace")
        {
            _raceID = raceID;
        }
        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
            var p = command.Parameters.Add("RaceId", SqlDbType.Int);
            p.Value = _raceID;
        }

        public override Race Translate(SqlCommand command, SqlDataReader reader)
        {
            if (!reader.Read())
                return null;

            return new Race(_raceID,
               reader.GetString(reader.GetOrdinal("Name")),
               reader.GetString(reader.GetOrdinal("Description")),
               reader.GetInt32(reader.GetOrdinal("DefenseMod")),
               reader.GetInt32(reader.GetOrdinal("AttackMod")));
        }

    }
}
