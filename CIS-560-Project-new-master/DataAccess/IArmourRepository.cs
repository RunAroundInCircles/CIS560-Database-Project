using System.Collections.Generic;
using CharacterData.Models;

namespace CharacterData
{
    public interface IArmourRepository
    {
        IReadOnlyList<Armour> RetrieveArmour();

        Armour GetArmour(int armourID);

        Armour CreateArmour(string name,string type, string weakness, string strength, string description, int durability, int defenseMod);
    }
}
