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
using System.Drawing;
namespace Social_Media_System
{
    public partial class MyPosts : Form
    {
        int id;
        byte[] imageData;
        public string UserName { get; set; }

        public MyPosts()
        {
            InitializeComponent();
        }
        void clear()
        {
            txt_post_title.Text = rtb_description.Text
             = lbl_postdate.Text = lbl_posttime.Text = txt_catalogName.Text = txt_catalogDesc.Text = "";
            pb_mypost.Image = null;

        }
        void GetAllData()
        {
            try
            {
                using (DB_Context context = new DB_Context())
                {
                    dgv_MyPost.DataSource = context.Posts.Where(i => i.AuturUserName == UserName).Select(i => new
                    {
                        PostID = i.Id,
                        CatlogId = i.Catalog_ID,
                        PostTitle = i.Title,
                        PostDescribtion = i.Description,
                        PostDate = i.Date,
                        PostTime = i.Time,
                        PostCatlogName = i.Catalog.Name,
                        PostCatlogDesc = i.Catalog.Description,
                    })
                     .ToList();
                }

                dgv_MyPost.Columns[0].Visible
                    = false;
                dgv_MyPost.Columns[1].Visible
                    = false;
                btn_Edit.Visible = false;
                btn_delete.Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error loading Your Posts: {ex.Message}");
            }
        }
        private void MyPosts_Load(object sender, EventArgs e)
        {
            GetAllData();
        }

        private void dgv_MyPost_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_Add.Visible = false;
            btn_Edit.Visible = true;
            btn_delete.Visible = true;
            id = Convert.ToInt32(dgv_MyPost.Rows[e.RowIndex].Cells[0].Value);
            try
            {
                Post PostData;
                using (DB_Context context = new DB_Context())
                {
                    PostData = context.Posts.FirstOrDefault(i => i.Id == id);
                }
                if (PostData != null)
                {
                    txt_post_title.Text = PostData.Title;
                    txt_catalogName.Text = PostData.Catalog.Name;
                    txt_catalogDesc.Text = PostData.Catalog.Description;
                    rtb_description.Text = PostData.Description;
                    lbl_postdate.Text = PostData.Date.ToString();
                    lbl_posttime.Text = PostData.Time.ToString();
                    using (MemoryStream memoryStream = new MemoryStream(PostData.ImageData))
                    {
                        pb_mypost.Image = Image.FromStream(memoryStream);
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error loading post details: {ex.Message}");
            }

        }

        private void btn_EditePhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif)|*.jpg; *.jpeg; *.png; *.gif";
                openFileDialog.Title = "Select an Image File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imageData = File.ReadAllBytes(openFileDialog.FileName);
                    pb_mypost.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                        !String.IsNullOrEmpty(txt_post_title.Text)
                        && !String.IsNullOrEmpty(rtb_description.Text)
                        && pb_mypost.Image != null)
                {
                    using (DB_Context context = new DB_Context())
                    {

                        var post = new Post();

                        post.Title = txt_post_title.Text;
                        post.Description = rtb_description.Text;
                        post.Date = DateTime.Now.Date;
                        post.Time = DateTime.Now.TimeOfDay;
                        post.ImageData = imageData;
                        post.AuturUserName = UserName;
                        post.Author = context.authors.FirstOrDefault(i => i.UserName == UserName);
                        post.Catalog = new catalog()
                        {
                            Name = txt_catalogName.Text,
                            Description = txt_catalogDesc.Text
                        };
                        context.Posts.Add(post);
                        context.SaveChanges();
                        GetAllData();
                    }
                    MessageBox.Show($" Successful ADD :)");
                }
                else
                {
                    MessageBox.Show($" ADD Faild => Your Data Is Invalid :(");

                }

                btn_Add.Visible = true;
                btn_Edit.Visible = false;
                btn_delete.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Adding Your Posts: {ex.Message}");
            }



        }
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                using (DB_Context context = new DB_Context())
                {
                    var post = context.Posts.FirstOrDefault(i => i.Id == id);
                    if (post != null
                        && !String.IsNullOrEmpty(txt_post_title.Text)
                        && !String.IsNullOrEmpty(rtb_description.Text)
                        && !String.IsNullOrEmpty(txt_catalogName.Text)
                        && !String.IsNullOrEmpty(txt_catalogDesc.Text)
                        && pb_mypost.Image != null)
                    {
                        post.Title = txt_post_title.Text;
                        post.Description = rtb_description.Text;
                        post.Date = DateTime.Now.Date;
                        post.Time = DateTime.Now.TimeOfDay;
                        post.ImageData = imageData;
                        post.Catalog.Name = txt_catalogName.Text;
                        post.Catalog.Description = txt_catalogDesc.Text;
                    }
                    context.SaveChanges();
                }
                GetAllData();
                MessageBox.Show($" Successful Edit :)");
                btn_Add.Visible = true;
                btn_Edit.Visible = false;
                btn_delete.Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error Editing Your Posts: {ex.Message}");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                using (DB_Context context = new DB_Context())
                {
                    var post = context.Posts.Where(i => i.Id == id);
                    if (post != null)
                    {
                        context.Remove(post);
                    }
                    context.SaveChanges();
                }
                MessageBox.Show($" Successful Delete :)");
                btn_Add.Visible = true;
                btn_Edit.Visible = false;
                btn_delete.Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error Deleting Your Posts: {ex.Message}");
            }
        }

        private void btn_Allpost_Click(object sender, EventArgs e)
        {
            AllPosts allPosts = new AllPosts();
            allPosts.UserName= UserName;
            allPosts.Show();
            this.Hide();
        }

        private void btn_myProfile_Click(object sender, EventArgs e)
        {
            Profile myProfile = new Profile();
            myProfile.UserName = UserName;
            myProfile.Show();
            this.Hide();
        }
    }
}
