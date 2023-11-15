namespace Social_Media_System
{
    partial class MyPosts
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
            dgv_MyPost = new DataGridView();
            btn_Allpost = new Button();
            label4 = new Label();
            lbl_posttime = new Label();
            label6 = new Label();
            label5 = new Label();
            rtb_description = new RichTextBox();
            lbl_postdate = new Label();
            label3 = new Label();
            label2 = new Label();
            txt_post_title = new TextBox();
            label1 = new Label();
            pb_mypost = new PictureBox();
            btn_Edit = new Button();
            btn_delete = new Button();
            btn_EditePhoto = new Button();
            openFileDialog = new OpenFileDialog();
            btn_Add = new Button();
            txt_catalogDesc = new TextBox();
            label8 = new Label();
            txt_catalogName = new TextBox();
            label7 = new Label();
            btn_myProfile = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_MyPost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_mypost).BeginInit();
            SuspendLayout();
            // 
            // dgv_MyPost
            // 
            dgv_MyPost.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_MyPost.Location = new Point(2, 296);
            dgv_MyPost.Name = "dgv_MyPost";
            dgv_MyPost.RowHeadersWidth = 51;
            dgv_MyPost.RowTemplate.Height = 29;
            dgv_MyPost.Size = new Size(791, 153);
            dgv_MyPost.TabIndex = 0;
            dgv_MyPost.RowHeaderMouseDoubleClick += dgv_MyPost_RowHeaderMouseDoubleClick;
            // 
            // btn_Allpost
            // 
            btn_Allpost.Location = new Point(576, 187);
            btn_Allpost.Name = "btn_Allpost";
            btn_Allpost.Size = new Size(209, 36);
            btn_Allpost.TabIndex = 27;
            btn_Allpost.Text = "All Post";
            btn_Allpost.UseVisualStyleBackColor = true;
            btn_Allpost.Click += btn_Allpost_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1, 165);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 26;
            label4.Text = "Post Time";
            // 
            // lbl_posttime
            // 
            lbl_posttime.AutoSize = true;
            lbl_posttime.Location = new Point(117, 165);
            lbl_posttime.Name = "lbl_posttime";
            lbl_posttime.Size = new Size(0, 20);
            lbl_posttime.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(312, 165);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 24;
            label6.Text = "Post Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(482, 39);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 23;
            label5.Text = "Post Images";
            // 
            // rtb_description
            // 
            rtb_description.Location = new Point(84, 85);
            rtb_description.Name = "rtb_description";
            rtb_description.Size = new Size(378, 77);
            rtb_description.TabIndex = 22;
            rtb_description.Text = "";
            // 
            // lbl_postdate
            // 
            lbl_postdate.AutoSize = true;
            lbl_postdate.Location = new Point(428, 165);
            lbl_postdate.Name = "lbl_postdate";
            lbl_postdate.Size = new Size(0, 20);
            lbl_postdate.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 165);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1, 105);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 19;
            label2.Text = "Dscription";
            // 
            // txt_post_title
            // 
            txt_post_title.Location = new Point(84, 32);
            txt_post_title.Name = "txt_post_title";
            txt_post_title.Size = new Size(378, 27);
            txt_post_title.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 39);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 17;
            label1.Text = "Title";
            // 
            // pb_mypost
            // 
            pb_mypost.Location = new Point(576, 11);
            pb_mypost.Name = "pb_mypost";
            pb_mypost.Size = new Size(220, 95);
            pb_mypost.TabIndex = 16;
            pb_mypost.TabStop = false;
            // 
            // btn_Edit
            // 
            btn_Edit.Location = new Point(195, 254);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(136, 36);
            btn_Edit.TabIndex = 29;
            btn_Edit.Text = "Edit";
            btn_Edit.UseVisualStyleBackColor = true;
            btn_Edit.Click += btn_Edit_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(363, 254);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(158, 36);
            btn_delete.TabIndex = 31;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_EditePhoto
            // 
            btn_EditePhoto.Location = new Point(576, 112);
            btn_EditePhoto.Name = "btn_EditePhoto";
            btn_EditePhoto.Size = new Size(209, 36);
            btn_EditePhoto.TabIndex = 32;
            btn_EditePhoto.Text = "Uplode Photo";
            btn_EditePhoto.UseVisualStyleBackColor = true;
            btn_EditePhoto.Click += btn_EditePhoto_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(26, 254);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(136, 36);
            btn_Add.TabIndex = 33;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // txt_catalogDesc
            // 
            txt_catalogDesc.Location = new Point(415, 207);
            txt_catalogDesc.Name = "txt_catalogDesc";
            txt_catalogDesc.Size = new Size(145, 27);
            txt_catalogDesc.TabIndex = 37;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(312, 214);
            label8.Name = "label8";
            label8.Size = new Size(97, 20);
            label8.TabIndex = 36;
            label8.Text = "Catalog Desc";
            // 
            // txt_catalogName
            // 
            txt_catalogName.Location = new Point(113, 211);
            txt_catalogName.Name = "txt_catalogName";
            txt_catalogName.Size = new Size(174, 27);
            txt_catalogName.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(2, 214);
            label7.Name = "label7";
            label7.Size = new Size(105, 20);
            label7.TabIndex = 34;
            label7.Text = "Catalog Name";
            // 
            // btn_myProfile
            // 
            btn_myProfile.Location = new Point(576, 241);
            btn_myProfile.Name = "btn_myProfile";
            btn_myProfile.Size = new Size(209, 36);
            btn_myProfile.TabIndex = 38;
            btn_myProfile.Text = "My Profile";
            btn_myProfile.UseVisualStyleBackColor = true;
            btn_myProfile.Click += btn_myProfile_Click;
            // 
            // MyPosts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_myProfile);
            Controls.Add(txt_catalogDesc);
            Controls.Add(label8);
            Controls.Add(txt_catalogName);
            Controls.Add(label7);
            Controls.Add(btn_Add);
            Controls.Add(btn_EditePhoto);
            Controls.Add(btn_delete);
            Controls.Add(btn_Edit);
            Controls.Add(btn_Allpost);
            Controls.Add(label4);
            Controls.Add(lbl_posttime);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(rtb_description);
            Controls.Add(lbl_postdate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_post_title);
            Controls.Add(label1);
            Controls.Add(pb_mypost);
            Controls.Add(dgv_MyPost);
            Name = "MyPosts";
            Text = "MyPosts";
            Load += MyPosts_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_MyPost).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_mypost).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_MyPost;
        private Button btn_Allpost;
        private Label label4;
        private Label lbl_posttime;
        private Label label6;
        private Label label5;
        private RichTextBox rtb_description;
        private Label lbl_postdate;
        private Label label3;
        private Label label2;
        private TextBox txt_post_title;
        private Label label1;
        private PictureBox pb_mypost;
        private Button btn_Edit;
        private Button btn_delete;
        private Button btn_EditePhoto;
        private OpenFileDialog openFileDialog;
        private Button btn_Add;
        private TextBox txt_catalogDesc;
        private Label label8;
        private TextBox txt_catalogName;
        private Label label7;
        private Button btn_myProfile;
    }
}