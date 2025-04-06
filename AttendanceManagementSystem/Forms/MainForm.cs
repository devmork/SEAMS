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
using AttendanceManagementSystem.Forms.Events;

namespace AttendanceManagementSystem.Forms
{
	public partial class MainForm: DevExpress.XtraEditors.XtraForm
	{
        public MainForm()
		{
            InitializeComponent();
		}
        private void btn_Dashboard_Click(object sender, EventArgs e)
        {

        }
        private void btn_Events_Click(object sender, EventArgs e)
        {
            panel_Body.Controls.Clear();
            UserControl_Events userControl = new UserControl_Events();
            userControl.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(userControl);

        }

        
    }
}