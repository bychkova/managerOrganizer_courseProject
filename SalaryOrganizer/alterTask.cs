using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System;
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

        static string conStr = "server=localhost;Database=salary_organizer;" +
                                "User ID=root;Password=Strongpassword1234";
        MySqlConnection con = new MySqlConnection(conStr);
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
            if (alterHour.Text != "" && alterMinutes.Text != "" && alterDescription.Text != "")
            {
                try
                {
                    string date, time, desc;
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