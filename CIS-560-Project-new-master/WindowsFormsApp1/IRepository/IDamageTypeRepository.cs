using System.Collections.Generic;
using CharacterData.Models;

namespace CharacterData.IRepository
{
    public interface IDamageTypeRepository
    {
        IReadOnlyList<DamageType> RetrieveDamageTypes();

        DamageType GetDamageType(int damageTypeID);

        DamageType CreateDamageType(string name, string description);

        IReadOnlyList<string> GetDamageTypeStates();
    }
}
