using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace AttendanceManagementSystem.Forms.Students
{
	public partial class Students_UserControl: DevExpress.XtraEditors.XtraUserControl
	{
        public Students_UserControl()
		{
            InitializeComponent();
		}

        private void btn_AddStudent_Click(object sender, EventArgs e)
        {
            AddStudent_Form addStudent_Form = new AddStudent_Form();
            addStudent_Form.ShowDialog();
        }
    }
}
