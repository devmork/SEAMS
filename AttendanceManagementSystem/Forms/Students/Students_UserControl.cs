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

namespace AttendanceManagementSystem.Forms.Students
{
    public partial class Students_UserControl : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly IStudentsRepository _studentsRepository;

        public Students_UserControl()
        {
            InitializeComponent();
            _studentsRepository = new StudentRepository();
        }
        private void btn_AddStudent_Click(object sender, EventArgs e)
        {
            AddStudent_Form addStudent_Form = new AddStudent_Form();
            addStudent_Form.ShowDialog();
        }
        private void repositoryItem_ActionButton_Click(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView gv_Students = (gc_Students.MainView as DevExpress.XtraGrid.Views.Grid.GridView);

            Student selectedStudent = gv_Students.GetFocusedRow() as Student;

            if (selectedStudent != null)
            {
                EditStudent_Form editStudent_Form = new EditStudent_Form(selectedStudent);
                editStudent_Form.ShowDialog();
            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Please select a student to edit.");
            }
        }
        private void gc_Students_Load(object sender, EventArgs e)
        {
            gc_Students.DataSource = _studentsRepository.GetAllStudent();
        }
    }
}
