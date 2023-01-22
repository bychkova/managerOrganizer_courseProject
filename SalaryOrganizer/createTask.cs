using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace SalaryOrganizer
{
    public partial class createTask : MaterialForm
    {
        public createTask()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
        }

        private void cancelCreateTask_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createNewTask_Click(object sender, EventArgs e)
        {
            string date, time, desc;
            if (taskHour.Text != "" && taskMinutes.Text != "" && taskDescription.Text != "")
            {
                string conStr = "server=localhost;Database=salary_organizer;User ID=root;Password=Strongpassword1234";
                MySqlConnection con = new MySqlConnection(conStr);
                con.Open();
                date = taskDate.Value.ToString("yyyy-MM-dd");
                time = taskHour.Text + ":" + taskMinutes.Text;
                desc = taskDescription.Text;

                string sql = "INSERT INTO tasks (due_date, due_time, task_description) VALUE('"+date+"', '"+time+"', '"+desc+"');";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Задание добавлено", "Сообщение");
                taskDate.Value = DateTime.Now;
                taskHour.Text = "";
                taskMinutes.Text = "";
                taskDescription.Text = "";
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
