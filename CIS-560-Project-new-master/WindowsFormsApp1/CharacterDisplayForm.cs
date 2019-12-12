using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CharacterData.Models;
using CharacterData.SqlRepository;
using CharacterData;

namespace CharacterData
{
    public partial class ui_CharacterDisplayForm : Form
    {


        SqlSkillsRepository SkillsRepository = new SqlSkillsRepository("Server = mssql.cs.ksu.edu; Database = wwchan; Trusted_Connection = True;");
        SqlArmourTypeRepository ArmourTypeRepository = new SqlArmourTypeRepository("Server = mssql.cs.ksu.edu; Database = wwchan; Trusted_Connection = True;");
        SqlDamageTypeRepository DamageTypeRepository = new SqlDamageTypeRepository("Server = mssql.cs.ksu.edu; Database = wwchan; Trusted_Connection = True;");
        public ui_CharacterDisplayForm(Models.Player player, Armour a, Weapons w)
        {
            InitializeComponent();

         
            ui_NameTextbox.Text = player._name;
            ui_RaceTextbox.Text = player._race;
            ui_RaceSkillsTextbox.Text = player._raceSkills;
            ui_ClassTextbox.Text = player._class;
            ui_ClassSkillsTextbox.Text = player._classSkills;
            ui_DescriptionTextbox.Text = player._description;
            ui_ArmourTextbox.Text = player._armour;
            ui_WeaponsTextbox.Text = player._weapons;
            ArmourType at = ArmourTypeRepository.GetArmourType(a._type);
            DamageType dt = DamageTypeRepository.GetDamageType(w._damageTypeID);



            for (int i = 0; i < player._skills.Length; i++)
            {
                ui_SkillsTextbox.Text += (player._skills[i] + Environment.NewLine);
            }
        }

    }
}
