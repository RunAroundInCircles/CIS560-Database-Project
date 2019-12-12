using DataAccess;
using CharacterData.Models;
using System.Data;
using System.Data.SqlClient;

namespace CharacterData.DataDelegates
{
    class GetArmourTypeDelegate: DataReaderDelegate<ArmourType>
    {
        private int _armourTypeId { get; }

        public GetArmourTypeDelegate(int armourTypeId) : base("Player.GetArmourType")
        {
            _armourTypeId = armourTypeId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
            var p = command.Parameters.Add("ArmourTypeId", SqlDbType.Int);
            p.Value = _armourTypeId;
        }

        public override ArmourType Translate(SqlCommand command, SqlDataReader reader)
        {
            if (!reader.Read())
                return null;

            return new ArmourType(_armourTypeId,
               reader.GetString(reader.GetOrdinal("Name")));
        }
    }
}
