using System;
using System.Drawing;
using System.Windows.Forms;

namespace IWS_booking
{
    public partial class Form4 : Form
    {
        private int totalBookings = 0;
        private int activeBookings = 0;
        private int pendingReports = 0;
        private int totalStudents = 0;

        public Form4()
        {
            InitializeComponent();
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            lblTotalBookingsValue.Text = totalBookings.ToString();
            lblActiveBookingsValue.Text = activeBookings.ToString();
            lblPendingReportsValue.Text = pendingReports.ToString();
            lblStudentsValue.Text = totalStudents.ToString();

            dgvBookings.Rows.Clear();
            dgvBookings.Rows.Add("Discussion Room A", "Rethabile Mokwane", "09:00 - 10:00", "Confirmed");
            dgvBookings.Rows.Add("Discussion Room B", "Thando N.", "10:00 - 11:00", "Confirmed");
            dgvBookings.Rows.Add("Discussion Room C", "Lerato M.", "11:00 - 12:00", "Pending");
            dgvBookings.Rows.Add("Discussion Room A", "Siyabonga K.", "13:00 - 14:00", "Confirmed");

            dgvReports.Rows.Clear();
            dgvReports.Rows.Add("Rethabile Mokwane", "Room A equipment issue", DateTime.Today.ToShortDateString(), "Pending");
            dgvReports.Rows.Add("Thando N.", "Room B needs cleaning", DateTime.Today.AddDays(-1).ToShortDateString(), "Pending");
            dgvReports.Rows.Add("Lerato M.", "Projector not working", DateTime.Today.AddDays(-2).ToShortDateString(), "Resolved");

            dgvUsers.Rows.Clear();
            dgvUsers.Rows.Add("Rethabile Mokwane", "rethabile@example.com", "Student", "Active");
            dgvUsers.Rows.Add("Thando N.", "thando@example.com", "Student", "Active");
            dgvUsers.Rows.Add("Lerato M.", "lerato@example.com", "Student", "Active");
            dgvUsers.Rows.Add("Admin", "admin@iws.local", "Administrator", "Active");

            lblDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDashboardData();
            MessageBox.Show("Dashboard refreshed.", "IWS Booking",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnManageBookings_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedTab = tabBookings;
        }

        private void btnViewReports_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedTab = tabReports;
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedTab = tabUsers;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Log out",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void btnResolveReport_Click(object sender, EventArgs e)
        {
            if (dgvReports.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a report first.", "Reports",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dgvReports.SelectedRows[0].Cells["colReportStatus"].Value = "Resolved";
            MessageBox.Show("Report marked as resolved.", "Reports",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            if (dgvBookings.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a booking first.", "Bookings",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dgvBookings.Rows.RemoveAt(dgvBookings.SelectedRows[0].Index);
            MessageBox.Show("Booking removed from the dashboard.", "Bookings",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}
