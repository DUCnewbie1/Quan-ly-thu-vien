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
            this.label8 = new System.Windows.Forms.Label();
            this.dtpkNgayLap = new System.Windows.Forms.DateTimePicker();
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
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLDG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cập nhật thông tin đọc giả";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dtpkNgayLap);
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
            this.panel1.Location = new System.Drawing.Point(11, 128);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 134);
            this.panel1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(305, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Ngày Lập Thẻ";
            // 
            // dtpkNgayLap
            // 
            this.dtpkNgayLap.Location = new System.Drawing.Point(401, 92);
            this.dtpkNgayLap.Name = "dtpkNgayLap";
            this.dtpkNgayLap.Size = new System.Drawing.Size(193, 20);
            this.dtpkNgayLap.TabIndex = 17;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(401, 53);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(193, 20);
            this.txtSDT.TabIndex = 16;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(86, 92);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(186, 20);
            this.txtEmail.TabIndex = 15;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(86, 53);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(186, 20);
            this.txtDiaChi.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 99);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(305, 60);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "SĐT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Địa Chỉ";
            // 
            // txtTenDG
            // 
            this.txtTenDG.Location = new System.Drawing.Point(401, 11);
            this.txtTenDG.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenDG.Name = "txtTenDG";
            this.txtTenDG.Size = new System.Drawing.Size(193, 20);
            this.txtTenDG.TabIndex = 10;
            this.txtTenDG.TextChanged += new System.EventHandler(this.txtTenDG_TextChanged);
            // 
            // txtMaDG
            // 
            this.txtMaDG.Location = new System.Drawing.Point(86, 11);
            this.txtMaDG.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaDG.Name = "txtMaDG";
            this.txtMaDG.Size = new System.Drawing.Size(186, 20);
            this.txtMaDG.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Họ tên ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã đọc giả";
            // 
            // btnExitDG
            // 
            this.btnExitDG.Location = new System.Drawing.Point(697, 53);
            this.btnExitDG.Margin = new System.Windows.Forms.Padding(2);
            this.btnExitDG.Name = "btnExitDG";
            this.btnExitDG.Size = new System.Drawing.Size(61, 27);
            this.btnExitDG.TabIndex = 4;
            this.btnExitDG.Text = "Thoát";
            this.btnExitDG.UseVisualStyleBackColor = true;
            this.btnExitDG.Click += new System.EventHandler(this.btnExitDG_Click);
            // 
            // btnDeleteDG
            // 
            this.btnDeleteDG.Location = new System.Drawing.Point(621, 53);
            this.btnDeleteDG.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteDG.Name = "btnDeleteDG";
            this.btnDeleteDG.Size = new System.Drawing.Size(61, 27);
            this.btnDeleteDG.TabIndex = 2;
            this.btnDeleteDG.Text = "Xóa";
            this.btnDeleteDG.UseVisualStyleBackColor = true;
            this.btnDeleteDG.Click += new System.EventHandler(this.btnDeleteDG_Click);
            // 
            // btnEditDG
            // 
            this.btnEditDG.Location = new System.Drawing.Point(697, 13);
            this.btnEditDG.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditDG.Name = "btnEditDG";
            this.btnEditDG.Size = new System.Drawing.Size(61, 27);
            this.btnEditDG.TabIndex = 1;
            this.btnEditDG.Text = "Sửa";
            this.btnEditDG.UseVisualStyleBackColor = true;
            this.btnEditDG.Click += new System.EventHandler(this.btnEditDG_Click);
            // 
            // btnAddDG
            // 
            this.btnAddDG.Location = new System.Drawing.Point(621, 13);
            this.btnAddDG.Margin = new System.Windows.Forms.Padding(2);
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
            this.label2.Location = new System.Drawing.Point(11, 113);
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
            this.Email,
            this.NgayLap});
            this.dgvQLDG.Location = new System.Drawing.Point(11, 266);
            this.dgvQLDG.Margin = new System.Windows.Forms.Padding(2);
            this.dgvQLDG.Name = "dgvQLDG";
            this.dgvQLDG.RowHeadersWidth = 62;
            this.dgvQLDG.Size = new System.Drawing.Size(765, 281);
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
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(319, 73);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(186, 20);
            this.txtTimKiem.TabIndex = 18;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(212, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Tìm Kiếm Theo Mã ";
            // 
            // NgayLap
            // 
            this.NgayLap.HeaderText = "NgayLap";
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.Visible = false;
            // 
            // QuanLyDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 540);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.dgvQLDG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QuanLyDocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyDocGia";
            this.Load += new System.EventHandler(this.QuanLyDocGia_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLDG)).EndInit();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpkNgayLap;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
    }
}