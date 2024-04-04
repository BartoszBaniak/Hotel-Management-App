namespace WindowsFormsAppHotelManagement
{
    partial class UserControlReservation
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
            this.tabControlReservation = new System.Windows.Forms.TabControl();
            this.tabPageAddReservation = new System.Windows.Forms.TabPage();
            this.comboBoxNo = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePickerOut = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePickerIn = new System.Windows.Forms.DateTimePicker();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textBoxClientID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSearchReservation = new System.Windows.Forms.TabPage();
            this.dataGridViewReservation = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxSearchClientID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPageUpdateDeleteReservation = new System.Windows.Forms.TabPage();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.comboBoxNo1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerOut1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerIn1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxType1 = new System.Windows.Forms.ComboBox();
            this.textBoxClientID1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControlReservation.SuspendLayout();
            this.tabPageAddReservation.SuspendLayout();
            this.tabPageSearchReservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservation)).BeginInit();
            this.tabPageUpdateDeleteReservation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlReservation
            // 
            this.tabControlReservation.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlReservation.Controls.Add(this.tabPageAddReservation);
            this.tabControlReservation.Controls.Add(this.tabPageSearchReservation);
            this.tabControlReservation.Controls.Add(this.tabPageUpdateDeleteReservation);
            this.tabControlReservation.Location = new System.Drawing.Point(12, 12);
            this.tabControlReservation.Name = "tabControlReservation";
            this.tabControlReservation.SelectedIndex = 0;
            this.tabControlReservation.Size = new System.Drawing.Size(1176, 576);
            this.tabControlReservation.TabIndex = 2;
            // 
            // tabPageAddReservation
            // 
            this.tabPageAddReservation.Controls.Add(this.comboBoxNo);
            this.tabPageAddReservation.Controls.Add(this.label14);
            this.tabPageAddReservation.Controls.Add(this.dateTimePickerOut);
            this.tabPageAddReservation.Controls.Add(this.label13);
            this.tabPageAddReservation.Controls.Add(this.dateTimePickerIn);
            this.tabPageAddReservation.Controls.Add(this.comboBoxType);
            this.tabPageAddReservation.Controls.Add(this.textBoxClientID);
            this.tabPageAddReservation.Controls.Add(this.label12);
            this.tabPageAddReservation.Controls.Add(this.label11);
            this.tabPageAddReservation.Controls.Add(this.label4);
            this.tabPageAddReservation.Controls.Add(this.buttonAdd);
            this.tabPageAddReservation.Controls.Add(this.label1);
            this.tabPageAddReservation.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddReservation.Name = "tabPageAddReservation";
            this.tabPageAddReservation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddReservation.Size = new System.Drawing.Size(1168, 546);
            this.tabPageAddReservation.TabIndex = 0;
            this.tabPageAddReservation.Text = "Add Reservation";
            this.tabPageAddReservation.UseVisualStyleBackColor = true;
            this.tabPageAddReservation.Leave += new System.EventHandler(this.tabPageAddReservation_Leave);
            // 
            // comboBoxNo
            // 
            this.comboBoxNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxNo.FormattingEnabled = true;
            this.comboBoxNo.Items.AddRange(new object[] {
            "Select Room Number"});
            this.comboBoxNo.Location = new System.Drawing.Point(611, 148);
            this.comboBoxNo.Name = "comboBoxNo";
            this.comboBoxNo.Size = new System.Drawing.Size(302, 25);
            this.comboBoxNo.TabIndex = 29;
            this.comboBoxNo.SelectedIndexChanged += new System.EventHandler(this.comboBoxNo_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.label14.Location = new System.Drawing.Point(604, 318);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 37);
            this.label14.TabIndex = 28;
            this.label14.Text = "Out:";
            // 
            // dateTimePickerOut
            // 
            this.dateTimePickerOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerOut.Location = new System.Drawing.Point(611, 383);
            this.dateTimePickerOut.Name = "dateTimePickerOut";
            this.dateTimePickerOut.Size = new System.Drawing.Size(302, 23);
            this.dateTimePickerOut.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.label13.Location = new System.Drawing.Point(124, 318);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 37);
            this.label13.TabIndex = 26;
            this.label13.Text = "In:";
            // 
            // dateTimePickerIn
            // 
            this.dateTimePickerIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerIn.Location = new System.Drawing.Point(131, 383);
            this.dateTimePickerIn.Name = "dateTimePickerIn";
            this.dateTimePickerIn.Size = new System.Drawing.Size(302, 23);
            this.dateTimePickerIn.TabIndex = 25;
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
            this.comboBoxType.Location = new System.Drawing.Point(131, 148);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(302, 25);
            this.comboBoxType.TabIndex = 24;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // textBoxClientID
            // 
            this.textBoxClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.textBoxClientID.Location = new System.Drawing.Point(131, 242);
            this.textBoxClientID.Name = "textBoxClientID";
            this.textBoxClientID.Size = new System.Drawing.Size(302, 44);
            this.textBoxClientID.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.label12.Location = new System.Drawing.Point(124, 202);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 37);
            this.label12.TabIndex = 22;
            this.label12.Text = "Client ID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.label11.Location = new System.Drawing.Point(604, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(235, 37);
            this.label11.TabIndex = 20;
            this.label11.Text = "Room Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.label4.Location = new System.Drawing.Point(124, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 37);
            this.label4.TabIndex = 12;
            this.label4.Text = "Room Type:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(131, 440);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(160, 57);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Add Reservation:";
            // 
            // tabPageSearchReservation
            // 
            this.tabPageSearchReservation.Controls.Add(this.dataGridViewReservation);
            this.tabPageSearchReservation.Controls.Add(this.textBoxSearchClientID);
            this.tabPageSearchReservation.Controls.Add(this.label6);
            this.tabPageSearchReservation.Controls.Add(this.label7);
            this.tabPageSearchReservation.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchReservation.Name = "tabPageSearchReservation";
            this.tabPageSearchReservation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchReservation.Size = new System.Drawing.Size(1168, 546);
            this.tabPageSearchReservation.TabIndex = 1;
            this.tabPageSearchReservation.Text = "Search Reservation";
            this.tabPageSearchReservation.UseVisualStyleBackColor = true;
            this.tabPageSearchReservation.Enter += new System.EventHandler(this.tabPageSearchReservation_Enter);
            this.tabPageSearchReservation.Leave += new System.EventHandler(this.tabPageSearchReservation_Leave);
            // 
            // dataGridViewReservation
            // 
            this.dataGridViewReservation.AllowUserToAddRows = false;
            this.dataGridViewReservation.AllowUserToDeleteRows = false;
            this.dataGridViewReservation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewReservation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReservation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewReservation.Location = new System.Drawing.Point(18, 180);
            this.dataGridViewReservation.Name = "dataGridViewReservation";
            this.dataGridViewReservation.ReadOnly = true;
            this.dataGridViewReservation.Size = new System.Drawing.Size(1140, 353);
            this.dataGridViewReservation.TabIndex = 14;
            this.dataGridViewReservation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReservation_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Reservation_ID";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Reservation_Room_Type";
            this.Column2.HeaderText = "Room Type";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Reservation_Room_Number";
            this.Column3.HeaderText = "Room Number";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Reservation_Client_ID";
            this.Column4.HeaderText = "Client ID";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Reservation_In";
            this.Column5.HeaderText = "In";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Reservation_Out";
            this.Column6.HeaderText = "Out";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // textBoxSearchClientID
            // 
            this.textBoxSearchClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.textBoxSearchClientID.Location = new System.Drawing.Point(271, 97);
            this.textBoxSearchClientID.Name = "textBoxSearchClientID";
            this.textBoxSearchClientID.Size = new System.Drawing.Size(453, 44);
            this.textBoxSearchClientID.TabIndex = 13;
            this.textBoxSearchClientID.TextChanged += new System.EventHandler(this.textBoxSearchClientID_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.label6.Location = new System.Drawing.Point(264, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 37);
            this.label6.TabIndex = 12;
            this.label6.Text = "Client ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.label7.Location = new System.Drawing.Point(11, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(304, 37);
            this.label7.TabIndex = 11;
            this.label7.Text = "Search Reservation:";
            // 
            // tabPageUpdateDeleteReservation
            // 
            this.tabPageUpdateDeleteReservation.Controls.Add(this.buttonDelete);
            this.tabPageUpdateDeleteReservation.Controls.Add(this.comboBoxNo1);
            this.tabPageUpdateDeleteReservation.Controls.Add(this.label2);
            this.tabPageUpdateDeleteReservation.Controls.Add(this.dateTimePickerOut1);
            this.tabPageUpdateDeleteReservation.Controls.Add(this.label3);
            this.tabPageUpdateDeleteReservation.Controls.Add(this.dateTimePickerIn1);
            this.tabPageUpdateDeleteReservation.Controls.Add(this.comboBoxType1);
            this.tabPageUpdateDeleteReservation.Controls.Add(this.textBoxClientID1);
            this.tabPageUpdateDeleteReservation.Controls.Add(this.label5);
            this.tabPageUpdateDeleteReservation.Controls.Add(this.label8);
            this.tabPageUpdateDeleteReservation.Controls.Add(this.label9);
            this.tabPageUpdateDeleteReservation.Controls.Add(this.buttonUpdate);
            this.tabPageUpdateDeleteReservation.Controls.Add(this.label10);
            this.tabPageUpdateDeleteReservation.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpdateDeleteReservation.Name = "tabPageUpdateDeleteReservation";
            this.tabPageUpdateDeleteReservation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateDeleteReservation.Size = new System.Drawing.Size(1168, 546);
            this.tabPageUpdateDeleteReservation.TabIndex = 2;
            this.tabPageUpdateDeleteReservation.Text = "Update/Delete Reservation";
            this.tabPageUpdateDeleteReservation.UseVisualStyleBackColor = true;
            this.tabPageUpdateDeleteReservation.Leave += new System.EventHandler(this.tabPageUpdateDeleteReservation_Leave);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(297, 440);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(160, 57);
            this.buttonDelete.TabIndex = 42;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // comboBoxNo1
            // 
            this.comboBoxNo1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxNo1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxNo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxNo1.FormattingEnabled = true;
            this.comboBoxNo1.Items.AddRange(new object[] {
            "Select Room Number"});
            this.comboBoxNo1.Location = new System.Drawing.Point(611, 148);
            this.comboBoxNo1.Name = "comboBoxNo1";
            this.comboBoxNo1.Size = new System.Drawing.Size(302, 25);
            this.comboBoxNo1.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.label2.Location = new System.Drawing.Point(604, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 37);
            this.label2.TabIndex = 40;
            this.label2.Text = "Out:";
            // 
            // dateTimePickerOut1
            // 
            this.dateTimePickerOut1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerOut1.Location = new System.Drawing.Point(611, 383);
            this.dateTimePickerOut1.Name = "dateTimePickerOut1";
            this.dateTimePickerOut1.Size = new System.Drawing.Size(302, 23);
            this.dateTimePickerOut1.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.label3.Location = new System.Drawing.Point(124, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 37);
            this.label3.TabIndex = 38;
            this.label3.Text = "In:";
            // 
            // dateTimePickerIn1
            // 
            this.dateTimePickerIn1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerIn1.Location = new System.Drawing.Point(131, 383);
            this.dateTimePickerIn1.Name = "dateTimePickerIn1";
            this.dateTimePickerIn1.Size = new System.Drawing.Size(302, 23);
            this.dateTimePickerIn1.TabIndex = 37;
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
            this.comboBoxType1.Location = new System.Drawing.Point(131, 148);
            this.comboBoxType1.Name = "comboBoxType1";
            this.comboBoxType1.Size = new System.Drawing.Size(302, 25);
            this.comboBoxType1.TabIndex = 36;
            this.comboBoxType1.SelectedIndexChanged += new System.EventHandler(this.comboBoxType1_SelectedIndexChanged);
            // 
            // textBoxClientID1
            // 
            this.textBoxClientID1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.textBoxClientID1.Location = new System.Drawing.Point(131, 242);
            this.textBoxClientID1.Name = "textBoxClientID1";
            this.textBoxClientID1.Size = new System.Drawing.Size(302, 44);
            this.textBoxClientID1.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.label5.Location = new System.Drawing.Point(124, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 37);
            this.label5.TabIndex = 34;
            this.label5.Text = "Client ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.label8.Location = new System.Drawing.Point(604, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(235, 37);
            this.label8.TabIndex = 33;
            this.label8.Text = "Room Number:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.label9.Location = new System.Drawing.Point(124, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 37);
            this.label9.TabIndex = 32;
            this.label9.Text = "Room Type:";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(131, 440);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(160, 57);
            this.buttonUpdate.TabIndex = 31;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(468, 37);
            this.label10.TabIndex = 30;
            this.label10.Text = "Update and Delete Reservation:";
            // 
            // UserControlReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlReservation);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlReservation";
            this.Size = new System.Drawing.Size(1200, 600);
            this.Load += new System.EventHandler(this.UserControlReservation_Load);
            this.tabControlReservation.ResumeLayout(false);
            this.tabPageAddReservation.ResumeLayout(false);
            this.tabPageAddReservation.PerformLayout();
            this.tabPageSearchReservation.ResumeLayout(false);
            this.tabPageSearchReservation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservation)).EndInit();
            this.tabPageUpdateDeleteReservation.ResumeLayout(false);
            this.tabPageUpdateDeleteReservation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlReservation;
        private System.Windows.Forms.TabPage tabPageAddReservation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageSearchReservation;
        private System.Windows.Forms.DataGridView dataGridViewReservation;
        private System.Windows.Forms.TextBox textBoxSearchClientID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPageUpdateDeleteReservation;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox textBoxClientID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxNo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimePickerOut;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePickerIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ComboBox comboBoxNo1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerOut1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerIn1;
        private System.Windows.Forms.ComboBox comboBoxType1;
        private System.Windows.Forms.TextBox textBoxClientID1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label10;
    }
}
