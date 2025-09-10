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
            this.Age_label6 = new System.Windows.Forms.Label();
            this.Contactn_label7 = new System.Windows.Forms.Label();
            this.student_txt = new System.Windows.Forms.TextBox();
            this.Lastn_textBox3 = new System.Windows.Forms.TextBox();
            this.First_textBox4 = new System.Windows.Forms.TextBox();
            this.Age_textBox6 = new System.Windows.Forms.TextBox();
            this.Contactn_textBox7 = new System.Windows.Forms.TextBox();
            this.program_comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMiddleInitial = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Studentn_label1
            // 
            this.Studentn_label1.AutoSize = true;
            this.Studentn_label1.Location = new System.Drawing.Point(120, 114);
            this.Studentn_label1.Name = "Studentn_label1";
            this.Studentn_label1.Size = new System.Drawing.Size(64, 13);
            this.Studentn_label1.TabIndex = 0;
            this.Studentn_label1.Text = "Student No.";
            // 
            // Prog_label2
            // 
            this.Prog_label2.AutoSize = true;
            this.Prog_label2.Location = new System.Drawing.Point(353, 114);
            this.Prog_label2.Name = "Prog_label2";
            this.Prog_label2.Size = new System.Drawing.Size(46, 13);
            this.Prog_label2.TabIndex = 1;
            this.Prog_label2.Text = "Program";
            this.Prog_label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Last_label3
            // 
            this.Last_label3.AutoSize = true;
            this.Last_label3.Location = new System.Drawing.Point(120, 171);
            this.Last_label3.Name = "Last_label3";
            this.Last_label3.Size = new System.Drawing.Size(58, 13);
            this.Last_label3.TabIndex = 2;
            this.Last_label3.Text = "Last Name";
            // 
            // First_label4
            // 
            this.First_label4.AutoSize = true;
            this.First_label4.Location = new System.Drawing.Point(353, 171);
            this.First_label4.Name = "First_label4";
            this.First_label4.Size = new System.Drawing.Size(57, 13);
            this.First_label4.TabIndex = 3;
            this.First_label4.Text = "First Name";
            // 
            // Age_label6
            // 
            this.Age_label6.AutoSize = true;
            this.Age_label6.Location = new System.Drawing.Point(149, 221);
            this.Age_label6.Name = "Age_label6";
            this.Age_label6.Size = new System.Drawing.Size(29, 13);
            this.Age_label6.TabIndex = 5;
            this.Age_label6.Text = "Age:";
            // 
            // Contactn_label7
            // 
            this.Contactn_label7.AutoSize = true;
            this.Contactn_label7.Location = new System.Drawing.Point(404, 275);
            this.Contactn_label7.Name = "Contactn_label7";
            this.Contactn_label7.Size = new System.Drawing.Size(67, 13);
            this.Contactn_label7.TabIndex = 6;
            this.Contactn_label7.Text = "Contact No.:";
            this.Contactn_label7.Click += new System.EventHandler(this.Contactn_label7_Click);
            // 
            // student_txt
            // 
            this.student_txt.Location = new System.Drawing.Point(193, 111);
            this.student_txt.Name = "student_txt";
            this.student_txt.Size = new System.Drawing.Size(127, 20);
            this.student_txt.TabIndex = 8;
            this.student_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Lastn_textBox3
            // 
            this.Lastn_textBox3.Location = new System.Drawing.Point(193, 168);
            this.Lastn_textBox3.Name = "Lastn_textBox3";
            this.Lastn_textBox3.Size = new System.Drawing.Size(127, 20);
            this.Lastn_textBox3.TabIndex = 10;
            this.Lastn_textBox3.TextChanged += new System.EventHandler(this.Lastn_textBox3_TextChanged);
            // 
            // First_textBox4
            // 
            this.First_textBox4.Location = new System.Drawing.Point(419, 168);
            this.First_textBox4.Name = "First_textBox4";
            this.First_textBox4.Size = new System.Drawing.Size(127, 20);
            this.First_textBox4.TabIndex = 11;
            this.First_textBox4.TextChanged += new System.EventHandler(this.First_textBox4_TextChanged);
            // 
            // Age_textBox6
            // 
            this.Age_textBox6.Location = new System.Drawing.Point(193, 218);
            this.Age_textBox6.Name = "Age_textBox6";
            this.Age_textBox6.Size = new System.Drawing.Size(127, 20);
            this.Age_textBox6.TabIndex = 13;
            this.Age_textBox6.TextChanged += new System.EventHandler(this.Age_textBox6_TextChanged);
            // 
            // Contactn_textBox7
            // 
            this.Contactn_textBox7.Location = new System.Drawing.Point(477, 272);
            this.Contactn_textBox7.Name = "Contactn_textBox7";
            this.Contactn_textBox7.Size = new System.Drawing.Size(127, 20);
            this.Contactn_textBox7.TabIndex = 14;
            this.Contactn_textBox7.TextChanged += new System.EventHandler(this.Contactn_textBox7_TextChanged);
            // 
            // program_comboBox1
            // 
            this.program_comboBox1.FormattingEnabled = true;
            this.program_comboBox1.Location = new System.Drawing.Point(407, 110);
            this.program_comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.program_comboBox1.Name = "program_comboBox1";
            this.program_comboBox1.Size = new System.Drawing.Size(223, 21);
            this.program_comboBox1.TabIndex = 18;
            this.program_comboBox1.SelectedIndexChanged += new System.EventHandler(this.program_comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 39);
            this.label1.TabIndex = 19;
            this.label1.Text = "Registration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Birthday";
            // 
            // datePickerBirthday
            // 
            this.datePickerBirthday.Location = new System.Drawing.Point(184, 272);
            this.datePickerBirthday.Name = "datePickerBirthday";
            this.datePickerBirthday.Size = new System.Drawing.Size(181, 20);
            this.datePickerBirthday.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Gender:";
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(419, 221);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(104, 21);
            this.cbGender.TabIndex = 23;
            this.cbGender.SelectedIndexChanged += new System.EventHandler(this.cbGender_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(576, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "M.I.";
            // 
            // txtMiddleInitial
            // 
            this.txtMiddleInitial.Location = new System.Drawing.Point(607, 168);
            this.txtMiddleInitial.Name = "txtMiddleInitial";
            this.txtMiddleInitial.Size = new System.Drawing.Size(92, 20);
            this.txtMiddleInitial.TabIndex = 25;
            this.txtMiddleInitial.TextChanged += new System.EventHandler(this.txtMiddleInitial_TextChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(356, 344);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 26;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(839, 404);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtMiddleInitial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datePickerBirthday);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.program_comboBox1);
            this.Controls.Add(this.Contactn_textBox7);
            this.Controls.Add(this.Age_textBox6);
            this.Controls.Add(this.First_textBox4);
            this.Controls.Add(this.Lastn_textBox3);
            this.Controls.Add(this.student_txt);
            this.Controls.Add(this.Contactn_label7);
            this.Controls.Add(this.Age_label6);
            this.Controls.Add(this.First_label4);
            this.Controls.Add(this.Last_label3);
            this.Controls.Add(this.Prog_label2);
            this.Controls.Add(this.Studentn_label1);
            this.Name = "FormRegistration";
            this.Text = "FrmRegistration";
            this.Load += new System.EventHandler(this.FormRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Studentn_label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label Prog_label2;
        private System.Windows.Forms.Label Last_label3;
        private System.Windows.Forms.Label First_label4;
        private System.Windows.Forms.Label Age_label6;
        private System.Windows.Forms.Label Contactn_label7;
        private System.Windows.Forms.TextBox student_txt;
        private System.Windows.Forms.TextBox Lastn_textBox3;
        private System.Windows.Forms.TextBox First_textBox4;
        private System.Windows.Forms.TextBox Age_textBox6;
        private System.Windows.Forms.TextBox Contactn_textBox7;
        private System.Windows.Forms.ComboBox program_comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datePickerBirthday;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMiddleInitial;
        private System.Windows.Forms.Button btnRegister;
    }
}

