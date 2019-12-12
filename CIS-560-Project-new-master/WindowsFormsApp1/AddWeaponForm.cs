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
    public partial class ui_AddWeaponForm : Form
    {
        Weapons weapons = new Weapons(0,"",0,"",0);


        SqlWeaponsRepository weaponsRepository = Program.WeaponsRepository;
        SqlDamageTypeRepository DamageTypeRepository = Program.DamageTypeRepository;

        public ui_AddWeaponForm()
        {
            InitializeComponent();

            for (int i = 0; i <= 100; i++)
            {
                ui_DefModComboBox.Items.Add(i);
            }

            ui_DamageTypeComboBox.DataSource = DamageTypeRepository.RetrieveDamageTypes();
        }

        private void ui_AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                weapons._name = ui_NameTextbox.Text;
                weapons._description = ui_DescriptionTextbox.Text;
                weapons._damageTypeID = ((DamageType)ui_DamageTypeComboBox.SelectedItem)._damageTypeID;
                weapons._attackMod = Convert.ToInt32(ui_DefModComboBox.Text);

                weaponsRepository.CreateWeapons(weapons._name, weapons._damageTypeID, weapons._description, weapons._attackMod);
                MessageBox.Show("Weapon Added.");
            }
            catch (Exception)
            {
                MessageBox.Show("The name must be unique, the name, description, and attack modifier must not be empty.");
            }
        }
    }
}
