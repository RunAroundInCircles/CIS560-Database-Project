using CharacterData.Models;
using DataAccess;
using System.Data.SqlClient;
using System.Data;


namespace CharacterData.DataDelegates
{
    internal class SaveArmourDataDelegate : DataDelegate
    {
        private readonly int _armourID;
        private readonly string _name;
        private readonly string _type;
        private readonly string _weakness; 
        private readonly string _strength;
        private readonly string _description;
        private readonly int _durability;
        private readonly int _defenseMod ;

        public SaveArmourDataDelegate(int armourID, string name, string type, string weakness, string strength, string description, int durability, int defenseMod) : base("Armour.SaveArmour")
        {
            _armourID = armourID;
            _name = name;
            _type = type;
            _weakness = weakness;
            _strength = strength;
            _description = description;
            _durability = durability;
            _defenseMod = defenseMod;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("ArmourId", SqlDbType.Int);
            p.Value = _armourID;

            p = command.Parameters.Add("Name", SqlDbType.NVarChar);
            p.Value = _name;

            p = command.Parameters.Add("Type", SqlDbType.NVarChar);
            p.Value = _type;

            p = command.Parameters.Add("Weakness", SqlDbType.NVarChar);
            p.Value = _weakness;

            p = command.Parameters.Add("Strength", SqlDbType.NVarChar);
            p.Value = _strength;

            p = command.Parameters.Add("Description", SqlDbType.NVarChar);
            p.Value = _description;

            p = command.Parameters.Add("Durability", SqlDbType.Int);
            p.Value = _durability;

            p = command.Parameters.Add("DefenseMod", SqlDbType.Int);
            p.Value = _defenseMod;
        }
    }
}
