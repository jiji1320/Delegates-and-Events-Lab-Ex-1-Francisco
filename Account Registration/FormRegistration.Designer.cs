namespace Account_Registration
{
    partial class FormRegistration
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
            this.Studentn_label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Prog_label2 = new System.Windows.Forms.Label();
            this.Last_label3 = new System.Windows.Forms.Label();
            this.First_label4 = new System.Windows.Forms.Label();
            this.Middle_label5 = new System.Windows.Forms.Label();
            this.Age_label6 = new System.Windows.Forms.Label();
            this.Contactn_label7 = new System.Windows.Forms.Label();
            this.Address_label8 = new System.Windows.Forms.Label();
            this.student_txt = new System.Windows.Forms.TextBox();
            this.Lastn_textBox3 = new System.Windows.Forms.TextBox();
            this.First_textBox4 = new System.Windows.Forms.TextBox();
            this.Middlen_textBox5 = new System.Windows.Forms.TextBox();
            this.Age_textBox6 = new System.Windows.Forms.TextBox();
            this.Contactn_textBox7 = new System.Windows.Forms.TextBox();
            this.Adress_richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Next_button1 = new System.Windows.Forms.Button();
            this.program_comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Studentn_label1
            // 
            this.Studentn_label1.AutoSize = true;
            this.Studentn_label1.Location = new System.Drawing.Point(22, 27);
            this.Studentn_label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Studentn_label1.Name = "Studentn_label1";
            this.Studentn_label1.Size = new System.Drawing.Size(79, 16);
            this.Studentn_label1.TabIndex = 0;
            this.Studentn_label1.Text = "Student No.:";
            // 
            // Prog_label2
            // 
            this.Prog_label2.AutoSize = true;
            this.Prog_label2.Location = new System.Drawing.Point(254, 27);
            this.Prog_label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Prog_label2.Name = "Prog_label2";
            this.Prog_label2.Size = new System.Drawing.Size(62, 16);
            this.Prog_label2.TabIndex = 1;
            this.Prog_label2.Text = "Program:";
            this.Prog_label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Last_label3
            // 
            this.Last_label3.AutoSize = true;
            this.Last_label3.Location = new System.Drawing.Point(22, 87);
            this.Last_label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Last_label3.Name = "Last_label3";
            this.Last_label3.Size = new System.Drawing.Size(72, 16);
            this.Last_label3.TabIndex = 2;
            this.Last_label3.Text = "Last Name";
            // 
            // First_label4
            // 
            this.First_label4.AutoSize = true;
            this.First_label4.Location = new System.Drawing.Point(22, 142);
            this.First_label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.First_label4.Name = "First_label4";
            this.First_label4.Size = new System.Drawing.Size(72, 16);
            this.First_label4.TabIndex = 3;
            this.First_label4.Text = "First Name";
            // 
            // Middle_label5
            // 
            this.Middle_label5.AutoSize = true;
            this.Middle_label5.Location = new System.Drawing.Point(22, 198);
            this.Middle_label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Middle_label5.Name = "Middle_label5";
            this.Middle_label5.Size = new System.Drawing.Size(88, 16);
            this.Middle_label5.TabIndex = 4;
            this.Middle_label5.Text = "Middle Name";
            // 
            // Age_label6
            // 
            this.Age_label6.AutoSize = true;
            this.Age_label6.Location = new System.Drawing.Point(254, 87);
            this.Age_label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Age_label6.Name = "Age_label6";
            this.Age_label6.Size = new System.Drawing.Size(35, 16);
            this.Age_label6.TabIndex = 5;
            this.Age_label6.Text = "Age:";
            // 
            // Contactn_label7
            // 
            this.Contactn_label7.AutoSize = true;
            this.Contactn_label7.Location = new System.Drawing.Point(254, 142);
            this.Contactn_label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Contactn_label7.Name = "Contactn_label7";
            this.Contactn_label7.Size = new System.Drawing.Size(79, 16);
            this.Contactn_label7.TabIndex = 6;
            this.Contactn_label7.Text = "Contact No.:";
            this.Contactn_label7.Click += new System.EventHandler(this.Contactn_label7_Click);
            // 
            // Address_label8
            // 
            this.Address_label8.AutoSize = true;
            this.Address_label8.Location = new System.Drawing.Point(22, 254);
            this.Address_label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Address_label8.Name = "Address_label8";
            this.Address_label8.Size = new System.Drawing.Size(58, 16);
            this.Address_label8.TabIndex = 7;
            this.Address_label8.Text = "Address";
            // 
            // student_txt
            // 
            this.student_txt.Location = new System.Drawing.Point(25, 49);
            this.student_txt.Margin = new System.Windows.Forms.Padding(4);
            this.student_txt.Name = "student_txt";
            this.student_txt.Size = new System.Drawing.Size(168, 22);
            this.student_txt.TabIndex = 8;
            this.student_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Lastn_textBox3
            // 
            this.Lastn_textBox3.Location = new System.Drawing.Point(25, 107);
            this.Lastn_textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.Lastn_textBox3.Name = "Lastn_textBox3";
            this.Lastn_textBox3.Size = new System.Drawing.Size(168, 22);
            this.Lastn_textBox3.TabIndex = 10;
            this.Lastn_textBox3.TextChanged += new System.EventHandler(this.Lastn_textBox3_TextChanged);
            // 
            // First_textBox4
            // 
            this.First_textBox4.Location = new System.Drawing.Point(25, 162);
            this.First_textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.First_textBox4.Name = "First_textBox4";
            this.First_textBox4.Size = new System.Drawing.Size(168, 22);
            this.First_textBox4.TabIndex = 11;
            this.First_textBox4.TextChanged += new System.EventHandler(this.First_textBox4_TextChanged);
            // 
            // Middlen_textBox5
            // 
            this.Middlen_textBox5.Location = new System.Drawing.Point(25, 218);
            this.Middlen_textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.Middlen_textBox5.Name = "Middlen_textBox5";
            this.Middlen_textBox5.Size = new System.Drawing.Size(168, 22);
            this.Middlen_textBox5.TabIndex = 12;
            this.Middlen_textBox5.TextChanged += new System.EventHandler(this.Middlen_textBox5_TextChanged);
            // 
            // Age_textBox6
            // 
            this.Age_textBox6.Location = new System.Drawing.Point(257, 107);
            this.Age_textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.Age_textBox6.Name = "Age_textBox6";
            this.Age_textBox6.Size = new System.Drawing.Size(168, 22);
            this.Age_textBox6.TabIndex = 13;
            this.Age_textBox6.TextChanged += new System.EventHandler(this.Age_textBox6_TextChanged);
            // 
            // Contactn_textBox7
            // 
            this.Contactn_textBox7.Location = new System.Drawing.Point(257, 162);
            this.Contactn_textBox7.Margin = new System.Windows.Forms.Padding(4);
            this.Contactn_textBox7.Name = "Contactn_textBox7";
            this.Contactn_textBox7.Size = new System.Drawing.Size(168, 22);
            this.Contactn_textBox7.TabIndex = 14;
            this.Contactn_textBox7.TextChanged += new System.EventHandler(this.Contactn_textBox7_TextChanged);
            // 
            // Adress_richTextBox1
            // 
            this.Adress_richTextBox1.Location = new System.Drawing.Point(25, 274);
            this.Adress_richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.Adress_richTextBox1.Name = "Adress_richTextBox1";
            this.Adress_richTextBox1.Size = new System.Drawing.Size(415, 125);
            this.Adress_richTextBox1.TabIndex = 16;
            this.Adress_richTextBox1.Text = "";
            this.Adress_richTextBox1.TextChanged += new System.EventHandler(this.Adress_richTextBox1_TextChanged);
            // 
            // Next_button1
            // 
            this.Next_button1.Location = new System.Drawing.Point(165, 420);
            this.Next_button1.Margin = new System.Windows.Forms.Padding(4);
            this.Next_button1.Name = "Next_button1";
            this.Next_button1.Size = new System.Drawing.Size(151, 34);
            this.Next_button1.TabIndex = 17;
            this.Next_button1.Text = "Next";
            this.Next_button1.UseVisualStyleBackColor = true;
            this.Next_button1.Click += new System.EventHandler(this.Next_button1_Click);
            // 
            // program_comboBox1
            // 
            this.program_comboBox1.FormattingEnabled = true;
            this.program_comboBox1.Location = new System.Drawing.Point(257, 46);
            this.program_comboBox1.Name = "program_comboBox1";
            this.program_comboBox1.Size = new System.Drawing.Size(183, 24);
            this.program_comboBox1.TabIndex = 18;
            this.program_comboBox1.SelectedIndexChanged += new System.EventHandler(this.program_comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(476, 574);
            this.Controls.Add(this.program_comboBox1);
            this.Controls.Add(this.Next_button1);
            this.Controls.Add(this.Adress_richTextBox1);
            this.Controls.Add(this.Contactn_textBox7);
            this.Controls.Add(this.Age_textBox6);
            this.Controls.Add(this.Middlen_textBox5);
            this.Controls.Add(this.First_textBox4);
            this.Controls.Add(this.Lastn_textBox3);
            this.Controls.Add(this.student_txt);
            this.Controls.Add(this.Address_label8);
            this.Controls.Add(this.Contactn_label7);
            this.Controls.Add(this.Age_label6);
            this.Controls.Add(this.Middle_label5);
            this.Controls.Add(this.First_label4);
            this.Controls.Add(this.Last_label3);
            this.Controls.Add(this.Prog_label2);
            this.Controls.Add(this.Studentn_label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "FrmRegistration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Studentn_label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label Prog_label2;
        private System.Windows.Forms.Label Last_label3;
        private System.Windows.Forms.Label First_label4;
        private System.Windows.Forms.Label Middle_label5;
        private System.Windows.Forms.Label Age_label6;
        private System.Windows.Forms.Label Contactn_label7;
        private System.Windows.Forms.Label Address_label8;
        private System.Windows.Forms.TextBox student_txt;
        private System.Windows.Forms.TextBox Lastn_textBox3;
        private System.Windows.Forms.TextBox First_textBox4;
        private System.Windows.Forms.TextBox Middlen_textBox5;
        private System.Windows.Forms.TextBox Age_textBox6;
        private System.Windows.Forms.TextBox Contactn_textBox7;
        private System.Windows.Forms.RichTextBox Adress_richTextBox1;
        private System.Windows.Forms.Button Next_button1;
        private System.Windows.Forms.ComboBox program_comboBox1;
    }
}

