using System.Collections.Generic;
using CharacterData.Models;

namespace CharacterData
{
    public interface IRaceRepository
    {
        IReadOnlyList<Race> RetrieveRaces();

        Race GetRace(int raceID);

        Race CreateRace(string name, string description, int defenseMod, int attackMod);

    }
}
