﻿using DAL;
using DAL.Models;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Đức code form này 
namespace WindowsFormsApp2
{
    public partial class QuanLyNhanVien : Form
    {
        public QuanLyNhanVien()
        {
            InitializeComponent();
            CenterToScreen();
            DangKy dangKyForm = new DangKy();
            dangKyForm.NhanVienDaThemThanhCong += DangKyForm_NhanVienDaThemThanhCong;
        }
        private void DangKyForm_NhanVienDaThemThanhCong(object sender, EventArgs e)
        {
            // Cập nhật DataGridView
            LoadDataGridNV();
        }
        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LoadDataGridNV();
        }

        private void btnExitNVf_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // đổ dữ liệu lên datagirview từ cơ sở dữ liệu bảng Nhân viên
        private void LoadDataGridNV()
        {
            List<NhanVienWithTaiKhoan> ListNV = GetNhanVienData();
            BindGridNV(ListNV);
            
        }
        public class NhanVienWithTaiKhoan
        {
            public string MaNV { get; set; }
            public string TenNV { get; set; }
            public string Sdt { get; set; }
            public string Email { get; set; }
            public string TenTK { get; set; }
            public string MatKhau { get; set; }
        }
        private List<NhanVienWithTaiKhoan> GetNhanVienData()
        {
            using (Model1 dbContext = new Model1())
            {
                var query = from nv in dbContext.NhanVien
                            join tk in dbContext.TaiKhoan on nv.MaNV equals tk.MaNV into nvtks
                            from nvtk in nvtks.DefaultIfEmpty()
                            select new NhanVienWithTaiKhoan
                            {
                                MaNV = nv.MaNV,
                                TenNV = nv.TenNV,
                                Sdt = nv.Sdt,
                                Email = nv.Email,
                                TenTK = (nvtk != null) ? nvtk.TenTK : string.Empty,
                                MatKhau = (nvtk != null) ? nvtk.MatKhau : string.Empty
                            };

                return query.ToList();
            }
        }
        private void BindGridNV(List<NhanVienWithTaiKhoan> ListNV)
        {
            dgvQLNV.Rows.Clear();
            foreach (var item in ListNV)
            {
                int index = dgvQLNV.Rows.Add();
                dgvQLNV.Rows[index].Cells[0].Value = item.MaNV;
                dgvQLNV.Rows[index].Cells[1].Value = item.TenNV;
                dgvQLNV.Rows[index].Cells[2].Value = item.Sdt;
                dgvQLNV.Rows[index].Cells[3].Value = item.Email;
                dgvQLNV.Rows[index].Cells[4].Value = item.TenTK;
                dgvQLNV.Rows[index].Cells[5].Value = item.MatKhau;
            }
        }

        private void dgvQLNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvQLNV.Rows[e.RowIndex];
                txtIdNV.Text = selectedRow.Cells[0].Value.ToString().Trim();
                txtNameNV.Text = selectedRow.Cells[1].Value.ToString().Trim();
                txtPhoneNV.Text = selectedRow.Cells[2].Value.ToString().Trim();
                txtEmailNV.Text = selectedRow.Cells[3].Value.ToString().Trim();
            }
        }

        // Sửa xóa nhân viên---------------------------------------------------------------------------------

        private void btnEditNV_Click(object sender, EventArgs e)
        {
            string manv = txtIdNV.Text;
            string tennv = txtNameNV.Text;
            string sdtnv = txtPhoneNV.Text;
            string emailnv = txtEmailNV.Text;


            if (string.IsNullOrWhiteSpace(manv) || string.IsNullOrWhiteSpace(tennv) || string.IsNullOrWhiteSpace(sdtnv) || string.IsNullOrWhiteSpace(emailnv))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin nhân viên và nhập đúng định dạng dữ liệu.", "Lỗi");
                return;
            }
            if (txtPhoneNV.Text.Length != 10)
            {
                MessageBox.Show($"Số điện thoại phải có đúng 10 số! (Kí tự hiện tại: " +
                                $"{txtPhoneNV.Text.Length})");
                return;
            }
            if (!DNKDR.EmailDung(txtEmailNV.Text))
            {
                MessageBox.Show("Cấu trúc Email không hợp lệ, mời nhập lại");
                return;
            }
            NhanVien NhanVienToEdit = new NhanVien
            {
                MaNV = manv,
                TenNV = tennv,
                Sdt = sdtnv,
                Email = emailnv,
            };
            MessageBox.Show("Thêm thành công. ", "Thông báo");
            Class1<NhanVien> NhanVienDataAccess = new Class1<NhanVien>();
            NhanVienDataAccess.Sua(NhanVienToEdit);
            LoadDataGridNV();
        }

        private void btnDeleteNV_Click(object sender, EventArgs e)
        {
            string manv = txtIdNV.Text.Trim();
            Class1<NhanVien> NhanVienDataAccess = new Class1<NhanVien>();
            NhanVien NhanVienToDelete = NhanVienDataAccess.TimSachTheoMa(manv);
            if (NhanVienToDelete != null)
            {
                var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Xác nhận xóa!!", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    // Xóa tài khoản của nhân viên trước (nếu có)
                    using (Model1 context = new Model1())
                    {
                        TaiKhoan taiKhoanToDelete = context.TaiKhoan.FirstOrDefault(tk => tk.MaNV == manv);
                        if (taiKhoanToDelete != null)
                        {
                            context.TaiKhoan.Remove(taiKhoanToDelete);
                        }
                        context.SaveChanges();
                    }

                    // Xóa nhân viên
                    NhanVienDataAccess.Xoa(NhanVienToDelete);

                    MessageBox.Show("Xóa thành công. ", "Thông báo");
                    LoadDataGridNV();
                }
                else
                {
                    MessageBox.Show("Nhân viên không được xóa.", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên có mã " + manv + " để xóa.", "Thông báo");
            }
        }



        private void txtNameNV_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtNameNV.Text, "[^A-Za-zÀ-ỹ ]"))
            {
                MessageBox.Show("Vui lòng chỉ nhập chữ cái.");
                txtNameNV.Text = "";
            }
        }

        private void txtPhoneNV_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPhoneNV.Text, "[^0-9]"))
            {
                MessageBox.Show("Chỉ được nhập số.");
                return;
            }
            else if (txtPhoneNV.Text.Length > 10)
            {
                MessageBox.Show("Số điện thoại gồm 10 số.");
                return;
            }
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            DangKy dk = new DangKy();
            dk.ShowDialog();
            LoadDataGridNV();
        }
    }
}
