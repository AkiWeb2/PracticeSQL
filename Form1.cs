using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTIC
{
    public partial class Form1 : Form
    {
        DB db = new DB();
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var logUser = LoginBox.Text;
            var pasUser = PasswordBox.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable Table = new DataTable();

            string query = $"select * from register where Login = '{logUser}' and PasswordReg = '{pasUser}'";

            SqlCommand con = new SqlCommand(query, db.GetConnection());
            adapter.SelectCommand = con;
            adapter.Fill(Table);
            string[] mas = { "Admin", "Sled","Dello" };
            if (Table.Rows.Count == 1 && mas[0] == logUser)
            {
                Form8 form = new Form8();
                this.Hide();
                form.ShowDialog();
            }
            if (Table.Rows.Count == 1 && mas[1] == logUser)
            {
                Form9 form = new Form9();
                this.Hide();
                form.ShowDialog();
            }
            if (Table.Rows.Count == 1 && mas[2] == logUser)
            {
                Form10 form = new Form10();
                this.Hide();
                form.ShowDialog();
            }
        }

        private void LoginBox_TextChanged(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            LoginBox.MaxLength = 50;
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            PasswordBox.PasswordChar = '*';
            LoginBox.MaxLength = 50;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PasswordBox.UseSystemPasswordChar = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PasswordBox.UseSystemPasswordChar = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
