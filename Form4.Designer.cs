namespace IWS_booking
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.sidebar = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnViewReports = new System.Windows.Forms.Button();
            this.btnManageBookings = new System.Windows.Forms.Button();
            this.lblAdminRole = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.content = new System.Windows.Forms.Panel();
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.tabOverview = new System.Windows.Forms.TabPage();
            this.pnlQuickActions = new System.Windows.Forms.Panel();
            this.btnQuickUsers = new System.Windows.Forms.Button();
            this.btnQuickReports = new System.Windows.Forms.Button();
            this.btnQuickBookings = new System.Windows.Forms.Button();
            this.lblQuickActions = new System.Windows.Forms.Label();
            this.cardStudents = new System.Windows.Forms.Panel();
            this.lblStudentsValue = new System.Windows.Forms.Label();
            this.lblStudentsCaption = new System.Windows.Forms.Label();
            this.cardReports = new System.Windows.Forms.Panel();
            this.lblPendingReportsValue = new System.Windows.Forms.Label();
            this.lblReportsCaption = new System.Windows.Forms.Label();
            this.cardActive = new System.Windows.Forms.Panel();
            this.lblActiveBookingsValue = new System.Windows.Forms.Label();
            this.lblActiveCaption = new System.Windows.Forms.Label();
            this.cardBookings = new System.Windows.Forms.Panel();
            this.lblTotalBookingsValue = new System.Windows.Forms.Label();
            this.lblBookingsCaption = new System.Windows.Forms.Label();
            this.lblOverviewTitle = new System.Windows.Forms.Label();
            this.tabBookings = new System.Windows.Forms.TabPage();
            this.btnCancelBooking = new System.Windows.Forms.Button();
            this.dgvBookings = new System.Windows.Forms.DataGridView();
            this.colRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBookingStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBookingsTitle = new System.Windows.Forms.Label();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.btnResolveReport = new System.Windows.Forms.Button();
            this.dgvReports = new System.Windows.Forms.DataGridView();
            this.colReportStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComplaint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateSubmitted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReportStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblReportsTitle = new System.Windows.Forms.Label();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.colUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblUsersTitle = new System.Windows.Forms.Label();
            this.sidebar.SuspendLayout();
            this.header.SuspendLayout();
            this.content.SuspendLayout();
            this.tabAdmin.SuspendLayout();
            this.tabOverview.SuspendLayout();
            this.pnlQuickActions.SuspendLayout();
            this.cardStudents.SuspendLayout();
            this.cardReports.SuspendLayout();
            this.cardActive.SuspendLayout();
            this.cardBookings.SuspendLayout();
            this.tabBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            this.tabReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.Maroon;
            this.sidebar.Controls.Add(this.btnLogout);
            this.sidebar.Controls.Add(this.btnManageUsers);
            this.sidebar.Controls.Add(this.btnViewReports);
            this.sidebar.Controls.Add(this.btnManageBookings);
            this.sidebar.Controls.Add(this.lblAdminRole);
            this.sidebar.Controls.Add(this.lblLogo);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(386, 1200);
            this.sidebar.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Maroon;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(26, 1067);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(334, 87);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "  Log Out";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.BackColor = System.Drawing.Color.Maroon;
            this.btnManageUsers.FlatAppearance.BorderSize = 0;
            this.btnManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageUsers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnManageUsers.ForeColor = System.Drawing.Color.White;
            this.btnManageUsers.Location = new System.Drawing.Point(26, 425);
            this.btnManageUsers.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(334, 87);
            this.btnManageUsers.TabIndex = 1;
            this.btnManageUsers.Text = "  Users";
            this.btnManageUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageUsers.UseVisualStyleBackColor = false;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // btnViewReports
            // 
            this.btnViewReports.BackColor = System.Drawing.Color.Maroon;
            this.btnViewReports.FlatAppearance.BorderSize = 0;
            this.btnViewReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewReports.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnViewReports.ForeColor = System.Drawing.Color.White;
            this.btnViewReports.Location = new System.Drawing.Point(26, 325);
            this.btnViewReports.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnViewReports.Name = "btnViewReports";
            this.btnViewReports.Size = new System.Drawing.Size(334, 87);
            this.btnViewReports.TabIndex = 2;
            this.btnViewReports.Text = "  Reports";
            this.btnViewReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewReports.UseVisualStyleBackColor = false;
            this.btnViewReports.Click += new System.EventHandler(this.btnViewReports_Click);
            // 
            // btnManageBookings
            // 
            this.btnManageBookings.BackColor = System.Drawing.Color.Maroon;
            this.btnManageBookings.FlatAppearance.BorderSize = 0;
            this.btnManageBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageBookings.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnManageBookings.ForeColor = System.Drawing.Color.White;
            this.btnManageBookings.Location = new System.Drawing.Point(26, 225);
            this.btnManageBookings.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnManageBookings.Name = "btnManageBookings";
            this.btnManageBookings.Size = new System.Drawing.Size(334, 87);
            this.btnManageBookings.TabIndex = 3;
            this.btnManageBookings.Text = "  Bookings";
            this.btnManageBookings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageBookings.UseVisualStyleBackColor = false;
            this.btnManageBookings.Click += new System.EventHandler(this.btnManageBookings_Click);
            // 
            // lblAdminRole
            // 
            this.lblAdminRole.AutoSize = true;
            this.lblAdminRole.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAdminRole.ForeColor = System.Drawing.Color.White;
            this.lblAdminRole.Location = new System.Drawing.Point(48, 120);
            this.lblAdminRole.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAdminRole.Name = "lblAdminRole";
            this.lblAdminRole.Size = new System.Drawing.Size(225, 32);
            this.lblAdminRole.TabIndex = 4;
            this.lblAdminRole.Text = "Administrator Portal";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(43, 53);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(396, 72);
            this.lblLogo.TabIndex = 5;
            this.lblLogo.Text = "IWS BOOKING";
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.White;
            this.header.Controls.Add(this.btnRefresh);
            this.header.Controls.Add(this.lblDate);
            this.header.Controls.Add(this.lblWelcome);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(386, 0);
            this.header.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1671, 153);
            this.header.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Maroon;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(1397, 42);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(214, 67);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDate.ForeColor = System.Drawing.Color.Maroon;
            this.lblDate.Location = new System.Drawing.Point(53, 92);
            this.lblDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(69, 36);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.Maroon;
            this.lblWelcome.Location = new System.Drawing.Point(48, 27);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(437, 65);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Admin Dashboard";
            // 
            // content
            // 
            this.content.BackColor = System.Drawing.Color.White;
            this.content.Controls.Add(this.tabAdmin);
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(386, 153);
            this.content.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.content.Name = "content";
            this.content.Padding = new System.Windows.Forms.Padding(38, 37, 38, 37);
            this.content.Size = new System.Drawing.Size(1671, 1047);
            this.content.TabIndex = 0;
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.tabOverview);
            this.tabAdmin.Controls.Add(this.tabBookings);
            this.tabAdmin.Controls.Add(this.tabReports);
            this.tabAdmin.Controls.Add(this.tabUsers);
            this.tabAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAdmin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabAdmin.Location = new System.Drawing.Point(38, 37);
            this.tabAdmin.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(1595, 973);
            this.tabAdmin.TabIndex = 0;
            // 
            // tabOverview
            // 
            this.tabOverview.BackColor = System.Drawing.Color.White;
            this.tabOverview.Controls.Add(this.pnlQuickActions);
            this.tabOverview.Controls.Add(this.cardStudents);
            this.tabOverview.Controls.Add(this.cardReports);
            this.tabOverview.Controls.Add(this.cardActive);
            this.tabOverview.Controls.Add(this.cardBookings);
            this.tabOverview.Controls.Add(this.lblOverviewTitle);
            this.tabOverview.Location = new System.Drawing.Point(8, 46);
            this.tabOverview.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tabOverview.Name = "tabOverview";
            this.tabOverview.Size = new System.Drawing.Size(1579, 919);
            this.tabOverview.TabIndex = 0;
            this.tabOverview.Text = "Overview";
            // 
            // pnlQuickActions
            // 
            this.pnlQuickActions.BackColor = System.Drawing.Color.White;
            this.pnlQuickActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlQuickActions.Controls.Add(this.btnQuickUsers);
            this.pnlQuickActions.Controls.Add(this.btnQuickReports);
            this.pnlQuickActions.Controls.Add(this.btnQuickBookings);
            this.pnlQuickActions.Controls.Add(this.lblQuickActions);
            this.pnlQuickActions.Location = new System.Drawing.Point(34, 367);
            this.pnlQuickActions.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlQuickActions.Name = "pnlQuickActions";
            this.pnlQuickActions.Size = new System.Drawing.Size(1507, 315);
            this.pnlQuickActions.TabIndex = 0;
            // 
            // btnQuickUsers
            // 
            this.btnQuickUsers.BackColor = System.Drawing.Color.Maroon;
            this.btnQuickUsers.FlatAppearance.BorderSize = 0;
            this.btnQuickUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickUsers.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnQuickUsers.ForeColor = System.Drawing.Color.White;
            this.btnQuickUsers.Location = new System.Drawing.Point(977, 103);
            this.btnQuickUsers.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnQuickUsers.Name = "btnQuickUsers";
            this.btnQuickUsers.Size = new System.Drawing.Size(429, 117);
            this.btnQuickUsers.TabIndex = 0;
            this.btnQuickUsers.Text = "Manage Users";
            this.btnQuickUsers.UseVisualStyleBackColor = false;
            this.btnQuickUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // btnQuickReports
            // 
            this.btnQuickReports.BackColor = System.Drawing.Color.Maroon;
            this.btnQuickReports.FlatAppearance.BorderSize = 0;
            this.btnQuickReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickReports.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnQuickReports.ForeColor = System.Drawing.Color.White;
            this.btnQuickReports.Location = new System.Drawing.Point(506, 103);
            this.btnQuickReports.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnQuickReports.Name = "btnQuickReports";
            this.btnQuickReports.Size = new System.Drawing.Size(429, 117);
            this.btnQuickReports.TabIndex = 1;
            this.btnQuickReports.Text = "View Reports";
            this.btnQuickReports.UseVisualStyleBackColor = false;
            this.btnQuickReports.Click += new System.EventHandler(this.btnViewReports_Click);
            // 
            // btnQuickBookings
            // 
            this.btnQuickBookings.BackColor = System.Drawing.Color.Maroon;
            this.btnQuickBookings.FlatAppearance.BorderSize = 0;
            this.btnQuickBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickBookings.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnQuickBookings.ForeColor = System.Drawing.Color.White;
            this.btnQuickBookings.Location = new System.Drawing.Point(34, 103);
            this.btnQuickBookings.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnQuickBookings.Name = "btnQuickBookings";
            this.btnQuickBookings.Size = new System.Drawing.Size(429, 117);
            this.btnQuickBookings.TabIndex = 2;
            this.btnQuickBookings.Text = "Manage Bookings";
            this.btnQuickBookings.UseVisualStyleBackColor = false;
            this.btnQuickBookings.Click += new System.EventHandler(this.btnManageBookings_Click);
            // 
            // lblQuickActions
            // 
            this.lblQuickActions.AutoSize = true;
            this.lblQuickActions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblQuickActions.Location = new System.Drawing.Point(34, 30);
            this.lblQuickActions.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblQuickActions.Name = "lblQuickActions";
            this.lblQuickActions.Size = new System.Drawing.Size(220, 45);
            this.lblQuickActions.TabIndex = 3;
            this.lblQuickActions.Text = "Quick actions";
            // 
            // cardStudents
            // 
            this.cardStudents.BackColor = System.Drawing.Color.White;
            this.cardStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardStudents.Controls.Add(this.lblStudentsValue);
            this.cardStudents.Controls.Add(this.lblStudentsCaption);
            this.cardStudents.Location = new System.Drawing.Point(1191, 103);
            this.cardStudents.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cardStudents.Name = "cardStudents";
            this.cardStudents.Size = new System.Drawing.Size(350, 207);
            this.cardStudents.TabIndex = 1;
            // 
            // lblStudentsValue
            // 
            this.lblStudentsValue.AutoSize = true;
            this.lblStudentsValue.Font = new System.Drawing.Font("Segoe UI", 27F, System.Drawing.FontStyle.Bold);
            this.lblStudentsValue.Location = new System.Drawing.Point(31, 30);
            this.lblStudentsValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStudentsValue.Name = "lblStudentsValue";
            this.lblStudentsValue.Size = new System.Drawing.Size(81, 96);
            this.lblStudentsValue.TabIndex = 0;
            this.lblStudentsValue.Text = "0";
            // 
            // lblStudentsCaption
            // 
            this.lblStudentsCaption.AutoSize = true;
            this.lblStudentsCaption.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblStudentsCaption.ForeColor = System.Drawing.Color.Maroon;
            this.lblStudentsCaption.Location = new System.Drawing.Point(34, 138);
            this.lblStudentsCaption.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStudentsCaption.Name = "lblStudentsCaption";
            this.lblStudentsCaption.Size = new System.Drawing.Size(204, 36);
            this.lblStudentsCaption.TabIndex = 1;
            this.lblStudentsCaption.Text = "Registered users";
            // 
            // cardReports
            // 
            this.cardReports.BackColor = System.Drawing.Color.White;
            this.cardReports.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardReports.Controls.Add(this.lblPendingReportsValue);
            this.cardReports.Controls.Add(this.lblReportsCaption);
            this.cardReports.Location = new System.Drawing.Point(806, 103);
            this.cardReports.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cardReports.Name = "cardReports";
            this.cardReports.Size = new System.Drawing.Size(350, 207);
            this.cardReports.TabIndex = 2;
            // 
            // lblPendingReportsValue
            // 
            this.lblPendingReportsValue.AutoSize = true;
            this.lblPendingReportsValue.Font = new System.Drawing.Font("Segoe UI", 27F, System.Drawing.FontStyle.Bold);
            this.lblPendingReportsValue.Location = new System.Drawing.Point(31, 30);
            this.lblPendingReportsValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPendingReportsValue.Name = "lblPendingReportsValue";
            this.lblPendingReportsValue.Size = new System.Drawing.Size(81, 96);
            this.lblPendingReportsValue.TabIndex = 0;
            this.lblPendingReportsValue.Text = "0";
            // 
            // lblReportsCaption
            // 
            this.lblReportsCaption.AutoSize = true;
            this.lblReportsCaption.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblReportsCaption.ForeColor = System.Drawing.Color.Maroon;
            this.lblReportsCaption.Location = new System.Drawing.Point(34, 138);
            this.lblReportsCaption.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblReportsCaption.Name = "lblReportsCaption";
            this.lblReportsCaption.Size = new System.Drawing.Size(198, 36);
            this.lblReportsCaption.TabIndex = 1;
            this.lblReportsCaption.Text = "Pending reports";
            // 
            // cardActive
            // 
            this.cardActive.BackColor = System.Drawing.Color.White;
            this.cardActive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardActive.Controls.Add(this.lblActiveBookingsValue);
            this.cardActive.Controls.Add(this.lblActiveCaption);
            this.cardActive.Location = new System.Drawing.Point(420, 103);
            this.cardActive.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cardActive.Name = "cardActive";
            this.cardActive.Size = new System.Drawing.Size(350, 207);
            this.cardActive.TabIndex = 3;
            // 
            // lblActiveBookingsValue
            // 
            this.lblActiveBookingsValue.AutoSize = true;
            this.lblActiveBookingsValue.Font = new System.Drawing.Font("Segoe UI", 27F, System.Drawing.FontStyle.Bold);
            this.lblActiveBookingsValue.Location = new System.Drawing.Point(31, 30);
            this.lblActiveBookingsValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblActiveBookingsValue.Name = "lblActiveBookingsValue";
            this.lblActiveBookingsValue.Size = new System.Drawing.Size(81, 96);
            this.lblActiveBookingsValue.TabIndex = 0;
            this.lblActiveBookingsValue.Text = "0";
            // 
            // lblActiveCaption
            // 
            this.lblActiveCaption.AutoSize = true;
            this.lblActiveCaption.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblActiveCaption.ForeColor = System.Drawing.Color.Maroon;
            this.lblActiveCaption.Location = new System.Drawing.Point(34, 138);
            this.lblActiveCaption.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblActiveCaption.Name = "lblActiveCaption";
            this.lblActiveCaption.Size = new System.Drawing.Size(197, 36);
            this.lblActiveCaption.TabIndex = 1;
            this.lblActiveCaption.Text = "Active bookings";
            // 
            // cardBookings
            // 
            this.cardBookings.BackColor = System.Drawing.Color.White;
            this.cardBookings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardBookings.Controls.Add(this.lblTotalBookingsValue);
            this.cardBookings.Controls.Add(this.lblBookingsCaption);
            this.cardBookings.Location = new System.Drawing.Point(34, 103);
            this.cardBookings.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cardBookings.Name = "cardBookings";
            this.cardBookings.Size = new System.Drawing.Size(350, 207);
            this.cardBookings.TabIndex = 4;
            // 
            // lblTotalBookingsValue
            // 
            this.lblTotalBookingsValue.AutoSize = true;
            this.lblTotalBookingsValue.Font = new System.Drawing.Font("Segoe UI", 27F, System.Drawing.FontStyle.Bold);
            this.lblTotalBookingsValue.Location = new System.Drawing.Point(31, 30);
            this.lblTotalBookingsValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTotalBookingsValue.Name = "lblTotalBookingsValue";
            this.lblTotalBookingsValue.Size = new System.Drawing.Size(81, 96);
            this.lblTotalBookingsValue.TabIndex = 0;
            this.lblTotalBookingsValue.Text = "0";
            // 
            // lblBookingsCaption
            // 
            this.lblBookingsCaption.AutoSize = true;
            this.lblBookingsCaption.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblBookingsCaption.ForeColor = System.Drawing.Color.Maroon;
            this.lblBookingsCaption.Location = new System.Drawing.Point(34, 138);
            this.lblBookingsCaption.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBookingsCaption.Name = "lblBookingsCaption";
            this.lblBookingsCaption.Size = new System.Drawing.Size(181, 36);
            this.lblBookingsCaption.TabIndex = 1;
            this.lblBookingsCaption.Text = "Total bookings";
            // 
            // lblOverviewTitle
            // 
            this.lblOverviewTitle.AutoSize = true;
            this.lblOverviewTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblOverviewTitle.Location = new System.Drawing.Point(34, 33);
            this.lblOverviewTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOverviewTitle.Name = "lblOverviewTitle";
            this.lblOverviewTitle.Size = new System.Drawing.Size(303, 47);
            this.lblOverviewTitle.TabIndex = 5;
            this.lblOverviewTitle.Text = "Today\'s overview";
            // 
            // tabBookings
            // 
            this.tabBookings.Controls.Add(this.btnCancelBooking);
            this.tabBookings.Controls.Add(this.dgvBookings);
            this.tabBookings.Controls.Add(this.lblBookingsTitle);
            this.tabBookings.Location = new System.Drawing.Point(8, 46);
            this.tabBookings.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tabBookings.Name = "tabBookings";
            this.tabBookings.Size = new System.Drawing.Size(1579, 919);
            this.tabBookings.TabIndex = 1;
            this.tabBookings.Text = "Bookings";
            // 
            // btnCancelBooking
            // 
            this.btnCancelBooking.BackColor = System.Drawing.Color.Maroon;
            this.btnCancelBooking.FlatAppearance.BorderSize = 0;
            this.btnCancelBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelBooking.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelBooking.ForeColor = System.Drawing.Color.White;
            this.btnCancelBooking.Location = new System.Drawing.Point(1282, 842);
            this.btnCancelBooking.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.Size = new System.Drawing.Size(274, 63);
            this.btnCancelBooking.TabIndex = 0;
            this.btnCancelBooking.Text = "Remove Booking";
            this.btnCancelBooking.UseVisualStyleBackColor = false;
            this.btnCancelBooking.Click += new System.EventHandler(this.btnCancelBooking_Click);
            // 
            // dgvBookings
            // 
            this.dgvBookings.AllowUserToAddRows = false;
            this.dgvBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookings.BackgroundColor = System.Drawing.Color.White;
            this.dgvBookings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBookings.ColumnHeadersHeight = 36;
            this.dgvBookings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRoom,
            this.colStudent,
            this.colStartTime,
            this.colBookingStatus});
            this.dgvBookings.Location = new System.Drawing.Point(31, 97);
            this.dgvBookings.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgvBookings.MultiSelect = false;
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.ReadOnly = true;
            this.dgvBookings.RowHeadersWidth = 82;
            this.dgvBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookings.Size = new System.Drawing.Size(1526, 717);
            this.dgvBookings.TabIndex = 1;
            // 
            // colRoom
            // 
            this.colRoom.HeaderText = "Room";
            this.colRoom.MinimumWidth = 10;
            this.colRoom.Name = "colRoom";
            this.colRoom.ReadOnly = true;
            // 
            // colStudent
            // 
            this.colStudent.HeaderText = "Student";
            this.colStudent.MinimumWidth = 10;
            this.colStudent.Name = "colStudent";
            this.colStudent.ReadOnly = true;
            // 
            // colStartTime
            // 
            this.colStartTime.HeaderText = "Time";
            this.colStartTime.MinimumWidth = 10;
            this.colStartTime.Name = "colStartTime";
            this.colStartTime.ReadOnly = true;
            // 
            // colBookingStatus
            // 
            this.colBookingStatus.HeaderText = "Status";
            this.colBookingStatus.MinimumWidth = 10;
            this.colBookingStatus.Name = "colBookingStatus";
            this.colBookingStatus.ReadOnly = true;
            // 
            // lblBookingsTitle
            // 
            this.lblBookingsTitle.AutoSize = true;
            this.lblBookingsTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblBookingsTitle.Location = new System.Drawing.Point(31, 30);
            this.lblBookingsTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBookingsTitle.Name = "lblBookingsTitle";
            this.lblBookingsTitle.Size = new System.Drawing.Size(307, 47);
            this.lblBookingsTitle.TabIndex = 2;
            this.lblBookingsTitle.Text = "Current bookings";
            // 
            // tabReports
            // 
            this.tabReports.Controls.Add(this.btnResolveReport);
            this.tabReports.Controls.Add(this.dgvReports);
            this.tabReports.Controls.Add(this.lblReportsTitle);
            this.tabReports.Location = new System.Drawing.Point(8, 46);
            this.tabReports.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tabReports.Name = "tabReports";
            this.tabReports.Size = new System.Drawing.Size(1579, 919);
            this.tabReports.TabIndex = 2;
            this.tabReports.Text = "Reports";
            // 
            // btnResolveReport
            // 
            this.btnResolveReport.BackColor = System.Drawing.Color.Maroon;
            this.btnResolveReport.FlatAppearance.BorderSize = 0;
            this.btnResolveReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResolveReport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnResolveReport.ForeColor = System.Drawing.Color.White;
            this.btnResolveReport.Location = new System.Drawing.Point(1282, 842);
            this.btnResolveReport.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnResolveReport.Name = "btnResolveReport";
            this.btnResolveReport.Size = new System.Drawing.Size(274, 63);
            this.btnResolveReport.TabIndex = 0;
            this.btnResolveReport.Text = "Mark Resolved";
            this.btnResolveReport.UseVisualStyleBackColor = false;
            this.btnResolveReport.Click += new System.EventHandler(this.btnResolveReport_Click);
            // 
            // dgvReports
            // 
            this.dgvReports.AllowUserToAddRows = false;
            this.dgvReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReports.BackgroundColor = System.Drawing.Color.White;
            this.dgvReports.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReports.ColumnHeadersHeight = 36;
            this.dgvReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colReportStudent,
            this.colComplaint,
            this.colDateSubmitted,
            this.colReportStatus});
            this.dgvReports.Location = new System.Drawing.Point(31, 97);
            this.dgvReports.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgvReports.MultiSelect = false;
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.ReadOnly = true;
            this.dgvReports.RowHeadersWidth = 82;
            this.dgvReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReports.Size = new System.Drawing.Size(1526, 717);
            this.dgvReports.TabIndex = 1;
            // 
            // colReportStudent
            // 
            this.colReportStudent.HeaderText = "Student";
            this.colReportStudent.MinimumWidth = 10;
            this.colReportStudent.Name = "colReportStudent";
            this.colReportStudent.ReadOnly = true;
            // 
            // colComplaint
            // 
            this.colComplaint.HeaderText = "Report";
            this.colComplaint.MinimumWidth = 10;
            this.colComplaint.Name = "colComplaint";
            this.colComplaint.ReadOnly = true;
            // 
            // colDateSubmitted
            // 
            this.colDateSubmitted.HeaderText = "Date";
            this.colDateSubmitted.MinimumWidth = 10;
            this.colDateSubmitted.Name = "colDateSubmitted";
            this.colDateSubmitted.ReadOnly = true;
            // 
            // colReportStatus
            // 
            this.colReportStatus.HeaderText = "Status";
            this.colReportStatus.MinimumWidth = 10;
            this.colReportStatus.Name = "colReportStatus";
            this.colReportStatus.ReadOnly = true;
            // 
            // lblReportsTitle
            // 
            this.lblReportsTitle.AutoSize = true;
            this.lblReportsTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblReportsTitle.Location = new System.Drawing.Point(31, 30);
            this.lblReportsTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblReportsTitle.Name = "lblReportsTitle";
            this.lblReportsTitle.Size = new System.Drawing.Size(280, 47);
            this.lblReportsTitle.TabIndex = 2;
            this.lblReportsTitle.Text = "Student reports";
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.dgvUsers);
            this.tabUsers.Controls.Add(this.lblUsersTitle);
            this.tabUsers.Location = new System.Drawing.Point(8, 46);
            this.tabUsers.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Size = new System.Drawing.Size(1579, 919);
            this.tabUsers.TabIndex = 3;
            this.tabUsers.Text = "Users";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsers.ColumnHeadersHeight = 36;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUserName,
            this.colUserEmail,
            this.colUserRole,
            this.colUserStatus});
            this.dgvUsers.Location = new System.Drawing.Point(31, 97);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersWidth = 82;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(1526, 808);
            this.dgvUsers.TabIndex = 0;
            // 
            // colUserName
            // 
            this.colUserName.HeaderText = "Name";
            this.colUserName.MinimumWidth = 10;
            this.colUserName.Name = "colUserName";
            this.colUserName.ReadOnly = true;
            // 
            // colUserEmail
            // 
            this.colUserEmail.HeaderText = "Email";
            this.colUserEmail.MinimumWidth = 10;
            this.colUserEmail.Name = "colUserEmail";
            this.colUserEmail.ReadOnly = true;
            // 
            // colUserRole
            // 
            this.colUserRole.HeaderText = "Role";
            this.colUserRole.MinimumWidth = 10;
            this.colUserRole.Name = "colUserRole";
            this.colUserRole.ReadOnly = true;
            // 
            // colUserStatus
            // 
            this.colUserStatus.HeaderText = "Status";
            this.colUserStatus.MinimumWidth = 10;
            this.colUserStatus.Name = "colUserStatus";
            this.colUserStatus.ReadOnly = true;
            // 
            // lblUsersTitle
            // 
            this.lblUsersTitle.AutoSize = true;
            this.lblUsersTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblUsersTitle.Location = new System.Drawing.Point(31, 30);
            this.lblUsersTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUsersTitle.Name = "lblUsersTitle";
            this.lblUsersTitle.Size = new System.Drawing.Size(290, 47);
            this.lblUsersTitle.TabIndex = 1;
            this.lblUsersTitle.Text = "Registered users";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2057, 1200);
            this.Controls.Add(this.content);
            this.Controls.Add(this.header);
            this.Controls.Add(this.sidebar);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MinimumSize = new System.Drawing.Size(1696, 1036);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IWS Booking - Admin Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            this.sidebar.ResumeLayout(false);
            this.sidebar.PerformLayout();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.content.ResumeLayout(false);
            this.tabAdmin.ResumeLayout(false);
            this.tabOverview.ResumeLayout(false);
            this.tabOverview.PerformLayout();
            this.pnlQuickActions.ResumeLayout(false);
            this.pnlQuickActions.PerformLayout();
            this.cardStudents.ResumeLayout(false);
            this.cardStudents.PerformLayout();
            this.cardReports.ResumeLayout(false);
            this.cardReports.PerformLayout();
            this.cardActive.ResumeLayout(false);
            this.cardActive.PerformLayout();
            this.cardBookings.ResumeLayout(false);
            this.cardBookings.PerformLayout();
            this.tabBookings.ResumeLayout(false);
            this.tabBookings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            this.tabReports.ResumeLayout(false);
            this.tabReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.tabUsers.ResumeLayout(false);
            this.tabUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnViewReports;
        private System.Windows.Forms.Button btnManageBookings;
        private System.Windows.Forms.Label lblAdminRole;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.TabControl tabAdmin;
        private System.Windows.Forms.TabPage tabOverview;
        private System.Windows.Forms.Panel pnlQuickActions;
        private System.Windows.Forms.Button btnQuickUsers;
        private System.Windows.Forms.Button btnQuickReports;
        private System.Windows.Forms.Button btnQuickBookings;
        private System.Windows.Forms.Label lblQuickActions;
        private System.Windows.Forms.Panel cardStudents;
        private System.Windows.Forms.Label lblStudentsCaption;
        private System.Windows.Forms.Label lblStudentsValue;
        private System.Windows.Forms.Panel cardReports;
        private System.Windows.Forms.Label lblReportsCaption;
        private System.Windows.Forms.Label lblPendingReportsValue;
        private System.Windows.Forms.Panel cardActive;
        private System.Windows.Forms.Label lblActiveCaption;
        private System.Windows.Forms.Label lblActiveBookingsValue;
        private System.Windows.Forms.Panel cardBookings;
        private System.Windows.Forms.Label lblBookingsCaption;
        private System.Windows.Forms.Label lblTotalBookingsValue;
        private System.Windows.Forms.Label lblOverviewTitle;
        private System.Windows.Forms.TabPage tabBookings;
        private System.Windows.Forms.Button btnCancelBooking;
        private System.Windows.Forms.DataGridView dgvBookings;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookingStatus;
        private System.Windows.Forms.Label lblBookingsTitle;
        private System.Windows.Forms.TabPage tabReports;
        private System.Windows.Forms.Button btnResolveReport;
        private System.Windows.Forms.DataGridView dgvReports;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReportStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComplaint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateSubmitted;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReportStatus;
        private System.Windows.Forms.Label lblReportsTitle;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserStatus;
        private System.Windows.Forms.Label lblUsersTitle;
    }
}
