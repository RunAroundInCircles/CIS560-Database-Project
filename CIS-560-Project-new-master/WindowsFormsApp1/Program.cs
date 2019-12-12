using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CharacterData.SqlRepository;

namespace CharacterData
{
    static class Program
    {
        public static SqlRaceRepository RaceRepository = new SqlRaceRepository("Server = mssql.cs.ksu.edu; Database = wwchan; Trusted_Connection = True;");
        public static SqlClassRepository ClassRepository = new SqlClassRepository("Server = mssql.cs.ksu.edu; Database = wwchan; Trusted_Connection = True;");
        public static SqlArmourRepository ArmourRepository = new SqlArmourRepository("Server = mssql.cs.ksu.edu; Database = wwchan; Trusted_Connection = True;");
        public static SqlWeaponsRepository WeaponsRepository = new SqlWeaponsRepository("Server = mssql.cs.ksu.edu; Database = wwchan; Trusted_Connection = True;");
        public static SqlSkillsRepository SkillsRepository = new SqlSkillsRepository("Server = mssql.cs.ksu.edu; Database = wwchan; Trusted_Connection = True;");
        public static SqlArmourTypeRepository ArmourTypeRepository = new SqlArmourTypeRepository("Server = mssql.cs.ksu.edu; Database = wwchan; Trusted_Connection = True;");
        public static SqlDamageTypeRepository DamageTypeRepository = new SqlDamageTypeRepository("Server = mssql.cs.ksu.edu; Database = wwchan; Trusted_Connection = True;");
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WindowsFormsApp1.ui_MainMenuForm());
        }
    }
}
