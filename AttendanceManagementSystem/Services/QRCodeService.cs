using System;
using System.Drawing;
using ZXing;
using ZXing.Common;
using AttendanceManagementSystem.Interfaces.Repositories;
using System.IO;
using DevExpress.XtraEditors;

namespace AttendanceManagementSystem.Data.Repositories
{
    public class QRCodeService : IQRCodeService
    {
        public Bitmap GeneratedQRCode { get; private set; }
        public void GenerateQRCode(string schoolStudentId)
        {
            if (string.IsNullOrEmpty(schoolStudentId))
            {
                XtraMessageBox.Show("Please fill in all required fields before generating QR code.");
                return;
            }
            BarcodeWriter writer = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new EncodingOptions
                {
                    Width = 250,
                    Height = 250,
                    Margin = 1
                }
            };
            //GeneratedQRCode = writer.Write(schoolStudentId);
            GeneratedQRCode = writer.Write(schoolStudentId);
        }
        // Used to display the QR code in the UI
        public Image GetQRCodeImage()
        {
            if (GeneratedQRCode == null)
                XtraMessageBox.Show("QR code has not been generated. GenerateQRCode first.");
            return GeneratedQRCode;
        }

        // Store QR code as byte array
        public byte[] GetQRCodeByteArray()
        {
            if (GeneratedQRCode == null)
                XtraMessageBox.Show("QR code has not been generated.GenerateQRCode first.");

            using (MemoryStream ms = new MemoryStream())
            {
                GeneratedQRCode.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
    }
}
