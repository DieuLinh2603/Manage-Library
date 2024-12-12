namespace Login
{
    partial class History_Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History_Book));
            this.dtgv_MuonSach = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dtgv_TraSach = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimKiem_Muon = new System.Windows.Forms.Button();
            this.txtSoTheMuon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenSachMuon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpMuon = new System.Windows.Forms.DateTimePicker();
            this.dtpTra = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenSachTra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTimKiem_Tra = new System.Windows.Forms.Button();
            this.txtSoTheTra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLamMoiMuon = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_MuonSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_TraSach)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_MuonSach
            // 
            this.dtgv_MuonSach.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgv_MuonSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_MuonSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dtgv_MuonSach.Location = new System.Drawing.Point(12, 135);
            this.dtgv_MuonSach.Name = "dtgv_MuonSach";
            this.dtgv_MuonSach.RowHeadersWidth = 51;
            this.dtgv_MuonSach.RowTemplate.Height = 24;
            this.dtgv_MuonSach.Size = new System.Drawing.Size(1370, 252);
            this.dtgv_MuonSach.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "SoThe";
            this.Column2.HeaderText = "Số thẻ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 160;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "HoTen";
            this.Column3.HeaderText = "Họ tên";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 160;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Email";
            this.Column4.HeaderText = "Email";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 160;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TenSach";
            this.Column5.HeaderText = "Tên sách";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 160;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "NgayMuon";
            this.Column6.HeaderText = "Ngày mượn";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 160;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(557, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 51);
            this.label2.TabIndex = 23;
            this.label2.Text = "Trả Sách";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(518, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 51);
            this.label1.TabIndex = 24;
            this.label1.Text = "Mượn Sách";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(782, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(782, 406);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // dtgv_TraSach
            // 
            this.dtgv_TraSach.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgv_TraSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_TraSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.Column8});
            this.dtgv_TraSach.Location = new System.Drawing.Point(35, 520);
            this.dtgv_TraSach.Name = "dtgv_TraSach";
            this.dtgv_TraSach.RowHeadersWidth = 51;
            this.dtgv_TraSach.RowTemplate.Height = 24;
            this.dtgv_TraSach.Size = new System.Drawing.Size(1370, 258);
            this.dtgv_TraSach.TabIndex = 27;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SoThe";
            this.dataGridViewTextBoxColumn2.HeaderText = "Số thẻ";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 140;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "HoTen";
            this.dataGridViewTextBoxColumn3.HeaderText = "Họ tên";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 140;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 140;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TenSach";
            this.dataGridViewTextBoxColumn5.HeaderText = "Tên sách";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 140;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NgayMuon";
            this.dataGridViewTextBoxColumn6.HeaderText = "Ngày mượn";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 140;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "NgayTra";
            this.dataGridViewTextBoxColumn7.HeaderText = "Ngày trả";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 140;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "PhiPhat";
            this.Column8.HeaderText = "Phí phạt";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // btnTimKiem_Muon
            // 
            this.btnTimKiem_Muon.BackColor = System.Drawing.Color.CadetBlue;
            this.btnTimKiem_Muon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem_Muon.FlatAppearance.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.btnTimKiem_Muon.FlatAppearance.BorderSize = 2;
            this.btnTimKiem_Muon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem_Muon.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem_Muon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTimKiem_Muon.Location = new System.Drawing.Point(1398, 26);
            this.btnTimKiem_Muon.Name = "btnTimKiem_Muon";
            this.btnTimKiem_Muon.Size = new System.Drawing.Size(111, 56);
            this.btnTimKiem_Muon.TabIndex = 30;
            this.btnTimKiem_Muon.Text = "Tìm kiếm";
            this.btnTimKiem_Muon.UseVisualStyleBackColor = false;
            this.btnTimKiem_Muon.Click += new System.EventHandler(this.btnTimKiem_Muon_Click);
            // 
            // txtSoTheMuon
            // 
            this.txtSoTheMuon.Location = new System.Drawing.Point(137, 85);
            this.txtSoTheMuon.Multiline = true;
            this.txtSoTheMuon.Name = "txtSoTheMuon";
            this.txtSoTheMuon.Size = new System.Drawing.Size(312, 32);
            this.txtSoTheMuon.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(43, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 29);
            this.label4.TabIndex = 28;
            this.label4.Text = "Số thẻ";
            // 
            // txtTenSachMuon
            // 
            this.txtTenSachMuon.Location = new System.Drawing.Point(579, 85);
            this.txtTenSachMuon.Multiline = true;
            this.txtTenSachMuon.Name = "txtTenSachMuon";
            this.txtTenSachMuon.Size = new System.Drawing.Size(312, 32);
            this.txtTenSachMuon.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(453, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 29);
            this.label3.TabIndex = 31;
            this.label3.Text = "Tên sách";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(895, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 29);
            this.label8.TabIndex = 40;
            this.label8.Text = "Ngày mượn";
            // 
            // dtpMuon
            // 
            this.dtpMuon.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMuon.Location = new System.Drawing.Point(1045, 88);
            this.dtpMuon.Name = "dtpMuon";
            this.dtpMuon.Size = new System.Drawing.Size(305, 30);
            this.dtpMuon.TabIndex = 41;
            // 
            // dtpTra
            // 
            this.dtpTra.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTra.Location = new System.Drawing.Point(1045, 469);
            this.dtpTra.Name = "dtpTra";
            this.dtpTra.Size = new System.Drawing.Size(305, 30);
            this.dtpTra.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(895, 472);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 29);
            this.label5.TabIndex = 47;
            this.label5.Text = "Ngày mượn";
            // 
            // txtTenSachTra
            // 
            this.txtTenSachTra.Location = new System.Drawing.Point(579, 469);
            this.txtTenSachTra.Multiline = true;
            this.txtTenSachTra.Name = "txtTenSachTra";
            this.txtTenSachTra.Size = new System.Drawing.Size(312, 32);
            this.txtTenSachTra.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(453, 472);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 29);
            this.label6.TabIndex = 45;
            this.label6.Text = "Tên sách";
            // 
            // btnTimKiem_Tra
            // 
            this.btnTimKiem_Tra.BackColor = System.Drawing.Color.CadetBlue;
            this.btnTimKiem_Tra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem_Tra.FlatAppearance.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.btnTimKiem_Tra.FlatAppearance.BorderSize = 2;
            this.btnTimKiem_Tra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem_Tra.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem_Tra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTimKiem_Tra.Location = new System.Drawing.Point(1411, 409);
            this.btnTimKiem_Tra.Name = "btnTimKiem_Tra";
            this.btnTimKiem_Tra.Size = new System.Drawing.Size(111, 56);
            this.btnTimKiem_Tra.TabIndex = 44;
            this.btnTimKiem_Tra.Text = "Tìm kiếm";
            this.btnTimKiem_Tra.UseVisualStyleBackColor = false;
            this.btnTimKiem_Tra.Click += new System.EventHandler(this.btnTimKiem_Tra_Click);
            // 
            // txtSoTheTra
            // 
            this.txtSoTheTra.Location = new System.Drawing.Point(137, 469);
            this.txtSoTheTra.Multiline = true;
            this.txtSoTheTra.Name = "txtSoTheTra";
            this.txtSoTheTra.Size = new System.Drawing.Size(312, 32);
            this.txtSoTheTra.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(43, 472);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 29);
            this.label7.TabIndex = 42;
            this.label7.Text = "Số thẻ";
            // 
            // btnLamMoiMuon
            // 
            this.btnLamMoiMuon.BackColor = System.Drawing.Color.CadetBlue;
            this.btnLamMoiMuon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoiMuon.FlatAppearance.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.btnLamMoiMuon.FlatAppearance.BorderSize = 2;
            this.btnLamMoiMuon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoiMuon.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoiMuon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLamMoiMuon.Location = new System.Drawing.Point(1398, 99);
            this.btnLamMoiMuon.Name = "btnLamMoiMuon";
            this.btnLamMoiMuon.Size = new System.Drawing.Size(111, 56);
            this.btnLamMoiMuon.TabIndex = 49;
            this.btnLamMoiMuon.Text = "Làm mới";
            this.btnLamMoiMuon.UseVisualStyleBackColor = false;
            this.btnLamMoiMuon.Click += new System.EventHandler(this.btnLamMoiMuon_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(1411, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 56);
            this.button1.TabIndex = 50;
            this.button1.Text = "Làm mới";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // History_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1531, 818);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLamMoiMuon);
            this.Controls.Add(this.dtpTra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTenSachTra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTimKiem_Tra);
            this.Controls.Add(this.txtSoTheTra);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpMuon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTenSachMuon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTimKiem_Muon);
            this.Controls.Add(this.txtSoTheMuon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtgv_TraSach);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgv_MuonSach);
            this.MaximizeBox = false;
            this.Name = "History_Book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "History_Book";
            this.Load += new System.EventHandler(this.History_Book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_MuonSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_TraSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_MuonSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dtgv_TraSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button btnTimKiem_Muon;
        private System.Windows.Forms.TextBox txtSoTheMuon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenSachMuon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpMuon;
        private System.Windows.Forms.DateTimePicker dtpTra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenSachTra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTimKiem_Tra;
        private System.Windows.Forms.TextBox txtSoTheTra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLamMoiMuon;
        private System.Windows.Forms.Button button1;
    }
}