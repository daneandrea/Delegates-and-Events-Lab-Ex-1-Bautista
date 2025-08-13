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
        private StudentInfoClass studentInfo;

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


        private void Form2_Load(object sender, EventArgs e)
        {
            label9.Text = DelProgram(studentInfoClass.Program);
            label10.Text = DelLastName(studentInfoClass.LastName);
            label11.Text = DelFirstName(studentInfoClass.FirstName);
            label12.Text = DelMiddleName(studentInfoClass.MiddleName);
            label13.Text = DelAddress(studentInfoClass.Address);
            label14.Text = DelAge(studentInfoClass.Age).ToString();
            label15.Text = DelContactNo(studentInfoClass.ContactNo).ToString();
            label16.Text = DelStudentNo(studentInfoClass.StudentNo).ToString();

        }


        private void FrmConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }
    }
}
