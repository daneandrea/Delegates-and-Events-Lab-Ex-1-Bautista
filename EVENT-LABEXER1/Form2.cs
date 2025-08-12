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
    public partial class Form2 : Form
    {
       // private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private DelegateNumber DelNumAge, DelNumContactNo, DelStudioNo;
        private StudentInfoClass studentInfo;
        
        public Form2()
        {
            InitializeComponent();

          //  DelProgram = new DelegateText(StudentInfoClass.GetProgram);


        }


        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

    }
}
