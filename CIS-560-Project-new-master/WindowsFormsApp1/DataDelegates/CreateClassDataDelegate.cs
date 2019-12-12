using CharacterData.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace CharacterData.DataDelegates
{
    class CreateClassDataDelegate : NonQueryDataDelegate<Class>
    {
        public string _name { get; }

        public string _description { get; }

        public int _defenseMod { get; }

        public int _attackMod { get; }

        public CreateClassDataDelegate(string name, string description, int defenseMod, int attackMod): base("Homebrew.InsertClass")
        {
            _name = name;
            _description = description;

            _defenseMod = defenseMod;
            _attackMod = attackMod;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("Name", SqlDbType.NVarChar);
            p.Value = _name;

            p = command.Parameters.Add("Description", SqlDbType.NVarChar);
            p.Value = _description;


            p = command.Parameters.Add("DefenseMod", SqlDbType.Int);
            p.Value = _defenseMod;

            p = command.Parameters.Add("AttackMod", SqlDbType.Int);
            p.Value = _attackMod;

            p = command.Parameters.Add("ClassId", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override Class Translate(SqlCommand command)
        {
            return new Class((int)command.Parameters["ClassId"].Value, _name, _description, _defenseMod, _attackMod);
        }
    }
}
