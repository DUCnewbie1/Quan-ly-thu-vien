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
            this.SuspendLayout();
            // 
            // btn_CreateExcel
            // 
            this.btn_CreateExcel.Location = new System.Drawing.Point(12, 12);
            this.btn_CreateExcel.Name = "btn_CreateExcel";
            this.btn_CreateExcel.Size = new System.Drawing.Size(75, 23);
            this.btn_CreateExcel.TabIndex = 0;
            this.btn_CreateExcel.Text = "Tạo Excel";
            this.btn_CreateExcel.UseVisualStyleBackColor = true;
            this.btn_CreateExcel.Click += new System.EventHandler(this.btn_CreateExcel_Click);
            // 
            // Excel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_CreateExcel);
            this.Name = "Excel";
            this.Text = "Excel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CreateExcel;
    }
}