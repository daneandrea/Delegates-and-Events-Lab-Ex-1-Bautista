using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVENT_LABEXER1
{
    public delegate long DelegateNumber(long number);
    public delegate string DelegateName(string name);

    public partial class Form1 : Form
    {

        private object StudentInfoClass;

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            // StudentInfoClass.FirstName = FirstName.Text.ToString();
            // StudentInfoClass.LastName = LastName.Text.ToString();
            //StudentInfoClass.MiddleName = MiddleName.Text.ToString();


            Form2 formConfirm = new Form2();
            formConfirm.ShowDialog();

        }
    }
}
