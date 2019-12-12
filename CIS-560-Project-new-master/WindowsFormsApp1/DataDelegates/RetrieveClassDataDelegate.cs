using DataAccess;
using CharacterData.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace CharacterData.DataDelegates
{
    internal class RetrieveClassDataDelegate : DataReaderDelegate<IReadOnlyList<Class>>
    {
        
        public RetrieveClassDataDelegate()
           : base("List.GetAllClasses")
        {
            
        }

        public override IReadOnlyList<Class> Translate(SqlCommand command, SqlDataReader reader)
        {
            var classes = new List<Class>();

            while (reader.Read())
            {
                classes.Add(new Class(
                    reader.GetInt32(reader.GetOrdinal("ClassId")),
                    reader.GetString(reader.GetOrdinal("Name")),
                    reader.GetString(reader.GetOrdinal("Description")),
                    reader.GetInt32(reader.GetOrdinal("DefenseMod")),
                    reader.GetInt32(reader.GetOrdinal("AttackMod"))));

            }

            return classes;
        }
    }
}