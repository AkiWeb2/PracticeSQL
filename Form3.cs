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
    public partial class Form3 : Form
    {
        DB db = new DB();
        int select;
        public Form3()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            CreatColums();
            RefData(dataGridView1);
        }
        private void CreatColums()
        {
            dataGridView1.Columns.Add("ID_Court", "ID");
            dataGridView1.Columns.Add("NameCourt", "Название суда");
            dataGridView1.Columns.Add("PhoneCourt", "Номер телефона");
            dataGridView1.Columns.Add("IsNew", String.Empty);

        }
        private void ClearFild()
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
        }
        private void ReatRows(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), RowState.ModifindNew);
        }
        private void RefData(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string queru = $"select * from Court";

            SqlCommand com = new SqlCommand(queru, db.GetConnection());

            db.open();

            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ReatRows(dgv, read);
            }
            read.Close();
        }
        void ExecSQL(string sql)
        {
            db.open();
            var com = new SqlCommand(sql, db.GetConnection());
            com.CommandText = sql;
            com.ExecuteNonQuery();
            db.closed();
        }

        private void Deleted()
        {
            try
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows[index].Visible = false;
                string Message = "Вы точно хотите удалить запись";

                if (MessageBox.Show(Message, "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }
                var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                string sql = "delete from Court where ID_Court =" + id;
                ExecSQL(sql);


                if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
                {
                    dataGridView1.Rows[index].Cells[2].Value = RowState.Deleted;
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Не выделена строчка");
            }

        }

     
        private void Cen()
        {
            var select = dataGridView1.CurrentCell.RowIndex;
            var ID = textBox1.Text;
            var NameCourt = textBox2.Text;
            var Phone = textBox3.Text;


            if (dataGridView1.Rows[select].Cells[0].Value.ToString() != string.Empty)
            {

                dataGridView1.Rows[select].SetValues(ID, NameCourt, Phone);
                dataGridView1.Rows[select].Cells[3].Value = RowState.Modifind;

            }
        }
    
        private void UpdateBD()
        {
            try
            {
                db.open();
                for (int index = 0; index < dataGridView1.Rows.Count; index++)
                {
                    var row = (RowState)dataGridView1.Rows[index].Cells[3].Value;
                    if (row == RowState.Existed)
                    {
                        continue;
                    }

                    if (row == RowState.Modifind)
                    {
                        var ID = dataGridView1.Rows[index].Cells[0].Value.ToString();
                        var Name = dataGridView1.Rows[index].Cells[1].Value.ToString();
                        var Phone = dataGridView1.Rows[index].Cells[2].Value.ToString();

                        var chenQ = $"update Court set NameCourt = '{Name}', PhoneCourt = '{Phone}' where ID_Court = '{ID}'";

                        var com = new SqlCommand(chenQ, db.GetConnection());
                        com.ExecuteNonQuery();
                    }
                }
                db.closed();
            }
            catch (Exception ignored) { }

        }
    
        private void NewFild()
        {
            try
            {
                db.open();

                var NameCourt = textBox2.Text;
                var Phone = textBox3.Text;
                var addQ = $"insert into Court (NameCourt, PhoneCourt) values ('{NameCourt}', '{Phone}')";
                var com = new SqlCommand(addQ, db.GetConnection());
                com.ExecuteNonQuery();
                MessageBox.Show("Запись созданна");


                db.closed();
            }
            catch
            {
                MessageBox.Show("Ошибка! Убедитесь что поле ID пустое");
                textBox1.Text = " ";
            }

        }
     

        private void serd(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string seard = $"select * from Court where concat(ID_Court, NameCourt, PhoneCourt) like '%" + textBox4.Text + "%' ";
            SqlCommand command = new SqlCommand(seard, db.GetConnection());
            db.open();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReatRows(dgv, reader);
            }

            db.closed();
        }
     

       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            select = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[select];
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();

            }
        }

    

        private void button1_Click_1(object sender, EventArgs e)
        {
            Deleted();
            ClearFild();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Cen();
            ClearFild();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            UpdateBD();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
           
            NewFild();
            RefData(dataGridView1);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            RefData(dataGridView1);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            serd(dataGridView1);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
           
            this.Close();
            
        }
    }
}
