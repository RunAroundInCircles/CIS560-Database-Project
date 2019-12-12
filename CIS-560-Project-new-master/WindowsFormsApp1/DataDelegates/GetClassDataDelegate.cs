using DataAccess;
using CharacterData.Models;
using System.Data;
using System.Data.SqlClient;

namespace CharacterData.DataDelegates
{
    class GetClassDataDelegate : DataReaderDelegate<Class>
    {
        private int _classID { get; }

        public GetClassDataDelegate(int classID) : base("Player.GetClass")
        {
            _classID = classID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
            var p = command.Parameters.Add("ClassId", SqlDbType.Int);
            p.Value = _classID;
        }

        public override Class Translate(SqlCommand command, SqlDataReader reader)
        {
            if (!reader.Read())
                return null;

            return new Class(_classID,
               reader.GetString(reader.GetOrdinal("Name")),
               reader.GetString(reader.GetOrdinal("Description")),
               reader.GetInt32(reader.GetOrdinal("DefenseMod")),
               reader.GetInt32(reader.GetOrdinal("AttackMod")));
        }
    }
}
