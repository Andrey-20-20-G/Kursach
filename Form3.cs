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

namespace Черновик
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }  

        private void Регистрация_Click_1(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            bool nextStep=false;
            MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM users WHERE Login = @login", db.GetConnection());
            sqlCommand.Parameters.AddWithValue("Login", Login.Text);
            MySqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.HasRows)
            {
                Login.BackColor = Color.LightCoral;
                MessageBox.Show("Этот логин уже занят. Попробуйте придумать другой логин");
                reader.Close();
            }
            else
            {
                reader.Close();
                if (Email.Text.Length >= 8 && Email.Text.Contains("@") && Email.Text.Contains(".") && Password.Text.Length >= 4 && Login.Text.Length >= 4)
                {    
                    nextStep = true;
                }
                else
                {
                    Email.BackColor = Color.LightCoral;
                    Login.BackColor = Color.LightCoral;
                    Password.BackColor = Color.LightCoral;
                    MessageBox.Show("Что-то введено неверно, проверьте ввод");
                }
            }
            if(nextStep == true)
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`Email`, `Login`, `Password`) VALUES (@email, @login, @password)", db.GetConnection());

            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = Email.Text;
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = Login.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = Password.Text;


            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Поздравляю!!! У вас есть аккаунт");
            else
                MessageBox.Show("Проверьте правильность введенных данных");


            db.closeConnection();
            Form2 form = new Form2(); this.Hide(); form.Closed += (s, args) => this.Close();
                form.Show(); 
            }
            
        }
        private void Отмена_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }
    }
}
