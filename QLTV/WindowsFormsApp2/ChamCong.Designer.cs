namespace WindowsFormsApp2
{
    partial class ChamCong
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameCc = new System.Windows.Forms.TextBox();
            this.btnChamCong = new System.Windows.Forms.Button();
            this.cmbCa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvChamCong = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTKe = new System.Windows.Forms.Button();
            this.btnThoatCc = new System.Windows.Forms.Button();
            this.dtpToday = new System.Windows.Forms.DateTimePicker();
            this.dgvTke = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTke)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(535, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chấm công";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(9, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên tài khoản";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNameCc
            // 
            this.txtNameCc.Location = new System.Drawing.Point(132, 58);
            this.txtNameCc.Name = "txtNameCc";
            this.txtNameCc.ReadOnly = true;
            this.txtNameCc.Size = new System.Drawing.Size(282, 21);
            this.txtNameCc.TabIndex = 2;
            // 
            // btnChamCong
            // 
            this.btnChamCong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(116)))), ((int)(((byte)(190)))));
            this.btnChamCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamCong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChamCong.Location = new System.Drawing.Point(106, 208);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.Size = new System.Drawing.Size(140, 57);
            this.btnChamCong.TabIndex = 3;
            this.btnChamCong.Text = "Chấm công";
            this.btnChamCong.UseVisualStyleBackColor = false;
            this.btnChamCong.Click += new System.EventHandler(this.btnChamCong_Click);
            // 
            // cmbCa
            // 
            this.cmbCa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCa.FormattingEnabled = true;
            this.cmbCa.Items.AddRange(new object[] {
            "Sáng ",
            "Chiều"});
            this.cmbCa.Location = new System.Drawing.Point(133, 139);
            this.cmbCa.Name = "cmbCa";
            this.cmbCa.Size = new System.Drawing.Size(281, 23);
            this.cmbCa.TabIndex = 4;
            this.cmbCa.DropDown += new System.EventHandler(this.cmbCa_DropDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(9, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chọn ca";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dgvChamCong
            // 
            this.dgvChamCong.AllowUserToAddRows = false;
            this.dgvChamCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChamCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvChamCong.Location = new System.Drawing.Point(452, 97);
            this.dgvChamCong.Name = "dgvChamCong";
            this.dgvChamCong.RowHeadersWidth = 62;
            this.dgvChamCong.RowTemplate.Height = 28;
            this.dgvChamCong.Size = new System.Drawing.Size(873, 84);
            this.dgvChamCong.TabIndex = 6;
            this.dgvChamCong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChamCong_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên NV";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ca làm";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Từ";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTKe);
            this.panel1.Controls.Add(this.btnThoatCc);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbCa);
            this.panel1.Controls.Add(this.btnChamCong);
            this.panel1.Controls.Add(this.txtNameCc);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(13, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 385);
            this.panel1.TabIndex = 7;
            // 
            // btnTKe
            // 
            this.btnTKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(116)))), ((int)(((byte)(190)))));
            this.btnTKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTKe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTKe.Location = new System.Drawing.Point(106, 292);
            this.btnTKe.Name = "btnTKe";
            this.btnTKe.Size = new System.Drawing.Size(140, 57);
            this.btnTKe.TabIndex = 7;
            this.btnTKe.Text = "Thống kê";
            this.btnTKe.UseVisualStyleBackColor = false;
            this.btnTKe.Click += new System.EventHandler(this.btnTKe_Click);
            // 
            // btnThoatCc
            // 
            this.btnThoatCc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(116)))), ((int)(((byte)(190)))));
            this.btnThoatCc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatCc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoatCc.Location = new System.Drawing.Point(274, 208);
            this.btnThoatCc.Name = "btnThoatCc";
            this.btnThoatCc.Size = new System.Drawing.Size(140, 57);
            this.btnThoatCc.TabIndex = 6;
            this.btnThoatCc.Text = "Thoát";
            this.btnThoatCc.UseVisualStyleBackColor = false;
            this.btnThoatCc.Click += new System.EventHandler(this.btnThoatCc_Click);
            // 
            // dtpToday
            // 
            this.dtpToday.Location = new System.Drawing.Point(896, 44);
            this.dtpToday.Name = "dtpToday";
            this.dtpToday.Size = new System.Drawing.Size(430, 21);
            this.dtpToday.TabIndex = 7;
            // 
            // dgvTke
            // 
            this.dgvTke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTke.Location = new System.Drawing.Point(453, 235);
            this.dgvTke.Name = "dgvTke";
            this.dgvTke.RowHeadersWidth = 62;
            this.dgvTke.RowTemplate.Height = 28;
            this.dgvTke.Size = new System.Drawing.Size(872, 224);
            this.dgvTke.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(462, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Đã châm công hôm nay";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1339, 495);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvTke);
            this.Controls.Add(this.dtpToday);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvChamCong);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "ChamCong";
            this.Text = "ChamCong";
            this.Load += new System.EventHandler(this.ChamCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameCc;
        private System.Windows.Forms.Button btnChamCong;
        private System.Windows.Forms.ComboBox cmbCa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvChamCong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThoatCc;
        private System.Windows.Forms.DateTimePicker dtpToday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnTKe;
        private System.Windows.Forms.DataGridView dgvTke;
        private System.Windows.Forms.Label label4;
    }
}