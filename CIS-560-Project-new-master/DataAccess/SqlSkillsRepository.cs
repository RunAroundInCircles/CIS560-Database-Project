using System.Collections.Generic;
using DataAccess;
using CharacterData.Models;
using CharacterData.DataDelegates;
using System;

namespace CharacterData
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
    }
}
