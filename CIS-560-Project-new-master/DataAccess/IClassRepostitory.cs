using System.Collections.Generic;
using CharacterData.Models;

namespace CharacterData
{
    public interface IClassRepository
    {
        IReadOnlyList<Class> RetrieveClasses();

        Class GetClass(int classID);

        Class CreateClass(string name, string description, int level, int defenseMod, int attackMod);

    }
}
