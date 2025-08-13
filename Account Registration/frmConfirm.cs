﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Account_Registration.FormRegistration; 


namespace Account_Registration
{
    public partial class FrmConfirm : Form
    {
        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;

        private void label8_Click(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


       
        public FrmConfirm()
        {

            InitializeComponent();

            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelAddress = new DelegateText(StudentInfoClass.GetAddress);
            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelNumContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);
            
           
            

            


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label17.Text = DelProgram(StudentInfoClass.Program);
            label18.Text = DelLastName(StudentInfoClass.LastName);
            label19.Text = DelFirstName(StudentInfoClass.FirstName);
            label20.Text = DelMiddleName(StudentInfoClass.MiddleName);
            label21.Text = DelAddress(StudentInfoClass.Address);
            label22.Text = DelNumAge(StudentInfoClass.Age).ToString();
            label23.Text = DelNumContactNo(StudentInfoClass.ContactNo).ToString();
            label24.Text = DelStudNo(StudentInfoClass.StudentNo).ToString();


        }

        private void FrmConfirm_FormClosing(object sender, FormClosingEventArgs e) 
        { 
            this.DialogResult = DialogResult.OK;
        
        }
    }
}
