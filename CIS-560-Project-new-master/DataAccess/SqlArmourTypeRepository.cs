using System.Collections.Generic;
using DataAccess;
using CharacterData.Models;
using CharacterData.DataDelegates;
using System;

namespace CharacterData
{
    public class SqlArmourTypeRepository : IArmourTypeRepository
    {
        private readonly SqlCommandExecutor ex;

        public SqlArmourTypeRepository(string connection)
        {
            ex = new SqlCommandExecutor(connection);
        }

        public ArmourType CreateArmourType(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(name));

            var d = new CreateArmourTypeDataDelegate(name);
            return ex.ExecuteNonQuery(d);
        }

        public ArmourType GetArmourType(int armourTypeID)
        {
            var d = new GetArmourTypeDataDelegate(armourTypeID);
            return ex.ExecuteReader(d);
        }

        public IReadOnlyList<ArmourType> RetrieveArmourType()
        {
            return ex.ExecuteReader(new RetrieveArmourTypeDataDelegate());
        }
    }
}
