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
    public partial class ui_AddArmourForm : Form
    {
        Armour armour = new Armour(0, "", 0, 0, 0, "", 0);

        SqlArmourRepository ArmourRepository = Program.ArmourRepository;
        SqlArmourTypeRepository ArmourTypeRepository = Program.ArmourTypeRepository;
        SqlDamageTypeRepository DamageTypeRepository = Program.DamageTypeRepository;
        public ui_AddArmourForm()
        {
            InitializeComponent();

            for (int i = 0; i <= 100; i++)
            {
                ui_DefModComboBox.Items.Add(i);
            }

            ui_ArmourTypeComboBox.DataSource = ArmourTypeRepository.RetrieveArmourType();
            ui_StrengthComboBox.DataSource = DamageTypeRepository.RetrieveDamageTypes();
            ui_WeaknessComboBox.DataSource = DamageTypeRepository.RetrieveDamageTypes();

        }

        private void ui_AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ui_NameTextbox.Text) ||
                    string.IsNullOrWhiteSpace(ui_DescriptionTextbox.Text))
                    throw new Exception();
                armour._name = ui_NameTextbox.Text;
                armour._type = ((ArmourType)ui_ArmourTypeComboBox.SelectedItem)._armourTypeID;
                armour._strength = ((DamageType)ui_StrengthComboBox.SelectedItem)._damageTypeID;
                armour._weakness = ((DamageType)ui_WeaknessComboBox.SelectedItem)._damageTypeID;
                armour._defenseMod = int.Parse(ui_DefModComboBox.Text);
                ArmourRepository.CreateArmour(armour._name, armour._type, armour._weakness, armour._strength, armour._description, armour._defenseMod);
                MessageBox.Show("Armour Added");
            }
            catch (Exception)
            {
                MessageBox.Show("The name must be unique, the name, description, attack modifier, and defense modifier fields must not be empty, and the strength and weakness types cannot be the same.");
            }
        }
    }
}
