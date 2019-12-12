using DataAccess;
using CharacterData.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace CharacterData.DataDelegates
{
    internal class GetClassSkills : DataReaderDelegate<IReadOnlyList<Skills>>
    {

        public int _classId;
        public GetClassSkills(int classId)
        : base("Player.GetClassAttachedSkill")
        {
            _classId = classId;
        }
        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("ClassId", SqlDbType.Int);
            p.Value = _classId;

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
