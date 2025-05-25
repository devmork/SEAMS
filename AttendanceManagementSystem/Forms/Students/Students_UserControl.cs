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
            _studentsRepository = new StudentsRepository();
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
                Student selectedRow = gv_Students.GetFocusedRow() as Student;

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
        private void cbe_Course_SelectedValueChanged(object sender, EventArgs e)
        {
            string selectedCourse = cbe_Course.SelectedItem.ToString();
            gv_Students.ActiveFilterString = $"[Course] = '{selectedCourse}'";
        }
        private void cbe_YearLevel_SelectedValueChanged(object sender, EventArgs e)
        {
            string selectedYearLevel = cbe_YearLevel.SelectedItem.ToString();
            gv_Students.ActiveFilterString = $"[YearLevel] = '{selectedYearLevel}'";
        }
        private void findPanel_TextChanged(object sender, EventArgs e)
        {
            string searchStudentId = findPanel.Text.ToString();

            if (string.IsNullOrEmpty(searchStudentId))
            {
                gv_Students.ActiveFilterString = "";
            }
            else
            {
                gv_Students.ActiveFilterString = $"[SchoolStudentId] = '{searchStudentId}'";
            }
        }
    }
}
