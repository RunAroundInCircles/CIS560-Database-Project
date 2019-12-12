using DataAccess;
using CharacterData.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CharacterData.DataDelegates
{
    internal class RetrieveSkillsDataDelegate : DataReaderDelegate<IReadOnlyList<Skills>>
    {
        public RetrieveSkillsDataDelegate()
           : base("List.GetAllSkills")
        {

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
