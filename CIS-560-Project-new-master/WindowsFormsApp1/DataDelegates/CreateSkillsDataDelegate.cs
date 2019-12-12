using CharacterData.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace CharacterData.DataDelegates
{
    class CreateSkillsDataDelegate : NonQueryDataDelegate<Skills>
    {

        public string _name { get; }

        public string _description { get; }

        public int _levelRequirement { get; }

        public CreateSkillsDataDelegate(string name, string description, int levelRequirement) : base("Homebrew.InsertSkill")
        {
            _name = name;
            _description = description;
            _levelRequirement = levelRequirement;
        }
        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("Name", SqlDbType.NVarChar);
            p.Value = _name;

            p = command.Parameters.Add("Description", SqlDbType.NVarChar);
            p.Value = _description;

            p = command.Parameters.Add("LevelRequirement", SqlDbType.Int);
            p.Value = _levelRequirement;

            p = command.Parameters.Add("SkillId", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override Skills Translate(SqlCommand command)
        {
            return new Skills((int)command.Parameters["SkillId"].Value, _name, _description, _levelRequirement);
        }
    }
}
