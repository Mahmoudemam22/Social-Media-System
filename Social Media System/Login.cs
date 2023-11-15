using Social_Media_System.Model;
using Social_Media_System.Validtion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Social_Media_System
{
    public partial class Login : Form
    {
        DB_Context context;
        public Login()
        {
            InitializeComponent();
            context = new DB_Context();

        }
        public bool IsUserNameValid(string userName)
        {
            if (userName == null)
            {
                MessageBox.Show(" Invalid Username");
                return false;
            }
            return (context.authors.Any(i => i.UserName == userName));
        }
        public bool IsPassWordValid(string userName, string password)
        {
            Author? userPassword = context.authors.FirstOrDefault
                                    (i => i.UserName == userName);
            if (userPassword != null && password != null && userPassword.Password == password)
                return true;
            return false;
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (IsUserNameValid(txt_usname.Text) && !string.IsNullOrEmpty(txt_pass.Text))
            {
                if (IsPassWordValid(txt_usname.Text, txt_pass.Text))
                {
                    Profile profile = new Profile();
                    profile.UserName = txt_usname.Text;
                    profile.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Your UserName And Password Dosnt Match ");
                }

            }
            else
            {
                MessageBox.Show("Invalid Data ");
            }
        }
    }
}

