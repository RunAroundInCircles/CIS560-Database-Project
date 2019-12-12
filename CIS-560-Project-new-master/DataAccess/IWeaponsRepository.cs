using System.Collections.Generic;
using CharacterData.Models;

namespace CharacterData
{
    public interface IWeaponsRepository
    {
        IReadOnlyList<Weapons> RetrieveWeapons();

        Weapons GetWeapons(int weaponsID);

        Weapons CreateWeapons(string name, int damageTypeID, string description, int damageType);
    }
}
