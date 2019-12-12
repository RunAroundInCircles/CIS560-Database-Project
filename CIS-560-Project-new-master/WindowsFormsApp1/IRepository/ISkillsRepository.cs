using System.Collections.Generic;
using CharacterData.Models;

namespace CharacterData.IRepository
{
    public interface ISkillsRepository
    {
        IReadOnlyList<Skills> RetrieveSkills();

        Skills GetSkills(int skillsID);

        Skills CreateSkills(string name, string description, int levelRequirement);

        IReadOnlyList<Skills> GetSkillClass(int classId);

        IReadOnlyList<Skills> GetAvailableSkills(int raceId,int skillId, int level);

        IReadOnlyList<string> GetFromSkill(int skillId);
    }
}
