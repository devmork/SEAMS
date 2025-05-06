using System;
using System.Drawing;
using ZXing;
using ZXing.Common;
using AttendanceManagementSystem.Interfaces.Repositories;

namespace AttendanceManagementSystem.Data.Repositories
{
    public class QRCodeRepository : IQRCodeRepository
    {
        public Bitmap GeneratedQRCode { get; set; }

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
    }
}
