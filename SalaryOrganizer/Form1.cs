using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace SalaryOrganizer
{
    public partial class Form1 : MaterialForm
    {
        static string conStr = "server=localhost;Database=salary_organizer;" +
                                "User ID=root;Password=Strongpassword1234";
        MySqlConnection con = new MySqlConnection(conStr);

        DBmanager manager = new DBmanager();
        public Form1()
        {
            InitializeComponent();

            //дизайн
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            taskDateTo.MinDate = taskDateFrom.Value;
            dataLabel.Text = mainCalendar.SelectionRange.Start.ToString("dd.MM.yyyy");

            con.Open();           
            //таблица задач
            manager.refreshTasks(con, tableTasks);
            //таблица сотрудников
            manager.refreshEmployee(con, tableEmployee);
            //таблица задач на сегодня
            manager.refreshTodayTasks(con, todayTasks);
            con.Close();
        }

        //вкладка главная
        private void showAllTasks_Click(object sender, EventArgs e)
        {
            orgTabs.SelectedIndex = 1;
        }

        private void mainCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            string selectedDate = mainCalendar.SelectionRange.Start.ToString("yyyy-MM-dd");
            string query = "SELECT due_time AS 'время', " +
                                         "task_description AS 'описание' " +
                                          "FROM tasks WHERE due_date ='"+selectedDate+"';";
            MySqlDataAdapter sqlData = new MySqlDataAdapter(query, con);
            DataTable table = new DataTable();
            sqlData.Fill(table);
            todayTasks.DataSource = table;
            dataLabel.Text = mainCalendar.SelectionRange.Start.ToString("dd.MM.yyyy");
        }
        

        //вкладка задачи
        private void searchTaskByDate_Click(object sender, EventArgs e)
        {
            string dateFrom = taskDateFrom.Value.ToString("yyyy-MM-dd");
            string dateTo = taskDateTo.Value.ToString("yyyy-MM-dd");
            con.Open();
            string queryTaskFromTo = "SELECT id AS 'номер', due_date AS 'дата', due_time AS 'время', task_description AS 'описание' FROM tasks WHERE due_date BETWEEN '"+dateFrom+"' AND '"+dateTo+"' ORDER BY due_date;";
            MySqlDataAdapter sqlDataTaskFromTo = new MySqlDataAdapter(queryTaskFromTo, con);
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
            manager.refreshTasks(con, tableTasks);
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
            con.Open();
            string sql = "DELETE FROM tasks WHERE id ="+TaskData.TaskIndex+";";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Задание удалено", "Сообщение");

            manager.refreshTasks(con, tableTasks);

            con.Close();
        }

        //вкладка сотрудники
        private void addEmployee_Click(object sender, EventArgs e)
        {
            addEmployee addEmployee = new addEmployee();
            addEmployee.ShowDialog();
        }

        private void alterEmployee_Click(object sender, EventArgs e)
        {
            EmployeeData.EmployeeIndex = Convert.ToInt16(tableEmployee.CurrentRow.Cells[0].Value.ToString());
            EmployeeData.Surname = tableEmployee.CurrentRow.Cells[1].Value.ToString();
            EmployeeData.Shop = Convert.ToInt16(tableEmployee.CurrentRow.Cells[2].Value.ToString());
            EmployeeData.Salary = Convert.ToInt32(tableEmployee.CurrentRow.Cells[3].Value.ToString());

            alterEmployee alterEmployee = new alterEmployee();
            alterEmployee.ShowDialog();
        }
        private void deleteEmployee_Click(object sender, EventArgs e)
        {
            EmployeeData.EmployeeIndex = Convert.ToInt32(tableEmployee.CurrentRow.Cells[0].Value.ToString());
            con.Open();
            string sql = "DELETE FROM employees WHERE id ="+EmployeeData.EmployeeIndex+";";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Данные сотрудника удалены", "Сообщение");

            manager.refreshEmployee(con, tableEmployee);

            con.Close();
        }
        
        private void refreshEmployeeList_Click(object sender, EventArgs e)
        {
            con.Open();
            manager.refreshEmployee(con, tableEmployee);
            con.Close();
        }
        private void showAllEmployeeByShop_Click(object sender, EventArgs e)
        {
            if (shopToShow.Text != "")
            {
                int shop = Convert.ToInt16(shopToShow.Text);

                con.Open();
                string query = "SELECT id AS 'табельный номер', " +
                                            "surname AS 'фамилия', shop AS 'цех', " +
                                            "salary AS 'зарплата' FROM employees WHERE shop ='"+shop+"';";
                MySqlDataAdapter sqlData = new MySqlDataAdapter(query, con);
                DataTable table = new DataTable();
                sqlData.Fill(table);
                tableEmployee.DataSource = table;
                con.Close();
            }
            else
            {
                MessageBox.Show("Введите номер цеха", "Сообщение");
            }
        }
        private void deleteAllEmployeeByShop_Click(object sender, EventArgs e)
        {
            if (shopToDelete.Text != "")
            {
                int shop = Convert.ToInt16(shopToDelete.Text);

                con.Open();
                string query = "DELETE FROM employees WHERE shop ="+shop+"; ";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Сотрудники цеха "+shop+" удалены из таблицы", "Сообщение");

                manager.refreshEmployee(con, tableEmployee);
                con.Close();
            }
            else
            {
                MessageBox.Show("Введите номер цеха", "Сообщение");
            }
        }
        private void increaseSalary_Click(object sender, EventArgs e)
        {
            if (empId.Text != "" && percent.Text != "")
            {
                try
                {
                    con.Open();
                    int id = Convert.ToInt16(empId.Text);
                    int incPerc = Convert.ToInt16(percent.Text);
                    string sql = @"UPDATE employees SET salary = salary + salary *"+incPerc+"/100 WHERE id ="+id+";";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.ExecuteNonQuery();

                    manager.refreshEmployee(con, tableEmployee);
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("Сотрудника с введенным табельным номером не существует", "Сообщение");
                }
            }
            else
            {
                MessageBox.Show("Введите данные", "Сообщение");
            }
        }

        //вкладка зарплата
        private void getSumSalary_Click(object sender, EventArgs e)
        {
            if(shopSumSalary.Text != "")
            {
                try
                {
                    int shop = Convert.ToInt16(shopSumSalary.Text);

                    con.Open();
                    string query = "SELECT SUM(salary) FROM employees WHERE shop = "+shop+";";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    string sumSalary = cmd.ExecuteScalar().ToString() + " ₽";
                    showSumSalary.Text = sumSalary;
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("В данном цехе нет сотрудников", "Сообщение");
                }
            }            
        }
        private void getAverageSalary_Click(object sender, EventArgs e)
        {
            if (shopAverageSalary.Text != "")
            {
                try
                {
                    int shop = Convert.ToInt16(shopAverageSalary.Text);

                    con.Open();
                    string query = "Select round(sum(salary) / COUNT(salary), 0) from employees where shop = "+shop+";";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    string avgSalary = cmd.ExecuteScalar().ToString() + " ₽";
                    showAverageSalary.Text = avgSalary;
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("В данном цехе нет сотрудников", "Сообщение");
                }
            }
        }

        private void createPayrollBTN_Click(object sender, EventArgs e)
        {
            if (shopPayroll.Text != "" && monthPayroll.Text != "" && yearPayroll.Text !="")
            {
                string shop = shopPayroll.Text;
                string month = monthPayroll.Text;
                string year = yearPayroll.Text;
                string amount;
                con.Open();
                string query = "SELECT id, surname, salary FROM employees WHERE shop = "+shop+";";
                MySqlDataAdapter sqlData = new MySqlDataAdapter(query, con);
                DataTable table = new DataTable();
                sqlData.Fill(table);
                payroll.DataSource = table;

                string queryAmount = "SELECT SUM(salary) FROM employees WHERE shop = "+shop+";";
                MySqlCommand cmd = new MySqlCommand(queryAmount, con);
                amount = cmd.ExecuteScalar().ToString();
                con.Close();

                Excel.Application exApp = new Excel.Application();
                exApp.Workbooks.Open(@"C:\payRollData\payRollTemplate.xlsx");
                Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;
                wsh.Cells[9, 1] = "Цех № "+ shop;               
                wsh.Cells[13, 26] = year.Substring(2,2);               
                wsh.Cells[13, 58] = year.Substring(2, 2);
                switch (month)
                {
                    case "январь":
                        wsh.Cells[26, 50] = 1;
                        wsh.Cells[13, 10] = "января";
                        wsh.Cells[13, 42] = "января";
                        wsh.Cells[26, 85] = "01.01." + year;
                        wsh.Cells[26, 97] = "31.01." + year;
                        break;
                    case "февраль":
                        wsh.Cells[26, 50] = 2;
                        wsh.Cells[13, 10] = "февраля";
                        wsh.Cells[13, 42] = "февраля";
                        wsh.Cells[26, 85] = "01.02." + year;
                        wsh.Cells[26, 97] = "28.02." + year;
                        break;
                    case "март":
                        wsh.Cells[26, 50] = 3;//номер
                        wsh.Cells[13, 10] = "марта";//января
                        wsh.Cells[13, 42] = "марта";//января
                        wsh.Cells[26, 85] = "01.03." + year;//1
                        wsh.Cells[26, 97] = "31.03." + year;//31
                        break;
                    case "апрель":
                        wsh.Cells[26, 50] = 4;//номер
                        wsh.Cells[13, 10] = "апреля";//января
                        wsh.Cells[13, 42] = "апреля";//января
                        wsh.Cells[26, 85] = "01.04." + year;//1
                        wsh.Cells[26, 97] = "30.03." + year;//31
                        break;
                    case "май":
                        wsh.Cells[26, 50] = 5;//номер
                        wsh.Cells[13, 10] = "мая";//января
                        wsh.Cells[13, 42] = "мая";//января
                        wsh.Cells[26, 85] = "01.05." + year;//1
                        wsh.Cells[26, 97] = "31.05." + year;//31
                        break;
                    case "июнь":
                        wsh.Cells[26, 50] = 6;//номер
                        wsh.Cells[13, 10] = "июня";//января
                        wsh.Cells[13, 42] = "июня";//января
                        wsh.Cells[26, 85] = "01.06." + year;//1
                        wsh.Cells[26, 97] = "30.06." + year;//31
                        break;
                    case "июль":
                        wsh.Cells[26, 50] = 7;//номер
                        wsh.Cells[13, 10] = "июля";//января
                        wsh.Cells[13, 42] = "июля";//января
                        wsh.Cells[26, 85] = "01.07." + year;//1
                        wsh.Cells[26, 97] = "31.07." + year;//31
                        break;
                    case "август":
                        wsh.Cells[26, 50] = 8;//номер
                        wsh.Cells[13, 10] = "августа";//января
                        wsh.Cells[13, 42] = "августа";//января
                        wsh.Cells[26, 85] = "01.08." + year;//1
                        wsh.Cells[26, 97] = "31.08." + year;//31
                        break;
                    case "сентябрь":
                        wsh.Cells[26, 50] = 9;//номер
                        wsh.Cells[13, 10] = "сентября";//января
                        wsh.Cells[13, 42] = "сентября";//января
                        wsh.Cells[26, 85] = "01.09." + year;//1
                        wsh.Cells[26, 97] = "30.09." + year;//31
                        break;
                    case "октябрь":
                        wsh.Cells[26, 50] = 10;//номер
                        wsh.Cells[13, 10] = "октября";//января
                        wsh.Cells[13, 42] = "октября";//января
                        wsh.Cells[26, 85] = "01.10." + year;//1
                        wsh.Cells[26, 97] = "31.10." + year;//31
                        break;
                    case "ноябрь":
                        wsh.Cells[26, 50] = 11;//номер
                        wsh.Cells[13, 10] = "ноября";//января
                        wsh.Cells[13, 42] = "ноября";//января
                        wsh.Cells[26, 85] = "01.11." + year;//1
                        wsh.Cells[26, 97] = "30.11." + year;//31
                        break;
                    case "декабрь":
                        wsh.Cells[26, 50] = 12;//номер
                        wsh.Cells[13, 10] = "декабря";//января
                        wsh.Cells[13, 42] = "декабря";//января
                        wsh.Cells[26, 85] = "01.12." + year;//1
                        wsh.Cells[26, 97] = "30.12." + year;//31
                        break;
                }               
                wsh.Cells[26, 66] = DateTime.Now.ToString("dd.MM.yyyy");

                int i, j;
                for (i=0; i<payroll.RowCount-1; i++)
                {
                    wsh.Cells[i+31, 1] = i+1;
                    
                    for (j=0; j<payroll.ColumnCount; j++)
                    {
                        if (j==0)
                        {
                            wsh.Cells[i+31, j+10] = payroll[j, i].Value.ToString();
                        }
                        if (j==1)
                        {
                            wsh.Cells[i+31, j+21] = payroll[j, i].Value.ToString();
                        }
                        if (j==2)
                        {
                            wsh.Cells[i+31, j+56] = payroll[j, i].Value.ToString();
                        }
                        
                    }
                }
                wsh.Cells[76, 58] = amount;

                exApp.Visible = true;
            }
            
        }
    }
}