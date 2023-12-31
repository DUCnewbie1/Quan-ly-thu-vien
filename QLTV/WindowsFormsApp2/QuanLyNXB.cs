﻿using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp2
{
    public partial class QuanLyNXB : Form
    {
        public QuanLyNXB()
        {
            InitializeComponent();
            CenterToScreen();
            LoadDataGrid();
        }
        private void LoadDataGrid()
        {
            Model1 context = new Model1();
            var NXBList = context.NhaXuatBan.ToList();
            BindGrid(NXBList);
        }
        private void BindGrid(List<NhaXuatBan> listNXB)
        {
            dgvNXB.Rows.Clear();
            foreach (var item in listNXB)
            {
                int index = dgvNXB.Rows.Add();
                dgvNXB.Rows[index].Cells[0].Value = item.MaNXB;
                dgvNXB.Rows[index].Cells[1].Value = item.TenNXB;
                dgvNXB.Rows[index].Cells[2].Value = item.DiaChi;
                dgvNXB.Rows[index].Cells[3].Value = item.Email;
                dgvNXB.Rows[index].Cells[4].Value = item.Sdt;
            }
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaNXB.Text) ||
                string.IsNullOrWhiteSpace(txt_TenNXB.Text) ||
                string.IsNullOrWhiteSpace(txt_DiaChi.Text) ||
                string.IsNullOrWhiteSpace(txt_Email.Text) ||
                string.IsNullOrWhiteSpace(txt_SDT.Text) 
                )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhà xuất bản.");
                return;
            }
            if (!DNKDR.EmailDung(txt_Email.Text))
            {
                MessageBox.Show("Cấu trúc Email không hợp lệ, mời nhập lại");
                return;
            }
            string maNXB = txt_MaNXB.Text.Trim();
            string tenNXB = txt_TenNXB.Text;
            string diaChi = txt_DiaChi.Text;
            string email = txt_Email.Text;
            string sdt = txt_SDT.Text;

            if (txt_SDT.Text.Length != 10)
            {
                MessageBox.Show($"Số điện thoại phải có đúng 10 số! (kí tự hiện tại: " +
                                $"{txt_SDT.Text.Length})");
                return;
            }
            using (Model1 context = new Model1())
            {
                var existingReader = context.NhaXuatBan.FirstOrDefault(dg => dg.MaNXB == maNXB);
                if (existingReader != null)
                {
                    MessageBox.Show("Mã nhà xuất bản đã tồn tại. Vui lòng nhập mã nhà xuất bản khác.", "Lỗi");
                    return;
                }

                NhaXuatBan nxb = new NhaXuatBan
                {
                    MaNXB = maNXB,
                    TenNXB = tenNXB,
                    DiaChi = diaChi,
                    Sdt = sdt,
                    Email = email
                };
                Class1<NhaXuatBan> nxbDataAccess = new Class1<NhaXuatBan>();
                nxbDataAccess.Them(nxb);
                MessageBox.Show("Thêm Thành công", "Thông báo");
                LoadDataGrid();
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaNXB.Text) ||
                string.IsNullOrWhiteSpace(txt_TenNXB.Text) ||
                string.IsNullOrWhiteSpace(txt_DiaChi.Text) ||
                string.IsNullOrWhiteSpace(txt_Email.Text) ||
                string.IsNullOrWhiteSpace(txt_SDT.Text)
                )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhà xuất bản.");
                return;
            }
            string maNXB = txt_MaNXB.Text;
            string tenNXB = txt_TenNXB.Text;
            string diaChi = txt_DiaChi.Text;
            string email = txt_Email.Text;
            string sdt = txt_SDT.Text;

            if (txt_SDT.Text.Length != 10)
            {
                MessageBox.Show($"Số điện thoại phải có đúng 10 số! (kí tự hiện tại: " +
                                $"{txt_SDT.Text.Length})");
                return;
            }
            if (!DNKDR.EmailDung(txt_Email.Text))
            {
                MessageBox.Show("Cấu trúc Email không hợp lệ, mời nhập lại");
                return;
            }
            using (Model1 context = new Model1())
            {

                NhaXuatBan nxb = new NhaXuatBan
                {
                    MaNXB = maNXB,
                    TenNXB = tenNXB,
                    DiaChi = diaChi,
                    Sdt = sdt,
                    Email = email
                };
                Class1<NhaXuatBan> nxbDataAccess = new Class1<NhaXuatBan>();
                nxbDataAccess.Sua(nxb);
                MessageBox.Show("Sửa Thành công", "Thông báo");
                LoadDataGrid();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string maNXB = txt_MaNXB.Text.Trim();
            Class1<NhaXuatBan> nxbDataAccess = new Class1<NhaXuatBan>();
            NhaXuatBan nxbBiXoa = nxbDataAccess.TimSachTheoMa(maNXB);

            if (nxbDataAccess.NXBCoSach(maNXB))
            {
                MessageBox.Show("Nhà xuất bản này đã có sách trong thư viện. Không thể xóa!");
                return;
            }
            if (nxbBiXoa != null)
            {
                var confirmResult = MessageBox.Show($"Nhà xuất bản {txt_MaNXB.Text} {txt_TenNXB.Text} sẽ bị xóa!",
                                                     "Xác nhận xóa!!",
                                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    nxbDataAccess.Xoa(nxbBiXoa);
                    MessageBox.Show("Xóa thành công. ", "Thông báo");
                    LoadDataGrid();
                }
                else
                {
                    MessageBox.Show("Không xóa được nhà xuất bản này.", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhà xuất bản có mã " + maNXB + "để xóa.", "Thông báo");
            }
        }
        private void dgvNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvNXB.Rows[e.RowIndex];

                string maNXB = selectedRow.Cells["MaNXB"].Value.ToString().Trim();
                string tenNXB = selectedRow.Cells["TenNXB"].Value.ToString().Trim();
                string diaChi = selectedRow.Cells["DiaChi"].Value.ToString().Trim();
                string email = selectedRow.Cells["Email"].Value.ToString().Trim();
                string sdt = selectedRow.Cells["SDT"].Value.ToString().Trim();
                txt_MaNXB.Text = maNXB;
                txt_TenNXB.Text = tenNXB;
                txt_DiaChi.Text = diaChi;
                txt_Email.Text = email;
                txt_SDT.Text = sdt;
            }
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
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
        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLySach formQuanLySach = new QuanLySach();
            formQuanLySach.ShowDialog();
        }

        private void quảnLýĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyDocGia formQuanLyDocGia = new QuanLyDocGia();
            formQuanLyDocGia.ShowDialog();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien formQuanLyNhanVien = new QuanLyNhanVien();
            formQuanLyNhanVien.ShowDialog();
        }
    }
}
