using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryOrganizer
{
    public partial class alterTask : MaterialForm
    {
        public alterTask()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
        }

        private void alterTask_Load(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(TaskData.DueDate.Substring(6,4));
            int month = Convert.ToInt32(TaskData.DueDate.Substring(3, 2));
            int day = Convert.ToInt32(TaskData.DueDate.Substring(0, 2));
            alterDate.Value = new DateTime(year, month, day);
            alterHour.Text = TaskData.DueTime.Substring(0,2);
            alterMinutes.Text = TaskData.DueTime.Substring(3, 2);
            alterDescription.Text = TaskData.TaskDescription;
        }

        private void canceAlterTask_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void alterTaskBtn_Click(object sender, EventArgs e)
        {
            string date, time, desc;
            if (alterHour.Text != "" && alterMinutes.Text != "" && alterDescription.Text != "")
            {
                string conStr = "server=localhost;Database=salary_organizer;User ID=root;Password=Strongpassword1234";
                MySqlConnection con = new MySqlConnection(conStr);
                con.Open();
                date = alterDate.Value.ToString("yyyy-MM-dd");
                time = alterHour.Text + ":" + alterMinutes.Text;
                desc = alterDescription.Text;

                string sql = "UPDATE tasks SET due_date ='"+date+"', due_time ='"+time+"', task_description='"+desc+"' WHERE id ="+TaskData.TaskIndex+";";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Задание изменено", "Сообщение");
                this.Close();

                con.Close();
            }
            else
            {
                MessageBox.Show("Введите данные", "Сообщение");
            }
        }
    }
}
