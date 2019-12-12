using System.Collections.Generic;
using CharacterData.Models;

namespace CharacterData.IRepository
{
    public interface IClassRepository
    {
        IReadOnlyList<Class> RetrieveClasses();

        Class GetClass(int classID);

        Class CreateClass(string name, string description, int defenseMod, int attackMod);

        IReadOnlyList<string> GetOptimalClasses();


    }
}
