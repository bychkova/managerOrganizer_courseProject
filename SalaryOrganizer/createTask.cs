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

        static string conStr = "server=localhost;Database=salary_organizer;" +
                                "User ID=root;Password=Strongpassword1234";
        MySqlConnection con = new MySqlConnection(conStr);

        private void cancelCreateTask_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createNewTask_Click(object sender, EventArgs e)
        {
            if (taskHour.Text != "" && taskMinutes.Text != "" && taskDescription.Text != "")
            {
                try
                {
                    string date, time, desc;
                    con.Open();
                    date = taskDate.Value.ToString("yyyy-MM-dd");
                    time = taskHour.Text + ":" + taskMinutes.Text;
                    desc = taskDescription.Text;

                    string sql = "INSERT INTO tasks (due_date, due_time, task_description) VALUE('"+date+"', '"+time+"', '"+desc+"');";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Задание добавлено", "Сообщение");
                    this.Close();
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("Ошибка соединения", "Сообщение");
                }
            }
            else
            {
                MessageBox.Show("Введите данные", "Сообщение");
            }
        }
    }
}