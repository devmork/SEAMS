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
using AttendanceManagementSystem.Interfaces.Repositories;
using AttendanceManagementSystem.Data.Repositories;
using AttendanceManagementSystem.Services;
using System.Data.SQLite;
using Dapper;
using DevExpress.XtraCharts;
using AttendanceManagementSystem.DTO;

namespace AttendanceManagementSystem.Forms.Dashboard
{
    public partial class Dashboard_UserControl : DevExpress.XtraEditors.XtraUserControl
    {
        private string _connectionString = "Data Source=SEAMS.db;Version=3;Mode=ReadWrite;";

        private IStudentsRepository _studentRepository;
        private IAttendanceRepository _attendanceRepository;

        public Dashboard_UserControl()
        {
            InitializeComponent();
            _studentRepository = new StudentsRepository();
            _attendanceRepository = new AttendanceRepository();
        }
        private void Dashboard_UserControl_Load(object sender, EventArgs e)
        {
            txt_TotalAttendance.Text = AttendanceService.GetAttendanceCount().ToString();
            txt_TotalStudents.Text = _studentRepository.GetTotalStudents().ToString();

            string allCourse = "All Course";
            var attendanceSummary = GetAttendanceSummary(allCourse);

            Series attendanceSeries = chartControl_AttendaceSummary.Series["AttendanceSummary"];

            attendanceSeries.Points.Clear();
            foreach (var data in attendanceSummary)
            {
                attendanceSeries.Points.Add(new SeriesPoint(data.YearLevel, data.AttendanceCount));
            }
            chartControl_AttendaceSummary.RefreshData();
        }
        private List<AttendanceSummaryDTO> GetAttendanceSummary(string course)
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                string sql = @"SELECT Course, YearLevel, AttendanceId, COUNT(AttendanceId) AS AttendanceCount 
                                FROM AttendanceRecords 
                                WHERE (Course = @Course OR @Course = 'All Course')
                                GROUP BY YearLevel";
                var attendanceSummary = connection.Query<AttendanceSummaryDTO>(sql, new { Course = course }).ToList();
                return attendanceSummary;
            }
        }
        private void cbe_FilterCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCourse = cbe_FilterCourse.SelectedItem.ToString();

            var attendanceSummary = GetAttendanceSummary(selectedCourse);
            LoadAttendanceSummaryToChart(attendanceSummary);
        }
        private void LoadAttendanceSummaryToChart(List<AttendanceSummaryDTO> attendanceSummary)
        {
            Series attendanceSeries = chartControl_AttendaceSummary.Series["AttendanceSummary"];
            attendanceSeries.Points.Clear();

            foreach (var data in attendanceSummary)
            {
                attendanceSeries.Points.Add(new SeriesPoint(data.YearLevel, data.AttendanceCount));
            }
            chartControl_AttendaceSummary.RefreshData();
        }
    }
}
