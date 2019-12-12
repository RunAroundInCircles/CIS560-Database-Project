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

namespace WindowsFormsApp1
{
    public partial class ui_CreateCharacterForm : Form
    {
        SqlRaceRepository RaceRepository = Program.RaceRepository;
        SqlClassRepository ClassRepository = Program.ClassRepository;
        SqlArmourRepository ArmourRepository = Program.ArmourRepository;
        SqlWeaponsRepository WeaponsRepository = Program.WeaponsRepository;
        SqlSkillsRepository SkillsRepository = Program.SkillsRepository;
        SqlDamageTypeRepository DamageTypeRepository = Program.DamageTypeRepository;
        //static string _skill;
        Player player = new Player("",0,"","", "", "", new string[12],"","", "");

        IReadOnlyList<Class> classes;
        IReadOnlyList<Race> races;
        IReadOnlyList<Skills> skills;
        IReadOnlyList<Armour> armour;
        IReadOnlyList<Weapons> weapons;
        public ui_CreateCharacterForm()
        {
            InitializeComponent();


            
            //populates the drop down box for race
            races = RaceRepository.RetrieveRaces();
            ui_RaceComboBox.DataSource = races;

            //populates the drop down box for class
            classes = ClassRepository.RetrieveClasses();
            ui_ClassComboBox.DataSource = classes;


            armour = ArmourRepository.RetrieveArmour();
            foreach (Armour a in armour)
            {
                //while(Armour.Items.Contains(a._name) == false)  //Gets rid of duplicate Class types
                Armour.Items.Add(a._name);
            }

             weapons = WeaponsRepository.RetrieveWeapons();
            foreach (Weapons w in weapons)
            {
                //while(ui_WeaponComboBox.Items.Contains(w._name) == false)  //Gets rid of duplicate Class types
                Weapon.Items.Add(w._name);
            }

            skills = SkillsRepository.RetrieveSkills();
            foreach(Skills s in skills)
            {
                ui_SkillsListBox.Items.Add(s._name);
            }
        }

        private void ui_CreateCharacterButton_Click(object sender, EventArgs e)
        {
            if (Armour.SelectedIndex == -1)
            {
                MessageBox.Show("Select Armour.");
                return;
            }

            if (Weapon.SelectedIndex == -1)
            {
                MessageBox.Show("Select a Weapon.");
                return;
            }

            int level;
            if (!int.TryParse(ui_Level_Textbox.Text, out level))
            {
                MessageBox.Show("You must enter a number into the level textbox.");
                return;
            }

            int a = Armour.SelectedIndex;
            Armour ar = armour[a];

            int w = Weapon.SelectedIndex;
            Weapons we = weapons[w];
            
            player._name = ui_NameTextBox.Text;
            player._level = Convert.ToInt32(ui_Level_Textbox.Text);
            player._race = ui_RaceComboBox.Text;
            player._class = ui_ClassComboBox.Text;
            player._description = ui_DescriptionTextbox.Text;

            int i = 0;
            foreach (Skills s in SkillsRepository.GetAvailableSkills(classes[ui_ClassComboBox.SelectedIndex]._classID, races[ui_RaceComboBox.SelectedIndex]._raceID, level))
            {
                player._skills[i] = s._name;
                i++;
            }

            foreach (string str in Weapon.SelectedItems)
            {
                player._weapons += (str + Environment.NewLine);
            }

            foreach (string str in Armour.SelectedItems)
            {
                player._armour += (str + Environment.NewLine);
            }

            foreach (Skills s in ui_RaceSkill_listBox.Items)
            {
                player._raceSkills += (s.ToString() + Environment.NewLine);
            }

            foreach (Skills s in ui_ClassSkill_listBox.Items)
            {
                player._classSkills += (s.ToString() + Environment.NewLine);
            }


            ui_CharacterDisplayForm displayCharacter = new ui_CharacterDisplayForm(player, ar, we);
            displayCharacter.Show();
        }
        private void ui_ClassComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ui_ClassSkill_listBox.DataSource =
                SkillsRepository.GetSkillClass(((IReadOnlyList<Class>)ui_ClassComboBox.DataSource)[ui_ClassComboBox.SelectedIndex]._classID);
        }

        private void ui_RaceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ui_RaceSkill_listBox.DataSource =
                SkillsRepository.GetSkillRace(((IReadOnlyList<Race>)ui_RaceComboBox.DataSource)[ui_RaceComboBox.SelectedIndex]._raceID);
        }

        private void ui_GetAvailableSkills_Click(object sender, EventArgs e)
        {
            int level;
            if (!int.TryParse(ui_Level_Textbox.Text, out level))
            {
                MessageBox.Show("You must select a Class, a Race, and enter a number into the level textbox.");
                return;
            }
            AvailableSkills avs = new AvailableSkills(
            SkillsRepository.GetAvailableSkills(classes[ui_ClassComboBox.SelectedIndex]._classID, races[ui_RaceComboBox.SelectedIndex]._raceID, level));
            avs.Show();
        }

        private void ui_GetClasses_Click(object sender, EventArgs e)
        {
            int level;
            if (ui_SkillsListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Select a Skill.");
                return;
            }
            GetFromSkills gf = new GetFromSkills(SkillsRepository.GetFromSkill(skills[ui_SkillsListBox.SelectedIndex]._skillId));
            gf.Show();
        }

        private void ui_DamagetypeGet_Click(object sender, EventArgs e)
        {
            DamageTypeStats stats = new DamageTypeStats(DamageTypeRepository.GetDamageTypeStates());
            stats.Show();
        }

        private void ui_OptimalClasses_Click(object sender, EventArgs e)
        {
            GetOptimalClasses oc = new GetOptimalClasses(ClassRepository.GetOptimalClasses());
            oc.Show();
        }
    }
}
