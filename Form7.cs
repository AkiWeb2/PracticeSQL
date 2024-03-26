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
    public partial class Form7 : Form
    {
        DB db = new DB();
        int select;
        public Form7()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            CreatColums();
            RefData(dataGridView1);
            Court();


        }
        private void Court()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pRUKDataSet.Court". При необходимости она может быть перемещена или удалена.
            this.courtTableAdapter.Fill(this.pRUKDataSet.Court);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pRUKDataSet.Investigator". При необходимости она может быть перемещена или удалена.
            this.investigatorTableAdapter.Fill(this.pRUKDataSet.Investigator);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pRUKDataSet.Victim". При необходимости она может быть перемещена или удалена.
            this.victimTableAdapter.Fill(this.pRUKDataSet.Victim);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pRUKDataSet.Defendant". При необходимости она может быть перемещена или удалена.
            this.defendantTableAdapter.Fill(this.pRUKDataSet.Defendant);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pRUKDataSet.Advocate". При необходимости она может быть перемещена или удалена.
            this.advocateTableAdapter.Fill(this.pRUKDataSet.Advocate);
        }
        private void CreatColums()
        {
            dataGridView1.Columns.Add("ID_CaseCourt", "ID");
            dataGridView1.Columns.Add("defandant", "Ответчик");
            dataGridView1.Columns.Add("victim", "Жертва");
            dataGridView1.Columns.Add("investigator", "Следователь");
            dataGridView1.Columns.Add("advocate", "Адвокат");
            dataGridView1.Columns.Add("court", "Суд");
            dataGridView1.Columns.Add("categories", "Категория дела");
            dataGridView1.Columns.Add("CategoriesOfConsideration", "Категория рассмотрения");
            dataGridView1.Columns.Add("IsNew", String.Empty);

        }
        private void ClearFild()
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            comboBox1.Text = " ";
            comboBox2.Text = " ";
            comboBox3.Text = " ";
            comboBox4.Text = " ";
            comboBox5.Text = " ";

        }
        private void ReatRows(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2), record.GetInt32(3), record.GetInt32(4), record.GetInt32(5), record.GetString(6), record.GetString(7), RowState.ModifindNew);
        }
        private void RefData(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string queru = $"select * from CaseCourt";

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
                string sql = "delete from CaseCourt where ID_CaseCourt =" + id;
                ExecSQL(sql);


                if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
                {
                    dataGridView1.Rows[index].Cells[4].Value = RowState.Deleted;
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
            var defandant = comboBox3.Text;
            var victim = comboBox2.Text;
            var investigator = comboBox4.Text;
            var advocate = comboBox1.Text;
            var court = comboBox5.Text;
            var categories = textBox2.Text;
            var CategoriesOfConsideration = textBox3.Text;

            if (dataGridView1.Rows[select].Cells[0].Value.ToString() != string.Empty)
            {

                dataGridView1.Rows[select].SetValues(ID,defandant,victim,investigator,advocate,court,categories,CategoriesOfConsideration);
                dataGridView1.Rows[select].Cells[8].Value = RowState.Modifind;

            }
        }
        private void UpdateBD()
        {
            try
            {
                db.open();
                for (int index = 0; index < dataGridView1.Rows.Count; index++)
                {
                    var row = (RowState)dataGridView1.Rows[index].Cells[8].Value;
                    if (row == RowState.Existed)
                    {
                        continue;
                    }

                    if (row == RowState.Modifind)
                    {
                        var ID = dataGridView1.Rows[index].Cells[0].Value.ToString();
                        var defandant = dataGridView1.Rows[index].Cells[1].Value.ToString();
                        var victim = dataGridView1.Rows[index].Cells[2].Value.ToString();
                        var investigator = dataGridView1.Rows[index].Cells[3].Value.ToString();
                        var advocate = dataGridView1.Rows[index].Cells[4].Value.ToString();

                        var court = dataGridView1.Rows[index].Cells[5].Value.ToString();
                        var categories = dataGridView1.Rows[index].Cells[6].Value.ToString();
                        var CategoriesOfConsideration = dataGridView1.Rows[index].Cells[7].Value.ToString();


                        var chenQ = $"update CaseCourt set defandant = '{defandant}',victim = '{victim}',investigator = '{investigator}', advocate = '{advocate}',court='{court}',categories = '{categories}',CategoriesOfConsideration = '{CategoriesOfConsideration}' where ID_CaseCourt = '{ID}'";

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
                
                var defandant = comboBox3.Text;
                var victim = comboBox2.Text;
                var investigator = comboBox4.Text;
                var advocate = comboBox1.Text;
                var court = comboBox5.Text;
                var categories = textBox2.Text;
                var Consideration = textBox3.Text;

                var addQ = $"insert into CaseCourt (defandant,victim,investigator,advocate,court,categories,CategoriesOfConsideration) values ('{defandant}', '{victim}','{investigator}','{advocate}','{court}','{categories}',{Consideration})";
                var com = new SqlCommand(addQ, db.GetConnection());
                com.ExecuteNonQuery();
                MessageBox.Show("Запись созданна");


                db.closed();
            }
            catch(Exception ex)
            {
                //MessageBox.Show("Ошибка! Убедитесь что поле ID пустое");
                MessageBox.Show(ex.Message);
                textBox1.Text = " ";
            }

        }
        private void serd(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string seard = $"select * from CaseCourt where concat(ID_CaseCourt) like '%" + textBox4.Text + "%' ";
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
            try
            {
                select = e.RowIndex;
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[select];
                    textBox1.Text = row.Cells[0].Value.ToString();
                    comboBox3.Text = row.Cells[1].Value.ToString();
                    comboBox2.Text = row.Cells[2].Value.ToString();
                    comboBox4.Text = row.Cells[3].Value.ToString();
                    comboBox1.Text = row.Cells[4].Value.ToString();
                    comboBox5.Text = row.Cells[5].Value.ToString();
                    textBox2.Text = row.Cells[6].Value.ToString();
                    textBox3.Text = row.Cells[7].Value.ToString();
                   

                }
            }
            catch (Exception ignore) { }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            NewFild();
            RefData(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deleted();
            ClearFild();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cen();
            ClearFild();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateBD();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RefData(dataGridView1);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            serd(dataGridView1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }
    }
}
