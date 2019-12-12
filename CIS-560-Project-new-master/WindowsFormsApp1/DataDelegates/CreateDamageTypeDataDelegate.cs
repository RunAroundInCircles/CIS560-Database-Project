using CharacterData.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace CharacterData.DataDelegates
{
    class CreateDamageTypeDataDelegate : NonQueryDataDelegate<DamageType>
    {
        public string _name { get; }

        public string _description { get; }


        public CreateDamageTypeDataDelegate(string name, string description) : base("Player.GetClassAttachedSkill")
        {
            _name = name;
            _description = description;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("Name", SqlDbType.NVarChar);
            p.Value = _name;

            p = command.Parameters.Add("Description", SqlDbType.NVarChar);
            p.Value = _description;

            p = command.Parameters.Add("DamageTypeID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override DamageType Translate(SqlCommand command)
        {
            return new DamageType((int)command.Parameters["DamageTypeID"].Value, _name, _description);
        }
    }
}
