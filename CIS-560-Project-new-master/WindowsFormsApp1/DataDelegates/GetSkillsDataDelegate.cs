using DataAccess;
using CharacterData.Models;
using System.Data;
using System.Data.SqlClient;

namespace CharacterData.DataDelegates
{
    class GetSkillsDataDelegate : DataReaderDelegate<Skills>
    {
        private int _skillsID { get; }

        public GetSkillsDataDelegate(int skillsID) : base("Skills.GetSkills")
        {
            _skillsID = skillsID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
            var p = command.Parameters.Add("SkillId", SqlDbType.Int);
            p.Value = _skillsID;
        }

        public override Skills Translate(SqlCommand command, SqlDataReader reader)
        {
            if (!reader.Read())
                return null;

            return new Skills(_skillsID,
               reader.GetString(reader.GetOrdinal("Name")),
               reader.GetString(reader.GetOrdinal("Description")),
               reader.GetInt32(reader.GetOrdinal("LevelRequirement")));
        }
    }
}
