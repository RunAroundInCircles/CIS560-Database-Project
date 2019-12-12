using System.Collections.Generic;
using DataAccess;
using CharacterData.Models;
using CharacterData.DataDelegates;
using System;
using CharacterData.IRepository;

namespace CharacterData.SqlRepository
{
    public class SqlArmourRepository : IArmourRepository
    {
        private readonly SqlCommandExecutor ex;

        public SqlArmourRepository(string connection)
        {
            ex = new SqlCommandExecutor(connection);
        }

        public Armour CreateArmour(string name, int type, int weakness, int strength, string description, int defenseMod)
        {
            var d = new CreateArmourDataDelegate(name, type, weakness, strength, description, defenseMod);
            return ex.ExecuteNonQuery(d);
        }

        public Armour GetArmour(int armourID)
        {
            var d = new GetArmourDataDelegate(armourID);
            return ex.ExecuteReader(d);
        }

        public IReadOnlyList<Armour> RetrieveArmour()
        {
            return ex.ExecuteReader(new RetrieveArmourDataDelegate());
        }
    }
}
