﻿namespace WindowsFormsApp2
{
    partial class QuanLySach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLySach));
            this.pnlAddBook = new System.Windows.Forms.Panel();
            this.cbTacGia = new System.Windows.Forms.ComboBox();
            this.cbNXB = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnOutQLS = new System.Windows.Forms.Button();
            this.btnImportBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYearBook = new System.Windows.Forms.TextBox();
            this.txtNameBook = new System.Windows.Forms.TextBox();
            this.txtIdBook = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvQLS = new System.Windows.Forms.DataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSBookQLS = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlAddBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLS)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAddBook
            // 
            this.pnlAddBook.AutoSize = true;
            this.pnlAddBook.Controls.Add(this.cbTacGia);
            this.pnlAddBook.Controls.Add(this.cbNXB);
            this.pnlAddBook.Controls.Add(this.txtQuantity);
            this.pnlAddBook.Controls.Add(this.txtPrice);
            this.pnlAddBook.Controls.Add(this.label10);
            this.pnlAddBook.Controls.Add(this.label9);
            this.pnlAddBook.Controls.Add(this.btnOutQLS);
            this.pnlAddBook.Controls.Add(this.btnImportBook);
            this.pnlAddBook.Controls.Add(this.btnDeleteBook);
            this.pnlAddBook.Controls.Add(this.btnEditBook);
            this.pnlAddBook.Controls.Add(this.btnAddBook);
            this.pnlAddBook.Controls.Add(this.label7);
            this.pnlAddBook.Controls.Add(this.label6);
            this.pnlAddBook.Controls.Add(this.label5);
            this.pnlAddBook.Controls.Add(this.label4);
            this.pnlAddBook.Controls.Add(this.txtCategory);
            this.pnlAddBook.Controls.Add(this.label3);
            this.pnlAddBook.Controls.Add(this.label2);
            this.pnlAddBook.Controls.Add(this.txtYearBook);
            this.pnlAddBook.Controls.Add(this.txtNameBook);
            this.pnlAddBook.Controls.Add(this.txtIdBook);
            this.pnlAddBook.Location = new System.Drawing.Point(3, 114);
            this.pnlAddBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlAddBook.Name = "pnlAddBook";
            this.pnlAddBook.Size = new System.Drawing.Size(855, 115);
            this.pnlAddBook.TabIndex = 0;
            // 
            // cbTacGia
            // 
            this.cbTacGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTacGia.FormattingEnabled = true;
            this.cbTacGia.Location = new System.Drawing.Point(537, 57);
            this.cbTacGia.Name = "cbTacGia";
            this.cbTacGia.Size = new System.Drawing.Size(132, 21);
            this.cbTacGia.TabIndex = 19;
            // 
            // cbNXB
            // 
            this.cbNXB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNXB.FormattingEnabled = true;
            this.cbNXB.Location = new System.Drawing.Point(306, 56);
            this.cbNXB.Name = "cbNXB";
            this.cbNXB.Size = new System.Drawing.Size(152, 21);
            this.cbNXB.TabIndex = 18;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(743, 58);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 17;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(743, 18);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(678, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Số Lượng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(674, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Giá Sách";
            // 
            // btnOutQLS
            // 
            this.btnOutQLS.Location = new System.Drawing.Point(402, 86);
            this.btnOutQLS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOutQLS.Name = "btnOutQLS";
            this.btnOutQLS.Size = new System.Drawing.Size(56, 21);
            this.btnOutQLS.TabIndex = 13;
            this.btnOutQLS.Text = "Thoát";
            this.btnOutQLS.UseVisualStyleBackColor = true;
            this.btnOutQLS.Click += new System.EventHandler(this.btnOutQLS_Click);
            // 
            // btnImportBook
            // 
            this.btnImportBook.Location = new System.Drawing.Point(322, 86);
            this.btnImportBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImportBook.Name = "btnImportBook";
            this.btnImportBook.Size = new System.Drawing.Size(56, 21);
            this.btnImportBook.TabIndex = 12;
            this.btnImportBook.Text = "Import";
            this.btnImportBook.UseVisualStyleBackColor = true;
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(239, 86);
            this.btnDeleteBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(56, 21);
            this.btnDeleteBook.TabIndex = 10;
            this.btnDeleteBook.Text = "Xóa";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnEditBook
            // 
            this.btnEditBook.Location = new System.Drawing.Point(161, 86);
            this.btnEditBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(56, 21);
            this.btnEditBook.TabIndex = 9;
            this.btnEditBook.Text = "Sửa ";
            this.btnEditBook.UseVisualStyleBackColor = true;
            this.btnEditBook.Click += new System.EventHandler(this.btnEditBook_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(84, 86);
            this.btnAddBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(56, 21);
            this.btnAddBook.TabIndex = 8;
            this.btnAddBook.Text = "Thêm ";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(476, 65);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tác giả";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(476, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Thể loại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nhà XB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Năm XB";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(537, 18);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(132, 20);
            this.txtCategory.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã sách";
            // 
            // txtYearBook
            // 
            this.txtYearBook.Location = new System.Drawing.Point(307, 20);
            this.txtYearBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtYearBook.Name = "txtYearBook";
            this.txtYearBook.Size = new System.Drawing.Size(151, 20);
            this.txtYearBook.TabIndex = 2;
            // 
            // txtNameBook
            // 
            this.txtNameBook.Location = new System.Drawing.Point(63, 58);
            this.txtNameBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNameBook.Name = "txtNameBook";
            this.txtNameBook.Size = new System.Drawing.Size(181, 20);
            this.txtNameBook.TabIndex = 1;
            // 
            // txtIdBook
            // 
            this.txtIdBook.Location = new System.Drawing.Point(63, 18);
            this.txtIdBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdBook.Name = "txtIdBook";
            this.txtIdBook.Size = new System.Drawing.Size(181, 20);
            this.txtIdBook.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cập nhật sách";
            // 
            // dgvQLS
            // 
            this.dgvQLS.AllowUserToAddRows = false;
            this.dgvQLS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach,
            this.TheLoai,
            this.NamXB,
            this.GiaSach,
            this.SoLuong,
            this.MaNXB,
            this.MaTacGia});
            this.dgvQLS.Location = new System.Drawing.Point(3, 233);
            this.dgvQLS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvQLS.Name = "dgvQLS";
            this.dgvQLS.RowHeadersWidth = 62;
            this.dgvQLS.RowTemplate.Height = 28;
            this.dgvQLS.Size = new System.Drawing.Size(855, 205);
            this.dgvQLS.TabIndex = 2;
            this.dgvQLS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLS_CellClick);
            // 
            // MaSach
            // 
            this.MaSach.HeaderText = "Mã Sách";
            this.MaSach.MinimumWidth = 8;
            this.MaSach.Name = "MaSach";
            // 
            // TenSach
            // 
            this.TenSach.HeaderText = "Tên Sách";
            this.TenSach.MinimumWidth = 8;
            this.TenSach.Name = "TenSach";
            // 
            // TheLoai
            // 
            this.TheLoai.HeaderText = "Thể Loại";
            this.TheLoai.MinimumWidth = 8;
            this.TheLoai.Name = "TheLoai";
            // 
            // NamXB
            // 
            this.NamXB.HeaderText = "Năm Xuất Bản";
            this.NamXB.MinimumWidth = 8;
            this.NamXB.Name = "NamXB";
            // 
            // GiaSach
            // 
            this.GiaSach.HeaderText = "Giá Sách";
            this.GiaSach.MinimumWidth = 8;
            this.GiaSach.Name = "GiaSach";
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 8;
            this.SoLuong.Name = "SoLuong";
            // 
            // MaNXB
            // 
            this.MaNXB.HeaderText = "Nhà xuất bản";
            this.MaNXB.MinimumWidth = 8;
            this.MaNXB.Name = "MaNXB";
            // 
            // MaTacGia
            // 
            this.MaTacGia.HeaderText = "Tác Giả";
            this.MaTacGia.MinimumWidth = 8;
            this.MaTacGia.Name = "MaTacGia";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtSBookQLS);
            this.panel1.Location = new System.Drawing.Point(3, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 55);
            this.panel1.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(257, 35);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tên sách";
            // 
            // txtSBookQLS
            // 
            this.txtSBookQLS.Location = new System.Drawing.Point(322, 28);
            this.txtSBookQLS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSBookQLS.Name = "txtSBookQLS";
            this.txtSBookQLS.Size = new System.Drawing.Size(218, 20);
            this.txtSBookQLS.TabIndex = 0;
            this.txtSBookQLS.TextChanged += new System.EventHandler(this.txtSBookQLS_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Green;
            this.label11.Location = new System.Drawing.Point(319, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 32);
            this.label11.TabIndex = 4;
            this.label11.Text = "Quản lý sách";
            // 
            // QuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 445);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvQLS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlAddBook);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "QuanLySach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLySach";
            this.Load += new System.EventHandler(this.QuanLySach_Load);
            this.pnlAddBook.ResumeLayout(false);
            this.pnlAddBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddBook;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYearBook;
        private System.Windows.Forms.TextBox txtNameBook;
        private System.Windows.Forms.TextBox txtIdBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOutQLS;
        private System.Windows.Forms.Button btnImportBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnEditBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.DataGridView dgvQLS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSBookQLS;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTacGia;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbTacGia;
        private System.Windows.Forms.ComboBox cbNXB;
        private System.Windows.Forms.Label label11;
    }
}