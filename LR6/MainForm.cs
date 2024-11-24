using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LR6.DB;
using System.Text.Json;

namespace LR6
{
    public partial class MainForm : Form
    {
        public static List<int> JuriList;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            activityBindingSource.DataSource = DBConst.model.Activity.ToList();
        }

        private void btShowJuri_Click(object sender, EventArgs e)
        {
            JuriList = new List<int>();
            JuriList = JsonSerializer.Deserialize<List<int>>
                (dataGridView1.CurrentRow.Cells[6].Value.ToString());
            ShowJuriForm showJuriForm = new ShowJuriForm();
            showJuriForm.ShowDialog();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            AddActivityForm activityForm = new AddActivityForm();
            activityForm.ShowDialog();
            activityBindingSource.DataSource = DBConst.model.Activity.ToList();
        }
    }
}
