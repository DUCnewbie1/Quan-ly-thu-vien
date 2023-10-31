namespace WindowsFormsApp2
{
    partial class timKiemSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(timKiemSach));
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbFollowName = new System.Windows.Forms.RadioButton();
            this.rbFollowIDBook = new System.Windows.Forms.RadioButton();
            this.btnExitSBook = new System.Windows.Forms.Button();
            this.btnSBook = new System.Windows.Forms.Button();
            this.txtSBook = new System.Windows.Forms.TextBox();
            this.dgvSBook = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSBook)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbFollowName);
            this.panel1.Controls.Add(this.rbFollowIDBook);
            this.panel1.Controls.Add(this.btnExitSBook);
            this.panel1.Controls.Add(this.btnSBook);
            this.panel1.Controls.Add(this.txtSBook);
            this.panel1.Location = new System.Drawing.Point(5, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 86);
            this.panel1.TabIndex = 0;
            // 
            // rbFollowName
            // 
            this.rbFollowName.AutoSize = true;
            this.rbFollowName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFollowName.Location = new System.Drawing.Point(29, 53);
            this.rbFollowName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbFollowName.Name = "rbFollowName";
            this.rbFollowName.Size = new System.Drawing.Size(107, 17);
            this.rbFollowName.TabIndex = 4;
            this.rbFollowName.TabStop = true;
            this.rbFollowName.Text = "Theo tên sách";
            this.rbFollowName.UseVisualStyleBackColor = true;
            // 
            // rbFollowIDBook
            // 
            this.rbFollowIDBook.AutoSize = true;
            this.rbFollowIDBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFollowIDBook.Location = new System.Drawing.Point(28, 23);
            this.rbFollowIDBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbFollowIDBook.Name = "rbFollowIDBook";
            this.rbFollowIDBook.Size = new System.Drawing.Size(108, 17);
            this.rbFollowIDBook.TabIndex = 3;
            this.rbFollowIDBook.TabStop = true;
            this.rbFollowIDBook.Text = "Theo Mã Sách";
            this.rbFollowIDBook.UseVisualStyleBackColor = true;
            // 
            // btnExitSBook
            // 
            this.btnExitSBook.Location = new System.Drawing.Point(468, 38);
            this.btnExitSBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExitSBook.Name = "btnExitSBook";
            this.btnExitSBook.Size = new System.Drawing.Size(50, 21);
            this.btnExitSBook.TabIndex = 2;
            this.btnExitSBook.Text = "Thoát";
            this.btnExitSBook.UseVisualStyleBackColor = true;
            this.btnExitSBook.Click += new System.EventHandler(this.btnExitSBook_Click);
            // 
            // btnSBook
            // 
            this.btnSBook.Location = new System.Drawing.Point(404, 38);
            this.btnSBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSBook.Name = "btnSBook";
            this.btnSBook.Size = new System.Drawing.Size(50, 21);
            this.btnSBook.TabIndex = 1;
            this.btnSBook.Text = "Tìm";
            this.btnSBook.UseVisualStyleBackColor = true;
            // 
            // txtSBook
            // 
            this.txtSBook.Location = new System.Drawing.Point(137, 40);
            this.txtSBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSBook.Name = "txtSBook";
            this.txtSBook.Size = new System.Drawing.Size(247, 20);
            this.txtSBook.TabIndex = 0;
            // 
            // dgvSBook
            // 
            this.dgvSBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSBook.Location = new System.Drawing.Point(5, 150);
            this.dgvSBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvSBook.Name = "dgvSBook";
            this.dgvSBook.RowHeadersWidth = 62;
            this.dgvSBook.RowTemplate.Height = 28;
            this.dgvSBook.Size = new System.Drawing.Size(614, 220);
            this.dgvSBook.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tìm kiếm sách";
            // 
            // timKiemSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 369);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSBook);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "timKiemSach";
            this.Text = "timKiemSach";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbFollowName;
        private System.Windows.Forms.RadioButton rbFollowIDBook;
        private System.Windows.Forms.Button btnExitSBook;
        private System.Windows.Forms.Button btnSBook;
        private System.Windows.Forms.TextBox txtSBook;
        private System.Windows.Forms.DataGridView dgvSBook;
        private System.Windows.Forms.Label label1;
    }
}