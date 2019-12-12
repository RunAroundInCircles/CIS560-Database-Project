using System.Collections.Generic;
using DataAccess;
using CharacterData.Models;
using CharacterData.DataDelegates;
using System;
using CharacterData.IRepository;

namespace CharacterData.SqlRepository
{
    class SqlSkillsRepository : ISkillsRepository
    {
        private readonly SqlCommandExecutor ex;

        public SqlSkillsRepository(string connection)
        {
            ex = new SqlCommandExecutor(connection);
        }

        public Skills CreateSkills(string name, string description, int levelRequirement)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(name));

            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(description));

            var d = new CreateSkillsDataDelegate(name, description, levelRequirement);
            return ex.ExecuteNonQuery(d);
        }

        public Skills GetSkills(int skillsID)
        {
            var d = new GetSkillsDataDelegate(skillsID);
            return ex.ExecuteReader(d);
        }

        public IReadOnlyList<Skills> RetrieveSkills()
        {
            return ex.ExecuteReader(new RetrieveSkillsDataDelegate());
        }
        public IReadOnlyList<Skills> GetSkillClass(int classId)
        {
            return ex.ExecuteReader(new GetClassSkills(classId));
        }
        public IReadOnlyList<Skills> GetSkillRace(int raceId)
        {
            return ex.ExecuteReader(new GetRaceSkills(raceId));
        }
        public IReadOnlyList<Skills> GetAvailableSkills(int classId, int raceId, int level)
        {
            return ex.ExecuteReader(new GetAvailableSkills(classId,raceId,level));
        }

        public IReadOnlyList<string> GetFromSkill(int skillId)
        {
            return ex.ExecuteReader(new GetFromSkillGetNonDuplicatedClassOrRace(skillId));
        }
    }
}
