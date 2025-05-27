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
using AttendanceManagementSystem.Models.Base;
using System.IO.Compression;
using System.IO;
using ZXing.QrCode;
using ZXing;
using AttendanceManagementSystem.Forms.Students;
using System.Data.SqlClient;
using AttendanceManagementSystem.Interfaces.Repositories;
using Dapper;
using System.Data.SQLite;

namespace AttendanceManagementSystem.Forms.Reports
{
    public partial class AllQRCodes : DevExpress.XtraEditors.XtraForm
    {
        private string _connectionStrng = "Data Source=SEAMS.db;Version=3;Mode=ReadWrite;";
        private string downloadFolder;

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

        private void btn_Report_Click(object sender, EventArgs e)
        {
            // Validation: Check if course is selected
            if (cbe_FilterCourse.SelectedItem == null || string.IsNullOrWhiteSpace(cbe_FilterCourse.SelectedItem.ToString()))
            {
                XtraMessageBox.Show("Please select a course.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validation: Check if year level is selected
            if (cbe_FilterYearLevel.SelectedItem == null || string.IsNullOrWhiteSpace(cbe_FilterYearLevel.SelectedItem.ToString()))
            {
                XtraMessageBox.Show("Please select a year level.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedCourse = cbe_FilterCourse.SelectedItem.ToString();
            string selectedYearLevel = cbe_FilterYearLevel.SelectedItem.ToString();

            // Prompt user to select a folder for downloading QR codes
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    downloadFolder = folderDialog.SelectedPath;

                    try
                    {
                        using (var connection = new SQLiteConnection(_connectionStrng))
                        {
                            connection.Open();

                            // Query students with dynamic filtering for "ALL" selections
                            string sql = @"
                                SELECT SchoolStudentId, LastName, FirstName 
                                FROM Student 
                                WHERE (Course = @Course OR @Course IS NULL) 
                                AND (YearLevel = @YearLevel OR @YearLevel IS NULL)";

                            var parameters = new DynamicParameters();
                            parameters.Add("@Course", selectedCourse == "All Courses" ? (object)DBNull.Value : selectedCourse);
                            parameters.Add("@YearLevel", selectedYearLevel == "All Year Level" ? (object)DBNull.Value : selectedYearLevel);

                            var students = connection.Query<Student>(sql, parameters).ToList();

                            if (students.Count == 0)
                            {
                                XtraMessageBox.Show("No students found for the selected criteria.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }

                            // Generate a unique ZIP file name with timestamp
                            string zipFileName = $"QR_Codes_{DateTime.Now:yyyyMMdd_HHmmss}.zip";
                            string zipFilePath = Path.Combine(downloadFolder, zipFileName);

                            // Create the ZIP file
                            using (var zipStream = new FileStream(zipFilePath, FileMode.Create))
                            using (var zipArchive = new ZipArchive(zipStream, ZipArchiveMode.Create))
                            {
                                foreach (var student in students)
                                {
                                    // Generate QR code image
                                    using (var qrCodeImage = GeneratedQRCode(student.SchoolStudentId))
                                    {
                                        // Sanitize names
                                        string lastNameSanitized = SanitizeName(student.LastName);
                                        string firstNameSanitized = SanitizeName(student.FirstName);
                                        string entryName = $"{lastNameSanitized}_{firstNameSanitized}.png";

                                        // Create ZIP entry
                                        var zipEntry = zipArchive.CreateEntry(entryName);
                                        using (var entryStream = zipEntry.Open())
                                        {
                                            qrCodeImage.Save(entryStream, System.Drawing.Imaging.ImageFormat.Png);
                                        }
                                    }
                                }
                            }

                            // Success Prompt: Inform user of successful download
                            XtraMessageBox.Show($"{students.Count} QR codes have been successfully downloaded to {zipFilePath}.",
                                "Download Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show($"Error creating ZIP file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private Bitmap GeneratedQRCode(string data)
        {
            var barcodeWriter = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new QrCodeEncodingOptions
                {
                    Width = 200,
                    Height = 200,
                    Margin = 0
                }
            };
            return barcodeWriter.Write(data);
        }

        private void AllQRCodes_Load(object sender, EventArgs e)
        {
            PopulateComboBoxes();
        }
        private void PopulateComboBoxes()
        {
            try
            {
                using (var connection = new SQLiteConnection(_connectionStrng))
                {
                    connection.Open();

                    // Populate Course combo box with distinct courses
                    string courseSql = "SELECT DISTINCT Course FROM Student";
                    var courses = connection.Query<string>(courseSql).ToList();
                    cbe_FilterCourse.Properties.Items.AddRange(courses);

                    // Populate Year Level combo box with distinct year levels
                    string yearLevelSql = "SELECT DISTINCT YearLevel FROM Student";
                    var yearLevels = connection.Query<string>(yearLevelSql).ToList();
                    cbe_FilterYearLevel.Properties.Items.AddRange(yearLevels);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error loading combo boxes: {ex.Message}");
            }
        }
        // Helper method to sanitize names for filenames
        private string SanitizeName(string name)
        {
            var invalidChars = Path.GetInvalidFileNameChars();
            return new string(name.Select(c => invalidChars.Contains(c) ? '_' : c).ToArray());
        }
    }
}