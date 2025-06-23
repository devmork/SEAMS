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
using System.IO.Compression;
using ZXing.QrCode;
using ZXing;

namespace AttendanceManagementSystem.Forms.Students
{
    public partial class Students_UserControl : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly IStudentsRepository _studentsRepository;
        public Students_UserControl()
        {
            InitializeComponent();
            _studentsRepository = new StudentsRepository();
            LoadStudents();
        }
        private void btn_AddStudent_Click(object sender, EventArgs e)
        {
            using (var addStudentForm = new AddStudent_Form())
            {
                if (addStudentForm.ShowDialog() == DialogResult.OK)
                {
                    LoadStudents();
                }
            }
        }
        public void LoadStudents()
        {
            gc_Students.DataSource = _studentsRepository.GetAllStudent();
        }
        private void cbe_FilterCourse_SelectedValueChanged(object sender, EventArgs e)
        {
            string selectedCourse = cbe_FilterCourse.SelectedItem.ToString();
            gv_Students.ActiveFilterString = $"[Course] = '{selectedCourse}'";
        }

        private void cbe_FilterYearLevel_SelectedValueChanged(object sender, EventArgs e)
        {
            string selectedYearLevel = cbe_FilterYearLevel.SelectedItem.ToString();
            gv_Students.ActiveFilterString = $"[YearLevel] = '{selectedYearLevel}'";
        }
        private void repositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Student selectedRow = gv_Students.GetFocusedRow() as Student;

            EditStudent_Form editStudentForm = new EditStudent_Form(selectedRow);
            if (editStudentForm.ShowDialog() == DialogResult.OK)
            {
                LoadStudents();
            }
        }
    }
}
