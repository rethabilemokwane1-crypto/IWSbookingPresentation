using System;
using System.Windows.Forms;
using System.Drawing;

namespace IWS_booking
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panel1;
        private Label label1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBookRoom = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdoSlot4 = new System.Windows.Forms.RadioButton();
            this.rdoSlot3 = new System.Windows.Forms.RadioButton();
            this.rdoSlot2 = new System.Windows.Forms.RadioButton();
            this.rdoSlot1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabMyBookings = new System.Windows.Forms.TabPage();
            this.lblScanStatus = new System.Windows.Forms.Label();
            this.btnStartScan = new System.Windows.Forms.Button();
            this.picWebcam = new System.Windows.Forms.PictureBox();
            this.cmbCameras = new System.Windows.Forms.ComboBox();
            this.btnCancelBooking = new System.Windows.Forms.Button();
            this.lstMyBookings = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.timerScan = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabBookRoom.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabMyBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWebcam)).BeginInit();
            this.tabProfile.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1639, 96);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1639, 96);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Dashboard";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBookRoom);
            this.tabControl1.Controls.Add(this.tabMyBookings);
            this.tabControl1.Controls.Add(this.tabProfile);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(256, 30);
            this.tabControl1.Location = new System.Drawing.Point(0, 96);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1639, 983);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged_1);
            // 
            // tabBookRoom
            // 
            this.tabBookRoom.Controls.Add(this.button2);
            this.tabBookRoom.Controls.Add(this.button1);
            this.tabBookRoom.Controls.Add(this.label4);
            this.tabBookRoom.Controls.Add(this.textBox7);
            this.tabBookRoom.Controls.Add(this.textBox6);
            this.tabBookRoom.Controls.Add(this.textBox5);
            this.tabBookRoom.Controls.Add(this.textBox4);
            this.tabBookRoom.Controls.Add(this.textBox3);
            this.tabBookRoom.Controls.Add(this.textBox2);
            this.tabBookRoom.Controls.Add(this.textBox1);
            this.tabBookRoom.Controls.Add(this.panel2);
            this.tabBookRoom.Controls.Add(this.label3);
            this.tabBookRoom.Controls.Add(this.cmbRoom);
            this.tabBookRoom.Controls.Add(this.label2);
            this.tabBookRoom.Location = new System.Drawing.Point(8, 38);
            this.tabBookRoom.Margin = new System.Windows.Forms.Padding(6);
            this.tabBookRoom.Name = "tabBookRoom";
            this.tabBookRoom.Padding = new System.Windows.Forms.Padding(40, 38, 40, 38);
            this.tabBookRoom.Size = new System.Drawing.Size(1552, 937);
            this.tabBookRoom.TabIndex = 0;
            this.tabBookRoom.Text = "Book Rooms";
            this.tabBookRoom.UseVisualStyleBackColor = true;
            this.tabBookRoom.Click += new System.EventHandler(this.tabBookRoom_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(1222, 740);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 75);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1014, 740);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 75);
            this.button1.TabIndex = 12;
            this.button1.Text = "Book Room";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(609, 36);
            this.label4.TabIndex = 11;
            this.label4.Text = "Group Members (Use student emails for validations)";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(56, 181);
            this.textBox7.Margin = new System.Windows.Forms.Padding(6);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(598, 42);
            this.textBox7.TabIndex = 10;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(56, 300);
            this.textBox6.Margin = new System.Windows.Forms.Padding(6);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(598, 42);
            this.textBox6.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(816, 181);
            this.textBox5.Margin = new System.Windows.Forms.Padding(6);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(598, 42);
            this.textBox5.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(816, 240);
            this.textBox4.Margin = new System.Windows.Forms.Padding(6);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(598, 42);
            this.textBox4.TabIndex = 7;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(816, 300);
            this.textBox3.Margin = new System.Windows.Forms.Padding(6);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(598, 42);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(56, 360);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(598, 42);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 240);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(598, 42);
            this.textBox1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.rdoSlot4);
            this.panel2.Controls.Add(this.rdoSlot3);
            this.panel2.Controls.Add(this.rdoSlot2);
            this.panel2.Controls.Add(this.rdoSlot1);
            this.panel2.Location = new System.Drawing.Point(56, 498);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(562, 192);
            this.panel2.TabIndex = 3;
            // 
            // rdoSlot4
            // 
            this.rdoSlot4.AutoSize = true;
            this.rdoSlot4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSlot4.Location = new System.Drawing.Point(8, 146);
            this.rdoSlot4.Margin = new System.Windows.Forms.Padding(6);
            this.rdoSlot4.Name = "rdoSlot4";
            this.rdoSlot4.Size = new System.Drawing.Size(206, 34);
            this.rdoSlot4.TabIndex = 3;
            this.rdoSlot4.Text = "14:00 - 16:00";
            this.rdoSlot4.UseVisualStyleBackColor = true;
            // 
            // rdoSlot3
            // 
            this.rdoSlot3.AutoSize = true;
            this.rdoSlot3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSlot3.Location = new System.Drawing.Point(8, 100);
            this.rdoSlot3.Margin = new System.Windows.Forms.Padding(6);
            this.rdoSlot3.Name = "rdoSlot3";
            this.rdoSlot3.Size = new System.Drawing.Size(206, 34);
            this.rdoSlot3.TabIndex = 2;
            this.rdoSlot3.Text = "12:00 - 14:00";
            this.rdoSlot3.UseVisualStyleBackColor = true;
            // 
            // rdoSlot2
            // 
            this.rdoSlot2.AutoSize = true;
            this.rdoSlot2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSlot2.Location = new System.Drawing.Point(8, 54);
            this.rdoSlot2.Margin = new System.Windows.Forms.Padding(6);
            this.rdoSlot2.Name = "rdoSlot2";
            this.rdoSlot2.Size = new System.Drawing.Size(206, 34);
            this.rdoSlot2.TabIndex = 1;
            this.rdoSlot2.Text = "10:00 - 12:00";
            this.rdoSlot2.UseVisualStyleBackColor = true;
            // 
            // rdoSlot1
            // 
            this.rdoSlot1.AllowDrop = true;
            this.rdoSlot1.AutoSize = true;
            this.rdoSlot1.Checked = true;
            this.rdoSlot1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSlot1.Location = new System.Drawing.Point(8, 8);
            this.rdoSlot1.Margin = new System.Windows.Forms.Padding(6);
            this.rdoSlot1.Name = "rdoSlot1";
            this.rdoSlot1.Size = new System.Drawing.Size(206, 34);
            this.rdoSlot1.TabIndex = 0;
            this.rdoSlot1.TabStop = true;
            this.rdoSlot1.Text = "08:00 - 10:00";
            this.rdoSlot1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 460);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time slot:";
            // 
            // cmbRoom
            // 
            this.cmbRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(56, 58);
            this.cmbRoom.Margin = new System.Windows.Forms.Padding(6);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(696, 45);
            this.cmbRoom.TabIndex = 1;
            this.cmbRoom.SelectedIndexChanged += new System.EventHandler(this.cmbRoom_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Discussion Room";
            // 
            // tabMyBookings
            // 
            this.tabMyBookings.Controls.Add(this.label8);
            this.tabMyBookings.Controls.Add(this.lblScanStatus);
            this.tabMyBookings.Controls.Add(this.btnStartScan);
            this.tabMyBookings.Controls.Add(this.picWebcam);
            this.tabMyBookings.Controls.Add(this.cmbCameras);
            this.tabMyBookings.Controls.Add(this.btnCancelBooking);
            this.tabMyBookings.Controls.Add(this.lstMyBookings);
            this.tabMyBookings.Controls.Add(this.label5);
            this.tabMyBookings.Location = new System.Drawing.Point(8, 38);
            this.tabMyBookings.Margin = new System.Windows.Forms.Padding(6);
            this.tabMyBookings.Name = "tabMyBookings";
            this.tabMyBookings.Padding = new System.Windows.Forms.Padding(6);
            this.tabMyBookings.Size = new System.Drawing.Size(1623, 937);
            this.tabMyBookings.TabIndex = 1;
            this.tabMyBookings.Text = "My bookings";
            this.tabMyBookings.UseVisualStyleBackColor = true;
            // 
            // lblScanStatus
            // 
            this.lblScanStatus.AutoSize = true;
            this.lblScanStatus.Location = new System.Drawing.Point(437, 666);
            this.lblScanStatus.Name = "lblScanStatus";
            this.lblScanStatus.Size = new System.Drawing.Size(85, 36);
            this.lblScanStatus.TabIndex = 6;
            this.lblScanStatus.Text = "Ready";
            // 
            // btnStartScan
            // 
            this.btnStartScan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStartScan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnStartScan.Location = new System.Drawing.Point(409, 611);
            this.btnStartScan.Name = "btnStartScan";
            this.btnStartScan.Size = new System.Drawing.Size(203, 50);
            this.btnStartScan.TabIndex = 5;
            this.btnStartScan.Text = "Start QR scan";
            this.btnStartScan.UseVisualStyleBackColor = true;
            this.btnStartScan.Click += new System.EventHandler(this.btnStartScan_Click_1);
            // 
            // picWebcam
            // 
            this.picWebcam.Location = new System.Drawing.Point(45, 611);
            this.picWebcam.Name = "picWebcam";
            this.picWebcam.Size = new System.Drawing.Size(341, 226);
            this.picWebcam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWebcam.TabIndex = 4;
            this.picWebcam.TabStop = false;
            // 
            // cmbCameras
            // 
            this.cmbCameras.FormattingEnabled = true;
            this.cmbCameras.Location = new System.Drawing.Point(20, 510);
            this.cmbCameras.Name = "cmbCameras";
            this.cmbCameras.Size = new System.Drawing.Size(741, 44);
            this.cmbCameras.TabIndex = 3;
            this.cmbCameras.SelectedIndexChanged += new System.EventHandler(this.cmbCameras_SelectedIndexChanged);
            // 
            // btnCancelBooking
            // 
            this.btnCancelBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelBooking.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelBooking.ForeColor = System.Drawing.Color.Maroon;
            this.btnCancelBooking.Location = new System.Drawing.Point(1002, 494);
            this.btnCancelBooking.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.Size = new System.Drawing.Size(246, 75);
            this.btnCancelBooking.TabIndex = 2;
            this.btnCancelBooking.Text = "Cancel Booking";
            this.btnCancelBooking.UseVisualStyleBackColor = true;
            // 
            // lstMyBookings
            // 
            this.lstMyBookings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstMyBookings.FormattingEnabled = true;
            this.lstMyBookings.ItemHeight = 36;
            this.lstMyBookings.Location = new System.Drawing.Point(20, 100);
            this.lstMyBookings.Margin = new System.Windows.Forms.Padding(6);
            this.lstMyBookings.Name = "lstMyBookings";
            this.lstMyBookings.Size = new System.Drawing.Size(1067, 364);
            this.lstMyBookings.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 45);
            this.label5.TabIndex = 0;
            this.label5.Text = "Your Bookings";
            // 
            // tabProfile
            // 
            this.tabProfile.Controls.Add(this.btnLogOut);
            this.tabProfile.Controls.Add(this.groupBox1);
            this.tabProfile.Location = new System.Drawing.Point(8, 38);
            this.tabProfile.Margin = new System.Windows.Forms.Padding(6);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Padding = new System.Windows.Forms.Padding(6);
            this.tabProfile.Size = new System.Drawing.Size(1623, 937);
            this.tabProfile.TabIndex = 2;
            this.tabProfile.Text = "Profile";
            this.tabProfile.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Maroon;
            this.btnLogOut.Location = new System.Drawing.Point(848, 369);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(6);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(174, 65);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.picAvatar);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(1016, 346);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(182, 69);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(341, 36);
            this.label7.TabIndex = 2;
            this.label7.Text = "Student number: 000000000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(178, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(270, 51);
            this.label6.TabIndex = 1;
            this.label6.Text = "Student Name";
            // 
            // picAvatar
            // 
            this.picAvatar.Location = new System.Drawing.Point(6, 0);
            this.picAvatar.Margin = new System.Windows.Forms.Padding(6);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(160, 154);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 0;
            this.picAvatar.TabStop = false;
            // 
            // timerScan
            // 
            this.timerScan.Interval = 300;
            this.timerScan.Tick += new System.EventHandler(this.timerScan_Tick_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(105, 572);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(207, 36);
            this.label8.TabIndex = 7;
            this.label8.Text = "Confirm Booking";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1639, 1079);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form3";
            this.Text = "Student Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing_1);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabBookRoom.ResumeLayout(false);
            this.tabBookRoom.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabMyBookings.ResumeLayout(false);
            this.tabMyBookings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWebcam)).EndInit();
            this.tabProfile.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #region Designer generated code for events
        // The event handlers are implemented in Form3.cs or can be attached to Form3 methods.
        #endregion

        private TabControl tabControl1;
        private TabPage tabMyBookings;
        private TabPage tabProfile;
        private TabPage tabBookRoom;
        private TextBox textBox1;
        private Panel panel2;
        private RadioButton rdoSlot4;
        private RadioButton rdoSlot3;
        private RadioButton rdoSlot2;
        private RadioButton rdoSlot1;
        private Label label3;
        private ComboBox cmbRoom;
        private Label label2;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label4;
        private Button button2;
        private Button button1;
        private ListBox lstMyBookings;
        private Label label5;
        private Button btnCancelBooking;
        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private PictureBox picAvatar;
        private Button btnLogOut;
        private ComboBox cmbCameras;
        private Button btnStartScan;
        private PictureBox picWebcam;
        private Label lblScanStatus;
        private Timer timerScan;
        private Label label8;
    }
}
