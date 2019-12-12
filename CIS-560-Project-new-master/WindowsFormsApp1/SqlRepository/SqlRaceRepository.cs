using System.Collections.Generic;
using DataAccess;
using CharacterData.Models;
using CharacterData.DataDelegates;
using System;
using CharacterData.IRepository;

namespace CharacterData.SqlRepository
{
    public class SqlRaceRepository : IRaceRepository
    {
        private readonly SqlCommandExecutor ex;

        public SqlRaceRepository(string connection)
        {
            ex = new SqlCommandExecutor(connection);
        }

        public Race CreateRace(string name, string description, int defenseMod, int attackMod)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(name));

            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(description));

            var d = new CreateRaceDataDelegate(name, description, defenseMod, attackMod);
            return ex.ExecuteNonQuery(d);
        }

        public Race GetRace(int raceID)
        {
            var d = new GetRaceDataDelegate(raceID);
            return ex.ExecuteReader(d);
        }

        public IReadOnlyList<Race> RetrieveRaces()
        {
            return ex.ExecuteReader(new RetrieveRaceDataDelegate());
        }

    }
}
