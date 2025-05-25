using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;

namespace AttendanceManagementSystem.Utilities
{
    public static class QRScannerHelper
    {
        public static string DecodeQRCode(Bitmap bitmap)
        {
            var reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            return result?.Text;
        }
    }
}
