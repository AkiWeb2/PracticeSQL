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
    public partial class Form10 : Form
    {
        public Form10()
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

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 form1 = new Form7();

            form1.Show();
        }
    }
}
