using System.Collections.Generic;
using CharacterData.Models;

namespace CharacterData
{
    public interface IArmourTypeRepository
    {
        IReadOnlyList<ArmourType> RetrieveArmourType();

        ArmourType GetArmourType(int armourTypeID);

        ArmourType CreateArmourType(string name);
    }
}
