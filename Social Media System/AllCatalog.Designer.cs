namespace Social_Media_System
{
    partial class AllCatalog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_myProfile = new Button();
            btn_myCatalog = new Button();
            dgv_catalog = new DataGridView();
            label2 = new Label();
            txt_catalogName = new TextBox();
            label1 = new Label();
            txt_catalogDescription = new TextBox();
            btn_allPosts = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_catalog).BeginInit();
            SuspendLayout();
            // 
            // btn_myProfile
            // 
            btn_myProfile.Location = new Point(579, 155);
            btn_myProfile.Name = "btn_myProfile";
            btn_myProfile.Size = new Size(209, 37);
            btn_myProfile.TabIndex = 29;
            btn_myProfile.Text = "My Profile";
            btn_myProfile.UseVisualStyleBackColor = true;
            btn_myProfile.Click += btn_myProfile_Click;
            // 
            // btn_myCatalog
            // 
            btn_myCatalog.Location = new Point(579, 35);
            btn_myCatalog.Name = "btn_myCatalog";
            btn_myCatalog.Size = new Size(209, 37);
            btn_myCatalog.TabIndex = 28;
            btn_myCatalog.Text = "My Catalog";
            btn_myCatalog.UseVisualStyleBackColor = true;
            btn_myCatalog.Click += btn_myCatalog_Click;
            // 
            // dgv_catalog
            // 
            dgv_catalog.AllowUserToAddRows = false;
            dgv_catalog.AllowUserToDeleteRows = false;
            dgv_catalog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_catalog.Location = new Point(1, 255);
            dgv_catalog.Name = "dgv_catalog";
            dgv_catalog.ReadOnly = true;
            dgv_catalog.RowHeadersWidth = 51;
            dgv_catalog.RowTemplate.Height = 29;
            dgv_catalog.Size = new Size(799, 188);
            dgv_catalog.TabIndex = 27;
            dgv_catalog.RowHeaderMouseDoubleClick += dgv_catalog_RowHeaderMouseDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1, 126);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 19;
            label2.Text = "Dscription";
            // 
            // txt_catalogName
            // 
            txt_catalogName.Location = new Point(83, 28);
            txt_catalogName.Name = "txt_catalogName";
            txt_catalogName.ReadOnly = true;
            txt_catalogName.Size = new Size(378, 27);
            txt_catalogName.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 17;
            label1.Text = "Name";
            // 
            // txt_catalogDescription
            // 
            txt_catalogDescription.Location = new Point(83, 126);
            txt_catalogDescription.Name = "txt_catalogDescription";
            txt_catalogDescription.ReadOnly = true;
            txt_catalogDescription.Size = new Size(378, 27);
            txt_catalogDescription.TabIndex = 30;
            // 
            // btn_allPosts
            // 
            btn_allPosts.Location = new Point(579, 93);
            btn_allPosts.Name = "btn_allPosts";
            btn_allPosts.Size = new Size(209, 37);
            btn_allPosts.TabIndex = 31;
            btn_allPosts.Text = "All Posts";
            btn_allPosts.UseVisualStyleBackColor = true;
            btn_allPosts.Click += btn_allPosts_Click;
            // 
            // AllCatalog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_allPosts);
            Controls.Add(txt_catalogDescription);
            Controls.Add(btn_myProfile);
            Controls.Add(btn_myCatalog);
            Controls.Add(dgv_catalog);
            Controls.Add(label2);
            Controls.Add(txt_catalogName);
            Controls.Add(label1);
            Name = "AllCatalog";
            Text = "AllCatalog";
            Load += AllCatalog_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_catalog).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_myProfile;
        private Button btn_myCatalog;
        private DataGridView dgv_catalog;
        private Label label2;
        private TextBox txt_catalogName;
        private Label label1;
        private TextBox txt_catalogDescription;
        private Button btn_allPosts;
    }
}