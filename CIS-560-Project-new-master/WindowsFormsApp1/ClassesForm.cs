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

namespace WindowsFormsApp1
{
    public partial class ui_ClassForm : Form
    {

        SqlClassRepository ClassRepository = new SqlClassRepository("Server = mssql.cs.ksu.edu; Database = wwchan; Trusted_Connection = True;");

        public ui_ClassForm()
        {
            InitializeComponent();

            IReadOnlyList<Class> classes = ClassRepository.RetrieveClasses();
            foreach (Class c in classes)
            {
                ui_ClassFormTextbox.AppendText(String.Format("{0, -30}  {1, -15}  {2, -15}  {3}" + "\n", c._name, c._attackMod, c._defenseMod , c._description));
            }

        }

        private void ui_AddClassButton_Click(object sender, EventArgs e)
        {
            ui_AddClassForm ui_AddClassForm = new ui_AddClassForm();
            ui_AddClassForm.Show();
        }

        private void ui_ClassFormRefreshButton_Click(object sender, EventArgs e)
        {
            ui_ClassFormTextbox.Clear();
            IReadOnlyList<Class> classes = ClassRepository.RetrieveClasses();
            foreach (Class c in classes)
            {
                ui_ClassFormTextbox.AppendText(String.Format("{0, -30}  {1, -15}  {2, -15}  {3}" + "\n", c._name, c._attackMod, c._defenseMod, c._description));
            }
        }
    }
}
