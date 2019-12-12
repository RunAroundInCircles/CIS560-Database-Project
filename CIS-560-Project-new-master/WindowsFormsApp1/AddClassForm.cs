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
    public partial class ui_AddClassForm : Form
    {
        Class _class = new Class(1 ,"","",0,0);

        SqlClassRepository ClassRepository = Program.ClassRepository;


        public ui_AddClassForm()
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
                if(string.IsNullOrWhiteSpace(ui_NameTextbox.Text) ||
                    string.IsNullOrWhiteSpace(ui_DescriptionTextbox.Text))
                    throw new Exception();
                _class._name = ui_NameTextbox.Text;
                _class._description = ui_DescriptionTextbox.Text;
                _class._attackMod = Convert.ToInt32(ui_AttackModComboBox.Text);
                _class._defenseMod = Convert.ToInt32(ui_DefModComboBox.Text);
                ClassRepository.CreateClass(_class._name, _class._description, _class._defenseMod, _class._attackMod);
                MessageBox.Show("Class Added.");
            } catch (Exception) {
                MessageBox.Show("The name must be unique, the name, description, attack modifier, and defense modifier must not be empty.");
            }
        }
    }
}
