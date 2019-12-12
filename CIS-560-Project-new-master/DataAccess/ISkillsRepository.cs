using System.Collections.Generic;
using CharacterData.Models;

namespace CharacterData
{
    public interface ISkillsRepository
    {
        IReadOnlyList<Skills> RetrieveSkills();

        Skills GetSkills(int skillsID);

        Skills CreateSkills(string name, string description, int levelRequirement);
    }
}
