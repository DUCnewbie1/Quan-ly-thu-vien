using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using DAL.Models;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp2
{
    public partial class QuenMatKhau : Form
    {
        KiemTraNhapChuoi EmailTextBoxHandler;
        public QuenMatKhau()
        {
            InitializeComponent();
            CenterToScreen();
            EmailTextBoxHandler = DNKDR.EmailTextBoxHandler;
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            string Email = txt_Email.Text;
            if (string.IsNullOrEmpty(Email))
            {
                MessageBox.Show("Vui lòng điền Email.");
                return;
            }
            if (!DNKDR.EmailDung(Email))
            {
                MessageBox.Show("Cấu trúc Email không hợp lệ, mời nhập lại");
                return;
            }
            TaiKhoan tk = new TaiKhoan();
            // Thực hiện lưu thông tin vào cơ sở dữ liệu
            try
            {
                using (SqlConnection conn = new SqlConnection(DNKDR.ConnectionString))
                {
                    conn.Open();

                    // Kiểm tra xem Email có tồn tại không
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = $"SELECT COUNT(*) FROM NhanVien WHERE Email = @Email";
                        cmd.Parameters.AddWithValue("@Email", Email);
                        int EmailCount = Convert.ToInt32(cmd.ExecuteScalar());
                        if (EmailCount == 0)
                        {
                            MessageBox.Show("Email này không tồn tại. Vui lòng nhập lại.");
                            return;
                        }
                    }
                    string getIdQuery = $"SELECT MaNV FROM NhanVien WHERE Email = @Email";
                    string idValue;
                    
                    using (SqlCommand cmd = new SqlCommand(getIdQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", Email);
                        idValue = cmd.ExecuteScalar().ToString();
                    }

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = $"SELECT TenTK, MatKhau " +
                                          $"FROM TaiKhoan " +
                                          $"WHERE MaNV = @Id";
                        cmd.Parameters.AddWithValue("@Id", idValue);

                        using (SqlDataReader data = cmd.ExecuteReader())
                        {
                            if (data.Read())
                            {
                                string tentk = data["TenTK"].ToString();
                                string matkhau = data["MatKhau"].ToString();
                                string EmailNhap = txt_Email.Text;

                                GuiEmail(tentk, matkhau, EmailNhap);
                            }
                        }
                    }

                    this.Hide();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình xác nhận Email: " + ex.Message);
            }
        }
        private void GuiEmail(string tentk, string matkhau, string emailnhap)
        {
            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();

            // Cập nhật với thông tin tài khoản Gmail mới
            smtp.UseDefaultCredentials = false;
            message.From = new MailAddress("thongbaoquanlythuvien@gmail.com");
            smtp.Credentials = new NetworkCredential("thongbaoquanlythuvien@gmail.com", "htil dyle rglf mehl");

            message.To.Add(new MailAddress(emailnhap));
            message.Subject = "Xác nhận thông tin tài khoản";
            message.Body = $"Tên tài khoản của bạn là: {tentk}\nMật khẩu của bạn là: {matkhau}";

            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

            try
            {
                smtp.Send(message);
                MessageBox.Show("Email gửi thành công, hãy kiểm tra Email để lấy thông tin tài khoản!.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi trong quá trình gửi Email: " + ex.Message);
            }
        }
        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void QuenMatKhau_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void Llbl_QuenEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo { FileName = "https://accounts.google.com/signin/v2/usernamerecovery?flowName=GlifWebSignIn&flowEntry=ServiceLogin", UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không thể mở link: " + ex.Message);
            }
        }
    }
}
