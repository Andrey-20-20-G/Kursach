using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Черновик
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Отмена_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Авторизация_Click(object sender, EventArgs e)
        {
            string LoginUser = textBox1.Text;
            string PasswordUser = textBox2.Text;
            DB db = new DB();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @uL AND `Password` = @uP", db.GetConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = LoginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = PasswordUser;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                    this.Hide();
                    var form2 = new Form2();
                    form2.Closed += (s, args) => this.Close();
                    form2.Show();
            }
            else
            {
                MessageBox.Show("Логин или пароль не совпадают. Попробуйте ввести данные еще раз");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form3 = new Form3();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }
    }
}
