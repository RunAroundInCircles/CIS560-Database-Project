using CharacterData.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace CharacterData.DataDelegates
{
    class CreateArmourTypeDataDelegate : NonQueryDataDelegate<ArmourType>
    {
        public int _armourTypeID { get; }

        public string _name { get; }

        public CreateArmourTypeDataDelegate(string name): base("ArmourType.CreateArmourType")
        {
            _name = name;
        }
        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("Name", SqlDbType.NVarChar);
            p.Value = _name;

            p = command.Parameters.Add("ArmourTypeID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override ArmourType Translate(SqlCommand command)
        {
            return new ArmourType((int)command.Parameters["ArmourTypeID"].Value, _name);
        }

    }
}
