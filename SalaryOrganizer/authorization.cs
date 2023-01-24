
using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Threading;
using System.Windows.Forms;

namespace SalaryOrganizer
{
    public partial class authorization : MaterialForm
    {

        Thread authToMain;
        public authorization()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
        }
        static string conStr = "server=localhost;Database=salary_organizer;" +
                                "User ID=root;Password=Strongpassword1234";
        MySqlConnection con = new MySqlConnection(conStr);
        private void authoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (loginField.Text != "" && passwordField.Text != "")
                {
                    con.Open();
                    string query = "SELECT user_name, pass_word FROM users WHERE user_name ='" + loginField.Text + "' AND pass_word ='" + passwordField.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader row = cmd.ExecuteReader();
                    if (row.HasRows)
                    {
                        this.Close();
                        authToMain = new Thread(openMain);
                        authToMain.SetApartmentState(ApartmentState.STA);
                        authToMain.Start();
                    }
                    else
                    {
                        MessageBox.Show("Пользователь не найден", "Сообщение");
                        loginField.Text = "";
                        passwordField.Text = "";

                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Пустое поле логин или пароль", "Сообщение");
                    loginField.Text = "";
                    passwordField.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Ошибка соединения", "Сообщение");
            }
        }       
        public void openMain(object obj)
        {
            Application.Run(new Form1());
        }
    }
}
