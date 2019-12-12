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
    public partial class ui_AddRaceForm : Form
    {

        SqlRaceRepository raceRepository = Program.RaceRepository;

        Race _race = new Race(0,"","",0,0);

        public ui_AddRaceForm()
        {
            InitializeComponent();

            for (int i = 0; i <= 100; i++)
            {
                ui_DefModComboBox.Items.Add(i);
                ui_AttackModComboBox.Items.Add(i);
            }

        }

        private void ui_AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                _race._name = ui_NameTextbox.Text;
                _race._description = ui_DescriptionTextbox.Text;
                _race._attackMod = Convert.ToInt32(ui_AttackModComboBox.Text);
                _race._defenseMod = Convert.ToInt32(ui_DefModComboBox.Text);
                Race r = raceRepository.CreateRace(_race._name, _race._description, _race._attackMod, _race._defenseMod);
                MessageBox.Show("Race Added.");
            }
            catch (Exception)
            {
                MessageBox.Show("The name must be unique, the name, description, attack modifier, and defense modifier must not be empty.");
            }
        }
    }
}
