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
├── Forms/
│   ├── MainForm.cs                      
│   ├── Dashboard/
│   │   └── Dashboard_UserControl.cs     
│   ├── Attendance/
│   │   ├── Attendance_UserControl.cs   
│   │   ├── AddEvent_Form.cs            
│   │   ├── EditEvent_Form.cs            
│   ├── Reports/
│   │   ├── Reports_UserControl.cs       
│   │   ├── StudentAttendanceReport_Form 
│   ├── Student/
│   │   ├── Student_UserControl.cs       
│   │   ├── AddStudent_Form.cs           
│   │   └── StudentDetailsForm.cs        
│   ├── QRScanner/
│   │   └── QRScanner_UserControl.cs     
├── Models/
│   ├── Base/                           
│   │   ├──
│   │   ├── Attendance.cs               
│   ├── Student.cs                      
│   ├── AttendanceRecords.cs                       
│   ├── User.cs                          
├── Data/
│   ├── DatabaseContext.cs              
│   ├── Repositories/
│   │   ├── AttendanceRepository.cs      
│   │   ├── ReportsRepository.cs         
│   │   ├── StudentsRepository.cs        
│   │   └── UsersRepository.cs           
├── Services/
│   ├── AttendanceService.cs             
│   ├── QRCodeService.cs                
│   ├── EmailService.cs                  
│   ├── ReportService.cs                 
│   ├── AuthenticationService.cs         
├── Interfaces/                          
│   ├── Repositories/
│   │   ├── IAttendanceRepository.cs     
│   │   ├── IReportsRepository.cs        
│   │   ├── IStudentsRepository.cs       
│   │   ├── IUsersRepository.cs         
│   ├── Services/
│   │   ├── IAttendanceService.cs        
│   │   ├── IQRCodeService.cs           
│   │   ├── IEmailService.cs            
│   │   ├── IReportService.cs            
│   │   ├── IAuthenticationService.cs    
│   ├── Utilities/
│   │   ├── IQRScannerHelper.cs          
│   │   ├── IAttendanceCalculationHelper.cs
│   │   ├── IValidationHelper.cs         
│   │   ├── IExportHelper.cs            
│   │   ├── ILogger.cs                   
│   │   ├── IConfigurationManager.cs    
├── Utilities/
│    ├── QRScannerHelper.cs           
│    ├── AttendanceCalculationHelper.cs 
│    ├── ValidationHelper.cs          
│    └── ExportHelper.cs              
└── Reports/
```




