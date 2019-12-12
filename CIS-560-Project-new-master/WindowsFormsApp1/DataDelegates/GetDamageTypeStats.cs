using DataAccess;
using CharacterData.Models;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace CharacterData.DataDelegates
{
    class GetDamageTypeStats: DataReaderDelegate<IReadOnlyList<string>>
    {
        private int _damageTypeID { get; }

        public GetDamageTypeStats() : base("Player.GetDamageTypeStats")
        {
          
        }

        public override IReadOnlyList<string> Translate(SqlCommand command, SqlDataReader reader)
        {
            var damageType = new List<string>();
            //damageType.Add(string.Format("{0,-20}\t{1,-5}\t{2,-5}\t{3,-5}\t{4,-5}\t{5,-5}\t{6,-5}\t{7,-5}\t{8,-5}\t{9,-5}\t", "Name", "Acronym", "NumWeapons", "AverageDamage"
            //    , "HighestDamage", "NumStrongArmour", "AverageDefenseStrongArmour", "StrongestArmourDefenseMod", "NumWeakArmour", "AverageDefenseWeakArmour"));
            while (reader.Read())
            {
                damageType.Add(
                    string.Format("{1,-20}\t{2,-5}\t{3,-5}\t{4,-5}\t{5,-5}\t{7,-5}\t{8,-5}\t{9,-5}\t{11,-5}\t{12,-5}",
                    reader.GetInt32(reader.GetOrdinal("DamageTypeId")),
                    reader.GetString(reader.GetOrdinal("Name")),
                    reader.GetString(reader.GetOrdinal("Acronym")),
                    reader.GetInt32(reader.GetOrdinal("NumWeapons")),
                    reader.GetInt32(reader.GetOrdinal("AverageDamage")),
                    reader.GetInt32(reader.GetOrdinal("HighestDamage")),
                    reader.GetInt32(reader.GetOrdinal("StrongestWeaponLowestId")),
                    reader.GetInt32(reader.GetOrdinal("NumStrongArmour")),
                    reader.GetInt32(reader.GetOrdinal("AverageDefenseStrongArmour")),
                    reader.GetInt32(reader.GetOrdinal("StrongestArmourDefenseMod")),
                    reader.GetInt32(reader.GetOrdinal("StrongestArmourLowestId")),
                    reader.GetInt32(reader.GetOrdinal("NumWeakArmour")),
                    reader.GetInt32(reader.GetOrdinal("AverageDefenseWeakArmour"))));
            }

            return damageType;
        }
    }
}
