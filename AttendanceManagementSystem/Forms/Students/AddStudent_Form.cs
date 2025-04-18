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
using System.Data.SQLite;
using ZXing;
using System.Drawing.Imaging;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.IO;

namespace AttendanceManagementSystem.Forms.Students
{
	public partial class AddStudent_Form: DevExpress.XtraEditors.XtraForm
	{
        public AddStudent_Form()
		{
            InitializeComponent();
		}

        private Bitmap GenerateQRCode(string content)
        {
            BarcodeWriter writer = new BarcodeWriter //ZXing class used to generate barcodes and QR codes, configures tto output QR Codes into images
            {
                Format = BarcodeFormat.QR_CODE, //Tells ZXign to generate QR codes, BarcodeFormat.QR_CODE is an enum value representing the QR format.

                Options = new ZXing.Common.EncodingOptions //ZXing.Common.EncodingOptions class is used to set the encoding options for the barcode generation.
                {
                    Width = 250, //Width of the QR code image
                    Height = 250, //Height of the QR code image
                    Margin = 1 //Margin around the QR code
                }
            };
            return writer.Write(content); //Generates the QR code image using the content provided. And returns the generated image as a Bitmap object.
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            string qrText = ComposeQRText();
            Bitmap qrImage = GenerateQRCode(qrText);
            pe_QRCode.Image = qrImage;
        }

        private string ComposeQRText()
        { 
            return $"{txt_SchoolStudentId.Text}-{txt_FirstName.Text}-{txt_MiddleName.Text}-{txt_LastName.Text}"; // Assuming these are input fields  
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string firstName = txt_FirstName.Text;
            string middleName = txt_MiddleName.Text;
            string lastName = txt_LastName.Text;
            string schoolId = txt_SchoolStudentId.Text;
            string course = cbe_Course.Text;
            int yearLevel = (int)se_YearLevel.Value;
            string email = txt_EmailAddress.Text;

            // Compose QR content
            string qrText = $"{schoolId}|{firstName}|{middleName}|{lastName}|{course}|{yearLevel}|{email}";

            Bitmap qrCodeImage = GenerateQRCode(qrText);
            pe_QRCode.Image = qrCodeImage; // Show QR code on UI

            // Convert QR image to byte array
            using (MemoryStream ms = new MemoryStream())
            {
                qrCodeImage.Save(ms, ImageFormat.Png);
                byte[] qrBytes = ms.ToArray();

                // Save to SQLite
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=SEAMS_DB.db"))
                {
                    conn.Open();
                    string sql = @"INSERT INTO Students 
                (FirstName, MiddleName, LastName, SchoolID, Course, YearLevel, Email, QRImage)
                VALUES (@FirstName, @MiddleName, @LastName, @SchoolID, @Course, @YearLevel, @Email, @QRImage)";

                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@MiddleName", middleName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@SchoolID", schoolId);
                        cmd.Parameters.AddWithValue("@Course", course);
                        cmd.Parameters.AddWithValue("@YearLevel", yearLevel);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@QRImage", qrBytes);
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            SaveQRCodeToFile(qrCodeImage, schoolId);

            XtraMessageBox.Show("Student data and QR code saved successfully!");
        }

        private void SaveQRCodeToFile(Bitmap qrImage, string fileNameBase)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG Image|*.png|PDF Document|*.pdf";
            sfd.FileName = $"{fileNameBase}_QRCode";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (sfd.FilterIndex == 1) // Save as PNG  
                {
                    qrImage.Save(sfd.FileName, ImageFormat.Png);
                }
                else if (sfd.FilterIndex == 2) // Save as PDF  
                {
                    PdfDocument doc = new PdfDocument();
                    PdfPage page = doc.AddPage();
                    XGraphics gfx = XGraphics.FromPdfPage(page);

                    // Fix: Use a MemoryStream to convert Bitmap to XImage  
                    using (MemoryStream ms = new MemoryStream())
                    {
                        qrImage.Save(ms, ImageFormat.Png);
                        ms.Seek(0, SeekOrigin.Begin);
                        XImage xImg = XImage.FromStream(ms);
                        gfx.DrawImage(xImg, 50, 50, 200, 200);
                    }

                    doc.Save(sfd.FileName);
                }
            }
        }
    }
}