using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem.Interfaces.Repositories
{
    public interface IQRCodeRepository
    {
        void GenerateQRCode(string schoolStudentId);
    }
}