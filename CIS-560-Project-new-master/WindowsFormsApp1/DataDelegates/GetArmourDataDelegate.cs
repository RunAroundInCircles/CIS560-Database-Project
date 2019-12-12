using DataAccess;
using CharacterData.Models;
using System.Data;
using System.Data.SqlClient;


namespace CharacterData.DataDelegates
{
    class GetArmourDataDelegate : DataReaderDelegate<Armour>
    {
        private int _armourID { get; }

        public GetArmourDataDelegate(int armourID) : base("Armour.GetArmour")
        {
            _armourID = armourID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
            var p = command.Parameters.Add("ArmourID", SqlDbType.Int);
            p.Value = _armourID;
        }

        public override Armour Translate(SqlCommand command, SqlDataReader reader)
        {
            if (!reader.Read())
                return null;

            return new Armour(_armourID,
               reader.GetString(reader.GetOrdinal("Name")),
               reader.GetInt32(reader.GetOrdinal("ArmourTypeId")),
               reader.GetInt32(reader.GetOrdinal("Weakness")),
               reader.GetInt32(reader.GetOrdinal("Strength")),
               reader.GetString(reader.GetOrdinal("Description")),
               reader.GetInt32(reader.GetOrdinal("DefenseMod")));
        }
    }
}
