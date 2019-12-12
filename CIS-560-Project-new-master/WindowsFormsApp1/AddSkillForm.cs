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
    public partial class ui_AddSkillForm : Form
    {
        Skills skills = new Skills(0,"","", 0);


        SqlSkillsRepository SkillsRepository = Program.SkillsRepository;

        public ui_AddSkillForm()
        {
            InitializeComponent();
        }

        private void ui_AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                skills._name = ui_NameTextbox.Text;
                skills._levelRequirement = Convert.ToInt32(textBox1.Text);
                skills._description = ui_DescriptionTextbox.Text;

                SkillsRepository.CreateSkills(skills._name, skills._description, skills._levelRequirement);
                MessageBox.Show("Skill Added.");
            }
            catch (Exception)
            {
                MessageBox.Show("The name must be unique, the name, description, and level requirement must not be empty, and level requirement must be a number.");
            }
        }
    }
}
