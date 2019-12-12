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
    public partial class DamageTypeStats : Form
    {
        public DamageTypeStats(IReadOnlyList<string> vs)
        {
            InitializeComponent();

            foreach(string s in vs)
            {
                ui_damageTypeTextbox.AppendText(s);
                ui_damageTypeTextbox.AppendText("\n\n");
            }
        }
    }
}
