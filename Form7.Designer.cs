namespace PRACTIC
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.advocateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRUKDataSet = new PRACTIC.PRUKDataSet();
            this.advocateTableAdapter = new PRACTIC.PRUKDataSetTableAdapters.AdvocateTableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.defendantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.victimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.investigatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.courtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.defendantTableAdapter = new PRACTIC.PRUKDataSetTableAdapters.DefendantTableAdapter();
            this.victimTableAdapter = new PRACTIC.PRUKDataSetTableAdapters.VictimTableAdapter();
            this.investigatorTableAdapter = new PRACTIC.PRUKDataSetTableAdapters.InvestigatorTableAdapter();
            this.courtTableAdapter = new PRACTIC.PRUKDataSetTableAdapters.CourtTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.advocateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRUKDataSet)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defendantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.victimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.investigatorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courtBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.advocateBindingSource, "ID_Advocate", true));
            this.comboBox1.DataSource = this.advocateBindingSource;
            this.comboBox1.DisplayMember = "ID_Advocate";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(639, 184);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "ID_Advocate";
            // 
            // advocateBindingSource
            // 
            this.advocateBindingSource.DataMember = "Advocate";
            this.advocateBindingSource.DataSource = this.pRUKDataSet;
            // 
            // pRUKDataSet
            // 
            this.pRUKDataSet.DataSetName = "PRUKDataSet";
            this.pRUKDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // advocateTableAdapter
            // 
            this.advocateTableAdapter.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(380, 335);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(147, 23);
            this.button6.TabIndex = 98;
            this.button6.Text = "Обновление Таблицы";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(685, 335);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 97;
            this.button5.Text = "Выход";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 96;
            this.label4.Text = "Поиск";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(443, 15);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 95;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(377, 121);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(103, 125);
            this.flowLayoutPanel1.TabIndex = 94;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Удаление";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 90);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Новая запись";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(503, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 93;
            this.label3.Text = "Категория рассмотрения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(514, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 92;
            this.label2.Text = "Кадегория дела";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(531, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 91;
            this.label1.Text = "ID";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(645, 266);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(115, 20);
            this.textBox3.TabIndex = 90;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(623, 240);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(137, 20);
            this.textBox2.TabIndex = 89;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(719, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(41, 20);
            this.textBox1.TabIndex = 88;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(356, 341);
            this.dataGridView1.TabIndex = 87;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(534, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 99;
            this.label5.Text = "Адвокат";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.defendantBindingSource, "ID_Defandant", true));
            this.comboBox2.DataSource = this.defendantBindingSource;
            this.comboBox2.DisplayMember = "ID_Defandant";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(639, 126);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 100;
            this.comboBox2.ValueMember = "ID_Defandant";
            // 
            // defendantBindingSource
            // 
            this.defendantBindingSource.DataMember = "Defendant";
            this.defendantBindingSource.DataSource = this.pRUKDataSet;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.victimBindingSource, "ID_Victim", true));
            this.comboBox3.DataSource = this.victimBindingSource;
            this.comboBox3.DisplayMember = "ID_Victim";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(639, 102);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 101;
            this.comboBox3.ValueMember = "ID_Victim";
            // 
            // victimBindingSource
            // 
            this.victimBindingSource.DataMember = "Victim";
            this.victimBindingSource.DataSource = this.pRUKDataSet;
            // 
            // comboBox4
            // 
            this.comboBox4.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.investigatorBindingSource, "ID_Investigator", true));
            this.comboBox4.DataSource = this.investigatorBindingSource;
            this.comboBox4.DisplayMember = "ID_Investigator";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(639, 153);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 102;
            this.comboBox4.ValueMember = "ID_Investigator";
            // 
            // investigatorBindingSource
            // 
            this.investigatorBindingSource.DataMember = "Investigator";
            this.investigatorBindingSource.DataSource = this.pRUKDataSet;
            // 
            // comboBox5
            // 
            this.comboBox5.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.courtBindingSource, "ID_Court", true));
            this.comboBox5.DataSource = this.courtBindingSource;
            this.comboBox5.DisplayMember = "ID_Court";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(639, 213);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 103;
            this.comboBox5.ValueMember = "ID_Court";
            // 
            // courtBindingSource
            // 
            this.courtBindingSource.DataMember = "Court";
            this.courtBindingSource.DataSource = this.pRUKDataSet;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(534, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 104;
            this.label6.Text = "Ответчик";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(534, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 105;
            this.label7.Text = "Жертва";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(534, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 106;
            this.label8.Text = "Следователь";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(534, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 107;
            this.label9.Text = "Суд";
            // 
            // defendantTableAdapter
            // 
            this.defendantTableAdapter.ClearBeforeFill = true;
            // 
            // victimTableAdapter
            // 
            this.victimTableAdapter.ClearBeforeFill = true;
            // 
            // investigatorTableAdapter
            // 
            this.investigatorTableAdapter.ClearBeforeFill = true;
            // 
            // courtTableAdapter
            // 
            this.courtTableAdapter.ClearBeforeFill = true;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 382);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form7";
            this.Text = "Состояние дела";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.advocateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRUKDataSet)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defendantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.victimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.investigatorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courtBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private PRUKDataSet pRUKDataSet;
        private System.Windows.Forms.BindingSource advocateBindingSource;
        private PRUKDataSetTableAdapters.AdvocateTableAdapter advocateTableAdapter;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource defendantBindingSource;
        private PRUKDataSetTableAdapters.DefendantTableAdapter defendantTableAdapter;
        private System.Windows.Forms.BindingSource victimBindingSource;
        private PRUKDataSetTableAdapters.VictimTableAdapter victimTableAdapter;
        private System.Windows.Forms.BindingSource investigatorBindingSource;
        private PRUKDataSetTableAdapters.InvestigatorTableAdapter investigatorTableAdapter;
        private System.Windows.Forms.BindingSource courtBindingSource;
        private PRUKDataSetTableAdapters.CourtTableAdapter courtTableAdapter;
    }
}