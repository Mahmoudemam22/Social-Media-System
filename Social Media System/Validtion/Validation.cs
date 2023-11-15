using Social_Media_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Social_Media_System.Validtion
{
    public static class Validation
    {

        public static bool ValidateEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            if (Regex.IsMatch(email, pattern))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid email address.");
                return false;
            }
        }
        public static bool ValidatePassword(string password)
        {
            string pattern = @"^(?=.*[a-zA-Z]).{8,}$";
            if (Regex.IsMatch(password, pattern))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Password Must Be more Than 8 char With one Letter ");
                return false;
            }
        }
        public static bool ValidateAge(decimal age)
        {
            if (age > 15) return true;
            else
            {
                MessageBox.Show("Age Must Be more Than 15");
                return false;
            }
        }
        public static bool IsUserNameValid(string userName ,DB_Context context)
        {
            string pattern = @"^[a-zA-Z0-9_]{3,20}$";
            if (userName == null)
            {
                MessageBox.Show(" Invalid Username");
                return false;
            }
            else if (context.authors.Any(i => i.UserName == userName))
            {
                MessageBox.Show(" Username Isnt available");
                return false;
            }
            else if (Regex.IsMatch(userName, pattern))
            {
                return true;
            }
            else
            {
                MessageBox.Show(" Username Must Be More Than 2 char less than 20 char ");
                return false;
            }
        }
    }
}
