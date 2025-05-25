using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using AttendanceManagementSystem.Interfaces.Repositories;
using AttendanceManagementSystem.Data.Repositories;
using AttendanceManagementSystem.Models.Base;
using DevExpress.Utils.MVVM;
using ZXing;
using OpenCvSharp.Extensions;
using OpenCvSharp;
using AttendanceManagementSystem.Utilities;
namespace AttendanceManagementSystem.Forms.QRScanner
{
	public partial class QRScanner_UserControl: DevExpress.XtraEditors.XtraUserControl
	{
        private readonly IAttendanceRepository _attendanceRepository;
        private VideoCapture capture;
        private Timer frameTimer = new Timer();
        public QRScanner_UserControl()
		{
            InitializeComponent();
            _attendanceRepository = new AttendanceRepository();
            frameTimer.Interval = 30;  // Frame refresh every 30ms (approx. 33fps)
            frameTimer.Tick += FrameTimer_Tick;
        }
        private void QRScanner_UserControl_Load(object sender, EventArgs e)
        {
            foreach (var attendance in _attendanceRepository.GetAllAttendance())
            {
                cbe_ChooseAttendance.Properties.Items.Add(attendance.AttendanceName);
            }
        }
        private void btn_StartScan_Click(object sender, EventArgs e)
        {
            txt_QRValue.Text = "Scanning...";
            // Open the default camera (index 0)
            capture = new VideoCapture(0);
            if (!capture.IsOpened())
            {
                XtraMessageBox.Show("Unable to access the webcam.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frameTimer.Start();
        }
        private void FrameTimer_Tick(object sender, EventArgs e)
        {
            using (Mat frame = new Mat())
            {
                if (capture.Read(frame) && !frame.Empty())
                {
                    Cv2.Resize(frame, frame, new OpenCvSharp.Size(pe_QRCamera.Width, pe_QRCamera.Height));
                    // Convert the OpenCvSharp Mat to a Bitmap for display and scanning
                    Bitmap bitmap = BitmapConverter.ToBitmap(frame);
                    pe_QRCamera.Image = bitmap;

                    string qrCodeText = QRScannerHelper.DecodeQRCode(bitmap);
                    if (!string.IsNullOrEmpty(qrCodeText))
                    {
                        frameTimer.Stop();
                        txt_QRValue.Text = qrCodeText;
                        //XtraMessageBox.Show($"QR Code Scanned: {qrCodeText}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        StopCamera();
                    }
                }
            }
        }
        private void btn_StopScan_Click(object sender, EventArgs e)
        {
            StopCamera();
        }
        private void StopCamera()
        {
            frameTimer.Stop();
            if (capture != null && capture.IsOpened())
            {
                capture.Release();
                capture.Dispose();
            }
            pe_QRCamera.Image = null;
        }
    }
}
