using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics.Tracing;
using System.Configuration;
using BLL;

namespace WindowsFormsApp2
{
    public partial class DangNhap : Form
    {
        private int UserID;
        //Giới hạn kí tự khi điền thông tin đăng nhập
        KiemTraNhapChuoi TKTextBoxHandler;
        KiemTraNhapChuoi MKTextBoxHandler;
        public DangNhap()
        {
            InitializeComponent();
            // Khởi tạo các xử lý cho txt_TK và txt_MK
            TKTextBoxHandler = DNKDR.TKTextBoxHandler;
            MKTextBoxHandler = DNKDR.MKTextBoxHandler;
        }
        //Kiểm tra khi nhấn nút đăng nhập
        private void DN_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DNKDR.ConnectionString))
                {
                    conn.Open();
                    string tk = txt_TK.Text;
                    string mk = txt_MK.Text;

                    // Kiểm tra nếu người dùng chưa nhập tên đăng nhập hoặc mật khẩu
                    if (string.IsNullOrWhiteSpace(tk) || string.IsNullOrWhiteSpace(mk))
                    {
                        MessageBox.Show("Bạn chưa nhập tên đăng nhập hoặc mật khẩu.");
                        return;
                    }

                    string sql = @"SELECT id FROM TaiKhoan WHERE TenTK=@tk COLLATE SQL_Latin1_General_CP1_CS_AS 
                                   AND MatKhau=@mk COLLATE SQL_Latin1_General_CP1_CS_AS";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@tk", tk);
                        cmd.Parameters.AddWithValue("@mk", mk);
                        UserID = Convert.ToInt32(cmd.ExecuteScalar());
                        using (SqlDataReader data = cmd.ExecuteReader())
                        {
                            if (data.Read())
                            {
                                int userId = data.GetInt32(0); // Lấy user id từ cột "id" trong kết quả truy vấn
                                XuLy.GhiNhanTaiKhoan(tk);
                                //Home home = new Home(userId); // Truyền user id vào Form1
                                //  LÝ DO ĐỔI LẠI THÀNH HOME() VÌ CÁI HOME(USERID) KO CHẠY VÔ 
                                // Lý do đổi lại thành Home(userId) là vì chỉ có id của admin mới được đăng ký nhân viên :))
                                Home home = new Home(userId); // Truyền user id vào Form1
                                home.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
        // Kiểm tra xem người dùng có muốn thoát chương trình hay không
        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && DNKDR.ConfirmExit())
            {
                Application.ExitThread();
            }
            else
            {
                // Nếu người dùng chọn "No" hoặc không muốn thoát, hủy sự kiện đóng form để ngăn form đóng đi.
                e.Cancel = true;
            }
        }
        //Khi nhấn nút đăng ký
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Dang_Ky f = new Dang_Ky();
        //    f.Show();
        //    this.Hide();
        //}
        // Đặt con trỏ chuột vào ô nhập tên tài khoản
        private void DangNhap_Load(object sender, EventArgs e)
        {
            txt_TK.Select();
        }
        // Thực hiện đăng nhập khi ấn phím Enter trên ô nhập mật khẩu
        private void txt_MK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                DN_Click(sender, e);
            }
        }

        // kiểm tra nhập tên đăng nhập có quá kí tự quy định không
        private void txt_TK_TextChanged(object sender, EventArgs e)
        {
            if (DNKDR.TextThayDoi)
            {
                return;
            }
            DNKDR.TextThayDoi = true;
            DNKDR.TKVuotQuaDoDaiMax = TKTextBoxHandler.KiemTraNhap(txt_TK, txt_TK.Name); ;
            DNKDR.TextThayDoi = false;
        }
        // kiểm tra nhập mật khẩu có quá kí tự quy định không
        private void txt_MK_TextChanged(object sender, EventArgs e)
        {
            if (DNKDR.TextThayDoi)
            {
                return;
            }
            DNKDR.TextThayDoi = true;
            DNKDR.MKVuotQuaDoDaiMax = MKTextBoxHandler.KiemTraNhap(txt_MK, txt_MK.Name);
            DNKDR.TextThayDoi = false;
        }

        //  hiện mật khẩu 
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txt_MK.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void DangNhap_Load_1(object sender, EventArgs e)
        {

        }
        // quên mật khẩu 
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhau mk = new QuenMatKhau();
            mk.Show();
        }
    }
}
