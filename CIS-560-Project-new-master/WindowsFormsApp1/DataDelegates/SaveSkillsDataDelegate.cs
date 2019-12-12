using CharacterData.Models;
using DataAccess;
using System.Data.SqlClient;
using System.Data;

namespace CharacterData.DataDelegates
{
    internal class SaveSkillsDataDelegate : DataDelegate
    {
        private readonly int _skillsID;
        private readonly string _name;
        private readonly string _description;
        private readonly int _levelRequirement;

        public SaveSkillsDataDelegate(int skillsID, string name, string description, int level) : base("Skills.SaveSkills")
        {
            _skillsID = skillsID;
            _name = name;
            _description = description;
            _levelRequirement = level;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("ClassId", SqlDbType.Int);
            p.Value = _skillsID;

            p = command.Parameters.Add("Name", SqlDbType.NVarChar);
            p.Value = _name;

            p = command.Parameters.Add("Description", SqlDbType.NVarChar);
            p.Value = _description;

            p = command.Parameters.Add("LevelRequirement", SqlDbType.Int);
            p.Value = _levelRequirement;
        }
    }
}
