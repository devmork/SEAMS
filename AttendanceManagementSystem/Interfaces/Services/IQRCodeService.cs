using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem.Interfaces.Repositories
{
    public interface IQRCodeService
    {
        void GenerateQRCode(string schoolStudentId);
        Image GetQRCodeImage();
        byte[] GetQRCodeByteArray();
    }
}