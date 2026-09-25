namespace IWS_booking
{
    partial class StudentDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageBook = new System.Windows.Forms.TabPage();
            this.tabPageMyBookings = new System.Windows.Forms.TabPage();
            this.tabPageProfile = new System.Windows.Forms.TabPage();
            this.lblRoom = new System.Windows.Forms.Label();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.lblTimeSlot = new System.Windows.Forms.Label();
            this.cmbTimeSlot = new System.Windows.Forms.ComboBox();
            this.btnBook = new System.Windows.Forms.Button();
            this.lblMyBookings = new System.Windows.Forms.Label();
            this.lstMyBookings = new System.Windows.Forms.ListBox();
            this.btnCancelBooking = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageBook.SuspendLayout();
            this.tabPageMyBookings.SuspendLayout();
            this.tabPageProfile.SuspendLayout();
            this.SuspendLayout();
            //
            // panel1
            //
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 50);
            this.panel1.TabIndex = 0;
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Dashboard";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // tabControlMain
            //
            this.tabControlMain.Controls.Add(this.tabPageBook);
            this.tabControlMain.Controls.Add(this.tabPageMyBookings);
            this.tabControlMain.Controls.Add(this.tabPageProfile);
            this.tabControlMain.Location = new System.Drawing.Point(10, 60);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(580, 380);
            this.tabControlMain.TabIndex = 1;
            //
            // tabPageBook
            //
            this.tabPageBook.Controls.Add(this.lblRoom);
            this.tabPageBook.Controls.Add(this.cmbRoom);
            this.tabPageBook.Controls.Add(this.lblTimeSlot);
            this.tabPageBook.Controls.Add(this.cmbTimeSlot);
            this.tabPageBook.Controls.Add(this.btnBook);
            this.tabPageBook.Location = new System.Drawing.Point(4, 22);
            this.tabPageBook.Name = "tabPageBook";
            this.tabPageBook.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBook.Size = new System.Drawing.Size(572, 354);
            this.tabPageBook.TabIndex = 0;
            this.tabPageBook.Text = "Book Room";
            this.tabPageBook.UseVisualStyleBackColor = true;
            //
            // tabPageMyBookings
            //
            this.tabPageMyBookings.Controls.Add(this.lblMyBookings);
            this.tabPageMyBookings.Controls.Add(this.lstMyBookings);
            this.tabPageMyBookings.Controls.Add(this.btnCancelBooking);
            this.tabPageMyBookings.Location = new System.Drawing.Point(4, 22);
            this.tabPageMyBookings.Name = "tabPageMyBookings";
            this.tabPageMyBookings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMyBookings.Size = new System.Drawing.Size(572, 354);
            this.tabPageMyBookings.TabIndex = 1;
            this.tabPageMyBookings.Text = "My Bookings";
            this.tabPageMyBookings.UseVisualStyleBackColor = true;
            //
            // tabPageProfile
            //
            this.tabPageProfile.Controls.Add(this.btnLogout);
            this.tabPageProfile.Location = new System.Drawing.Point(4, 22);
            this.tabPageProfile.Name = "tabPageProfile";
            this.tabPageProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProfile.Size = new System.Drawing.Size(572, 354);
            this.tabPageProfile.TabIndex = 2;
            this.tabPageProfile.Text = "Profile";
            this.tabPageProfile.UseVisualStyleBackColor = true;
            //
            // lblRoom
            //
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(20, 20);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(80, 13);
            this.lblRoom.TabIndex = 1;
            this.lblRoom.Text = "Discussion Room";
            //
            // cmbRoom
            //
            this.cmbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(20, 40);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(520, 21);
            this.cmbRoom.TabIndex = 2;
            //
            // lblTimeSlot
            //
            this.lblTimeSlot.AutoSize = true;
            this.lblTimeSlot.Location = new System.Drawing.Point(20, 80);
            this.lblTimeSlot.Name = "lblTimeSlot";
            this.lblTimeSlot.Size = new System.Drawing.Size(60, 13);
            this.lblTimeSlot.TabIndex = 3;
            this.lblTimeSlot.Text = "Time Slot";
            //
            // cmbTimeSlot
            //
            this.cmbTimeSlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTimeSlot.FormattingEnabled = true;
            this.cmbTimeSlot.Location = new System.Drawing.Point(20, 100);
            this.cmbTimeSlot.Name = "cmbTimeSlot";
            this.cmbTimeSlot.Size = new System.Drawing.Size(520, 21);
            this.cmbTimeSlot.TabIndex = 4;
            //
            // btnBook
            //
            this.btnBook.BackColor = System.Drawing.Color.Maroon;
            this.btnBook.FlatAppearance.BorderSize = 0;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.Color.White;
            this.btnBook.Location = new System.Drawing.Point(20, 140);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(520, 40);
            this.btnBook.TabIndex = 5;
            this.btnBook.Text = "Book Room";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            //
            // lblMyBookings
            //
            this.lblMyBookings.AutoSize = true;
            this.lblMyBookings.Location = new System.Drawing.Point(20, 20);
            this.lblMyBookings.Name = "lblMyBookings";
            this.lblMyBookings.Size = new System.Drawing.Size(75, 13);
            this.lblMyBookings.TabIndex = 6;
            this.lblMyBookings.Text = "My Bookings";
            //
            // lstMyBookings
            //
            this.lstMyBookings.FormattingEnabled = true;
            this.lstMyBookings.Location = new System.Drawing.Point(20, 40);
            this.lstMyBookings.Name = "lstMyBookings";
            this.lstMyBookings.Size = new System.Drawing.Size(520, 238);
            this.lstMyBookings.TabIndex = 7;
            //
            // btnCancelBooking
            //
            this.btnCancelBooking.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancelBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelBooking.Location = new System.Drawing.Point(20, 290);
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.Size = new System.Drawing.Size(520, 32);
            this.btnCancelBooking.TabIndex = 8;
            this.btnCancelBooking.Text = "Cancel Selected Booking";
            this.btnCancelBooking.UseVisualStyleBackColor = false;
            this.btnCancelBooking.Click += new System.EventHandler(this.btnCancelBooking_Click);
            //
            // btnLogout
            //
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(20, 20);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 32);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            //
            // StudentDashboard
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 460);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.panel1);
            this.Name = "StudentDashboard";
            this.Text = "Student Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageBook.ResumeLayout(false);
            this.tabPageBook.PerformLayout();
            this.tabPageMyBookings.ResumeLayout(false);
            this.tabPageMyBookings.PerformLayout();
            this.tabPageProfile.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageBook;
        private System.Windows.Forms.TabPage tabPageMyBookings;
        private System.Windows.Forms.TabPage tabPageProfile;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.Label lblTimeSlot;
        private System.Windows.Forms.ComboBox cmbTimeSlot;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Label lblMyBookings;
        private System.Windows.Forms.ListBox lstMyBookings;
        private System.Windows.Forms.Button btnCancelBooking;
        private System.Windows.Forms.Button btnLogout;
    }
}
