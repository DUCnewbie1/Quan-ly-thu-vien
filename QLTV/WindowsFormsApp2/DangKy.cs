using BLL;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp2
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }
        //Tạo mật khẩu ngẫu nhiên
        private void btn_CreatePassword_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int save = r.Next(100000, 999999);
            txt_MK.Text = Convert.ToString(save);
            txt_RepeatMK.Text = Convert.ToString(save);
        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }

        private void btn_DK_Click(object sender, EventArgs e)
        {
                try
                {
                    using (SqlConnection conn = new SqlConnection(DNKDR.ConnectionString))
                    {
                    if (txt_HoTen.Text == "" || txt_DiaChi.Text == "" || txt_Email.Text == "" ||
                        txt_SDT.Text == "" || txt_TenTK.Text == "" || txt_MK.Text == "" || txt_RepeatMK.Text == "")
                    {
                        MessageBox.Show("Mời nhập đầy đủ thông tin", "Thông báo");
                        return;
                    }
                    string hoTen = txt_HoTen.Text;
                        string diaChi = txt_DiaChi.Text;
                        string email = txt_Email.Text;
                        string sdt = txt_SDT.Text;
                        string tentk = txt_TenTK.Text;
                        string matkhau = txt_MK.Text;
                        string nhaplai = txt_RepeatMK.Text;
                        if (matkhau == nhaplai)
                        {
                            using (SqlCommand cmd = new SqlCommand())
                            {
                                NhanVien nv = new NhanVien
                                {
                                    TenNV = hoTen,
                                    Sdt = sdt,
                                    Email = email,
                                };
                                Class1<NhanVien> classNV = new Class1<NhanVien>();
                                classNV.Them(nv);
                                TaiKhoan tk = new TaiKhoan
                                {
                                    TenTK = tentk,
                                    MatKhau = matkhau,
                                    LoaiTK = "NhanVien",
                                };
                                Class1<TaiKhoan> classTK = new Class1<TaiKhoan>();
                                classTK.Them(tk);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu nhập lại không trùng với mật khẩu. Vui lòng kiểm tra lại ", "Thông báo");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi trong quá trình đăng ký: " + ex.Message);
                }
        }

        private void btn_HuyDK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
