using BLL;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
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
            CenterToScreen();
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
                    if (txt_HoTen.Text == ""|| txt_Email.Text == "" ||txt_SDT.Text == "" || txt_TenTK.Text == "" || txt_MK.Text == "" || txt_RepeatMK.Text == "")
                    {
                        MessageBox.Show("Mời nhập đầy đủ thông tin", "Thông báo");
                        return;
                    }
                    string hoTen = txt_HoTen.Text;   
                    string email = txt_Email.Text;
                    string sdt = txt_SDT.Text;
                    string tentk = txt_TenTK.Text;
                    string matkhau = txt_MK.Text;
                    string nhaplai = txt_RepeatMK.Text;
                    if (matkhau == nhaplai)
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            string newMaNV = GenerateNewMaNV();
                            NhanVien nv = new NhanVien
                            {
                                MaNV = newMaNV,
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
                                MaNV = newMaNV,
                            };
                            MessageBox.Show("Đăng ký tài khoản nhân viên thành công", "Thông báo");
                            txt_HoTen.Text = null;
                            txt_Email.Text = null;
                            txt_SDT.Text = null;
                            txt_TenTK.Text = null;
                            txt_MK.Text = null;
                            txt_RepeatMK.Text = null;
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
        private string GenerateNewMaNV()
        {
            using (Model1 context = new Model1())
            {
                var maxIndex = context.NhanVien
                    .Select(nv => nv.MaNV)
                    .Where(maNV => maNV.StartsWith("NV"))
                    .Select(maNV => maNV.Substring(2, 2))
                    .DefaultIfEmpty("00")
                    .Max();

                int nextIndex = (int.Parse(maxIndex) + 1);
                string newMaNV = "NV" + nextIndex.ToString("D2");
                return newMaNV;
            }
        }


        private void btn_HuyDK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
