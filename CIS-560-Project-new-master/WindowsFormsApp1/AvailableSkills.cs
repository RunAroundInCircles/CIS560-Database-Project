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

namespace WindowsFormsApp1
{
    public partial class AvailableSkills : Form
    {
        public AvailableSkills(IReadOnlyList<Skills> skills)
        {
            InitializeComponent();

            foreach (Skills s in skills)
            {
                ui_skillsListBox.Items.Add(String.Format("{0,-30}  {1,-15}  {2}" + "\n", s._name, s._levelRequirement, s._description));
                Console.WriteLine(s._name);
            }
            if (skills.Count == 0) ui_skillsListBox.Items.Add("No Skills were found for the selected Class, Skill, and Level");
        }

        private void AvailableSkills_Load(object sender, EventArgs e)
        {

        }
    }
}
