using Social_Media_System.Model;
using Social_Media_System.Validtion;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Social_Media_System
{
    public partial class fr_Register : Form
    {

        public DB_Context context;
        public fr_Register()
        {
            InitializeComponent();
        }


        private void btn_register_Click(object sender, EventArgs e)
        {
            context = new DB_Context();
            if (Validation.IsUserNameValid(txt_usname.Text, context) && Validation.ValidatePassword(txt_pass.Text) && Validation.ValidateEmail(txt_email.Text) && Validation.ValidateAge(nud_age.Value))
            {
                Author author = new Author()
                {
                    UserName = txt_usname.Text,
                    Age = Convert.ToInt32(nud_age.Value),
                    Email = txt_email.Text,
                    Password = txt_pass.Text,

                };
                context.authors.Add(author);
                context.SaveChanges();
                MessageBox.Show("Thank you for Registering :)");
                Login login = new Login();
                login.Show();
                this.Hide();



            }
            else
            {
                MessageBox.Show("Invalid Data");
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }

}
