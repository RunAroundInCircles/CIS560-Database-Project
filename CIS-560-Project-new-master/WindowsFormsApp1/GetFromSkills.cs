using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GetFromSkills : Form
    {
        public GetFromSkills(IReadOnlyList<string> skills)
        {
            InitializeComponent();

            foreach (string s in skills)
            {
                ui_GetFromSkills.AppendText(s + "\n");
            }
        }
    }
}
