using CharacterData.Models;
using DataAccess;
using System.Data.SqlClient;
using System.Data;

namespace CharacterData.DataDelegates
{
    internal class SaveArmourTypeDataDelegate: DataDelegate
    {
        private readonly int _armourID;
        private readonly string _name;

        public SaveArmourTypeDataDelegate(int armourID, string name) : base("ArmourType.SaveArmourType")
        {
            _armourID = armourID;
            _name = name;

        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("ArmourTypeId", SqlDbType.Int);
            p.Value = _armourID;

            p = command.Parameters.Add("Name", SqlDbType.NVarChar);
            p.Value = _name;
        }
    }
}
