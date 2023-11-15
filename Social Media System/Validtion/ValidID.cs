using Social_Media_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Media_System.Validtion
{
    public static class ValidID
    {
        public static bool IsUserNameValid(string userName, DB_Context context)
        {
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
            return true;
        }
    }
}
