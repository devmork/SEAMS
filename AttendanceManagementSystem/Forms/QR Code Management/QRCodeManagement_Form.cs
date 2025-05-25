using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AttendanceManagementSystem.Data.Repositories;
using AttendanceManagementSystem.Interfaces.Repositories;
using AttendanceManagementSystem.Models.Base;
using DevExpress.XtraEditors;
using OpenCvSharp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AttendanceManagementSystem.Forms.QR_Code_Management
{
    public partial class QRCodeManagement_Form : DevExpress.XtraEditors.XtraForm
    {
        private readonly IStudentsRepository _studentsRepository; // Fix for CS0103  
        private SaveFileDialog sfd = new SaveFileDialog { Filter = "ZIP files (*.zip)|*.zip", Title = "Save QR Codes ZIP File" };

        public QRCodeManagement_Form()
        {
            InitializeComponent();
            _studentsRepository = new StudenstRepository();
            LoadData();
        }


        private void LoadData()
        {
            string course = cbe_Course.SelectedIndex > 0 ? cbe_Course.Text : string.Empty;
            int? yearLevel = cbe_YearLevel.SelectedIndex > 0 ? (int?)int.Parse(cbe_YearLevel.Text) : null;

            var filteredStudents = _studentsRepository.GetAllStudent(course, yearLevel) ?? new List<Student>();
            gc_QRCodes.DataSource = filteredStudents;
        }


        private void gc_QRCodes_Load(object sender, EventArgs e)
        {
            // Ensure data is loaded when the control is initialized  
            LoadData();
        }
        private void cbe_Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }
        private void cbe_YearLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }
        private async Task BulkDownloadQRCodesAsync(string fileName)
        {
            var students = gc_QRCodes.DataSource as List<Student>;
            if (students == null || students.Count == 0)
            {
                XtraMessageBox.Show("No students to download.");
                return;
            }

            progressBar.Visible = true;

            await Task.Run(() =>
            {
                using (var zip = new ZipFile())
                {
                    int count = 0;
                    foreach (var student in students)
                    {
                        if (student.QRCode != null)
                        {
                            using (var ms = new MemoryStream(student.QRCode))
                            {
                                zip.AddEntry($"{student.SchoolStudentId}.png", ms.ToArray());
                            }
                        }
                        count++;
                        Invoke(new Action(() => progressBar.EditValue = (count * 100) / students.Count));
                    }
                    zip.Save(fileName);
                }
            });

            progressBar.Visible = false;
        }

        private async void simpleButton1_Click(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                await BulkDownloadQRCodesAsync(sfd.FileName);
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            cbe_Course.SelectedIndex = 0;
            cbe_YearLevel.SelectedIndex = 0;
            LoadData();

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}