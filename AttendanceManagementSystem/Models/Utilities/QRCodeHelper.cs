using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AttendanceManagementSystem.Data.Repositories;

namespace AttendanceManagementSystem.Models.Utilities
{
    public static class QRCodeHelper
    {
        public static Image GetQRCodeImage(object qrCodeRepository)
        {
            return ((QRCodeRepository)qrCodeRepository).GeneratedQRCode;
        }

        public static byte[] GetQRCodeByteArray(object qrCodeRepository)
        {
            Image qrCodeImage = GetQRCodeImage(qrCodeRepository);
            if (qrCodeImage == null)
            {
                return null;
            }

            using (MemoryStream ms = new MemoryStream())
            {
                qrCodeImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
    }
}
