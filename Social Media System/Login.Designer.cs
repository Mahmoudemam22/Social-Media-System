namespace Social_Media_System
{
    partial class Login
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
            btn_login = new Button();
            txt_pass = new TextBox();
            label4 = new Label();
            txt_usname = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.Location = new Point(337, 200);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(173, 29);
            btn_login.TabIndex = 21;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // txt_pass
            // 
            txt_pass.Location = new Point(324, 139);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(220, 27);
            txt_pass.TabIndex = 20;
            txt_pass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(216, 146);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 19;
            label4.Text = "Password";
            // 
            // txt_usname
            // 
            txt_usname.Location = new Point(324, 82);
            txt_usname.Name = "txt_usname";
            txt_usname.Size = new Size(220, 27);
            txt_usname.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(216, 85);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 17;
            label3.Text = "User Name";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_login);
            Controls.Add(txt_pass);
            Controls.Add(label4);
            Controls.Add(txt_usname);
            Controls.Add(label3);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_login;
        private TextBox txt_pass;
        private Label label4;
        private TextBox txt_usname;
        private Label label3;
    }
}