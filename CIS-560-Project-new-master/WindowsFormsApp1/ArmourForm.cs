using System;
using CharacterData.Models;
using CharacterData.SqlRepository;
using System.Windows.Forms;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    public partial class ui_ArmourForm : Form
    {


        SqlArmourRepository ArmourRepository = new SqlArmourRepository("Server = mssql.cs.ksu.edu; Database = wwchan; Trusted_Connection = True;");

        public ui_ArmourForm()
        {
            InitializeComponent();

            IReadOnlyList<Armour> armours = ArmourRepository.RetrieveArmour();
            foreach (Armour c in armours)
            {
                ui_ArmourFormTextbox.AppendText(String.Format("{0,-45}  {1,-15}  {2,-15} {3, -15}  {4}" + "\n", c._name, c._defenseMod, c._strength, c._weakness, c._description));
            }
        }

        private void ui_ArmourAddButton_Click(object sender, EventArgs e)
        {
            ui_AddArmourForm ui_AddArmourForm = new ui_AddArmourForm();
            ui_AddArmourForm.Show();
        }

        private void ui_ArmourFormRefreshButton_Click(object sender, EventArgs e)
        {
            IReadOnlyList<Armour> armours = ArmourRepository.RetrieveArmour();
            foreach (Armour c in armours)
            {
                ui_ArmourFormTextbox.AppendText(String.Format("{0,-45}  {1,-15}  {2,-15} {3, -15}  {4}" + "\n", c._name, c._defenseMod, c._strength, c._weakness, c._description));
            }
        }
    }
}
