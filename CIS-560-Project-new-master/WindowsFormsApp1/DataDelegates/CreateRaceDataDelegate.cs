using CharacterData.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace CharacterData.DataDelegates
{
    class CreateRaceDataDelegate : NonQueryDataDelegate<Race>
    {
        public string _name { get; }

        public string _description { get; }

        public int _attackMod { get; }

        public int _defenseMod { get; }

        public CreateRaceDataDelegate(string name, string description, int defenseMod, int attackMod) : base("Homebrew.InsertRace")
        {
            _name = name;
            _description = description;
            _attackMod = attackMod;
            _defenseMod = defenseMod;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("RaceId", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;

            p = command.Parameters.Add("Name", SqlDbType.NVarChar);
            p.Value = _name;

            p = command.Parameters.Add("Description", SqlDbType.NVarChar);
            p.Value = _description;

            p = command.Parameters.Add("AttackMod", SqlDbType.Int);
            p.Value = _attackMod;

            p = command.Parameters.Add("DefenseMod", SqlDbType.Int);
            p.Value = _defenseMod;


        }

        public override Race Translate(SqlCommand command)
        {
            return new Race((int)command.Parameters["RaceId"].Value, _name, _description, _defenseMod, _attackMod);
        }
    }
}
