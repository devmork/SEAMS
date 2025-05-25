using AttendanceManagementSystem.Interfaces.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;

namespace AttendanceManagementSystem.Utilities
{
    public class QRScannerHelper : IQRScannerHelper
    {
        public string DecodeQRCode(Bitmap bitmap)
        {
            try
            {
                BarcodeReader reader = new BarcodeReader();
                var result = reader.Decode(bitmap);
                return result?.Text;
            }
            catch
            {
                return null; // Return null if decoding fails
            }
        }
    }
}
