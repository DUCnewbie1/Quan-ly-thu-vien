namespace WindowsFormsApp2
{
    partial class QuanLyDocGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyDocGia));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenDG = new System.Windows.Forms.TextBox();
            this.txtMaDG = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExitDG = new System.Windows.Forms.Button();
            this.btnDeleteDG = new System.Windows.Forms.Button();
            this.btnEditDG = new System.Windows.Forms.Button();
            this.btnAddDG = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvQLDG = new System.Windows.Forms.DataGridView();
            this.MaDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýĐộcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhàXuấtBảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mượnTrảSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lậpPhiếuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.độcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoThốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLDG)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cập nhật thông tin độc giả";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtTenDG);
            this.panel1.Controls.Add(this.txtMaDG);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnExitDG);
            this.panel1.Controls.Add(this.btnDeleteDG);
            this.panel1.Controls.Add(this.btnEditDG);
            this.panel1.Controls.Add(this.btnAddDG);
            this.panel1.Location = new System.Drawing.Point(8, 67);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 135);
            this.panel1.TabIndex = 1;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(397, 68);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(193, 20);
            this.txtSDT.TabIndex = 16;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(82, 107);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(186, 20);
            this.txtEmail.TabIndex = 15;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(82, 68);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(186, 20);
            this.txtDiaChi.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 111);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 72);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "SĐT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Địa Chỉ";
            // 
            // txtTenDG
            // 
            this.txtTenDG.Location = new System.Drawing.Point(397, 26);
            this.txtTenDG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenDG.Name = "txtTenDG";
            this.txtTenDG.Size = new System.Drawing.Size(193, 20);
            this.txtTenDG.TabIndex = 10;
            this.txtTenDG.TextChanged += new System.EventHandler(this.txtTenDG_TextChanged);
            // 
            // txtMaDG
            // 
            this.txtMaDG.Location = new System.Drawing.Point(82, 26);
            this.txtMaDG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaDG.Name = "txtMaDG";
            this.txtMaDG.Size = new System.Drawing.Size(186, 20);
            this.txtMaDG.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Họ tên ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã đọc giả";
            // 
            // btnExitDG
            // 
            this.btnExitDG.Location = new System.Drawing.Point(693, 68);
            this.btnExitDG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExitDG.Name = "btnExitDG";
            this.btnExitDG.Size = new System.Drawing.Size(61, 27);
            this.btnExitDG.TabIndex = 4;
            this.btnExitDG.Text = "Thoát";
            this.btnExitDG.UseVisualStyleBackColor = true;
            this.btnExitDG.Click += new System.EventHandler(this.btnExitDG_Click);
            // 
            // btnDeleteDG
            // 
            this.btnDeleteDG.Location = new System.Drawing.Point(617, 68);
            this.btnDeleteDG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteDG.Name = "btnDeleteDG";
            this.btnDeleteDG.Size = new System.Drawing.Size(61, 27);
            this.btnDeleteDG.TabIndex = 2;
            this.btnDeleteDG.Text = "Xóa";
            this.btnDeleteDG.UseVisualStyleBackColor = true;
            this.btnDeleteDG.Click += new System.EventHandler(this.btnDeleteDG_Click);
            // 
            // btnEditDG
            // 
            this.btnEditDG.Location = new System.Drawing.Point(693, 28);
            this.btnEditDG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditDG.Name = "btnEditDG";
            this.btnEditDG.Size = new System.Drawing.Size(61, 27);
            this.btnEditDG.TabIndex = 1;
            this.btnEditDG.Text = "Sửa";
            this.btnEditDG.UseVisualStyleBackColor = true;
            this.btnEditDG.Click += new System.EventHandler(this.btnEditDG_Click);
            // 
            // btnAddDG
            // 
            this.btnAddDG.Location = new System.Drawing.Point(617, 28);
            this.btnAddDG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddDG.Name = "btnAddDG";
            this.btnAddDG.Size = new System.Drawing.Size(61, 27);
            this.btnAddDG.TabIndex = 0;
            this.btnAddDG.Text = "Thêm";
            this.btnAddDG.UseVisualStyleBackColor = true;
            this.btnAddDG.Click += new System.EventHandler(this.btnAddDG_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cập nhật thông tin";
            // 
            // dgvQLDG
            // 
            this.dgvQLDG.AllowUserToAddRows = false;
            this.dgvQLDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDocGia,
            this.TenDocGia,
            this.DiaChi,
            this.SDT,
            this.Email});
            this.dgvQLDG.Location = new System.Drawing.Point(9, 205);
            this.dgvQLDG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvQLDG.Name = "dgvQLDG";
            this.dgvQLDG.RowHeadersWidth = 62;
            this.dgvQLDG.Size = new System.Drawing.Size(765, 192);
            this.dgvQLDG.TabIndex = 4;
            this.dgvQLDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLDG_CellClick);
            // 
            // MaDocGia
            // 
            this.MaDocGia.HeaderText = "Mã Đọc Giả";
            this.MaDocGia.MinimumWidth = 8;
            this.MaDocGia.Name = "MaDocGia";
            // 
            // TenDocGia
            // 
            this.TenDocGia.HeaderText = "Tên Đọc Giả";
            this.TenDocGia.MinimumWidth = 8;
            this.TenDocGia.Name = "TenDocGia";
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.MinimumWidth = 8;
            this.DiaChi.Name = "DiaChi";
            // 
            // SDT
            // 
            this.SDT.HeaderText = "SĐT";
            this.SDT.MinimumWidth = 8;
            this.SDT.Name = "SDT";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hToolStripMenuItem,
            this.danhMụcToolStripMenuItem,
            this.mượnTrảSáchToolStripMenuItem,
            this.tìmKiếmToolStripMenuItem,
            this.báoCáoThốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(784, 30);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hToolStripMenuItem
            // 
            this.hToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.hToolStripMenuItem.Image = global::WindowsFormsApp2.Properties.Resources.system2;
            this.hToolStripMenuItem.Name = "hToolStripMenuItem";
            this.hToolStripMenuItem.Size = new System.Drawing.Size(93, 28);
            this.hToolStripMenuItem.Text = "Hệ thống";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Image = global::WindowsFormsApp2.Properties.Resources.iconexit;
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Q)));
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Image = global::WindowsFormsApp2.Properties.Resources.ext;
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýSáchToolStripMenuItem,
            this.quảnLýĐộcGiảToolStripMenuItem,
            this.quảnLýNhânViênToolStripMenuItem,
            this.quảnLýNhàXuấtBảnToolStripMenuItem});
            this.danhMụcToolStripMenuItem.Image = global::WindowsFormsApp2.Properties.Resources.list;
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // quảnLýSáchToolStripMenuItem
            // 
            this.quảnLýSáchToolStripMenuItem.Image = global::WindowsFormsApp2.Properties.Resources.addbook;
            this.quảnLýSáchToolStripMenuItem.Name = "quảnLýSáchToolStripMenuItem";
            this.quảnLýSáchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.quảnLýSáchToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.quảnLýSáchToolStripMenuItem.Text = "Quản lý sách";
            // 
            // quảnLýĐộcGiảToolStripMenuItem
            // 
            this.quảnLýĐộcGiảToolStripMenuItem.Image = global::WindowsFormsApp2.Properties.Resources.addhuman;
            this.quảnLýĐộcGiảToolStripMenuItem.Name = "quảnLýĐộcGiảToolStripMenuItem";
            this.quảnLýĐộcGiảToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.quảnLýĐộcGiảToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.quảnLýĐộcGiảToolStripMenuItem.Text = "Quản lý độc giả";
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Image = global::WindowsFormsApp2.Properties.Resources.addstaff;
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản lý nhân viên";
            // 
            // quảnLýNhàXuấtBảnToolStripMenuItem
            // 
            this.quảnLýNhàXuấtBảnToolStripMenuItem.Image = global::WindowsFormsApp2.Properties.Resources.publishing;
            this.quảnLýNhàXuấtBảnToolStripMenuItem.Name = "quảnLýNhàXuấtBảnToolStripMenuItem";
            this.quảnLýNhàXuấtBảnToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.quảnLýNhàXuấtBảnToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.quảnLýNhàXuấtBảnToolStripMenuItem.Text = "Quản lý nhà xuất bản";
            // 
            // mượnTrảSáchToolStripMenuItem
            // 
            this.mượnTrảSáchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lậpPhiếuToolStripMenuItem});
            this.mượnTrảSáchToolStripMenuItem.Image = global::WindowsFormsApp2.Properties.Resources.brrowbook;
            this.mượnTrảSáchToolStripMenuItem.Name = "mượnTrảSáchToolStripMenuItem";
            this.mượnTrảSáchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mượnTrảSáchToolStripMenuItem.Size = new System.Drawing.Size(119, 28);
            this.mượnTrảSáchToolStripMenuItem.Text = "Mượn trả sách";
            // 
            // lậpPhiếuToolStripMenuItem
            // 
            this.lậpPhiếuToolStripMenuItem.Image = global::WindowsFormsApp2.Properties.Resources.list;
            this.lậpPhiếuToolStripMenuItem.Name = "lậpPhiếuToolStripMenuItem";
            this.lậpPhiếuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.lậpPhiếuToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.lậpPhiếuToolStripMenuItem.Text = "Lập phiếu";
            // 
            // tìmKiếmToolStripMenuItem
            // 
            this.tìmKiếmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sáchToolStripMenuItem,
            this.độcGiảToolStripMenuItem});
            this.tìmKiếmToolStripMenuItem.Image = global::WindowsFormsApp2.Properties.Resources.search2;
            this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            this.tìmKiếmToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(92, 28);
            this.tìmKiếmToolStripMenuItem.Text = "Tìm kiếm";
            // 
            // sáchToolStripMenuItem
            // 
            this.sáchToolStripMenuItem.Image = global::WindowsFormsApp2.Properties.Resources.brrowbook;
            this.sáchToolStripMenuItem.Name = "sáchToolStripMenuItem";
            this.sáchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.sáchToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.sáchToolStripMenuItem.Text = "Sách";
            // 
            // độcGiảToolStripMenuItem
            // 
            this.độcGiảToolStripMenuItem.Image = global::WindowsFormsApp2.Properties.Resources.addhuman;
            this.độcGiảToolStripMenuItem.Name = "độcGiảToolStripMenuItem";
            this.độcGiảToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.độcGiảToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.độcGiảToolStripMenuItem.Text = "Độc giả";
            // 
            // báoCáoThốngKêToolStripMenuItem
            // 
            this.báoCáoThốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xuấtExcelToolStripMenuItem});
            this.báoCáoThốngKêToolStripMenuItem.Image = global::WindowsFormsApp2.Properties.Resources.report;
            this.báoCáoThốngKêToolStripMenuItem.Name = "báoCáoThốngKêToolStripMenuItem";
            this.báoCáoThốngKêToolStripMenuItem.Size = new System.Drawing.Size(135, 28);
            this.báoCáoThốngKêToolStripMenuItem.Text = "Báo cáo thống kê";
            // 
            // xuấtExcelToolStripMenuItem
            // 
            this.xuấtExcelToolStripMenuItem.Image = global::WindowsFormsApp2.Properties.Resources.excel;
            this.xuấtExcelToolStripMenuItem.Name = "xuấtExcelToolStripMenuItem";
            this.xuấtExcelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.xuấtExcelToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.xuấtExcelToolStripMenuItem.Text = "Xuất Excel";
            // 
            // QuanLyDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 403);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvQLDG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "QuanLyDocGia";
            this.Text = "QuanLyDocGia";
            this.Load += new System.EventHandler(this.QuanLyDocGia_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLDG)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExitDG;
        private System.Windows.Forms.Button btnDeleteDG;
        private System.Windows.Forms.Button btnEditDG;
        private System.Windows.Forms.Button btnAddDG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenDG;
        private System.Windows.Forms.TextBox txtMaDG;
        private System.Windows.Forms.DataGridView dgvQLDG;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýĐộcGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhàXuấtBảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mượnTrảSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lậpPhiếuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem độcGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoThốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuấtExcelToolStripMenuItem;
    }
}