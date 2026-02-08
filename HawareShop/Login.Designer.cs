namespace HawareShop
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            label1 = new Label();
            label2 = new Label();
            txt_username = new TextBox();
            label3 = new Label();
            txt_password = new TextBox();
            pictureBox1 = new PictureBox();
            btn_login = new Button();
            btn_reset = new Label();
            btn_close = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 540);
            panel1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(396, 9);
            label1.Name = "label1";
            label1.Size = new Size(131, 18);
            label1.TabIndex = 1;
            label1.Text = "Hardware Shop";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(364, 163);
            label2.Name = "label2";
            label2.Size = new Size(90, 18);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // txt_username
            // 
            txt_username.Location = new Point(364, 195);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(241, 27);
            txt_username.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(364, 245);
            label3.Name = "label3";
            label3.Size = new Size(85, 18);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(364, 277);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(241, 27);
            txt_password.TabIndex = 3;
            txt_password.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(415, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.Teal;
            btn_login.FlatAppearance.BorderColor = Color.White;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(406, 345);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(130, 39);
            btn_login.TabIndex = 5;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // btn_reset
            // 
            btn_reset.AutoSize = true;
            btn_reset.Font = new Font("Verdana", 11.25F, FontStyle.Underline, GraphicsUnit.Point);
            btn_reset.ForeColor = Color.Red;
            btn_reset.Location = new Point(441, 408);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(50, 18);
            btn_reset.TabIndex = 2;
            btn_reset.Text = "Reset";
            // 
            // btn_close
            // 
            btn_close.AutoSize = true;
            btn_close.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_close.ForeColor = Color.Red;
            btn_close.Location = new Point(773, 9);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(26, 25);
            btn_close.TabIndex = 2;
            btn_close.Text = "X";
            btn_close.Click += btn_close_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(828, 540);
            Controls.Add(btn_login);
            Controls.Add(pictureBox1);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(btn_close);
            Controls.Add(btn_reset);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Label label1;
        private TextBox txt_username;
        private Label label2;
        private TextBox txt_password;
        private Label label3;
        private PictureBox pictureBox1;
        private Button btn_login;
        private Label btn_close;
        private Label btn_reset;
    }
}
