using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryOrganizer
{
    class DBmanager
    {
        private string queryTask = "SELECT id AS 'номер', due_date AS 'дата', " +
                                    "due_time AS 'время', " +
                                    "task_description AS 'описание' FROM tasks;";

        private string queryEmployee = "SELECT id AS 'табельный номер', " +
                                        "surname AS 'фамилия', shop AS 'цех', " +
                                        "salary AS 'зарплата' FROM employees;";
        private string queryTodayTasks = "SELECT due_time AS 'время', " +
                                         "task_description AS 'описание' " +
                                          "FROM tasks WHERE due_date = CURRENT_DATE();";

        public DBmanager() { }
        private static DataTable createAdapter(string query, MySqlConnection con)
        {
            MySqlDataAdapter sqlData = new MySqlDataAdapter(query, con);
            DataTable table = new DataTable();
            sqlData.Fill(table);
            return table;
        }
        public void refreshTasks(MySqlConnection con, DataGridView dataTable)
        {
            DataTable table = createAdapter(queryTask, con);
            dataTable.DataSource = table;
        }
        public void refreshEmployee(MySqlConnection con, DataGridView dataTable)
        {
            DataTable table = createAdapter(queryEmployee, con);
            dataTable.DataSource = table;
        }
        public void refreshTodayTasks(MySqlConnection con, DataGridView dataTable)
        {
            DataTable table = createAdapter(queryTodayTasks, con);
            dataTable.DataSource = table;
        }
    }
}