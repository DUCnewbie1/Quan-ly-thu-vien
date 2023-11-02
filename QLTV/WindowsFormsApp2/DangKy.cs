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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp2
{
    public partial class DangKy : Form
    {
        public event EventHandler NhanVienDaThemThanhCong;
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
                using (Model1 context = new Model1())
                {
                    if (txt_HoTen.Text == ""|| txt_Email.Text == "" ||txt_SDT.Text == "" || txt_TenTK.Text == "" || txt_MK.Text == "" || txt_RepeatMK.Text == "")
                    {
                        MessageBox.Show("Mời nhập đầy đủ thông tin", "Thông báo");
                        return;
                    }
                    if(!DNKDR.EmailDung(txt_Email.Text))
                    {
                        MessageBox.Show("Cấu trúc Email không hợp lệ, mời nhập lại");
                        return;
                    }
                    if (txt_SDT.Text.Length != 10)
                    {
                        MessageBox.Show($"Số điện thoại phải có đúng 10 số! (kí tự hiện tại: " +
                                        $"{txt_SDT.Text.Length})");
                        return;
                    }
                    string hoTen = txt_HoTen.Text;   
                    string email = txt_Email.Text;
                    string sdt = txt_SDT.Text;
                    string tentk = txt_TenTK.Text;
                    string matkhau = txt_MK.Text;
                    string nhaplai = txt_RepeatMK.Text;
                    //Lấy tên tài khoản phân biệt hoa thường
                    string sql = @"SELECT TenTK FROM TaiKhoan WHERE TenTK = @tk COLLATE SQL_Latin1_General_CP1_CS_AS";
                    var trungTenTK = context.Database.SqlQuery<string>(sql, new SqlParameter("tk", tentk)).ToList();
                    if (trungTenTK.Count > 0)
                    {
                        MessageBox.Show("Tên tài khoản đã tồn tại. Vui lòng chọn một tên tài khoản khác.", "Lỗi");
                        return;
                    }
                    if (matkhau == nhaplai)
                    {
                            string newMaNV = GenerateNewMaNV();
                            NhanVien nv = new NhanVien
                            {
                                MaNV = newMaNV,
                                TenNV = hoTen,
                                Sdt = sdt,
                                Email = email,
                                DangLamViec = true,
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
                            NhanVienDaThemThanhCong?.Invoke(this, EventArgs.Empty);
                            txt_HoTen.Text = null;
                            txt_Email.Text = null;
                            txt_SDT.Text = null;
                            txt_TenTK.Text = null;
                            txt_MK.Text = null;
                            txt_RepeatMK.Text = null;
                            Class1<TaiKhoan> classTK = new Class1<TaiKhoan>();

                            classTK.Them(tk);
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


        private void txt_HoTen_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txt_HoTen.Text, "[^A-Za-zÀ-ỹ ]"))
            {
                MessageBox.Show("Vui lòng chỉ nhập chữ cái.");
                if (txt_HoTen.Text.Length > 0)
                {
                    txt_HoTen.Text = txt_HoTen.Text.Substring(0, txt_HoTen.Text.Length - 1);
                    txt_HoTen.SelectionStart = txt_HoTen.Text.Length;
                }
            }
        }

        private void txt_SDT_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txt_SDT.Text, "[^0-9]"))
            {
                MessageBox.Show("Chỉ được nhập số.");
                if (txt_SDT.Text.Length > 0)
                {
                    txt_SDT.Text = txt_SDT.Text.Substring(0, txt_SDT.Text.Length - 1);
                    txt_SDT.SelectionStart = txt_SDT.Text.Length;
                }
            }
        }
    }
}
