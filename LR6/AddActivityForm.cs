using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using LR6.DB;

namespace LR6
{
    public partial class AddActivityForm : Form
    {
        private List<int> IdJuri = new List<int>();
        public AddActivityForm()
        {
            InitializeComponent();
        }

        private void AddActivityForm_Load(object sender, EventArgs e)
        {
            eventBindingSourse.DataSource = DBConst.model.Event.ToList();
            usersBindingSourse1.DataSource = DBConst.model.User.Where(x =>x.RoleID == 1).ToList();
            usersBindingSourse2.DataSource = DBConst.model.User.Where(x => x.RoleID == 2).ToList();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btAddActivity_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbTitle.Text))
            {
                MessageBox.Show("Заполните поле Название!");
                return;
            }
            try
            {
                Convert.ToInt32(tbDay.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("В поле День должно быть целочисленное значение!");
                return;
            }
            if (IdJuri.Count <= 0)
            {
                MessageBox.Show("Добавьте члена жюри!");
                return;
            }

            Activity activity = new Activity();
            activity.Title = tbTitle.Text;
            activity.EventPlanID = (int)tbEvent.SelectedValue;
            activity.Day = Convert.ToInt32(tbDay.Text);
            activity.StartedAt = dateTimePicker1.Value.TimeOfDay;
            activity.ModeratorID = (int)cbModerator.SelectedValue;
            activity.GroupsJury = JsonSerializer.Serialize(IdJuri);

            DBConst.model.Activity.Add(activity);
            try
            {
                DBConst.model.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return;
            }
            Close();
        }

        private void btAddJuri_Click(object sender, EventArgs e)
        {
            int id = (int)cbJuri.SelectedValue;
            if (!IdJuri.Contains(id))
            {
                IdJuri.Add(id);
                MessageBox.Show($"Пользователь (ID: {cbJuri.SelectedValue}) добавлен. ");
                return;
            }
            MessageBox.Show("Такой жюри уже есть!");
        }
    }
}
