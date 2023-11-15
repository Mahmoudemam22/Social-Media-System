using Microsoft.EntityFrameworkCore;
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
    public partial class MyCatalog : Form
    {
        public string UserName { get; set; }
        int id;
        public MyCatalog()
        {
            InitializeComponent();
        }
        private void DisplayAllCatalog()
        {
            try
            {
                using (DB_Context context = new DB_Context())
                {
                    dgv_MyCatalog.DataSource = context.Posts.Where(i => i.AuturUserName == UserName).Select(i => new
                    {
                        CatalogID = i.Catalog_ID,
                        CatalogName = i.Catalog.Name,
                        CatalogDescribtion = i.Catalog.Description,
                    })
                     .ToList();
                    dgv_MyCatalog.Columns[0].Visible
                                        = false;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error loading Catalogs: {ex.Message}");
            }

        }

        private void MyCatalog_Load(object sender, EventArgs e)
        {
            DisplayAllCatalog();
        }

        private void btn_AllCatalog_Click(object sender, EventArgs e)
        {
            AllCatalog allCatalog = new AllCatalog();
            allCatalog.UserName = UserName;
            allCatalog.Show();
            this.Hide();
        }

        private void btn_myProfile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.UserName = UserName;
            profile.Show();
            this.Hide();
        }

        private void dgv_MyCatalog_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_Add.Visible = false;
            btn_Edit.Visible = true;
            btn_delete.Visible = true;
            id = Convert.ToInt32(dgv_MyCatalog.Rows[e.RowIndex].Cells[0].Value);
            try
            {
                catalog catalogData;
                using (DB_Context context = new DB_Context())
                {
                    catalogData = context.Catalogs.FirstOrDefault(i => i.ID == id);
                }
                if (catalogData != null)
                {
                    txt_catlogDesc.Text = catalogData.Description;
                    txt_catalogtitle.Text = catalogData.Name;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error loading catalog details: {ex.Message}");
            }

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                        !String.IsNullOrEmpty(txt_catalogtitle.Text)
                        && !String.IsNullOrEmpty(txt_catlogDesc.Text)
                        )
                {
                    using (DB_Context context = new DB_Context())
                    {

                        var catalog = new catalog();

                        catalog.Description = txt_catlogDesc.Text;
                        catalog.Name = txt_catalogtitle.Text;

                        context.Catalogs.Add(catalog);
                        context.SaveChanges();
                        DisplayAllCatalog();
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
                    var catalog = context.Catalogs.FirstOrDefault(i => i.ID == id);
                    if (catalog != null
                        && !String.IsNullOrEmpty(txt_catalogtitle.Text)
                        && !String.IsNullOrEmpty(txt_catlogDesc.Text)
                        )
                    {
                        catalog.Description = txt_catlogDesc.Text;
                        catalog.Name = txt_catalogtitle.Text;
                    }
                    context.SaveChanges();
                }
                DisplayAllCatalog();
                MessageBox.Show($" Successful Edit :)");
                btn_Add.Visible = true;
                btn_Edit.Visible = false;
                btn_delete.Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error Editing Your Catalog: {ex.Message}");
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                using (DB_Context context = new DB_Context())
                {
                    var catalog = context.Catalogs.Where(i => i.ID == id);
                    if (catalog != null)
                    {
                        context.Remove(catalog);
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

                MessageBox.Show($"Error Deleting Your Catalog: {ex.Message}");
            }

        }
    }
}

