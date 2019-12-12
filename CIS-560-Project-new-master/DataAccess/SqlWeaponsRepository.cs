using System.Collections.Generic;
using DataAccess;
using CharacterData.Models;
using CharacterData.DataDelegates;
using System;

namespace CharacterData
{
    public class SqlWeaponsRepository : IWeaponsRepository
    {
        private readonly SqlCommandExecutor ex;

        public SqlWeaponsRepository(string connection)
        {
            ex = new SqlCommandExecutor(connection);
        }

        public Weapons CreateWeapons(string name, int weaponsTypeID, string description, int attackMod)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(name));

            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(description));

            var d = new CreateWeaponsDataDelegate(name, description, weaponsTypeID, attackMod);
            return ex.ExecuteNonQuery(d);
        }

        public Weapons GetWeapons(int weaponsID)
        {
            var d = new GetWeaponsDataDelegate(weaponsID);
            return ex.ExecuteReader(d);
        }

        public IReadOnlyList<Weapons> RetrieveWeapons()
        {
            return ex.ExecuteReader(new RetrieveWeaponsDataDelegate());
        }
    }
}
