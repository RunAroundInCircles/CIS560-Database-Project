using CharacterData.Models;
using DataAccess;
using System.Data.SqlClient;
using System.Data;

namespace CharacterData.DataDelegates
{
    internal class SaveClassDataDelegate: DataDelegate
    {
        private readonly int _classID;
        private readonly string _name;
        private readonly string _description;
        private readonly int _defenseMod;
        private readonly int _attackMod;

        public SaveClassDataDelegate(int classID, string name, string description, int defenseMod, int attackMod): base("Class.SaveClasses")
        {
            _classID = classID;
            _name = name;
            _description = description;
            _defenseMod = defenseMod;
            _attackMod = attackMod;
        }
        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("ClassId", SqlDbType.Int);
            p.Value = _classID;

            p = command.Parameters.Add("Name", SqlDbType.NVarChar);
            p.Value = _name;

            p = command.Parameters.Add("Description", SqlDbType.NVarChar);
            p.Value = _description;

            p = command.Parameters.Add("DefenseMod", SqlDbType.Int);
            p.Value = _defenseMod;

            p = command.Parameters.Add("AttackMod", SqlDbType.Int);
            p.Value = _attackMod;
        }
    }
}
