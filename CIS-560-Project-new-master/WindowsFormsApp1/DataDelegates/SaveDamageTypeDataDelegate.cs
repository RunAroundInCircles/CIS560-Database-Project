using CharacterData.Models;
using DataAccess;
using System.Data.SqlClient;
using System.Data;

namespace CharacterData.DataDelegates
{
    internal class SaveDamageTypeDataDelegate : DataDelegate
    {
        private readonly int _damageTypeID;
        private readonly string _name;
        private readonly string _description;

        public SaveDamageTypeDataDelegate(int damageTypeID, string name, string description) : base("List.GetAllDamageTypes")
        {
            _damageTypeID = damageTypeID;
            _name = name;
            _description = description;
        }
        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("DamageTypeID", SqlDbType.Int);
            p.Value = _damageTypeID;

            p = command.Parameters.Add("Name", SqlDbType.NVarChar);
            p.Value = _name;

            p = command.Parameters.Add("Description", SqlDbType.NVarChar);
            p.Value = _description;
        }
    }
}
