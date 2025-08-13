using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountRegistration
{
    public partial class FrmConfirm : Form
    {
        private studentInfoClass.DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private studentInfoClass.DelegateNumber DelAge, DelContactNo, DelStudentNo;

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public FrmConfirm()
        {
            InitializeComponent();

            DelProgram = new studentInfoClass.DelegateText(studentInfoClass.GetProgram);
            DelLastName = new studentInfoClass.DelegateText(studentInfoClass.GetLastName);
            DelFirstName = new studentInfoClass.DelegateText(studentInfoClass.GetFirstName);
            DelMiddleName = new studentInfoClass.DelegateText(studentInfoClass.GetMiddleName);
            DelAddress = new studentInfoClass.DelegateText(studentInfoClass.GetAddress);
            DelAge = new studentInfoClass.DelegateNumber(studentInfoClass.GetAge);
            DelContactNo = new studentInfoClass.DelegateNumber(studentInfoClass.GetContactNo);
            DelStudentNo = new studentInfoClass.DelegateNumber(studentInfoClass.GetStudentNo);
        }

        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            // Student No
            label9.Text = DelStudentNo(studentInfoClass.StudentNo).ToString();
            
            // Program
            label10.Text = DelProgram(studentInfoClass.Program);
            
            // Last Name
            label11.Text = DelLastName(studentInfoClass.LastName);
            
            // First Name
            label12.Text = DelFirstName(studentInfoClass.FirstName);
            
            // Middle Name
            label13.Text = DelMiddleName(studentInfoClass.MiddleName);
            
            // Age
            label14.Text = DelAge(studentInfoClass.Age).ToString();
            
            // Contact No
            label15.Text = DelContactNo(studentInfoClass.ContactNo).ToString();
            
            // Address
            label16.Text = DelAddress(studentInfoClass.Address);
        }

        private void FrmConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
