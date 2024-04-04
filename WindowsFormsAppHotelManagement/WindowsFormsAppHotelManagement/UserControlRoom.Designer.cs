namespace WindowsFormsAppHotelManagement
{
    partial class UserControlRoom
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlRoom = new System.Windows.Forms.TabControl();
            this.tabPageAddRoom = new System.Windows.Forms.TabPage();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textBoxPhoneNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSearchRoom = new System.Windows.Forms.TabPage();
            this.dataGridViewRoom = new System.Windows.Forms.DataGridView();
            this.textBoxSearchRoomNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPageUpdateDeleteRoom = new System.Windows.Forms.TabPage();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.radioButtonNo1 = new System.Windows.Forms.RadioButton();
            this.radioButtonYes1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxType1 = new System.Windows.Forms.ComboBox();
            this.textBoxPhoneNo1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlRoom.SuspendLayout();
            this.tabPageAddRoom.SuspendLayout();
            this.tabPageSearchRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).BeginInit();
            this.tabPageUpdateDeleteRoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlRoom
            // 
            this.tabControlRoom.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlRoom.Controls.Add(this.tabPageAddRoom);
            this.tabControlRoom.Controls.Add(this.tabPageSearchRoom);
            this.tabControlRoom.Controls.Add(this.tabPageUpdateDeleteRoom);
            this.tabControlRoom.Location = new System.Drawing.Point(12, 12);
            this.tabControlRoom.Name = "tabControlRoom";
            this.tabControlRoom.SelectedIndex = 0;
            this.tabControlRoom.Size = new System.Drawing.Size(1176, 576);
            this.tabControlRoom.TabIndex = 1;
            // 
            // tabPageAddRoom
            // 
            this.tabPageAddRoom.Controls.Add(this.radioButtonNo);
            this.tabPageAddRoom.Controls.Add(this.radioButtonYes);
            this.tabPageAddRoom.Controls.Add(this.label2);
            this.tabPageAddRoom.Controls.Add(this.comboBoxType);
            this.tabPageAddRoom.Controls.Add(this.textBoxPhoneNo);
            this.tabPageAddRoom.Controls.Add(this.label4);
            this.tabPageAddRoom.Controls.Add(this.buttonAdd);
            this.tabPageAddRoom.Controls.Add(this.label3);
            this.tabPageAddRoom.Controls.Add(this.label1);
            this.tabPageAddRoom.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddRoom.Name = "tabPageAddRoom";
            this.tabPageAddRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddRoom.Size = new System.Drawing.Size(1168, 546);
            this.tabPageAddRoom.TabIndex = 0;
            this.tabPageAddRoom.Text = "Add Room";
            this.tabPageAddRoom.UseVisualStyleBackColor = true;
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Location = new System.Drawing.Point(306, 234);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(45, 21);
            this.radioButtonNo.TabIndex = 19;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "No";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.Location = new System.Drawing.Point(306, 207);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(46, 21);
            this.radioButtonYes.TabIndex = 18;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "Yes";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.label2.Location = new System.Drawing.Point(158, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 37);
            this.label2.TabIndex = 17;
            this.label2.Text = "Free:";
            // 
            // comboBoxType
            // 
            this.comboBoxType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Select Room Type",
            "Single",
            "Double",
            "Apartment",
            "Family"});
            this.comboBoxType.Location = new System.Drawing.Point(165, 125);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(326, 25);
            this.comboBoxType.TabIndex = 16;
            // 
            // textBoxPhoneNo
            // 
            this.textBoxPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.textBoxPhoneNo.Location = new System.Drawing.Point(670, 106);
            this.textBoxPhoneNo.Name = "textBoxPhoneNo";
            this.textBoxPhoneNo.Size = new System.Drawing.Size(326, 44);
            this.textBoxPhoneNo.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.label4.Location = new System.Drawing.Point(663, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 37);
            this.label4.TabIndex = 12;
            this.label4.Text = "Phone Number:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(165, 283);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(160, 57);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.label3.Location = new System.Drawing.Point(158, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "Room Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Add Room:";
            // 
            // tabPageSearchRoom
            // 
            this.tabPageSearchRoom.Controls.Add(this.dataGridViewRoom);
            this.tabPageSearchRoom.Controls.Add(this.textBoxSearchRoomNo);
            this.tabPageSearchRoom.Controls.Add(this.label6);
            this.tabPageSearchRoom.Controls.Add(this.label7);
            this.tabPageSearchRoom.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchRoom.Name = "tabPageSearchRoom";
            this.tabPageSearchRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchRoom.Size = new System.Drawing.Size(1168, 546);
            this.tabPageSearchRoom.TabIndex = 1;
            this.tabPageSearchRoom.Text = "Search Room";
            this.tabPageSearchRoom.UseVisualStyleBackColor = true;
            this.tabPageSearchRoom.Enter += new System.EventHandler(this.tabPageSearchRoom_Enter_1);
            this.tabPageSearchRoom.Leave += new System.EventHandler(this.tabPageSearchRoom_Leave_1);
            // 
            // dataGridViewRoom
            // 
            this.dataGridViewRoom.AllowUserToAddRows = false;
            this.dataGridViewRoom.AllowUserToDeleteRows = false;
            this.dataGridViewRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridViewRoom.Location = new System.Drawing.Point(18, 180);
            this.dataGridViewRoom.Name = "dataGridViewRoom";
            this.dataGridViewRoom.ReadOnly = true;
            this.dataGridViewRoom.Size = new System.Drawing.Size(1140, 353);
            this.dataGridViewRoom.TabIndex = 14;
            this.dataGridViewRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRoom_CellClick);
            // 
            // textBoxSearchRoomNo
            // 
            this.textBoxSearchRoomNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.textBoxSearchRoomNo.Location = new System.Drawing.Point(271, 97);
            this.textBoxSearchRoomNo.Name = "textBoxSearchRoomNo";
            this.textBoxSearchRoomNo.Size = new System.Drawing.Size(453, 44);
            this.textBoxSearchRoomNo.TabIndex = 13;
            this.textBoxSearchRoomNo.TextChanged += new System.EventHandler(this.textBoxSearchRoomNo_TextChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.label6.Location = new System.Drawing.Point(264, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 37);
            this.label6.TabIndex = 12;
            this.label6.Text = "Room Number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.label7.Location = new System.Drawing.Point(11, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 37);
            this.label7.TabIndex = 11;
            this.label7.Text = "Search Room:";
            // 
            // tabPageUpdateDeleteRoom
            // 
            this.tabPageUpdateDeleteRoom.Controls.Add(this.buttonDelete);
            this.tabPageUpdateDeleteRoom.Controls.Add(this.radioButtonNo1);
            this.tabPageUpdateDeleteRoom.Controls.Add(this.radioButtonYes1);
            this.tabPageUpdateDeleteRoom.Controls.Add(this.label5);
            this.tabPageUpdateDeleteRoom.Controls.Add(this.comboBoxType1);
            this.tabPageUpdateDeleteRoom.Controls.Add(this.textBoxPhoneNo1);
            this.tabPageUpdateDeleteRoom.Controls.Add(this.label8);
            this.tabPageUpdateDeleteRoom.Controls.Add(this.buttonUpdate);
            this.tabPageUpdateDeleteRoom.Controls.Add(this.label9);
            this.tabPageUpdateDeleteRoom.Controls.Add(this.label10);
            this.tabPageUpdateDeleteRoom.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpdateDeleteRoom.Name = "tabPageUpdateDeleteRoom";
            this.tabPageUpdateDeleteRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateDeleteRoom.Size = new System.Drawing.Size(1168, 546);
            this.tabPageUpdateDeleteRoom.TabIndex = 2;
            this.tabPageUpdateDeleteRoom.Text = "Update/Delete Room";
            this.tabPageUpdateDeleteRoom.UseVisualStyleBackColor = true;
            this.tabPageUpdateDeleteRoom.Leave += new System.EventHandler(this.tabPageUpdateDeleteRoom_Leave);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(346, 300);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(160, 57);
            this.buttonDelete.TabIndex = 29;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // radioButtonNo1
            // 
            this.radioButtonNo1.AutoSize = true;
            this.radioButtonNo1.Location = new System.Drawing.Point(321, 251);
            this.radioButtonNo1.Name = "radioButtonNo1";
            this.radioButtonNo1.Size = new System.Drawing.Size(45, 21);
            this.radioButtonNo1.TabIndex = 28;
            this.radioButtonNo1.TabStop = true;
            this.radioButtonNo1.Text = "No";
            this.radioButtonNo1.UseVisualStyleBackColor = true;
            // 
            // radioButtonYes1
            // 
            this.radioButtonYes1.AutoSize = true;
            this.radioButtonYes1.Location = new System.Drawing.Point(321, 224);
            this.radioButtonYes1.Name = "radioButtonYes1";
            this.radioButtonYes1.Size = new System.Drawing.Size(46, 21);
            this.radioButtonYes1.TabIndex = 27;
            this.radioButtonYes1.TabStop = true;
            this.radioButtonYes1.Text = "Yes";
            this.radioButtonYes1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.label5.Location = new System.Drawing.Point(173, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 37);
            this.label5.TabIndex = 26;
            this.label5.Text = "Free:";
            // 
            // comboBoxType1
            // 
            this.comboBoxType1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxType1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxType1.FormattingEnabled = true;
            this.comboBoxType1.Items.AddRange(new object[] {
            "Select Room Type",
            "Single",
            "Double",
            "Apartment",
            "Family"});
            this.comboBoxType1.Location = new System.Drawing.Point(180, 142);
            this.comboBoxType1.Name = "comboBoxType1";
            this.comboBoxType1.Size = new System.Drawing.Size(326, 25);
            this.comboBoxType1.TabIndex = 25;
            // 
            // textBoxPhoneNo1
            // 
            this.textBoxPhoneNo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.textBoxPhoneNo1.Location = new System.Drawing.Point(685, 123);
            this.textBoxPhoneNo1.Name = "textBoxPhoneNo1";
            this.textBoxPhoneNo1.Size = new System.Drawing.Size(326, 44);
            this.textBoxPhoneNo1.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.label8.Location = new System.Drawing.Point(678, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(242, 37);
            this.label8.TabIndex = 23;
            this.label8.Text = "Phone Number:";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(180, 300);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(160, 57);
            this.buttonUpdate.TabIndex = 22;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.label9.Location = new System.Drawing.Point(173, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 37);
            this.label9.TabIndex = 21;
            this.label9.Text = "Room Type:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.label10.Location = new System.Drawing.Point(21, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(322, 37);
            this.label10.TabIndex = 20;
            this.label10.Text = "Update/Delete Room:";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Room_ID";
            this.Column4.HeaderText = "ID";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Room_Type";
            this.Column1.HeaderText = "Type";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Room_Phone";
            this.Column2.HeaderText = "Phone";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Room_Free";
            this.Column3.HeaderText = "Is Free?";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // UserControlRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlRoom);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlRoom";
            this.Size = new System.Drawing.Size(1200, 600);
            this.Load += new System.EventHandler(this.UserControlRoom_Load);
            this.tabControlRoom.ResumeLayout(false);
            this.tabPageAddRoom.ResumeLayout(false);
            this.tabPageAddRoom.PerformLayout();
            this.tabPageSearchRoom.ResumeLayout(false);
            this.tabPageSearchRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).EndInit();
            this.tabPageUpdateDeleteRoom.ResumeLayout(false);
            this.tabPageUpdateDeleteRoom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlRoom;
        private System.Windows.Forms.TabPage tabPageAddRoom;
        private System.Windows.Forms.TextBox textBoxPhoneNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageSearchRoom;
        private System.Windows.Forms.DataGridView dataGridViewRoom;
        private System.Windows.Forms.TextBox textBoxSearchRoomNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPageUpdateDeleteRoom;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonNo1;
        private System.Windows.Forms.RadioButton radioButtonYes1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxType1;
        private System.Windows.Forms.TextBox textBoxPhoneNo1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
