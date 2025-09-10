using System;
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
        private DelegateText DelProgram, DelLastName, DelFirstName, DelMI, DelBirthday, DelGender;
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
            DelMI = new DelegateText(StudentInfoClass.GetMI);
            DelBirthday = new DelegateText(StudentInfoClass.GetBirthday);
            DelGender = new DelegateText(StudentInfoClass.GetGender);
            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelNumContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);
            
           
            

            


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label18.Text = DelProgram(StudentInfoClass.Program);
            label19.Text = DelLastName(StudentInfoClass.LastName);
            label20.Text = DelFirstName(StudentInfoClass.FirstName);
            label21.Text = DelMI(StudentInfoClass.MI);
            label26.Text = StudentInfoClass.Gender;
            label24.Text = StudentInfoClass.Birthday;
            label22.Text = DelNumAge(StudentInfoClass.Age).ToString();
            label23.Text = "+63" + StudentInfoClass.ContactNo.ToString();
            label17.Text = DelStudNo(StudentInfoClass.StudentNo).ToString();


        }

        private void FrmConfirm_FormClosing(object sender, FormClosingEventArgs e) 
        { 
            this.DialogResult = DialogResult.OK;
        
        }
    }
}
