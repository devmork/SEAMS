using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AttendanceManagementSystem.Models.Base;

namespace AttendanceManagementSystem.Interfaces.Repositories
{
    public interface IStudentsRepository
    {
        List<Student> GetStudent();
        void AddStudent(Student student);
    }
}
