using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace IWS_booking
{
    public partial class Form3 : Form
    {
        private readonly List<string> myBookings = new List<string>();

        // AForge & ZXing fields for QR Scanning
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private BarcodeReader barcodeReader;

        public Form3()
        {
            InitializeComponent();

            // Initialize barcode reader settings
            barcodeReader = new BarcodeReader
            {
                AutoRotate = true,
                Options = new ZXing.Common.DecodingOptions
                {
                    TryHarder = true
                }
            };
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Room setup
            cmbRoom.Items.Add("Room 1 - groups start at 3 members, max at 5");
            cmbRoom.Items.Add("Room 2 - groups start at 3 members, max at 7");
            cmbRoom.Items.Add("Room 3 - groups start at 3 members, max at 7");
            cmbRoom.Items.Add("Room 4 - groups start at 3 members, max at 6");

            // Detect connected webcams for the QR Scanner on tabMyBookings
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in videoDevices)
            {
                cmbCameras.Items.Add(device.Name);
            }

            if (cmbCameras.Items.Count > 0)
                cmbCameras.SelectedIndex = 0;
            else
                lblScanStatus.Text = "No camera detected.";
        }

        #region QR Code Scanning Logic (My Bookings Tab)

        // Event for "Start QR Scan" / "Stop Camera" button on tabMyBookings
        private void btnStartScan_Click(object sender, EventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                StopCamera();
                btnStartScan.Text = "Start QR Scan";
            }
            else
            {
                if (cmbCameras.SelectedIndex < 0) return;

                videoSource = new VideoCaptureDevice(videoDevices[cmbCameras.SelectedIndex].MonikerString);
                videoSource.NewFrame += VideoSource_NewFrame;
                videoSource.Start();

                timerScan.Interval = 300; // Scan frame every 300 ms
                timerScan.Start();

                btnStartScan.Text = "Stop Camera";
                lblScanStatus.Text = "Align QR code with the camera...";
            }
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap frame = (Bitmap)eventArgs.Frame.Clone();

            // Safely clear old frame to prevent memory leaks
            if (picWebcam.Image != null)
                picWebcam.Image.Dispose();

            picWebcam.Image = frame;
        }

        private void timerScan_Tick(object sender, EventArgs e)
        {
            if (picWebcam.Image == null) return;

            try
            {
                Bitmap snapshot = (Bitmap)picWebcam.Image.Clone();
                Result result = barcodeReader.Decode(snapshot);
                snapshot.Dispose();

                if (result != null)
                {
                    timerScan.Stop(); // Pause scanner while validating
                    ProcessBookingCheckIn(result.Text);
                }
            }
            catch (Exception ex)
            {
                lblScanStatus.Text = "Scan error: " + ex.Message;
            }
        }

        private void ProcessBookingCheckIn(string qrPayload)
        {
            lblScanStatus.Text = "Verifying booking...";

            // Validate booking code against existing records or Validator class
            bool isValid = Validator.ValidateBookingCode(qrPayload);

            if (isValid)
            {
                MessageBox.Show($"Booking confirmed!\nCode: {qrPayload}",
                                "Check-in Successful",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                lblScanStatus.Text = "Check-in complete.";
                StopCamera();
                btnStartScan.Text = "Start QR Scan";
            }
            else
            {
                MessageBox.Show("Invalid or expired booking QR code.",
                                "Check-in Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                lblScanStatus.Text = "Ready to scan again...";
                timerScan.Start(); // Resume scanning for another attempt
            }
        }

        // Auto-stop camera when changing tabs away from 'tabMyBookings'
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab != tabMyBookings)
            {
                StopCamera();
                if (btnStartScan != null) btnStartScan.Text = "Start QR Scan";
            }
        }

        private void StopCamera()
        {
            if (timerScan != null && timerScan.Enabled)
                timerScan.Stop();

            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                videoSource = null;
            }
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopCamera(); // Ensure video device frees up when Form3 closes
        }

        #endregion

        private void btnLogout_Click(object sender, EventArgs e)
        {
            StopCamera();
            var login = new Form1();
            login.Show();
            this.Hide();
        }

        private void cmbRoom_SelectedIndexChanged(object sender, EventArgs e) { }

        private void tabBookRoom_Click(object sender, EventArgs e) { }

        private void textBox4_TextChanged(object sender, EventArgs e) { }

        private void textBox7_TextChanged(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e) { }

        private void timerScan_Tick_1(object sender, EventArgs e)
        {

        }

        private void btnStartScan_Click_1(object sender, EventArgs e)
        {
            btnStartScan_Click(sender, e);
        }

        private void tabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab != tabMyBookings)
            {
                StopCamera();
                if (btnStartScan != null)
                    btnStartScan.Text = "Start QR scan";
            }
        }

        private void Form3_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            StopCamera();
        }

        private void cmbCameras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}