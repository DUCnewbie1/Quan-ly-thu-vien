namespace WindowsFormsApp2
{
    partial class timKiemDocGia
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
            this.dgvSReader = new System.Windows.Forms.DataGridView();
            this.rbFollowName = new System.Windows.Forms.RadioButton();
            this.rbFollowIDReader = new System.Windows.Forms.RadioButton();
            this.btnExitSReader = new System.Windows.Forms.Button();
            this.btnSReader = new System.Windows.Forms.Button();
            this.txtSReader = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSReader)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tìm Kiếm Đọc Giả";
            // 
            // dgvSReader
            // 
            this.dgvSReader.AllowUserToAddRows = false;
            this.dgvSReader.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSReader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSReader.Location = new System.Drawing.Point(8, 242);
            this.dgvSReader.Name = "dgvSReader";
            this.dgvSReader.RowHeadersWidth = 62;
            this.dgvSReader.RowTemplate.Height = 28;
            this.dgvSReader.Size = new System.Drawing.Size(921, 338);
            this.dgvSReader.TabIndex = 5;
            // 
            // rbFollowName
            // 
            this.rbFollowName.AutoSize = true;
            this.rbFollowName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFollowName.Location = new System.Drawing.Point(44, 82);
            this.rbFollowName.Name = "rbFollowName";
            this.rbFollowName.Size = new System.Drawing.Size(179, 24);
            this.rbFollowName.TabIndex = 4;
            this.rbFollowName.TabStop = true;
            this.rbFollowName.Text = "Theo Tên Đọc Giả";
            this.rbFollowName.UseVisualStyleBackColor = true;
            // 
            // rbFollowIDReader
            // 
            this.rbFollowIDReader.AutoSize = true;
            this.rbFollowIDReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFollowIDReader.Location = new System.Drawing.Point(42, 35);
            this.rbFollowIDReader.Name = "rbFollowIDReader";
            this.rbFollowIDReader.Size = new System.Drawing.Size(173, 24);
            this.rbFollowIDReader.TabIndex = 3;
            this.rbFollowIDReader.TabStop = true;
            this.rbFollowIDReader.Text = "Theo Mã Đọc Giả";
            this.rbFollowIDReader.UseVisualStyleBackColor = true;
            // 
            // btnExitSReader
            // 
            this.btnExitSReader.Location = new System.Drawing.Point(797, 56);
            this.btnExitSReader.Name = "btnExitSReader";
            this.btnExitSReader.Size = new System.Drawing.Size(75, 32);
            this.btnExitSReader.TabIndex = 2;
            this.btnExitSReader.Text = "Thoát";
            this.btnExitSReader.UseVisualStyleBackColor = true;
            this.btnExitSReader.Click += new System.EventHandler(this.btnExitSReader_Click);
            // 
            // btnSReader
            // 
            this.btnSReader.Location = new System.Drawing.Point(683, 56);
            this.btnSReader.Name = "btnSReader";
            this.btnSReader.Size = new System.Drawing.Size(75, 32);
            this.btnSReader.TabIndex = 1;
            this.btnSReader.Text = "Tìm";
            this.btnSReader.UseVisualStyleBackColor = true;
            this.btnSReader.Click += new System.EventHandler(this.btnSReader_Click);
            // 
            // txtSReader
            // 
            this.txtSReader.Location = new System.Drawing.Point(268, 59);
            this.txtSReader.Name = "txtSReader";
            this.txtSReader.Size = new System.Drawing.Size(368, 26);
            this.txtSReader.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbFollowName);
            this.panel1.Controls.Add(this.rbFollowIDReader);
            this.panel1.Controls.Add(this.btnExitSReader);
            this.panel1.Controls.Add(this.btnSReader);
            this.panel1.Controls.Add(this.txtSReader);
            this.panel1.Location = new System.Drawing.Point(8, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 132);
            this.panel1.TabIndex = 4;
            // 
            // timKiemDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(939, 591);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSReader);
            this.Controls.Add(this.panel1);
            this.Name = "timKiemDocGia";
            this.Text = "timKiemDocGia";
            this.Load += new System.EventHandler(this.timKiemDocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSReader)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSReader;
        private System.Windows.Forms.RadioButton rbFollowName;
        private System.Windows.Forms.RadioButton rbFollowIDReader;
        private System.Windows.Forms.Button btnExitSReader;
        private System.Windows.Forms.Button btnSReader;
        private System.Windows.Forms.TextBox txtSReader;
        private System.Windows.Forms.Panel panel1;
    }
}