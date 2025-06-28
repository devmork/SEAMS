# SEAMS - School Event Attendance Management System

**SEAMS** is a simple app made with Windows Forms. It helps track student attendance using QR codes. This project was built with C#, DevExpress, and SQLite. It’s part of my personal effort to create an easy-to-use desktop tool.

---

## Project Goal

Build a full-featured windows form application where SSG officeers can:

- Create attendance
- Register student
- Generate qr code
- Scan qr code
- Track attendance record (absent, present)
- Generate attendance report

## Teck Stack (Initial Setup)

| Layer          | Tech                           |
| -------------- | ------------------------------ |
| Framework      | Windows Form                   |
| Language       | C#                             |
| Styling        | DevExpress                     |
| Forms          | DevExpress XtraEditors         |
| Authentication | N/A (not implemented)          |
| Database       | SQLite                         |
| ORM            | Dapper                         |
| Deployment     | Local Execution (EXE)          |

## Features (Work in Progress)

- [x] Register student
- [x] Generate qr code
- [x] Create attendance
- [x] Scan qr code
- [x] View student attendance record
- [x] Generate all attendance report

---

## Project Structure

```
AttendanceManagementSystem/
├── DTO/
│   ├── AttendanceRecordsDTO.cs
│   ├── AttendanceSummaryDTO.cs
│   └── StudentsAttendanceDTO.cs
├── Data/
│   ├── Repositories/
│   │   ├── AttendanceRepository.cs
│   │   ├── StudentsRepository.cs
│   │   └── UserRepository.cs
│   └── SQLiteDataAccess.cs
├── Forms/
│   ├── Attendance/
│   │   ├── AddAttendance_Form.cs
│   │   ├── Attendance_UserControl.cs
│   │   └── EditAttendance_Form.cs
│   ├── Attendance Record/
│   │   ├── AttendanceRecords_UserControl.cs
│   │   └── StudentAttendanceRecord_Form.cs
│   ├── Auth/
│   │   ├── LogIn_Form.cs
│   │   └── SignUp_Form.cs
│   ├── Dashboard/
│   │   └── Dashboard_UserControl.cs
│   ├── QRScanner/
│   │   └── QRScanner_UserControl.cs
│   ├── Reports/
│   │   ├── AllAttendanceRecord_Form.cs
│   │   └── AllQRCodes.cs
│   ├── Students/
│   │   ├── AddStudent_Form.cs
│   │   ├── EditStudent_Form.cs
│   │   └── Students_UserControl.cs
│   └── MainForm.cs
├── Interfaces/
│   ├── Repositories/
│   │   ├── IAttendanceRepository.cs
│   │   ├── IStudentsRepository.cs
│   │   └── IUserRepository.cs
│   ├── Services/
│   │   ├── IAttendanceService.cs
│   │   └── IQRCodeService.cs
│   └── Utilities/
│       └── IQRScannerHelper.cs
├── Models/
│   ├── Base/
│   │   ├── Attendance.cs
│   │   └── Student.cs
│   └── Derived/
│       └── User.cs
├── Services/
│   ├── AttendanceService.cs
│   └── QRCodeService.cs
├── Utilities/
│   └── QRScannerHelper.cs
```




