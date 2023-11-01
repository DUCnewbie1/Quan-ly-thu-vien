namespace WindowsFormsApp2
{
    partial class LapPhieuTra
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
            this.label10 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTinhTrang = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbMaPM = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBook = new System.Windows.Forms.CheckedListBox();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbDocGia = new System.Windows.Forms.ComboBox();
            this.cbNhanVien = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpkNgayTra = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPhieuTra = new System.Windows.Forms.DataGridView();
            this.MaPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrangSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_Bookr = new System.Windows.Forms.ListBox();
            this.txtTinhTrangr = new System.Windows.Forms.TextBox();
            this.txtNhanVienr = new System.Windows.Forms.TextBox();
            this.txtMaPMr = new System.Windows.Forms.TextBox();
            this.txtDocGiar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMaPhieur = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtGhiChur = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.dtpkNgayTrar = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuTra)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(79, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Tìm Kiếm Theo Mã ";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(184, 21);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(100, 20);
            this.txtTimKiem.TabIndex = 37;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTinhTrang);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cbMaPM);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.checkedListBook);
            this.groupBox1.Controls.Add(this.txtMaPhieu);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbDocGia);
            this.groupBox1.Controls.Add(this.cbNhanVien);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpkNgayTra);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 222);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Thông Tin Phiếu Trả";
            // 
            // cbTinhTrang
            // 
            this.cbTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTinhTrang.FormattingEnabled = true;
            this.cbTinhTrang.Items.AddRange(new object[] {
            "Trả đủ sách",
            "Trả thiếu sách"});
            this.cbTinhTrang.Location = new System.Drawing.Point(374, 83);
            this.cbTinhTrang.Name = "cbTinhTrang";
            this.cbTinhTrang.Size = new System.Drawing.Size(144, 21);
            this.cbTinhTrang.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(291, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Tình trạng";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // cbMaPM
            // 
            this.cbMaPM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaPM.FormattingEnabled = true;
            this.cbMaPM.Location = new System.Drawing.Point(113, 86);
            this.cbMaPM.Name = "cbMaPM";
            this.cbMaPM.Size = new System.Drawing.Size(144, 21);
            this.cbMaPM.TabIndex = 38;
            this.cbMaPM.SelectedIndexChanged += new System.EventHandler(this.cbMaPM_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Mã Phiếu Mượn";
            // 
            // checkedListBook
            // 
            this.checkedListBook.FormattingEnabled = true;
            this.checkedListBook.Location = new System.Drawing.Point(113, 122);
            this.checkedListBook.Name = "checkedListBook";
            this.checkedListBook.Size = new System.Drawing.Size(144, 94);
            this.checkedListBook.TabIndex = 36;
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(113, 23);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(144, 20);
            this.txtMaPhieu.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Mã Phiếu ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Sách cần trả ";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(374, 126);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(144, 48);
            this.txtGhiChu.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(291, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Ghi Chú";
            // 
            // cbDocGia
            // 
            this.cbDocGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDocGia.FormattingEnabled = true;
            this.cbDocGia.Location = new System.Drawing.Point(113, 50);
            this.cbDocGia.Name = "cbDocGia";
            this.cbDocGia.Size = new System.Drawing.Size(144, 21);
            this.cbDocGia.TabIndex = 27;
            this.cbDocGia.SelectedIndexChanged += new System.EventHandler(this.cbDocGia_SelectedIndexChanged);
            // 
            // cbNhanVien
            // 
            this.cbNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNhanVien.FormattingEnabled = true;
            this.cbNhanVien.Location = new System.Drawing.Point(374, 50);
            this.cbNhanVien.Name = "cbNhanVien";
            this.cbNhanVien.Size = new System.Drawing.Size(144, 21);
            this.cbNhanVien.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Người lập phiếu ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Mã Đọc Giả ";
            // 
            // dtpkNgayTra
            // 
            this.dtpkNgayTra.Location = new System.Drawing.Point(374, 21);
            this.dtpkNgayTra.Name = "dtpkNgayTra";
            this.dtpkNgayTra.Size = new System.Drawing.Size(144, 20);
            this.dtpkNgayTra.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ngày Trả";
            // 
            // dgvPhieuTra
            // 
            this.dgvPhieuTra.AllowUserToAddRows = false;
            this.dgvPhieuTra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuTra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPT,
            this.NgayTra,
            this.GhiChu,
            this.TinhTrangSach,
            this.TenDocGia,
            this.TenNV,
            this.MaPM});
            this.dgvPhieuTra.Location = new System.Drawing.Point(12, 329);
            this.dgvPhieuTra.Name = "dgvPhieuTra";
            this.dgvPhieuTra.Size = new System.Drawing.Size(1035, 218);
            this.dgvPhieuTra.TabIndex = 33;
            this.dgvPhieuTra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuTra_CellClick);
            // 
            // MaPT
            // 
            this.MaPT.HeaderText = "Mã Phiếu Trả";
            this.MaPT.Name = "MaPT";
            // 
            // NgayTra
            // 
            this.NgayTra.HeaderText = "Ngày Trả";
            this.NgayTra.Name = "NgayTra";
            // 
            // GhiChu
            // 
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.Name = "GhiChu";
            // 
            // TinhTrangSach
            // 
            this.TinhTrangSach.HeaderText = "Tình Trạng Sách";
            this.TinhTrangSach.Name = "TinhTrangSach";
            // 
            // TenDocGia
            // 
            this.TenDocGia.HeaderText = "Tên Đọc Giả";
            this.TenDocGia.Name = "TenDocGia";
            // 
            // TenNV
            // 
            this.TenNV.HeaderText = "Tên Nhân Viên";
            this.TenNV.Name = "TenNV";
            // 
            // MaPM
            // 
            this.MaPM.HeaderText = "Mã Phiếu Mượn";
            this.MaPM.Name = "MaPM";
            this.MaPM.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(436, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "LẬP PHIẾU TRẢ";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(303, 19);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 23);
            this.btnThem.TabIndex = 35;
            this.btnThem.Text = "Lập phiếu";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_Bookr);
            this.groupBox2.Controls.Add(this.txtTinhTrangr);
            this.groupBox2.Controls.Add(this.txtNhanVienr);
            this.groupBox2.Controls.Add(this.txtMaPMr);
            this.groupBox2.Controls.Add(this.txtDocGiar);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtMaPhieur);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtGhiChur);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.dtpkNgayTrar);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Location = new System.Drawing.Point(542, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 272);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin phiếu trả";
            // 
            // lb_Bookr
            // 
            this.lb_Bookr.FormattingEnabled = true;
            this.lb_Bookr.Location = new System.Drawing.Point(113, 119);
            this.lb_Bookr.Name = "lb_Bookr";
            this.lb_Bookr.Size = new System.Drawing.Size(140, 134);
            this.lb_Bookr.TabIndex = 45;
            // 
            // txtTinhTrangr
            // 
            this.txtTinhTrangr.Location = new System.Drawing.Point(360, 87);
            this.txtTinhTrangr.Name = "txtTinhTrangr";
            this.txtTinhTrangr.ReadOnly = true;
            this.txtTinhTrangr.Size = new System.Drawing.Size(110, 20);
            this.txtTinhTrangr.TabIndex = 44;
            // 
            // txtNhanVienr
            // 
            this.txtNhanVienr.Location = new System.Drawing.Point(360, 53);
            this.txtNhanVienr.Name = "txtNhanVienr";
            this.txtNhanVienr.ReadOnly = true;
            this.txtNhanVienr.Size = new System.Drawing.Size(110, 20);
            this.txtNhanVienr.TabIndex = 43;
            // 
            // txtMaPMr
            // 
            this.txtMaPMr.Location = new System.Drawing.Point(360, 19);
            this.txtMaPMr.Name = "txtMaPMr";
            this.txtMaPMr.ReadOnly = true;
            this.txtMaPMr.Size = new System.Drawing.Size(79, 20);
            this.txtMaPMr.TabIndex = 42;
            // 
            // txtDocGiar
            // 
            this.txtDocGiar.Location = new System.Drawing.Point(113, 87);
            this.txtDocGiar.Name = "txtDocGiar";
            this.txtDocGiar.ReadOnly = true;
            this.txtDocGiar.Size = new System.Drawing.Size(79, 20);
            this.txtDocGiar.TabIndex = 41;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(272, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Tình trạng";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(272, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "Mã Phiếu Mượn";
            // 
            // txtMaPhieur
            // 
            this.txtMaPhieur.Location = new System.Drawing.Point(113, 19);
            this.txtMaPhieur.Name = "txtMaPhieur";
            this.txtMaPhieur.ReadOnly = true;
            this.txtMaPhieur.Size = new System.Drawing.Size(79, 20);
            this.txtMaPhieur.TabIndex = 35;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(30, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "Mã Phiếu ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(30, 122);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Sách đã trả ";
            // 
            // txtGhiChur
            // 
            this.txtGhiChur.Location = new System.Drawing.Point(360, 119);
            this.txtGhiChur.Multiline = true;
            this.txtGhiChur.Name = "txtGhiChur";
            this.txtGhiChur.ReadOnly = true;
            this.txtGhiChur.Size = new System.Drawing.Size(140, 85);
            this.txtGhiChur.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(272, 119);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Ghi Chú";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(272, 61);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(84, 13);
            this.label17.TabIndex = 25;
            this.label17.Text = "Người lập phiếu ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(33, 148);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 13);
            this.label18.TabIndex = 24;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(30, 94);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 13);
            this.label19.TabIndex = 23;
            this.label19.Text = "Mã Đọc Giả ";
            // 
            // dtpkNgayTrar
            // 
            this.dtpkNgayTrar.Enabled = false;
            this.dtpkNgayTrar.Location = new System.Drawing.Point(113, 54);
            this.dtpkNgayTrar.Name = "dtpkNgayTrar";
            this.dtpkNgayTrar.Size = new System.Drawing.Size(140, 20);
            this.dtpkNgayTrar.TabIndex = 22;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(30, 60);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(51, 13);
            this.label20.TabIndex = 20;
            this.label20.Text = "Ngày Trả";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtTimKiem);
            this.groupBox3.Location = new System.Drawing.Point(12, 273);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(524, 50);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức Năng";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(409, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 22);
            this.button1.TabIndex = 39;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LapPhieuTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 549);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvPhieuTra);
            this.Controls.Add(this.label1);
            this.Name = "LapPhieuTra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LapPhieuTra";
            this.Load += new System.EventHandler(this.LapPhieuTra_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuTra)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBook;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbDocGia;
        private System.Windows.Forms.ComboBox cbNhanVien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpkNgayTra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPhieuTra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbTinhTrang;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbMaPM;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrangSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPM;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMaPhieur;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtGhiChur;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dtpkNgayTrar;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtTinhTrangr;
        private System.Windows.Forms.TextBox txtNhanVienr;
        private System.Windows.Forms.TextBox txtMaPMr;
        private System.Windows.Forms.TextBox txtDocGiar;
        private System.Windows.Forms.ListBox lb_Bookr;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
    }
}