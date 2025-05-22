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
using AttendanceManagementSystem.Models.Base;
using System.Data.SQLite;
using DevExpress.XtraGrid;
using AttendanceManagementSystem.Interfaces.Repositories;
using AttendanceManagementSystem.Data.Repositories;
using ZXing.QrCode.Internal;
using System.IO;
using DevExpress.XtraGrid.Views.Grid;

namespace AttendanceManagementSystem.Forms.Students
{
    public partial class Students_UserControl : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly IStudentsRepository _studentsRepository;
        public Students_UserControl()
        {
            InitializeComponent();
            _studentsRepository = new StudentRepository();
            LoadData();
        }
        private void btn_AddStudent_Click(object sender, EventArgs e)
        {
            using (var addStudentForm = new AddStudent_Form())
            {
                if (addStudentForm.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }
        private void repositoryItem_ActionButton_Click(object sender, EventArgs e)
        {
            try
            {
                GridView grdview_Students = (gc_Students.MainView as GridView);
                Student selectedRow = grdview_Students.GetFocusedRow() as Student;

                if (selectedRow != null)
                {
                    EditStudent_Form editStudentForm = new EditStudent_Form(selectedRow);
                    if (editStudentForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadData();
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error editing student: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LoadData()
        {
            gc_Students.DataSource = _studentsRepository.GetAllStudent();
        }
    }
}
