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
using System.Threading;
using System.Threading.Tasks;
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
        connection con = new connection();
        private void authoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (loginField.Text != "" && passwordField.Text != "")
                {
                    con.Open();
                    string query = "SELECT user_name, pass_word FROM users WHERE user_name ='" + loginField.Text + "' AND pass_word ='" + passwordField.Text + "'";
                    MySqlDataReader row;
                    row = con.ExecuteReader(query);
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
                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Пустое поле логин или пароль", "Сообщение");
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
