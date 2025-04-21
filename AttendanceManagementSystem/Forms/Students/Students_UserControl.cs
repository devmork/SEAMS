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

namespace AttendanceManagementSystem.Forms.Students
{
	public partial class Students_UserControl: DevExpress.XtraEditors.XtraUserControl
	{
        public Students_UserControl()
		{
            InitializeComponent();
		}
        public BindingList<Student> GetStudentsFromDatabase()
        {
            var list = new BindingList<Student>();

            using (var conn = new SQLiteConnection("Data Source=SEAMS_DB.db;Version=3;"))
            {
                conn.Open();
                string query = "SELECT FullName, MiddleName, LastName, SchoolID, Course, YearLevel, Email, QRImage FROM Students";
                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Student
                        {
                            FullName = reader["FullName"].ToString(),
                            MiddleName = reader["MiddleName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            SchoolID = reader["SchoolID"].ToString(),
                            Course = reader["Course"].ToString(),
                            YearLevel = reader.GetInt32(reader.GetOrdinal("YearLevel")),
                            Email = reader["Email"].ToString(),
                            QRImage = reader["QRImage"] as byte[]
                        });
                    }
                }
            }

            return list;
        }

        private BindingList<Student> students;

        private void LoadStudents()
        {
            students = GetStudentsFromDatabase();
            gc_Students.DataSource = students;
        }

        private void btn_AddStudent_Click(object sender, EventArgs e)
        {
            AddStudent_Form addStudent_Form = new AddStudent_Form();
            addStudent_Form.ShowDialog();
        }

        private void gc_Students_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }
    }
}
