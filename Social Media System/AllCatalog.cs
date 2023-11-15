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
    public partial class AllCatalog : Form
    {
        public string UserName { get; set; }
        public AllCatalog()
        {
            InitializeComponent();
        }

        private void AllCatalog_Load(object sender, EventArgs e)
        {
            DisplayAllCatalog();
        }

        private void DisplayAllCatalog()
        {
            try
            {
                using (DB_Context context = new DB_Context())
                {
                    dgv_catalog.DataSource = context.Catalogs.Select(i => new
                    {
                        CatalogID = i.ID,
                        CatalogName = i.Name,
                        CatalogDescribtion = i.Description,
                    })
                     .ToList();
                    dgv_catalog.Columns[0].Visible
                                        = false;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error loading Catalogs: {ex.Message}");
            }

        }
        private void btn_myProfile_Click(object sender, EventArgs e)
        {
            Profile myProfile = new Profile();
            myProfile.UserName = UserName;
            myProfile.Show();
            this.Hide();
        }
        private void btn_myCatalog_Click(object sender, EventArgs e)
        {
            MyCatalog myCatalog = new MyCatalog();
            myCatalog.UserName = UserName;
            myCatalog.Show();
            this.Hide();
        }

        private void btn_allPosts_Click(object sender, EventArgs e)
        {
            AllPosts posts = new AllPosts();
            posts.UserName = UserName;
            posts.Show();
            this.Hide();
        }

        private void dgv_catalog_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            catalog? CatalgData;
            int id = Convert.ToInt32(dgv_catalog.Rows[e.RowIndex].Cells[0].Value);
            try
            {
                using (DB_Context context = new DB_Context())
                {
                     CatalgData = context.Catalogs.FirstOrDefault(i => i.ID == id);
                }
                if (CatalgData != null)
                {
                    txt_catalogName.Text = CatalgData.Name;
                    txt_catalogDescription.Text = CatalgData.Description;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error loading Catalog details: {ex.Message}");
            }
        }
    }
}
