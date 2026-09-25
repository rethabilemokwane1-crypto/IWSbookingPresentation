using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IWS_booking
{
    public partial class StudentDashboard : Form
    {
        // Placeholder in-memory data so the screen is clickable/demoable before
        // real storage (UserStore/BookingStore) exists. Swap these out once
        // rooms/bookings come from a real data source.
        private readonly List<string> myBookings = new List<string>();

        public StudentDashboard()
        {
            InitializeComponent();
            SeedComboBoxes();
        }

        private void SeedComboBoxes()
        {
            cmbRoom.Items.Clear();
            cmbRoom.Items.AddRange(new object[] { "Discussion Room A", "Discussion Room B", "Discussion Room C" });

            cmbTimeSlot.Items.Clear();
            cmbTimeSlot.Items.AddRange(new object[]
            {
                "09:00 - 10:00",
                "10:00 - 11:00",
                "11:00 - 12:00",
                "12:00 - 13:00",
                "13:00 - 14:00"
            });
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (cmbRoom.SelectedItem == null || cmbTimeSlot.SelectedItem == null)
            {
                MessageBox.Show("Please select both a room and a time slot.");
                return;
            }

            string entry = cmbRoom.SelectedItem + " @ " + cmbTimeSlot.SelectedItem;

            if (myBookings.Contains(entry))
            {
                MessageBox.Show("You've already booked that room and slot.");
                return;
            }

            // TODO: once BookingStore exists, check the room/slot isn't already
            // taken by someone else before adding it — this only stops the
            // same user double-booking the same slot for now.
            myBookings.Add(entry);
            lstMyBookings.Items.Add(entry);
            MessageBox.Show("Booking confirmed: " + entry);
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            if (lstMyBookings.SelectedItem == null)
            {
                MessageBox.Show("Select a booking from the list to cancel.");
                return;
            }

            string selected = lstMyBookings.SelectedItem.ToString();
            myBookings.Remove(selected);
            lstMyBookings.Items.Remove(lstMyBookings.SelectedItem);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }
    }
}
