using System.Collections.Generic;
using CharacterData.Models;

namespace CharacterData
{
    public interface IDamageTypeRepository
    {
        IReadOnlyList<DamageType> RetrieveDamageTypes();

        DamageType GetDamageType(int damageTypeID);

        DamageType CreateDamageType(string name, string description);
    }
}
