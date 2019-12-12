using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterData.Models
{
    public class Skills
    {
        //SkillId, Name, Description, LevelRequirement
 
        public int _skillId { get; set; }

        public string _name { get; set; }

        public string _description { get; set; }

        public int _levelRequirement { get; set; }


        internal Skills(int skillId, string name, string description, int levelRequirement)
        {
            _skillId = skillId;
            _name = name;
            _description = description;
            _levelRequirement = levelRequirement;
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
