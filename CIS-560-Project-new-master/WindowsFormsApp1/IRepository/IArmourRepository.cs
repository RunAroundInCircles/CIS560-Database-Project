using System.Collections.Generic;
using CharacterData.Models;

namespace CharacterData.IRepository
{
    public interface IArmourRepository
    {
        IReadOnlyList<Armour> RetrieveArmour();

        Armour GetArmour(int armourID);

        Armour CreateArmour(string name, int type, int weakness, int strength, string description, int defenseMod);
    }
}
