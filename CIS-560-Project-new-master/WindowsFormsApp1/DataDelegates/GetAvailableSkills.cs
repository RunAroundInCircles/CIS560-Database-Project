using DataAccess;
using CharacterData.Models;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace CharacterData.DataDelegates
{
    class GetAvailableSkills : DataReaderDelegate<IReadOnlyList<Skills>>
    {
        private int _classId { get; }
        private int _raceId { get; }
        private int _level { get; }


        public GetAvailableSkills(int classId, int raceId, int level) : base("Player.GetAvailableSkills")
        {
            _classId = classId;
            _raceId = raceId;
            _level = level;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
            var p = command.Parameters.Add("ClassId", SqlDbType.Int);
            p.Value = _classId;
            p = command.Parameters.Add("RaceId", SqlDbType.Int);
            p.Value = _raceId;
            p = command.Parameters.Add("Level", SqlDbType.Int);
            p.Value = _level;
        }

        public override IReadOnlyList<Skills> Translate(SqlCommand command, SqlDataReader reader)
        {
            var skills = new List<Skills>();

            while (reader.Read())
            {
                skills.Add(new Skills(
                    reader.GetInt32(reader.GetOrdinal("SkillId")),
                    reader.GetString(reader.GetOrdinal("Name")),
                    reader.GetString(reader.GetOrdinal("Description")),
                    reader.GetInt32(reader.GetOrdinal("LevelRequirement"))));
            }

            return skills;
        }
    }
}
