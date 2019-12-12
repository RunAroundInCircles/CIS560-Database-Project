using DataAccess;
using CharacterData.Models;
using System.Data;
using System.Data.SqlClient;

namespace CharacterData.DataDelegates
{
    class GetDamageTypeDataDelegate: DataReaderDelegate<DamageType>
    {
        private int _damageTypeID { get; }

        public GetDamageTypeDataDelegate(int damageTypeID) : base("Player.GetDamageType")
        {
            _damageTypeID = damageTypeID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
            var p = command.Parameters.Add("DamageTypeId", SqlDbType.Int);
            p.Value = _damageTypeID;
        }

        public override DamageType Translate(SqlCommand command, SqlDataReader reader)
        {
            if (!reader.Read())
                return null;

            return new DamageType(_damageTypeID,
               reader.GetString(reader.GetOrdinal("Name")),
               reader.GetString(reader.GetOrdinal("Acronym")));
        }
    }
}
