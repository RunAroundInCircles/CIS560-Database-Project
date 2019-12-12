using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ui_MainMenuForm : Form
    {
        public ui_MainMenuForm()
        {
            InitializeComponent();
        }

        private void ui_GetStartedCreateButton_Click_1(object sender, EventArgs e)
        {
            ui_CreateCharacterForm characterForm = new ui_CreateCharacterForm();
            characterForm.Show();
        }

        private void ui_RaceBrowseButton_Click_1(object sender, EventArgs e)
        {
            ui_RaceForm raceForm = new ui_RaceForm();
            raceForm.Show();
        }

        private void ui_RaceAddButton_Click(object sender, EventArgs e)
        {
            ui_AddRaceForm raceForm = new ui_AddRaceForm();
            raceForm.Show();
        }

        private void ui_BrowseClassButton_Click_1(object sender, EventArgs e)
        {
            ui_ClassForm classForm = new ui_ClassForm();
            classForm.Show();
        }

        private void ui_AddClassButton_Click_1(object sender, EventArgs e)
        {
            ui_AddClassForm addClassForm = new ui_AddClassForm();
            addClassForm.Show();
        }

        private void ui_SkillsBrowseButton_Click_1(object sender, EventArgs e)
        {
            ui_SkillsForm skillsForm = new ui_SkillsForm();
            skillsForm.Show();
        }

        private void ui_SkillsAddButton_Click_1(object sender, EventArgs e)
        {
            ui_AddSkillForm addSkillForm = new ui_AddSkillForm();
            addSkillForm.Show();
        }

        private void ui_WeaponsBrowseButton_Click_1(object sender, EventArgs e)
        {
            WeaponsForm weaponsForm = new WeaponsForm();
            weaponsForm.Show();
        }

        private void ui_WeaponsAddButton_Click_1(object sender, EventArgs e)
        {
            ui_AddWeaponForm addWeaponForm = new ui_AddWeaponForm();
            addWeaponForm.Show();
        }

        private void ui_ArmourBrowseButton_Click_1(object sender, EventArgs e)
        {
            ui_ArmourForm armourForm = new ui_ArmourForm();
            armourForm.Show();
        }

        private void ui_ArmourAddButton_Click_1(object sender, EventArgs e)
        {
            ui_AddArmourForm addArmourForm = new ui_AddArmourForm();
            addArmourForm.Show();
        }
    }
}
