namespace WindowsFormsApp2
{
    partial class QuanLyNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyNhanVien));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExitNV = new System.Windows.Forms.Button();
            this.btnDeleteNV = new System.Windows.Forms.Button();
            this.btnEditNV = new System.Windows.Forms.Button();
            this.btnAddNV = new System.Windows.Forms.Button();
            this.txtPhoneNV = new System.Windows.Forms.TextBox();
            this.txtEmailNV = new System.Windows.Forms.TextBox();
            this.txtNameNV = new System.Windows.Forms.TextBox();
            this.txtIdNV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvQLNV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_DangKy = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLNV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_DangKy);
            this.panel1.Controls.Add(this.btnExitNV);
            this.panel1.Controls.Add(this.btnDeleteNV);
            this.panel1.Controls.Add(this.btnEditNV);
            this.panel1.Controls.Add(this.btnAddNV);
            this.panel1.Controls.Add(this.txtPhoneNV);
            this.panel1.Controls.Add(this.txtEmailNV);
            this.panel1.Controls.Add(this.txtNameNV);
            this.panel1.Controls.Add(this.txtIdNV);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 118);
            this.panel1.TabIndex = 0;
            // 
            // btnExitNV
            // 
            this.btnExitNV.Location = new System.Drawing.Point(572, 52);
            this.btnExitNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExitNV.Name = "btnExitNV";
            this.btnExitNV.Size = new System.Drawing.Size(57, 20);
            this.btnExitNV.TabIndex = 17;
            this.btnExitNV.Text = "Thoát";
            this.btnExitNV.UseVisualStyleBackColor = true;
            this.btnExitNV.Click += new System.EventHandler(this.btnExitNVf_Click);
            // 
            // btnDeleteNV
            // 
            this.btnDeleteNV.Location = new System.Drawing.Point(493, 52);
            this.btnDeleteNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteNV.Name = "btnDeleteNV";
            this.btnDeleteNV.Size = new System.Drawing.Size(57, 20);
            this.btnDeleteNV.TabIndex = 15;
            this.btnDeleteNV.Text = "Xóa";
            this.btnDeleteNV.UseVisualStyleBackColor = true;
            this.btnDeleteNV.Click += new System.EventHandler(this.btnDeleteNV_Click);
            // 
            // btnEditNV
            // 
            this.btnEditNV.Location = new System.Drawing.Point(572, 19);
            this.btnEditNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditNV.Name = "btnEditNV";
            this.btnEditNV.Size = new System.Drawing.Size(57, 20);
            this.btnEditNV.TabIndex = 14;
            this.btnEditNV.Text = "Sửa";
            this.btnEditNV.UseVisualStyleBackColor = true;
            this.btnEditNV.Click += new System.EventHandler(this.btnEditNV_Click);
            // 
            // btnAddNV
            // 
            this.btnAddNV.Location = new System.Drawing.Point(493, 19);
            this.btnAddNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddNV.Name = "btnAddNV";
            this.btnAddNV.Size = new System.Drawing.Size(57, 20);
            this.btnAddNV.TabIndex = 13;
            this.btnAddNV.Text = "Thêm";
            this.btnAddNV.UseVisualStyleBackColor = true;
            this.btnAddNV.Click += new System.EventHandler(this.btnAddNV_Click);
            // 
            // txtPhoneNV
            // 
            this.txtPhoneNV.Location = new System.Drawing.Point(251, 34);
            this.txtPhoneNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPhoneNV.Name = "txtPhoneNV";
            this.txtPhoneNV.Size = new System.Drawing.Size(205, 20);
            this.txtPhoneNV.TabIndex = 9;
            this.txtPhoneNV.TextChanged += new System.EventHandler(this.txtPhoneNV_TextChanged);
            // 
            // txtEmailNV
            // 
            this.txtEmailNV.Location = new System.Drawing.Point(251, 66);
            this.txtEmailNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmailNV.Name = "txtEmailNV";
            this.txtEmailNV.Size = new System.Drawing.Size(205, 20);
            this.txtEmailNV.TabIndex = 8;
            // 
            // txtNameNV
            // 
            this.txtNameNV.Location = new System.Drawing.Point(47, 68);
            this.txtNameNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNameNV.Name = "txtNameNV";
            this.txtNameNV.Size = new System.Drawing.Size(147, 20);
            this.txtNameNV.TabIndex = 7;
            this.txtNameNV.TextChanged += new System.EventHandler(this.txtNameNV_TextChanged);
            // 
            // txtIdNV
            // 
            this.txtIdNV.Location = new System.Drawing.Point(47, 34);
            this.txtIdNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdNV.Name = "txtIdNV";
            this.txtIdNV.Size = new System.Drawing.Size(146, 20);
            this.txtIdNV.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(205, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "SĐT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NV";
            // 
            // dgvQLNV
            // 
            this.dgvQLNV.AllowUserToAddRows = false;
            this.dgvQLNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvQLNV.Location = new System.Drawing.Point(3, 197);
            this.dgvQLNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvQLNV.Name = "dgvQLNV";
            this.dgvQLNV.RowHeadersWidth = 62;
            this.dgvQLNV.RowTemplate.Height = 28;
            this.dgvQLNV.Size = new System.Drawing.Size(652, 231);
            this.dgvQLNV.TabIndex = 1;
            this.dgvQLNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLNV_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Nhân Viên";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên nhân viên";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "SĐT";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Email";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(224, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Cập nhật nhân viên";
            // 
            // btn_DangKy
            // 
            this.btn_DangKy.Location = new System.Drawing.Point(493, 77);
            this.btn_DangKy.Name = "btn_DangKy";
            this.btn_DangKy.Size = new System.Drawing.Size(136, 23);
            this.btn_DangKy.TabIndex = 18;
            this.btn_DangKy.Text = "Đăng ký nhân viên";
            this.btn_DangKy.UseVisualStyleBackColor = true;
            this.btn_DangKy.Click += new System.EventHandler(this.btn_DangKy_Click);
            // 
            // QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 439);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvQLNV);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "QuanLyNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyNhanVien";
            this.Load += new System.EventHandler(this.QuanLyNhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdNV;
        private System.Windows.Forms.Button btnDeleteNV;
        private System.Windows.Forms.Button btnEditNV;
        private System.Windows.Forms.Button btnAddNV;
        private System.Windows.Forms.TextBox txtPhoneNV;
        private System.Windows.Forms.TextBox txtEmailNV;
        private System.Windows.Forms.TextBox txtNameNV;
        private System.Windows.Forms.Button btnExitNV;
        private System.Windows.Forms.DataGridView dgvQLNV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btn_DangKy;
    }
}