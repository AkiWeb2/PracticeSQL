using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTIC
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
            Form1 form1 = new Form1();
            this.Close();
            form1.Show();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form1 = new Form2();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form1 = new Form3();
            
            form1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form1 = new Form4();
            
            form1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form5 form1 = new Form5();
            
            form1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 form1 = new Form6();
            
            form1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 form1 = new Form7();
            
            form1.Show();
        }
    }
}
