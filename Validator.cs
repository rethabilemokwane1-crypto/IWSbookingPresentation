using System.Windows.Forms;

namespace IWS_booking
{
    // Shared validation logic used by Form1 (Log In) and Form2 (Sign Up).
    // Pulled out of Form2 so both forms can call the same checks instead of
    // duplicating the same methods twice.
    public static class Validator
    {
        public static bool NotEmpty(string txt)
        {
            if (txt.Trim().Length == 0)
            {
                MessageBox.Show("This field is required");
                return false;
            }
            return true;
        }

        public static bool LettersOnly(string txt)
        {
            for (int i = 0; i < txt.Length; i++)
            {
                char L = txt[i];
                if (!char.IsLetter(L) && L != ' ')
                {
                    MessageBox.Show("Must contain letters and spaces");
                    return false;
                }
            }
            return true;
        }

        public static bool IsEmail(string email)
        {
            if (!email.Contains("@"))
            {
                MessageBox.Show("Email must contain '@'. ");
                return false;
            }
            else if (email.Contains(" "))
            {
                MessageBox.Show("email must not contain spaces.");
                return false;
            }
            else if (!email.Contains("."))
            {
                MessageBox.Show("email must contain a domain e.g .ac.za ");
                return false;
            }
            return true;
        }

        // Students sign up with @mywsu.ac.za, staff (Security/Librarian and
        // Librarian sign up with @wsu.ac.za. Checked after IsEmail so
        public static bool IsEmailForRole(string email, string role)
        {
            if (!IsEmail(email)) return false;

            string requiredDomain = role == "Student" ? "@mywsu.ac.za" : "@wsu.ac.za";
            if (!email.Trim().ToLower().EndsWith(requiredDomain))
            {
                MessageBox.Show(role + " accounts must use a " + requiredDomain + " email address.");
                return false;
            }
            return true;
        }

        public static bool PasswordCheck(string password)
        {
            if (password.Trim().Length < 8)
            {
                MessageBox.Show("password must have 8 characters");
                return false;
            }
            bool hasNumber = false;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    hasNumber = true;
                    break;
                }
            }
            if (!hasNumber)
            {
                MessageBox.Show("Password must contain at leaast 1 number");
                return false;
            }
            return true;
        }

        public static bool MatchPassword(string password, string passMatch)
        {
            if (passMatch != password)
            {
                MessageBox.Show("Must match password");
                return false;
            }
            return true;
        }

        // Validates the payload scanned from the QR code for discussion room check-in
        public static bool ValidateBookingCode(string bookingCode)
        {
            if (string.IsNullOrWhiteSpace(bookingCode))
                return false;

            // Basic check: Returns true if the code contains scanned text.
            // You can add specific room code formatting checks here.
            return bookingCode.Trim().Length > 0;
        }
    }
}
