using System;
using CharacterData.Models;
using CharacterData.SqlRepository;
using System.Windows.Forms;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    public partial class WeaponsForm : Form
    {

        SqlWeaponsRepository WeaponsRepository = new SqlWeaponsRepository("Server = mssql.cs.ksu.edu; Database = wwchan; Trusted_Connection = True;");

        public WeaponsForm()
        {
            InitializeComponent();

            IReadOnlyList<Weapons> weapons= WeaponsRepository.RetrieveWeapons();
            foreach (Weapons c in weapons)
            {
                ui_WeaponsFormTextbox.AppendText(String.Format("{0,-45}  {1,-15}  {2}" + "\n", c._name, c._attackMod, c._description));
            }
        }

        private void ui_WeaponsAddButton_Click(object sender, EventArgs e)
        {
            ui_AddWeaponForm ui_AddWeaponForm = new ui_AddWeaponForm();
            ui_AddWeaponForm.Show();
        }

        private void ui_WeaponsFormRefreshButton_Click(object sender, EventArgs e)
        {

            IReadOnlyList<Weapons> weapons = WeaponsRepository.RetrieveWeapons();
            foreach (Weapons c in weapons)
            {
                ui_WeaponsFormTextbox.AppendText(String.Format("{0,-45}  {1,-15}  {2}" + "\n", c._name, c._attackMod, c._description));
            }
        }
    }
}
