namespace WindowsFormsAppHotelManagement
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.pictureBoxMinimize = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBoxShow = new System.Windows.Forms.PictureBox();
            this.pictureBoxHide = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHide)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBoxShow);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBoxMinimize);
            this.panel1.Controls.Add(this.pictureBoxClose);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonLogin);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.textBoxUsername);
            this.panel1.Controls.Add(this.pictureBoxHide);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 476);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(832, 3);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(41, 38);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 6;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxClose_MouseClick);
            this.pictureBoxClose.MouseHover += new System.EventHandler(this.pictureBoxClose_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.label2.Location = new System.Drawing.Point(359, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Forgot Password?";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(395, 81);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(88, 82);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.label1.Location = new System.Drawing.Point(218, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hotel Management System";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(327, 370);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(221, 42);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Log in";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonLogin_MouseClick);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.textBoxPassword.Location = new System.Drawing.Point(235, 303);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(322, 40);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.textBoxUsername.Location = new System.Drawing.Point(235, 220);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(365, 40);
            this.textBoxUsername.TabIndex = 1;
            // 
            // pictureBoxMinimize
            // 
            this.pictureBoxMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMinimize.Image")));
            this.pictureBoxMinimize.Location = new System.Drawing.Point(785, 3);
            this.pictureBoxMinimize.Name = "pictureBoxMinimize";
            this.pictureBoxMinimize.Size = new System.Drawing.Size(41, 38);
            this.pictureBoxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMinimize.TabIndex = 7;
            this.pictureBoxMinimize.TabStop = false;
            this.pictureBoxMinimize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMinimize_MouseClick);
            this.pictureBoxMinimize.MouseHover += new System.EventHandler(this.pictureBoxMinimize_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.label3.Location = new System.Drawing.Point(229, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.label4.Location = new System.Drawing.Point(229, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password:";
            // 
            // pictureBoxShow
            // 
            this.pictureBoxShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxShow.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxShow.Image")));
            this.pictureBoxShow.Location = new System.Drawing.Point(555, 303);
            this.pictureBoxShow.Name = "pictureBoxShow";
            this.pictureBoxShow.Size = new System.Drawing.Size(45, 40);
            this.pictureBoxShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxShow.TabIndex = 10;
            this.pictureBoxShow.TabStop = false;
            this.pictureBoxShow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxShow_MouseClick);
            this.pictureBoxShow.MouseHover += new System.EventHandler(this.pictureBoxShow_MouseHover);
            // 
            // pictureBoxHide
            // 
            this.pictureBoxHide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxHide.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHide.Image")));
            this.pictureBoxHide.Location = new System.Drawing.Point(555, 303);
            this.pictureBoxHide.Name = "pictureBoxHide";
            this.pictureBoxHide.Size = new System.Drawing.Size(45, 40);
            this.pictureBoxHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHide.TabIndex = 11;
            this.pictureBoxHide.TabStop = false;
            this.pictureBoxHide.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxHide_MouseClick);
            this.pictureBoxHide.MouseHover += new System.EventHandler(this.pictureBoxHide_MouseHover);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Maiandra GD", 20.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.PictureBox pictureBoxMinimize;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxHide;
        private System.Windows.Forms.PictureBox pictureBoxShow;
    }
}