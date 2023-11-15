using Social_Media_System.Model;
using Social_Media_System.Validtion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Social_Media_System
{
    public partial class Profile : Form
    {

        public string UserName { get; set; }
        public Profile()
        {
            InitializeComponent();
        }


        private void btn_Allpost_Click(object sender, EventArgs e)
        {
            AllPosts allPosts = new AllPosts();
            allPosts.UserName = UserName;
            allPosts.Show();
            this.Hide();
        }

        private void btn_MyPosts_Click(object sender, EventArgs e)
        {
            MyPosts myPosts = new MyPosts();
            myPosts.UserName = UserName;
            myPosts.Show();
            this.Hide();
        }

        private void btn_AllCatalog_Click(object sender, EventArgs e)
        {
            AllCatalog allCatalog = new AllCatalog();
            allCatalog.UserName = UserName;
            allCatalog.Show();
            this.Hide();

        }

        private void btn_changPassword_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.UserName = UserName;
            //changePassword.Show();
            //this.Hide();

        }

        private void Profile_Load(object sender, EventArgs e)
        {
            txt_userName.Text = UserName;
            using (DB_Context Context = new DB_Context())
            {
                var Author = Context.authors.Where(i => i.UserName == UserName).FirstOrDefault();
                if (Author != null)
                {
                    txt_Email.Text = Author.Email;
                    nud_Age.Value = Author.Age;
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            if (Validation.IsUserNameValid(txt_userName.Text, new DB_Context())
                && Validation.ValidateEmail(txt_Email.Text)
                && Validation.ValidateAge(nud_Age.Value))
            {
                using (DB_Context Context = new DB_Context())
                {
                    var Author = Context.authors.Where(i => i.UserName == UserName).FirstOrDefault();
                    if (Author != null)
                    {
                        Author.UserName = txt_userName.Text;
                        Author.Email = txt_Email.Text;
                        Author.Age = Convert.ToInt32(nud_Age.Value);
                    }
                    Context.SaveChanges();
                }
                Login login  = new Login();
                login.Show();
                this.Hide();
            }
        }
    }
}
