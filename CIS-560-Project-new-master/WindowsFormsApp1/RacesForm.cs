using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using CharacterData.Models;
using CharacterData.SqlRepository;

namespace WindowsFormsApp1
{
    public partial class ui_RaceForm : Form
    {

        SqlRaceRepository RaceRepository = new SqlRaceRepository("Server = mssql.cs.ksu.edu; Database = wwchan; Trusted_Connection = True;");

        public ui_RaceForm()
        {
            InitializeComponent();

            IReadOnlyList<Race> races = RaceRepository.RetrieveRaces();
            foreach (Race c in races)
            {
                ui_RaceFormTextbox.AppendText(String.Format("{0,-30}  {1,-15}  {2,-15}  {3}" + "\n", c._name, c._attackMod, c._defenseMod, c._description));
            }
        }

        private void ui_RaceAddButton_Click(object sender, EventArgs e)
        {
            ui_AddRaceForm ui_AddRaceForm = new ui_AddRaceForm();
            ui_AddRaceForm.Show();
        }

        private void ui_RaceFormRefreshButton_Click(object sender, EventArgs e)
        {
            IReadOnlyList<Race> races = RaceRepository.RetrieveRaces();
            foreach (Race c in races)
            {
                ui_RaceFormTextbox.AppendText(String.Format("{0,-30}  {1,-15}  {2,-15}  {3}" + "\n", c._name, c._attackMod, c._defenseMod, c._description));
            }
        }
    }
}
