using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Account_Registration
{
    public partial class FormRegistration : Form
    {
        private object cbPrograms;
        private string fullName;
        private int _age;
        private long _contactNo;
        private long _studentNo;
        private string _contactNoDisplay;
        public FormRegistration()
        {
            InitializeComponent();
            Contactn_textBox7.Text = "+63";

         
        }
        public string FullName(string lastName, string firstName, string middleInitial)
        {
            if (Regex.IsMatch(lastName, "[a-zA-Z]+") && Regex.IsMatch(firstName, "[a-zA-Z]+") && Regex.IsMatch(middleInitial, "[a-zA-Z]+"))
            {
                return lastName + ", " + firstName + ", " + middleInitial;
            }
            else
            {

                throw new ArgumentNullException();
            }
        }

        public long StudentNumber(string studentNo)
        {
            if (Regex.IsMatch(studentNo, "[0-9]{11}"))
            {
                long result;
                if (long.TryParse(studentNo, out result))
                {
                    _studentNo = result;
                    return _studentNo;
                }
                else
                {
                    throw new FormatException();
                }
            }
            else
            {

                throw new ArgumentNullException();
            }
        }
        public int Age(string age)
        {
            if (Regex.IsMatch(age, "[0-9]{1,3}"))
            {
                int result;
                if (int.TryParse(age, out result))
                {
                    if (result > 0 && result < 150)
                    {
                        _age = result;
                        return _age;
                    }
                    else
                    {

                        throw new IndexOutOfRangeException();
                    }
                }
                else
                {

                    throw new FormatException();
                }
            }
            else
            {

                throw new ArgumentNullException();
            }
        }

        public long ContactNo(string contactNo)
        {
            _contactNoDisplay = contactNo;

            if (contactNo.StartsWith("+63"))
            {
                contactNo = contactNo.Substring(3);
            }

            if (Regex.IsMatch(contactNo, @"^[0-9]{10}$"))
            {
                long result;
                if (long.TryParse(contactNo, out result))
                {
                    _contactNo = result;
                    if (contactNo.Length > 10)
                    {

                        throw new OverflowException();
                    }
                    else
                    {
                        return _contactNo;
                    }
                }
                else
                {

                    throw new FormatException();
                }
            }
            else
            {

                throw new ArgumentNullException();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Next_button1_Click(object sender, EventArgs e)
        {
               
        }


        private void program_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[]
   {
            "BS Information Technology",
            "BS Computer Science",
            "BS Information Systems",
            "BS in Accountancy",
            "BS in Hospitality Management",
            "BS in Tourism Management"
   };

            for (int i = 0; i < 6; i++)
            {
                program_comboBox1.Items.Add(ListOfProgram[i].ToString());
            }
            string[] ListOfGender = new string[]
       {
            "Male",
            "Female",

       };

            for (int i = 0; i < ListOfGender.Length; i++)
            {
                cbGender.Items.Add(ListOfGender[i].ToString());
            }
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

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMiddleInitial_TextChanged(object sender, EventArgs e)
        {
        }    
        private void btnRegister_Click(object sender, EventArgs e)
        {
            StudentInfoClass.Program = program_comboBox1.Text.ToString();
            StudentInfoClass.FirstName = First_textBox4.Text.ToString();
            StudentInfoClass.LastName = Lastn_textBox3.Text.ToString();
            StudentInfoClass.MI = txtMiddleInitial.Text.ToString();
            StudentInfoClass.Birthday = datePickerBirthday.Text.ToString();
            StudentInfoClass.Gender = cbGender.Text.ToString();
            StudentInfoClass.StudentNo = long.Parse(student_txt.Text);
            StudentInfoClass.Age = long.Parse(Age_textBox6.Text);
            StudentInfoClass.ContactNo = long.Parse(Contactn_textBox7.Text);


            FrmConfirm confirm = new FrmConfirm();
            if (confirm.ShowDialog() == DialogResult.OK)
            {
                First_textBox4.Clear();
                Lastn_textBox3.Clear();
                
                cbGender.Items.Clear();
                student_txt.Clear();
                Age_textBox6.Clear();
                Contactn_textBox7.Clear();
                program_comboBox1.SelectedIndex = -1;


            }



        }
    }
    
    
}
        
    
