namespace WindowsFormsAppHotelManagement
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userControlDashboard1 = new WindowsFormsAppHotelManagement.UserControlDashboard();
            this.userControlReservation1 = new WindowsFormsAppHotelManagement.UserControlReservation();
            this.userControlRoom1 = new WindowsFormsAppHotelManagement.UserControlRoom();
            this.userControlClient1 = new WindowsFormsAppHotelManagement.UserControlClient();
            this.userControlSettings1 = new WindowsFormsAppHotelManagement.UserControlSettings();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.buttonReservation = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonClient = new System.Windows.Forms.Button();
            this.buttonRooms = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.labelDateTime);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1578, 825);
            this.panel1.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.labelUsername);
            this.panel4.Location = new System.Drawing.Point(300, 95);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1278, 117);
            this.panel4.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(35, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 37);
            this.label8.TabIndex = 17;
            this.label8.Text = "Welcome: ";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(200, 34);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(102, 37);
            this.labelUsername.TabIndex = 18;
            this.labelUsername.Text = "label9";
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.labelDateTime.Location = new System.Drawing.Point(339, 73);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(44, 16);
            this.labelDateTime.TabIndex = 16;
            this.labelDateTime.Text = "label8";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.userControlDashboard1);
            this.panel2.Controls.Add(this.userControlReservation1);
            this.panel2.Controls.Add(this.userControlRoom1);
            this.panel2.Controls.Add(this.userControlClient1);
            this.panel2.Controls.Add(this.userControlSettings1);
            this.panel2.Location = new System.Drawing.Point(300, 211);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1278, 614);
            this.panel2.TabIndex = 15;
            // 
            // userControlDashboard1
            // 
            this.userControlDashboard1.BackColor = System.Drawing.Color.White;
            this.userControlDashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlDashboard1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userControlDashboard1.Location = new System.Drawing.Point(0, 0);
            this.userControlDashboard1.Margin = new System.Windows.Forms.Padding(5);
            this.userControlDashboard1.Name = "userControlDashboard1";
            this.userControlDashboard1.Size = new System.Drawing.Size(1278, 614);
            this.userControlDashboard1.TabIndex = 0;
            // 
            // userControlReservation1
            // 
            this.userControlReservation1.BackColor = System.Drawing.Color.White;
            this.userControlReservation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlReservation1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userControlReservation1.Location = new System.Drawing.Point(0, 0);
            this.userControlReservation1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlReservation1.Name = "userControlReservation1";
            this.userControlReservation1.Size = new System.Drawing.Size(1278, 614);
            this.userControlReservation1.TabIndex = 0;
            this.userControlReservation1.Visible = false;
            // 
            // userControlRoom1
            // 
            this.userControlRoom1.BackColor = System.Drawing.Color.White;
            this.userControlRoom1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlRoom1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userControlRoom1.Location = new System.Drawing.Point(0, 0);
            this.userControlRoom1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlRoom1.Name = "userControlRoom1";
            this.userControlRoom1.Size = new System.Drawing.Size(1278, 614);
            this.userControlRoom1.TabIndex = 0;
            // 
            // userControlClient1
            // 
            this.userControlClient1.Location = new System.Drawing.Point(42, 13);
            this.userControlClient1.Name = "userControlClient1";
            this.userControlClient1.Size = new System.Drawing.Size(1200, 600);
            this.userControlClient1.TabIndex = 1;
            this.userControlClient1.Visible = false;
            // 
            // userControlSettings1
            // 
            this.userControlSettings1.BackColor = System.Drawing.Color.White;
            this.userControlSettings1.Location = new System.Drawing.Point(42, 7);
            this.userControlSettings1.Name = "userControlSettings1";
            this.userControlSettings1.Size = new System.Drawing.Size(1200, 600);
            this.userControlSettings1.TabIndex = 0;
            this.userControlSettings1.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.panel3.Controls.Add(this.buttonLogout);
            this.panel3.Controls.Add(this.buttonSettings);
            this.panel3.Controls.Add(this.buttonDashboard);
            this.panel3.Controls.Add(this.buttonReservation);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.buttonClient);
            this.panel3.Controls.Add(this.buttonRooms);
            this.panel3.Controls.Add(this.pictureBox8);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(301, 825);
            this.panel3.TabIndex = 23;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.buttonLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogout.Image")));
            this.buttonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLogout.Location = new System.Drawing.Point(17, 770);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(250, 55);
            this.buttonLogout.TabIndex = 22;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonLogout_MouseClick);
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.buttonSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.buttonSettings.ForeColor = System.Drawing.Color.White;
            this.buttonSettings.Image = ((System.Drawing.Image)(resources.GetObject("buttonSettings.Image")));
            this.buttonSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.Location = new System.Drawing.Point(17, 542);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(263, 55);
            this.buttonSettings.TabIndex = 22;
            this.buttonSettings.Text = "  Settings";
            this.buttonSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.buttonDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.buttonDashboard.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonDashboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonDashboard.Image")));
            this.buttonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.Location = new System.Drawing.Point(17, 218);
            this.buttonDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(263, 55);
            this.buttonDashboard.TabIndex = 2;
            this.buttonDashboard.Text = "  Dashboard";
            this.buttonDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDashboard.UseVisualStyleBackColor = false;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // buttonReservation
            // 
            this.buttonReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.buttonReservation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.buttonReservation.ForeColor = System.Drawing.Color.White;
            this.buttonReservation.Image = ((System.Drawing.Image)(resources.GetObject("buttonReservation.Image")));
            this.buttonReservation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReservation.Location = new System.Drawing.Point(17, 461);
            this.buttonReservation.Margin = new System.Windows.Forms.Padding(0);
            this.buttonReservation.Name = "buttonReservation";
            this.buttonReservation.Size = new System.Drawing.Size(263, 55);
            this.buttonReservation.TabIndex = 21;
            this.buttonReservation.Text = "  Reservation";
            this.buttonReservation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonReservation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonReservation.UseVisualStyleBackColor = false;
            this.buttonReservation.Click += new System.EventHandler(this.buttonReservation_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(17, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(249, 62);
            this.label7.TabIndex = 4;
            this.label7.Text = "Hotel Management \r\n         System";
            // 
            // buttonClient
            // 
            this.buttonClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.buttonClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.buttonClient.ForeColor = System.Drawing.Color.White;
            this.buttonClient.Image = ((System.Drawing.Image)(resources.GetObject("buttonClient.Image")));
            this.buttonClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClient.Location = new System.Drawing.Point(17, 299);
            this.buttonClient.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(263, 55);
            this.buttonClient.TabIndex = 19;
            this.buttonClient.Text = "  Client";
            this.buttonClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonClient.UseVisualStyleBackColor = false;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // buttonRooms
            // 
            this.buttonRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.buttonRooms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.buttonRooms.ForeColor = System.Drawing.Color.White;
            this.buttonRooms.Image = ((System.Drawing.Image)(resources.GetObject("buttonRooms.Image")));
            this.buttonRooms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRooms.Location = new System.Drawing.Point(17, 380);
            this.buttonRooms.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRooms.Name = "buttonRooms";
            this.buttonRooms.Size = new System.Drawing.Size(263, 55);
            this.buttonRooms.TabIndex = 20;
            this.buttonRooms.Text = "  Rooms";
            this.buttonRooms.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRooms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRooms.UseVisualStyleBackColor = false;
            this.buttonRooms.Click += new System.EventHandler(this.buttonRooms_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(96, 3);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(87, 86);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 14;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(1602, 848);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Button buttonClient;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonReservation;
        private System.Windows.Forms.Button buttonRooms;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private UserControlSettings userControlSettings1;
        private UserControlClient userControlClient1;
        private UserControlRoom userControlRoom1;
        private UserControlReservation userControlReservation1;
        private UserControlDashboard userControlDashboard1;
    }
}