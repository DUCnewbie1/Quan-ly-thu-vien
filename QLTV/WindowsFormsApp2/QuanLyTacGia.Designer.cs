namespace WindowsFormsApp2
{
    partial class QuanLyTacGia
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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MaTG = new System.Windows.Forms.TextBox();
            this.lbl_Ma = new System.Windows.Forms.Label();
            this.dgvTG = new System.Windows.Forms.DataGridView();
            this.MaTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_TenTG = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTG)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên tác giả";
            // 
            // txt_MaTG
            // 
            this.txt_MaTG.Location = new System.Drawing.Point(75, 31);
            this.txt_MaTG.Multiline = true;
            this.txt_MaTG.Name = "txt_MaTG";
            this.txt_MaTG.Size = new System.Drawing.Size(140, 21);
            this.txt_MaTG.TabIndex = 1;
            // 
            // lbl_Ma
            // 
            this.lbl_Ma.AutoSize = true;
            this.lbl_Ma.Location = new System.Drawing.Point(6, 39);
            this.lbl_Ma.Name = "lbl_Ma";
            this.lbl_Ma.Size = new System.Drawing.Size(57, 13);
            this.lbl_Ma.TabIndex = 0;
            this.lbl_Ma.Text = "Mã tác giả";
            // 
            // dgvTG
            // 
            this.dgvTG.AllowUserToAddRows = false;
            this.dgvTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTG,
            this.TenTG});
            this.dgvTG.Location = new System.Drawing.Point(12, 203);
            this.dgvTG.Name = "dgvTG";
            this.dgvTG.ReadOnly = true;
            this.dgvTG.RowHeadersWidth = 62;
            this.dgvTG.Size = new System.Drawing.Size(536, 281);
            this.dgvTG.TabIndex = 6;
            this.dgvTG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTG_CellClick);
            // 
            // MaTG
            // 
            this.MaTG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaTG.HeaderText = "Mã tác giả";
            this.MaTG.MinimumWidth = 8;
            this.MaTG.Name = "MaTG";
            this.MaTG.ReadOnly = true;
            // 
            // TenTG
            // 
            this.TenTG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenTG.HeaderText = "Tên tác giả";
            this.TenTG.MinimumWidth = 8;
            this.TenTG.Name = "TenTG";
            this.TenTG.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(174, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quản lý tác giả";
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(109, 29);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 10;
            this.btn_Edit.Text = "Sửa";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(6, 66);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 9;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(6, 29);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 8;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_TenTG
            // 
            this.txt_TenTG.Location = new System.Drawing.Point(75, 66);
            this.txt_TenTG.Multiline = true;
            this.txt_TenTG.Name = "txt_TenTG";
            this.txt_TenTG.Size = new System.Drawing.Size(140, 21);
            this.txt_TenTG.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_MaTG);
            this.groupBox1.Controls.Add(this.txt_TenTG);
            this.groupBox1.Controls.Add(this.lbl_Ma);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 119);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tác giả";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Exit);
            this.groupBox2.Controls.Add(this.btn_Add);
            this.groupBox2.Controls.Add(this.btn_Edit);
            this.groupBox2.Controls.Add(this.btn_Delete);
            this.groupBox2.Location = new System.Drawing.Point(348, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 119);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(109, 66);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 11;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // QuanLyTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 496);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvTG);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyTacGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyTacGia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTG)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MaTG;
        private System.Windows.Forms.Label lbl_Ma;
        private System.Windows.Forms.DataGridView dgvTG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_TenTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTG;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Exit;
    }
}