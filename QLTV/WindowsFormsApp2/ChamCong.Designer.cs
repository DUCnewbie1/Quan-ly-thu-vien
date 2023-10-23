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
            this.btnThoatCc = new System.Windows.Forms.Button();
            this.dtpToday = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chấm công";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên tài khoản";
            // 
            // txtNameCc
            // 
            this.txtNameCc.Location = new System.Drawing.Point(79, 34);
            this.txtNameCc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNameCc.Name = "txtNameCc";
            this.txtNameCc.ReadOnly = true;
            this.txtNameCc.Size = new System.Drawing.Size(171, 20);
            this.txtNameCc.TabIndex = 2;
            // 
            // btnChamCong
            // 
            this.btnChamCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamCong.Location = new System.Drawing.Point(63, 123);
            this.btnChamCong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.Size = new System.Drawing.Size(84, 34);
            this.btnChamCong.TabIndex = 3;
            this.btnChamCong.Text = "Chấm công";
            this.btnChamCong.UseVisualStyleBackColor = true;
            this.btnChamCong.Click += new System.EventHandler(this.btnChamCong_Click);
            // 
            // cmbCa
            // 
            this.cmbCa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCa.FormattingEnabled = true;
            this.cmbCa.Items.AddRange(new object[] {
            "Sáng ",
            "Chiều"});
            this.cmbCa.Location = new System.Drawing.Point(80, 82);
            this.cmbCa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCa.Name = "cmbCa";
            this.cmbCa.Size = new System.Drawing.Size(170, 21);
            this.cmbCa.TabIndex = 4;
            this.cmbCa.DropDown += new System.EventHandler(this.cmbCa_DropDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chọn ca";
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
            this.dgvChamCong.Location = new System.Drawing.Point(271, 57);
            this.dgvChamCong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvChamCong.Name = "dgvChamCong";
            this.dgvChamCong.RowHeadersWidth = 62;
            this.dgvChamCong.RowTemplate.Height = 28;
            this.dgvChamCong.Size = new System.Drawing.Size(475, 227);
            this.dgvChamCong.TabIndex = 6;
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
            this.panel1.Controls.Add(this.btnThoatCc);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbCa);
            this.panel1.Controls.Add(this.btnChamCong);
            this.panel1.Controls.Add(this.txtNameCc);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(8, 57);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 227);
            this.panel1.TabIndex = 7;
            // 
            // btnThoatCc
            // 
            this.btnThoatCc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatCc.Location = new System.Drawing.Point(165, 123);
            this.btnThoatCc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoatCc.Name = "btnThoatCc";
            this.btnThoatCc.Size = new System.Drawing.Size(84, 34);
            this.btnThoatCc.TabIndex = 6;
            this.btnThoatCc.Text = "Thoát";
            this.btnThoatCc.UseVisualStyleBackColor = true;
            this.btnThoatCc.Click += new System.EventHandler(this.btnThoatCc_Click);
            // 
            // dtpToday
            // 
            this.dtpToday.Location = new System.Drawing.Point(141, 16);
            this.dtpToday.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpToday.Name = "dtpToday";
            this.dtpToday.Size = new System.Drawing.Size(259, 20);
            this.dtpToday.TabIndex = 7;
            // 
            // ChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 292);
            this.Controls.Add(this.dtpToday);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvChamCong);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ChamCong";
            this.Text = "ChamCong";
            this.Load += new System.EventHandler(this.ChamCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}