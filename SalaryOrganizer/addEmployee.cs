using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace SalaryOrganizer
{
    public partial class addEmployee : MaterialForm
    {
        public addEmployee()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
        }

        static string conStr = "server=localhost;Database=salary_organizer;" +
                                "User ID=root;Password=Strongpassword1234";
        MySqlConnection con = new MySqlConnection(conStr);

        private void caancelAddEmployee_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void addEmployeeBtn_Click(object sender, EventArgs e)
        {
            string surname;
            int shop, salary;
            if (newEmpSurname.Text != "" && newEmpShop.Text != "" && newEmpSalary.Text != "")
            { 
                try
                {
                    con.Open();
                    surname = newEmpSurname.Text;
                    shop = Convert.ToInt16(newEmpShop.Text);
                    salary = Convert.ToInt32(newEmpSalary.Text);

                    string sql = "INSERT INTO employees (surname, shop, salary) " +
                                 "VALUE('"+surname+"', '"+shop+"', '"+salary+"');";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Задание добавлено", "Сообщение");

                    newEmpSurname.Text = "";
                    newEmpShop.Text = "";
                    newEmpSalary.Text = "";

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