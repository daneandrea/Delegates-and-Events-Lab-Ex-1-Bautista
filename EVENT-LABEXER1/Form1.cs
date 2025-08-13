using AccountRegistration;
using System;

using System.Windows.Forms;




namespace AccountRegistration
{


    public partial class FrmRegistration : Form
    {

        private object StudentInfoClass;

        public FrmRegistration()
        {
            InitializeComponent();
         
        }


        private void button1_Click(object sender, EventArgs e)
        {
            studentInfoClass.Program = ProgramcomboBox.Text.ToString();
            studentInfoClass.FirstName = FirstName.Text.ToString();
            studentInfoClass.LastName = LastName.Text.ToString();
            studentInfoClass.MiddleName = MiddleName.Text.ToString();
            studentInfoClass.Address = Address.Text.ToString();

            if (long.TryParse(Age.Text, out long age))
                studentInfoClass.Age = age;

            if (long.TryParse(ContactNo.Text, out long contactNo))
                studentInfoClass.ContactNo = contactNo;

            if (long.TryParse(StudentNo.Text, out long studentNo))
                studentInfoClass.StudentNo = studentNo;

            FrmConfirm frmConfirm = new FrmConfirm();
            if (frmConfirm.ShowDialog() == DialogResult.OK)
            {
                FirstName.Clear();
                LastName.Clear();
                MiddleName.Clear();
                Address.Clear();
                Age.Clear();
                ContactNo.Clear();
                StudentNo.Clear();
                ProgramcomboBox.SelectedIndex = -1;

            }


        }



        private void FrmRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}


    


        

       


   
