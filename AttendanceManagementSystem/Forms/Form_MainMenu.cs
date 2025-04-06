using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AttendanceManagementSystem.User_Controls;
using DevExpress.XtraEditors;

namespace AttendanceManagementSystem.Forms
{
    public partial class Form_MainMenu : DevExpress.XtraEditors.XtraForm
    {
        public Form_MainMenu()
        {
            InitializeComponent();
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            panel_Body.Controls.Clear();
            UserControl_Dashboard userControl = new UserControl_Dashboard();
            userControl.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(userControl);
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