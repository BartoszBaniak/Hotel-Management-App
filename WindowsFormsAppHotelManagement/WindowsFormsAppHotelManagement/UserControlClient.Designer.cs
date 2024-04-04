namespace WindowsFormsAppHotelManagement
{
    partial class UserControlClient
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
            this.tabControlClient = new System.Windows.Forms.TabControl();
            this.tabPageAddClient = new System.Windows.Forms.TabPage();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxPhoneNum = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSearchClient = new System.Windows.Forms.TabPage();
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxSearchPhoneNum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPageUpdateDeleteClient = new System.Windows.Forms.TabPage();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxAddress1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxLastName1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxPhoneNum1 = new System.Windows.Forms.TextBox();
            this.textBoxFirstName1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControlClient.SuspendLayout();
            this.tabPageAddClient.SuspendLayout();
            this.tabPageSearchClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            this.tabPageUpdateDeleteClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlClient
            // 
            this.tabControlClient.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlClient.Controls.Add(this.tabPageAddClient);
            this.tabControlClient.Controls.Add(this.tabPageSearchClient);
            this.tabControlClient.Controls.Add(this.tabPageUpdateDeleteClient);
            this.tabControlClient.Location = new System.Drawing.Point(12, 12);
            this.tabControlClient.Name = "tabControlClient";
            this.tabControlClient.SelectedIndex = 0;
            this.tabControlClient.Size = new System.Drawing.Size(1176, 576);
            this.tabControlClient.TabIndex = 0;
            // 
            // tabPageAddClient
            // 
            this.tabPageAddClient.Controls.Add(this.textBoxAddress);
            this.tabPageAddClient.Controls.Add(this.label5);
            this.tabPageAddClient.Controls.Add(this.textBoxLastName);
            this.tabPageAddClient.Controls.Add(this.label4);
            this.tabPageAddClient.Controls.Add(this.buttonAdd);
            this.tabPageAddClient.Controls.Add(this.textBoxPhoneNum);
            this.tabPageAddClient.Controls.Add(this.textBoxFirstName);
            this.tabPageAddClient.Controls.Add(this.label3);
            this.tabPageAddClient.Controls.Add(this.label2);
            this.tabPageAddClient.Controls.Add(this.label1);
            this.tabPageAddClient.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddClient.Name = "tabPageAddClient";
            this.tabPageAddClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddClient.Size = new System.Drawing.Size(1168, 550);
            this.tabPageAddClient.TabIndex = 0;
            this.tabPageAddClient.Text = "Add Client";
            this.tabPageAddClient.UseVisualStyleBackColor = true;
            this.tabPageAddClient.Leave += new System.EventHandler(this.tabPageAddClient_Leave);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.textBoxAddress.Location = new System.Drawing.Point(165, 334);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(831, 115);
            this.textBoxAddress.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.label5.Location = new System.Drawing.Point(158, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 37);
            this.label5.TabIndex = 14;
            this.label5.Text = "Address:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.textBoxLastName.Location = new System.Drawing.Point(670, 106);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(326, 44);
            this.textBoxLastName.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.label4.Location = new System.Drawing.Point(663, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 37);
            this.label4.TabIndex = 12;
            this.label4.Text = "Last Name:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(165, 465);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(160, 57);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxPhoneNum
            // 
            this.textBoxPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.textBoxPhoneNum.Location = new System.Drawing.Point(165, 225);
            this.textBoxPhoneNum.Name = "textBoxPhoneNum";
            this.textBoxPhoneNum.Size = new System.Drawing.Size(326, 44);
            this.textBoxPhoneNum.TabIndex = 10;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.textBoxFirstName.Location = new System.Drawing.Point(165, 106);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(326, 44);
            this.textBoxFirstName.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.label3.Location = new System.Drawing.Point(158, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.label2.Location = new System.Drawing.Point(158, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Phone Num.:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Add Client:";
            // 
            // tabPageSearchClient
            // 
            this.tabPageSearchClient.Controls.Add(this.dataGridViewClient);
            this.tabPageSearchClient.Controls.Add(this.textBoxSearchPhoneNum);
            this.tabPageSearchClient.Controls.Add(this.label6);
            this.tabPageSearchClient.Controls.Add(this.label7);
            this.tabPageSearchClient.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchClient.Name = "tabPageSearchClient";
            this.tabPageSearchClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchClient.Size = new System.Drawing.Size(1168, 550);
            this.tabPageSearchClient.TabIndex = 1;
            this.tabPageSearchClient.Text = "Search Client";
            this.tabPageSearchClient.UseVisualStyleBackColor = true;
            this.tabPageSearchClient.Enter += new System.EventHandler(this.tabPageSearchClient_Enter);
            this.tabPageSearchClient.Leave += new System.EventHandler(this.tabPageSearchClient_Leave);
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.AllowUserToAddRows = false;
            this.dataGridViewClient.AllowUserToDeleteRows = false;
            this.dataGridViewClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewClient.Location = new System.Drawing.Point(18, 182);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.ReadOnly = true;
            this.dataGridViewClient.Size = new System.Drawing.Size(1140, 353);
            this.dataGridViewClient.TabIndex = 14;
            this.dataGridViewClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClient_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Client_ID";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Client_FirstName";
            this.Column2.HeaderText = "First Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Client_LastName";
            this.Column3.HeaderText = "Last Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Client_Phone";
            this.Column4.HeaderText = "Phone Num.";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Client_Address";
            this.Column5.HeaderText = "Address";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // textBoxSearchPhoneNum
            // 
            this.textBoxSearchPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.textBoxSearchPhoneNum.Location = new System.Drawing.Point(271, 97);
            this.textBoxSearchPhoneNum.Name = "textBoxSearchPhoneNum";
            this.textBoxSearchPhoneNum.Size = new System.Drawing.Size(453, 44);
            this.textBoxSearchPhoneNum.TabIndex = 13;
            this.textBoxSearchPhoneNum.TextChanged += new System.EventHandler(this.textBoxSearchPhoneNum_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.label6.Location = new System.Drawing.Point(264, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 37);
            this.label6.TabIndex = 12;
            this.label6.Text = "Phone Num.:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.label7.Location = new System.Drawing.Point(11, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 37);
            this.label7.TabIndex = 11;
            this.label7.Text = "Search Client:";
            // 
            // tabPageUpdateDeleteClient
            // 
            this.tabPageUpdateDeleteClient.Controls.Add(this.buttonDelete);
            this.tabPageUpdateDeleteClient.Controls.Add(this.textBoxAddress1);
            this.tabPageUpdateDeleteClient.Controls.Add(this.label8);
            this.tabPageUpdateDeleteClient.Controls.Add(this.textBoxLastName1);
            this.tabPageUpdateDeleteClient.Controls.Add(this.label9);
            this.tabPageUpdateDeleteClient.Controls.Add(this.buttonUpdate);
            this.tabPageUpdateDeleteClient.Controls.Add(this.textBoxPhoneNum1);
            this.tabPageUpdateDeleteClient.Controls.Add(this.textBoxFirstName1);
            this.tabPageUpdateDeleteClient.Controls.Add(this.label10);
            this.tabPageUpdateDeleteClient.Controls.Add(this.label11);
            this.tabPageUpdateDeleteClient.Controls.Add(this.label12);
            this.tabPageUpdateDeleteClient.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpdateDeleteClient.Name = "tabPageUpdateDeleteClient";
            this.tabPageUpdateDeleteClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateDeleteClient.Size = new System.Drawing.Size(1168, 550);
            this.tabPageUpdateDeleteClient.TabIndex = 2;
            this.tabPageUpdateDeleteClient.Text = "Update/Delete Client";
            this.tabPageUpdateDeleteClient.UseVisualStyleBackColor = true;
            this.tabPageUpdateDeleteClient.Leave += new System.EventHandler(this.tabPageUpdateDeleteClient_Leave);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(355, 461);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(160, 57);
            this.buttonDelete.TabIndex = 26;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxAddress1
            // 
            this.textBoxAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.textBoxAddress1.Location = new System.Drawing.Point(162, 330);
            this.textBoxAddress1.Multiline = true;
            this.textBoxAddress1.Name = "textBoxAddress1";
            this.textBoxAddress1.Size = new System.Drawing.Size(831, 115);
            this.textBoxAddress1.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.label8.Location = new System.Drawing.Point(155, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 37);
            this.label8.TabIndex = 24;
            this.label8.Text = "Address:";
            // 
            // textBoxLastName1
            // 
            this.textBoxLastName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.textBoxLastName1.Location = new System.Drawing.Point(667, 102);
            this.textBoxLastName1.Name = "textBoxLastName1";
            this.textBoxLastName1.Size = new System.Drawing.Size(326, 44);
            this.textBoxLastName1.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.label9.Location = new System.Drawing.Point(660, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 37);
            this.label9.TabIndex = 22;
            this.label9.Text = "Last Name:";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(162, 461);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(160, 57);
            this.buttonUpdate.TabIndex = 21;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxPhoneNum1
            // 
            this.textBoxPhoneNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.textBoxPhoneNum1.Location = new System.Drawing.Point(162, 221);
            this.textBoxPhoneNum1.Name = "textBoxPhoneNum1";
            this.textBoxPhoneNum1.Size = new System.Drawing.Size(326, 44);
            this.textBoxPhoneNum1.TabIndex = 20;
            // 
            // textBoxFirstName1
            // 
            this.textBoxFirstName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.textBoxFirstName1.Location = new System.Drawing.Point(162, 102);
            this.textBoxFirstName1.Name = "textBoxFirstName1";
            this.textBoxFirstName1.Size = new System.Drawing.Size(326, 44);
            this.textBoxFirstName1.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.label10.Location = new System.Drawing.Point(155, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 37);
            this.label10.TabIndex = 18;
            this.label10.Text = "First Name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.label11.Location = new System.Drawing.Point(155, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(205, 37);
            this.label11.TabIndex = 17;
            this.label11.Text = "Phone Num.:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.label12.Location = new System.Drawing.Point(3, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(381, 37);
            this.label12.TabIndex = 16;
            this.label12.Text = "Update and Delete Client:";
            // 
            // UserControlClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlClient);
            this.Name = "UserControlClient";
            this.Size = new System.Drawing.Size(1200, 600);
            this.tabControlClient.ResumeLayout(false);
            this.tabPageAddClient.ResumeLayout(false);
            this.tabPageAddClient.PerformLayout();
            this.tabPageSearchClient.ResumeLayout(false);
            this.tabPageSearchClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            this.tabPageUpdateDeleteClient.ResumeLayout(false);
            this.tabPageUpdateDeleteClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlClient;
        private System.Windows.Forms.TabPage tabPageAddClient;
        private System.Windows.Forms.TabPage tabPageSearchClient;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxPhoneNum;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewClient;
        private System.Windows.Forms.TextBox textBoxSearchPhoneNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPageUpdateDeleteClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox textBoxAddress1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxLastName1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxPhoneNum1;
        private System.Windows.Forms.TextBox textBoxFirstName1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonDelete;
    }
}
