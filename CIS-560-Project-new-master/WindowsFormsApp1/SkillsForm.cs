using System;
using CharacterData.Models;
using CharacterData.SqlRepository;
using System.Windows.Forms;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    public partial class ui_SkillsForm : Form
    {


        SqlSkillsRepository SkillsRepository = new SqlSkillsRepository("Server = mssql.cs.ksu.edu; Database = wwchan; Trusted_Connection = True;");


        public ui_SkillsForm()
        {
            InitializeComponent();

            IReadOnlyList<Skills> skills = SkillsRepository.RetrieveSkills();
            foreach (Skills c in skills)
            {
                ui_SkillsFormTextbox.AppendText(String.Format("{0,-30}  {1,-15}  {2}" + "\n", c._name, c._levelRequirement, c._description));
            }
        }

        private void ui_SkillsAddButton_Click(object sender, EventArgs e)
        {
            ui_AddSkillForm ui_AddSkillForm = new ui_AddSkillForm();
            ui_AddSkillForm.Show();
        }

        private void ui_SkillsFormRefreshButton_Click(object sender, EventArgs e)
        {
            IReadOnlyList<Skills> skills = SkillsRepository.RetrieveSkills();
            foreach (Skills c in skills)
            {
                ui_SkillsFormTextbox.AppendText(String.Format("{0,-30}  {1,-15}  {2}" + "\n", c._name, c._levelRequirement, c._description));
            }
        }
    }
}
