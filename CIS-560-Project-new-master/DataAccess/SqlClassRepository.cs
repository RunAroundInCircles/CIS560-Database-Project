using System.Collections.Generic;
using DataAccess;
using CharacterData.Models;
using CharacterData.DataDelegates;
using System;

namespace CharacterData
{
    public class SqlClassRepository : IClassRepository
    {
        private readonly SqlCommandExecutor ex;

        public SqlClassRepository(string connection)
        {
            ex = new SqlCommandExecutor(connection);
        }

        public Class CreateClass(string name, string description, int level, int defenseMod, int attackMod)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(name));

            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(description));

            var d = new CreateClassDataDelegate(name, description, level,defenseMod, attackMod);
            return ex.ExecuteNonQuery(d);
        }

        public Class GetClass(int classID)
        {
            var d = new GetClassDataDelegate(classID);
            return ex.ExecuteReader(d);
        }

        public IReadOnlyList<Class> RetrieveClasses()
        {
            return ex.ExecuteReader(new RetrieveClassDataDelegate());
        }
    }
}
