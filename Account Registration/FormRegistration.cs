using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Account_Registration
{
    public partial class FormRegistration : Form
    {
        
        public FormRegistration()
        {
            InitializeComponent();

         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Next_button1_Click(object sender, EventArgs e)
        {
            StudentInfoClass.Program = program_comboBox1.Text.ToString();
            StudentInfoClass.FirstName = First_textBox4.Text.ToString();
            StudentInfoClass.LastName = Lastn_textBox3.Text.ToString();
            StudentInfoClass.MiddleName = Middlen_textBox5.Text.ToString();
            StudentInfoClass.Address = Adress_richTextBox1.Text.ToString();
            StudentInfoClass.StudentNo = long.Parse(student_txt.Text);
            StudentInfoClass.Age = long.Parse(Age_textBox6.Text);
            StudentInfoClass.ContactNo = long.Parse(Contactn_textBox7.Text);
            

            FrmConfirm confirm = new FrmConfirm();
            if (confirm.ShowDialog() == DialogResult.OK) {
                First_textBox4.Clear();
                Lastn_textBox3.Clear();
                Middlen_textBox5.Clear();
                Adress_richTextBox1.Clear();
                student_txt.Clear();
                Age_textBox6.Clear();
                Contactn_textBox7.Clear();
                program_comboBox1.SelectedIndex = -1;
                    
                    
             }

            
              
        }


        private void program_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Lastn_textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void First_textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Middlen_textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Age_textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Contactn_textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Adress_richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Contactn_label7_Click(object sender, EventArgs e)
        {

        }

        private void FormRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}
