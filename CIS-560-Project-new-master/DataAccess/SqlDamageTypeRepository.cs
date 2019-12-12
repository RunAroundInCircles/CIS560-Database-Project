using System.Collections.Generic;
using DataAccess;
using CharacterData.Models;
using CharacterData.DataDelegates;
using System;


namespace CharacterData
{
    public class SqlDamageTypeRepository : IDamageTypeRepository
    {
        private readonly SqlCommandExecutor ex;

        public SqlDamageTypeRepository(string connection)
        {
            ex = new SqlCommandExecutor(connection);
        }

        public DamageType CreateDamageType(string name, string description)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(name));

            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(description));

            var d = new CreateDamageTypeDataDelegate(name, description);
            return ex.ExecuteNonQuery(d);
        }

        public DamageType GetDamageType(int damageTypeID)
        {
            var d = new GetDamageTypeDataDelegate(damageTypeID);
            return ex.ExecuteReader(d);
        }

        public IReadOnlyList<DamageType> RetrieveDamageTypes()
        {
            return ex.ExecuteReader(new RetrieveDamageTypeDataDelegate());
        }
    }
}
