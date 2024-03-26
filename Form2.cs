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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PRACTIC
{
    enum RowState
    {
        Existed,
        New,
        Modifind,
        ModifindNew,
        Deleted,

    }
    public partial class Form2 : Form
    {
     
        DB db = new DB();
        int select;
        public Form2()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CreatColums();
            RefData(dataGridView1);
        }
        private void CreatColums()
        {
            dataGridView1.Columns.Add("ID_Advocate", "ID");
            dataGridView1.Columns.Add("FIO", "ФИО адвоката");
            dataGridView1.Columns.Add("Phone", "Номер телефона");
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

            string queru = $"select * from Advocate";

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
                string sql = "delete from Advocate where ID_Advocate =" + id;
                ExecSQL(sql);


                if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
                {
                    dataGridView1.Rows[index].Cells[2].Value = RowState.Deleted;
                    return;
                }
            }
            catch {
                MessageBox.Show("Не выделена строчка");
            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deleted();
            ClearFild();
        }
        private void Cen()
        {
            var select = dataGridView1.CurrentCell.RowIndex;
            var ID = textBox1.Text;
            var FIO = textBox2.Text;
            var Phone = textBox3.Text;


            if (dataGridView1.Rows[select].Cells[0].Value.ToString() != string.Empty)
            {

                dataGridView1.Rows[select].SetValues(ID, FIO, Phone);
                dataGridView1.Rows[select].Cells[3].Value = RowState.Modifind;

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Cen();
            ClearFild();
            
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
                        var FIO = dataGridView1.Rows[index].Cells[1].Value.ToString();
                        var Phone = dataGridView1.Rows[index].Cells[2].Value.ToString();

                        var chenQ = $"update Advocate set FIO = '{FIO}', Phone = '{Phone}' where ID_Advocate = '{ID}'";

                        var com = new SqlCommand(chenQ, db.GetConnection());
                        com.ExecuteNonQuery();
                    }
                }
                db.closed();
            }
            catch (Exception ignored) { }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            UpdateBD();
        }
        private void NewFild()
        {
            try
            {
                db.open();

                var FIO = textBox2.Text;
                var Phone = textBox3.Text;
                var addQ = $"insert into Advocate (FIO, Phone) values ('{FIO}', '{Phone}')";
                var com = new SqlCommand(addQ, db.GetConnection());
                com.ExecuteNonQuery();
                MessageBox.Show("Запись созданна");


                db.closed();
            }catch
            {
                MessageBox.Show("Ошибка! Убедитесь что поле ID пустое");
                textBox1.Text = " ";
            }
        
        }
        private void button4_Click(object sender, EventArgs e)
        {
            NewFild();
            RefData(dataGridView1);
        }

        private void serd(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string seard = $"select * from Advocate where concat(ID_Advocate, FIO, Phone) like '%" + textBox4.Text + "%' ";
            SqlCommand command = new SqlCommand(seard, db.GetConnection());
            db.open();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReatRows(dgv, reader);
            }

            db.closed();
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            serd(dataGridView1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RefData(dataGridView1);
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

        private void button5_Click(object sender, EventArgs e)
        {
           
            this.Close();
            
        }
    }
}
