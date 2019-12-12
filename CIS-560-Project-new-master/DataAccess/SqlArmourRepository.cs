using System.Collections.Generic;
using DataAccess;
using CharacterData.Models;
using CharacterData.DataDelegates;
using System;

namespace CharacterData
{
    public class SqlArmourRepository : IArmourRepository
    {
        private readonly SqlCommandExecutor ex;

        public SqlArmourRepository(string connection)
        {
            ex = new SqlCommandExecutor(connection);
        }

        public Armour CreateArmour(string name, string type, string weakness, string strength, string description, int durability, int defenseMod)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(name));

            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(description));

            var d = new CreateArmourDataDelegate(name,type, weakness, strength, description, durability, defenseMod);
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
