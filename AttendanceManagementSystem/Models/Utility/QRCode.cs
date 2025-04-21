using AttendanceManagementSystem.Models.Base;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;

namespace AttendanceManagementSystem.Models.Utility
{
    public class QRCode
    {
        private readonly string qrCodeValue;
        public string QRCodeValue
        {
            get { return qrCodeValue; }
        }
        public QRCode(string schoolStudentId)
        {
            if (string.IsNullOrEmpty(schoolStudentId))
                throw new ArgumentException("School Student ID cannot be null or empty.", nameof(schoolStudentId));

            qrCodeValue = schoolStudentId;
        }
        public Bitmap GenerateQRCode()
        {
            BarcodeWriter writer = new BarcodeWriter 
            {
                Format = BarcodeFormat.QR_CODE,

                Options = new ZXing.Common.EncodingOptions 
                {
                    Width = 250,
                    Height = 250, 
                    Margin = 1
                }
            };
            return writer.Write(qrCodeValue);
        }   
    }
}
