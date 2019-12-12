using System;
using System.Collections.Generic;
using DataAccess;
using CharacterData.Models;
using System.Data;
using System.Data.SqlClient;


namespace CharacterData.DataDelegates
{
    class GetFromSkillGetNonDuplicatedClassOrRace : DataReaderDelegate<IReadOnlyList<string>>
    {
        private int _skillsId { get; }

        public GetFromSkillGetNonDuplicatedClassOrRace(int skillId) : base("Player.FromSkillGetNonDuplicatedClassOrRace")
        {
            _skillsId = skillId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
            var p = command.Parameters.Add("SkillId", SqlDbType.Int);
            p.Value = _skillsId;

        }


        public override IReadOnlyList<string> Translate(SqlCommand command, SqlDataReader reader)
        {
            var skills = new List<string>();

            while (reader.Read())
            {
                skills.Add(
                    string.Format("{4,-10}\t{8,-5}\t{5,-5}\t{9,-5}\t{6,-5}\t{10,-5}\t{7,-5}\t",
                    reader.GetInt32(reader.GetOrdinal("SkillId")),
                    reader.GetString(reader.GetOrdinal("Name")),
                    reader.GetString(reader.GetOrdinal("Description")),
                    reader.GetInt32(reader.GetOrdinal("LevelRequirement")),
                    reader.GetString(reader.GetOrdinal("Source")),
                    reader.GetInt32(reader.GetOrdinal("SourceId")),
                    reader.GetInt32(reader.GetOrdinal("AttackMod")),
                    reader.GetInt32(reader.GetOrdinal("DefenseMod")),
                    reader.GetInt32(reader.GetOrdinal("PowerLevel")),
                    reader.GetInt64(reader.GetOrdinal("AttackRank")),
                    reader.GetInt64(reader.GetOrdinal("DefenseRank")),
                    reader.GetInt64(reader.GetOrdinal("PowerRank"))));
            }

            return skills;
        }
    }
}
