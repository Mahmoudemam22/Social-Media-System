namespace Social_Media_System
{
    partial class Profile
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
            btn_save = new Button();
            btn_Allpost = new Button();
            label2 = new Label();
            txt_userName = new TextBox();
            label1 = new Label();
            openFileDialog = new OpenFileDialog();
            txt_Email = new TextBox();
            label3 = new Label();
            nud_Age = new NumericUpDown();
            btn_MyPosts = new Button();
            btn_AllCatalog = new Button();
            btn_changPassword = new Button();
            ((System.ComponentModel.ISupportInitialize)nud_Age).BeginInit();
            SuspendLayout();
            // 
            // btn_save
            // 
            btn_save.Location = new Point(153, 148);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(136, 36);
            btn_save.TabIndex = 51;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_Allpost
            // 
            btn_Allpost.Location = new Point(39, 245);
            btn_Allpost.Name = "btn_Allpost";
            btn_Allpost.Size = new Size(149, 36);
            btn_Allpost.TabIndex = 50;
            btn_Allpost.Text = "All Post";
            btn_Allpost.UseVisualStyleBackColor = true;
            btn_Allpost.Click += btn_Allpost_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 97);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 42;
            label2.Text = "Age";
            // 
            // txt_userName
            // 
            txt_userName.Location = new Point(96, 37);
            txt_userName.Name = "txt_userName";
            txt_userName.Size = new Size(262, 27);
            txt_userName.TabIndex = 41;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 44);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 40;
            label1.Text = "User Name";
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(497, 37);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(262, 27);
            txt_Email.TabIndex = 57;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(416, 40);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 56;
            label3.Text = "Email";
            // 
            // nud_Age
            // 
            nud_Age.Location = new Point(96, 90);
            nud_Age.Name = "nud_Age";
            nud_Age.Size = new Size(150, 27);
            nud_Age.TabIndex = 58;
            // 
            // btn_MyPosts
            // 
            btn_MyPosts.Location = new Point(320, 245);
            btn_MyPosts.Name = "btn_MyPosts";
            btn_MyPosts.Size = new Size(152, 36);
            btn_MyPosts.TabIndex = 59;
            btn_MyPosts.Text = "My Post";
            btn_MyPosts.UseVisualStyleBackColor = true;
            btn_MyPosts.Click += btn_MyPosts_Click;
            // 
            // btn_AllCatalog
            // 
            btn_AllCatalog.Location = new Point(605, 245);
            btn_AllCatalog.Name = "btn_AllCatalog";
            btn_AllCatalog.Size = new Size(152, 36);
            btn_AllCatalog.TabIndex = 60;
            btn_AllCatalog.Text = "All Catalog";
            btn_AllCatalog.UseVisualStyleBackColor = true;
            btn_AllCatalog.Click += btn_AllCatalog_Click;
            // 
            // btn_changPassword
            // 
            btn_changPassword.Location = new Point(524, 148);
            btn_changPassword.Name = "btn_changPassword";
            btn_changPassword.Size = new Size(136, 36);
            btn_changPassword.TabIndex = 61;
            btn_changPassword.Text = "Change Password";
            btn_changPassword.UseVisualStyleBackColor = true;
            btn_changPassword.Click += btn_changPassword_Click;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_changPassword);
            Controls.Add(btn_AllCatalog);
            Controls.Add(btn_MyPosts);
            Controls.Add(nud_Age);
            Controls.Add(txt_Email);
            Controls.Add(label3);
            Controls.Add(btn_save);
            Controls.Add(btn_Allpost);
            Controls.Add(label2);
            Controls.Add(txt_userName);
            Controls.Add(label1);
            Name = "Profile";
            Text = "Profile";
            Load += Profile_Load;
            ((System.ComponentModel.ISupportInitialize)nud_Age).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_save;
        private Button btn_Allpost;
        private Label label2;
        private TextBox txt_userName;
        private Label label1;
        private OpenFileDialog openFileDialog;
        private TextBox txt_Email;
        private Label label3;
        private NumericUpDown nud_Age;
        private Button btn_MyPosts;
        private Button btn_AllCatalog;
        private Button btn_changPassword;
    }
}