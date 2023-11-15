namespace Social_Media_System
{
    partial class MyCatalog
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
            btn_Add = new Button();
            btn_delete = new Button();
            btn_Edit = new Button();
            btn_AllCatalog = new Button();
            label2 = new Label();
            txt_catalogtitle = new TextBox();
            label1 = new Label();
            dgv_MyCatalog = new DataGridView();
            txt_catlogDesc = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_MyCatalog).BeginInit();
            SuspendLayout();
            // 
            // btn_myProfile
            // 
            btn_myProfile.Location = new Point(586, 75);
            btn_myProfile.Name = "btn_myProfile";
            btn_myProfile.Size = new Size(209, 36);
            btn_myProfile.TabIndex = 60;
            btn_myProfile.Text = "My Profile";
            btn_myProfile.UseVisualStyleBackColor = true;
            btn_myProfile.Click += btn_myProfile_Click;
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(53, 167);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(136, 36);
            btn_Add.TabIndex = 55;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(390, 167);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(158, 36);
            btn_delete.TabIndex = 53;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_Edit
            // 
            btn_Edit.Location = new Point(222, 167);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(136, 36);
            btn_Edit.TabIndex = 52;
            btn_Edit.Text = "Edit";
            btn_Edit.UseVisualStyleBackColor = true;
            btn_Edit.Click += btn_Edit_Click;
            // 
            // btn_AllCatalog
            // 
            btn_AllCatalog.Location = new Point(586, 22);
            btn_AllCatalog.Name = "btn_AllCatalog";
            btn_AllCatalog.Size = new Size(209, 36);
            btn_AllCatalog.TabIndex = 51;
            btn_AllCatalog.Text = "All Catalog";
            btn_AllCatalog.UseVisualStyleBackColor = true;
            btn_AllCatalog.Click += btn_AllCatalog_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 100);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 43;
            label2.Text = "Dscription";
            // 
            // txt_catalogtitle
            // 
            txt_catalogtitle.Location = new Point(86, 27);
            txt_catalogtitle.Name = "txt_catalogtitle";
            txt_catalogtitle.Size = new Size(336, 27);
            txt_catalogtitle.TabIndex = 42;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 34);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 41;
            label1.Text = "Title";
            // 
            // dgv_MyCatalog
            // 
            dgv_MyCatalog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_MyCatalog.Location = new Point(4, 254);
            dgv_MyCatalog.Name = "dgv_MyCatalog";
            dgv_MyCatalog.RowHeadersWidth = 51;
            dgv_MyCatalog.RowTemplate.Height = 29;
            dgv_MyCatalog.Size = new Size(791, 190);
            dgv_MyCatalog.TabIndex = 39;
            dgv_MyCatalog.RowHeaderMouseDoubleClick += dgv_MyCatalog_RowHeaderMouseDoubleClick;
            // 
            // txt_catlogDesc
            // 
            txt_catlogDesc.Location = new Point(86, 100);
            txt_catlogDesc.Name = "txt_catlogDesc";
            txt_catlogDesc.Size = new Size(336, 27);
            txt_catlogDesc.TabIndex = 61;
            // 
            // MyCatalog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_catlogDesc);
            Controls.Add(btn_myProfile);
            Controls.Add(btn_Add);
            Controls.Add(btn_delete);
            Controls.Add(btn_Edit);
            Controls.Add(btn_AllCatalog);
            Controls.Add(label2);
            Controls.Add(txt_catalogtitle);
            Controls.Add(label1);
            Controls.Add(dgv_MyCatalog);
            Name = "MyCatalog";
            Text = "MyCatalog";
            Load += MyCatalog_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_MyCatalog).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_myProfile;
        private Button btn_Add;
        private Button btn_delete;
        private Button btn_Edit;
        private Button btn_AllCatalog;
        private Label label2;
        private TextBox txt_catalogtitle;
        private Label label1;
        private DataGridView dgv_MyCatalog;
        private TextBox txt_catlogDesc;
    }
}