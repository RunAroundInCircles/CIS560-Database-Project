using CharacterData.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace CharacterData.DataDelegates
{
    class CreateArmourDataDelegate : NonQueryDataDelegate<Armour>
    {

        public string _name { get; }

        public int _type { get; }

        public int _weakness { get; }

        public int _strength { get; }

        public string _description { get; }

        public int _defenseMod { get; }

        public CreateArmourDataDelegate(string name, int type, int weakness, int strength, string description, int defenseMod): base("Homebrew.InsertArmour")
        {
            _name = name;
            _type = type;
            _weakness = weakness;
            _strength = strength;
            _description = description;
            _defenseMod = defenseMod;
        }
        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("Name", SqlDbType.NVarChar);
            p.Value = _name;

            p = command.Parameters.Add("ArmourTypeId", SqlDbType.Int);
            p.Value = _type;

            p = command.Parameters.Add("DamageTypeWeak", SqlDbType.Int);
            p.Value = _weakness;

            p = command.Parameters.Add("DamageTypeStrong", SqlDbType.Int);
            p.Value = _strength;

            p = command.Parameters.Add("Description", SqlDbType.NVarChar);
            p.Value = _description;

            p = command.Parameters.Add("DefenseMod", SqlDbType.Int);
            p.Value = _defenseMod;

            p = command.Parameters.Add("ArmourId", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override Armour Translate(SqlCommand command)
        {
            return new Armour((int)command.Parameters["ArmourId"].Value, _name, _type, _weakness, _strength, _description, _defenseMod);
        }
    }
}
