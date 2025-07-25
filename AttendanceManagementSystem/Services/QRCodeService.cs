﻿using System;
using System.Drawing;
using ZXing;
using ZXing.Common;
using System.IO;
using DevExpress.XtraEditors;
using AttendanceManagementSystem.Interfaces.Repositories;
using System.Linq;

namespace AttendanceManagementSystem.Data.Repositories
{
    public static class QRCodeService
    {
        public static Bitmap GeneratedQRCode { get; set; }
        public static void GenerateQRCode(string schoolStudentId)
        {
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
        public static Image FetchQRCodeImage(string schoolStudentId, IStudentsRepository studentsRepository)
        {
            var student = studentsRepository.GetStudentQRCode(schoolStudentId).FirstOrDefault();

            using (var ms = new MemoryStream(student.QRCode))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
