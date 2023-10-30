namespace WindowsFormsApp2
{
    partial class Excel
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
            this.btn_CreateExcel = new System.Windows.Forms.Button();
            this.btn_ChonFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Excel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Excel)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_CreateExcel
            // 
            this.btn_CreateExcel.Location = new System.Drawing.Point(131, 395);
            this.btn_CreateExcel.Name = "btn_CreateExcel";
            this.btn_CreateExcel.Size = new System.Drawing.Size(75, 23);
            this.btn_CreateExcel.TabIndex = 0;
            this.btn_CreateExcel.Text = "Tạo Excel";
            this.btn_CreateExcel.UseVisualStyleBackColor = true;
            this.btn_CreateExcel.Click += new System.EventHandler(this.btn_CreateExcel_Click);
            // 
            // btn_ChonFile
            // 
            this.btn_ChonFile.Location = new System.Drawing.Point(399, 395);
            this.btn_ChonFile.Name = "btn_ChonFile";
            this.btn_ChonFile.Size = new System.Drawing.Size(75, 23);
            this.btn_ChonFile.TabIndex = 1;
            this.btn_ChonFile.Text = "Chọn File";
            this.btn_ChonFile.UseVisualStyleBackColor = true;
            this.btn_ChonFile.Click += new System.EventHandler(this.btn_ChonFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(105, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thống kê phiếu mượn trong tháng ";
            // 
            // dgv_Excel
            // 
            this.dgv_Excel.AllowUserToAddRows = false;
            this.dgv_Excel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Excel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Excel.Location = new System.Drawing.Point(3, 56);
            this.dgv_Excel.Name = "dgv_Excel";
            this.dgv_Excel.Size = new System.Drawing.Size(647, 333);
            this.dgv_Excel.TabIndex = 4;
            // 
            // Excel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 422);
            this.Controls.Add(this.dgv_Excel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ChonFile);
            this.Controls.Add(this.btn_CreateExcel);
            this.Name = "Excel";
            this.Text = "Excel";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Excel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CreateExcel;
        private System.Windows.Forms.Button btn_ChonFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Excel;
    }
}