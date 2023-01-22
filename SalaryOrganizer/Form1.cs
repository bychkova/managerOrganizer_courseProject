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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryOrganizer
{
    public partial class Form1 : MaterialForm
    {
        connection con = new connection();
        public DataSet taskSet;
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            con.Open();
            string queryTask = "SELECT id AS 'номер', due_date AS 'дата', due_time AS 'время', task_description AS 'описание' FROM tasks;";
            MySqlDataAdapter sqlDataTask = new MySqlDataAdapter(queryTask, con.getConectData());
            DataTable tableTaskDS = new DataTable();
            sqlDataTask.Fill(tableTaskDS);
            tableTasks.DataSource = tableTaskDS;

            string queryEmployee = "SELECT id AS 'табельный номер', surname AS 'фамилия', shop AS 'цех', salary AS 'зарплата' FROM employees;";
            MySqlDataAdapter sqlDataEmployee = new MySqlDataAdapter(queryEmployee, con.getConectData());
            DataTable tableEmployeeDS = new DataTable();
            sqlDataEmployee.Fill(tableEmployeeDS);
            tableEmployee.DataSource = tableEmployeeDS;

            con.Close();

        }

    }
}
