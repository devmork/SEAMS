using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace AttendanceManagementSystem.Forms.Reports
{
	public partial class AllQRCodes: DevExpress.XtraEditors.XtraForm
	{
        public AllQRCodes()
		{
            InitializeComponent();
		}

        private void btn_CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}