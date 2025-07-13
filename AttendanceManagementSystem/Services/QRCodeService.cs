using System;
using System.Drawing;
using ZXing;
using ZXing.Common;
using System.IO;
using DevExpress.XtraEditors;

namespace AttendanceManagementSystem.Data.Repositories
{
    public class QRCodeService
    {
        public static Bitmap GeneratedQRCode { get; set; }
        public static void GenerateQRCode(string schoolStudentId)
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
            GeneratedQRCode = writer.Write(schoolStudentId);
        }
        // USED TO DISPLAY QRCODE ON THE UI
        public static Image GetQRCodeImage()
        {
            return GeneratedQRCode;
        }
        // STORE QRCODE AS BYTE ARRAY
        public static byte[] GetQRCodeByteArray()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                GeneratedQRCode.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
    }
}
