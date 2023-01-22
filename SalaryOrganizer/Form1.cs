using Connection_DB;
using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace SalaryOrganizer
{
    public partial class Form1 : MaterialForm
    {
        connection con = new connection();
        public DataSet taskSet;
        public Form1()
        {
            InitializeComponent();

            //дизайн
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            con.Open();

            //таблица задач
            string queryTask = "SELECT id AS 'номер', due_date AS 'дата', due_time AS 'время', task_description AS 'описание' FROM tasks;";
            MySqlDataAdapter sqlDataTask = new MySqlDataAdapter(queryTask, con.getConectData());
            DataTable tableTaskDS = new DataTable();
            sqlDataTask.Fill(tableTaskDS);
            tableTasks.DataSource = tableTaskDS;

            //таблица сотрудников
            string queryEmployee = "SELECT id AS 'табельный номер', surname AS 'фамилия', shop AS 'цех', salary AS 'зарплата' FROM employees;";
            MySqlDataAdapter sqlDataEmployee = new MySqlDataAdapter(queryEmployee, con.getConectData());
            DataTable tableEmployeeDS = new DataTable();
            sqlDataEmployee.Fill(tableEmployeeDS);
            tableEmployee.DataSource = tableEmployeeDS;

            //таблица задач на сегодня
            string queryTodayTasks = "SELECT due_time AS 'время', task_description AS 'описание' FROM tasks WHERE due_date = CURRENT_DATE();";
            MySqlDataAdapter sqlDataTodayTasks = new MySqlDataAdapter(queryTodayTasks, con.getConectData());
            DataTable tableTodayTasksDS = new DataTable();
            sqlDataTodayTasks.Fill(tableTodayTasksDS);
            todayTasks.DataSource = tableTodayTasksDS;

            con.Close();

        }

        private void showAllTasks_Click(object sender, EventArgs e)
        {
            orgTabs.SelectedIndex = 1;
        }
        private void searchTaskByDate_Click(object sender, EventArgs e)
        {
            string dateFrom = taskDateFrom.Value.ToString("yyyy-MM-dd");
            string dateTo = taskDateTo.Value.ToString("yyyy-MM-dd");
            con.Open();
            string queryTaskFromTo = "SELECT id AS 'номер', due_date AS 'дата', due_time AS 'время', task_description AS 'описание' FROM tasks WHERE due_date BETWEEN '"+dateFrom+"' AND '"+dateTo+"' ORDER BY due_date;";
            MySqlDataAdapter sqlDataTaskFromTo = new MySqlDataAdapter(queryTaskFromTo, con.getConectData());
            DataTable tableTaskDSFromTo = new DataTable();
            sqlDataTaskFromTo.Fill(tableTaskDSFromTo);
            tableTasks.DataSource = tableTaskDSFromTo;
            con.Close();
        }

        private void taskDateFrom_ValueChanged(object sender, EventArgs e)
        {
            taskDateTo.MinDate = taskDateFrom.Value;
        }
        private void refreshTasks_Click(object sender, EventArgs e)
        {
            con.Open();
            string queryTask = "SELECT id AS 'номер', due_date AS 'дата', due_time AS 'время', task_description AS 'описание' FROM tasks;";
            MySqlDataAdapter sqlDataTask = new MySqlDataAdapter(queryTask, con.getConectData());
            DataTable tableTaskDS = new DataTable();
            sqlDataTask.Fill(tableTaskDS);
            tableTasks.DataSource = tableTaskDS;
            con.Close();
        }

        private void createTask_Click(object sender, EventArgs e)
        {
            createTask createTask = new createTask();
            createTask.ShowDialog();
        }

        private void alterTask_Click(object sender, EventArgs e)
        {
            TaskData.DueDate = tableTasks.CurrentRow.Cells[1].Value.ToString();
            TaskData.DueTime = tableTasks.CurrentRow.Cells[2].Value.ToString();
            TaskData.TaskDescription = tableTasks.CurrentRow.Cells[3].Value.ToString();
            TaskData.TaskIndex = Convert.ToInt32(tableTasks.CurrentRow.Cells[0].Value.ToString());

            alterTask alterTask = new alterTask();
            alterTask.ShowDialog();

        }

        private void deleteTask_Click(object sender, EventArgs e)
        {
            TaskData.TaskIndex = Convert.ToInt32(tableTasks.CurrentRow.Cells[0].Value.ToString());
            string conStr = "server=localhost;Database=salary_organizer;User ID=root;Password=Strongpassword1234";
            MySqlConnection con = new MySqlConnection(conStr);
            con.Open();
            string sql = "DELETE FROM tasks WHERE id ="+TaskData.TaskIndex+";";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Задание удалено", "Сообщение");

            string queryTask = "SELECT id AS 'номер', due_date AS 'дата', due_time AS 'время', task_description AS 'описание' FROM tasks;";
            MySqlDataAdapter sqlDataTask = new MySqlDataAdapter(queryTask, conStr);
            DataTable tableTaskDS = new DataTable();
            sqlDataTask.Fill(tableTaskDS);
            tableTasks.DataSource = tableTaskDS;

            con.Close();
        }
    }
}
