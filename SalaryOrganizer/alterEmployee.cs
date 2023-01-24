using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace SalaryOrganizer
{
    public partial class alterEmployee : MaterialForm
    {
        public alterEmployee()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
        }

        static string conStr = "server=localhost;Database=salary_organizer;" +
                                "User ID=root;Password=Strongpassword1234";
        MySqlConnection con = new MySqlConnection(conStr);
        private void alterEmployee_Load(object sender, EventArgs e)
        {
            surnameToAlter.Text = EmployeeData.Surname;
            shopToAlter.Text = EmployeeData.Shop.ToString();
        }
        private void cancelAlterEmployee_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void alterEmployeeBtn_Click(object sender, EventArgs e)
        {

            if (surnameToAlter.Text != "" && shopToAlter.Text != "")
            {
                try
                {
                    string surname = surnameToAlter.Text;
                    int shop = Convert.ToInt16(shopToAlter.Text);
                    con.Open();

                    string sql = "UPDATE employees " +
                                 "SET surname ='"+surname+"', shop ='"+shop+"'" +
                                 "WHERE id ="+EmployeeData.EmployeeIndex+";";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Данные сотрудника изменены", "Сообщение");
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