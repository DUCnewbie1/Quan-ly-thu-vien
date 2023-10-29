namespace WindowsFormsApp2
{
    partial class QuenMatKhau
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
            this.Llbl_QuenEmail = new System.Windows.Forms.LinkLabel();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_XacNhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // Llbl_QuenEmail
            // 
            this.Llbl_QuenEmail.AutoSize = true;
            this.Llbl_QuenEmail.Location = new System.Drawing.Point(81, 90);
            this.Llbl_QuenEmail.Name = "Llbl_QuenEmail";
            this.Llbl_QuenEmail.Size = new System.Drawing.Size(67, 13);
            this.Llbl_QuenEmail.TabIndex = 1;
            this.Llbl_QuenEmail.TabStop = true;
            this.Llbl_QuenEmail.Text = "Quên Email?";
            this.Llbl_QuenEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Llbl_QuenEmail_LinkClicked);
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(84, 67);
            this.txt_Email.Multiline = true;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(182, 20);
            this.txt_Email.TabIndex = 2;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_Title.Location = new System.Drawing.Point(78, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(201, 32);
            this.lbl_Title.TabIndex = 3;
            this.lbl_Title.Text = "Mời nhập email";
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(191, 106);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(75, 23);
            this.btn_Huy.TabIndex = 4;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.Location = new System.Drawing.Point(84, 106);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(75, 23);
            this.btn_XacNhan.TabIndex = 5;
            this.btn_XacNhan.Text = "Xác nhận";
            this.btn_XacNhan.UseVisualStyleBackColor = true;
            this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
            // 
            // QuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 158);
            this.Controls.Add(this.btn_XacNhan);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.Llbl_QuenEmail);
            this.Controls.Add(this.label1);
            this.Name = "QuenMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuenMatKhau";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuenMatKhau_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel Llbl_QuenEmail;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_XacNhan;
    }
}