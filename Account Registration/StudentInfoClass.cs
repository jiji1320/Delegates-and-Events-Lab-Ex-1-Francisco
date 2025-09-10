using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Registration
{
    public delegate long DelegateNumber(long number);
    public delegate string DelegateText(string text);
    internal class StudentInfoClass
    {
        public static string FirstName = "";
        public static string LastName = "";
        public static string MI = "";
        public static string Program = "";
        public static string Birthday = "";
        public static string Gender = "";
        public static long Age = 0;
        public static long ContactNo = 0;
        public static long StudentNo = 0;
        



        public static string GetFirstName(string FirstName)
        {
            return FirstName;
        }
        public static string GetLastName(string LastName)
        {
            return LastName;
        }
        public static string GetMI(string MiddleName)
        {
            return MiddleName;
        }
        public static string GetBirthday(string Birthday)
        {
            return Birthday;
        }
        public static string GetGender(string Gender) 
        {
            return Gender;
        }
        public static string GetProgram(string Program)
        {
            return Program;
        }
        public static long GetAge(long Age)
        {
            return Age;
        }
        public static long GetContactNo(long ContactNo)
        {
            return ContactNo;
        }
        public static long GetStudentNo(long StudentNo)
        {
            return StudentNo;
        }
        

    }
}
