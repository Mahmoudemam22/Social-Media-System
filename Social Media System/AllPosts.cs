using Social_Media_System.Model;
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
    public partial class AllPosts : Form
    {
        Post PostData;

        public string UserName { get; set; }
        public AllPosts()
        {
            InitializeComponent();
        }

        private void AllPosts_Load(object sender, EventArgs e)
        {
            try
            {
                using (DB_Context context = new DB_Context())
                {
                    dgv_posts.DataSource = context.Posts.Select(i => new
                    {
                        PostID = i.Id,
                        PostTitle = i.Title,
                        PostDescribtion = i.Description,
                        PostDate = i.Date,
                        PostTime = i.Time,
                        AuthorUserName = i.Author.UserName,
                        AuthorEmail = i.Author.Email,
                        PostCatlogName = i.Catalog.Name,
                        PostCatlogDesc = i.Catalog.Description
                    })
                     .ToList();
                    dgv_posts.Columns[0].Visible
                                        = false;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error loading posts: {ex.Message}");
            }

        }

        private void dgv_posts_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dgv_posts.Rows[e.RowIndex].Cells[0].Value);
            try
            {
                using (DB_Context context = new DB_Context())
                {
                    PostData = context.Posts.FirstOrDefault(i => i.Id == id);
                }
                if (PostData != null)
                {
                    txt_post_title.Text = PostData.Title;
                    rtb_description.Text = PostData.Description;
                    lbl_postdate.Text = PostData.Date.ToString();
                    lbl_posttime.Text = PostData.Time.ToString();
                    using (MemoryStream memoryStream = new MemoryStream(PostData.ImageData))
                    {
                        pb_allpost.Image = Image.FromStream(memoryStream);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error loading post details: {ex.Message}");
            }

        }

        private void btn_mypost_Click(object sender, EventArgs e)
        {
            MyPosts myPosts = new MyPosts();
            myPosts.UserName= UserName;
            myPosts.Show();
            this.Hide();
        }

        private void btn_createPost_Click(object sender, EventArgs e)
        {
            AllCatalog allCatalog = new AllCatalog()
            {
                UserName = UserName
            };
            allCatalog.Show();
            this.Hide();
        }

        private void btn_Profile_Click(object sender, EventArgs e)
        {
            Profile myProfile = new Profile();
            myProfile.UserName = UserName;
            myProfile.Show();
            this.Hide();
        }
    }
}
