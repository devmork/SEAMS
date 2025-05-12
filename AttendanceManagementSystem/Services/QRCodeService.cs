using System;
using System.Drawing;
using ZXing;
using ZXing.Common;
using AttendanceManagementSystem.Interfaces.Repositories;
using System.IO;

namespace AttendanceManagementSystem.Data.Repositories
{
    public class QRCodeService : IQRCodeService
    {
        public Bitmap GeneratedQRCode { get; private set; }
        public void GenerateQRCode(string schoolStudentId)
        {
            if (string.IsNullOrEmpty(schoolStudentId))
                throw new InvalidOperationException("School Student ID must be set before generating QR code.");

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
        public Image GetQRCodeImage()
        {
            if (GeneratedQRCode == null)
                throw new InvalidOperationException("QR code has not been generated. Call GenerateQRCode first.");
            return GeneratedQRCode;
        }
        public byte[] GetQRCodeByteArray()
        {
            if (GeneratedQRCode == null)
                throw new InvalidOperationException("QR code has not been generated. Call GenerateQRCode first.");

            using (MemoryStream ms = new MemoryStream())
            {
                GeneratedQRCode.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
    }
}
