using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms;
namespace WinFormsApp1
{


    public partial class RegisterForm : Form
    {

        public RegisterForm()
        {
            InitializeComponent();
        }


        private void Close_Button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        Point lastPoint;

        private void MainPanel_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MainPanel_MouseDown_1(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void ButtonRegist_Click(object sender, EventArgs e)
        {
            if (LoginField1.Text == "")
            {
                MessageBox.Show("Введите логин!");
                return;
            }
            if (PassField1.Text ==  "" )
            {
                MessageBox.Show("Введите пароль!");
                return;
            }
            if(CheckUser())
            {
                return;
            }
        
            DB db = new DB();
            
            MySqlCommand command = new MySqlCommand("INSERT INTO `people` (login, pass) VALUES(@ul, @up)", db.GetConnection());
            
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = LoginField1;
            command.Parameters.Add("@up", MySqlDbType.VarChar).Value = PassField1;
            db.OpenConnection();

          
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан!");
            }
            else
            {
                MessageBox.Show("Аккаунт не был создан!");
            }



            db.CloseConnection();
        }

        public Boolean CheckUser()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `people` WHERE `login` = @ul", db.GetConnection());
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = LoginField1.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже существует!");
                return true;
            }
            else
            {
                return false;
            }

        }
}
}

