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

namespace LR6
{
    public partial class ShowJuriForm : Form
    {
        public ShowJuriForm()
        {
            InitializeComponent();
        }

        private void ShowJuriForm_Load(object sender, EventArgs e)
        {
            int number = 1;
            foreach (int i in MainForm.JuriList)
            {
                User user = DBConst.model.User.Find(i);
                UserControlJuri userControl = new UserControlJuri();
                userControl.Fill(user, number);
                flowLayoutPanel1.Controls.Add(userControl);
                number++;
            }
        }
    }
}
