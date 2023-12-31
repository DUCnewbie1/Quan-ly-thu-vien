﻿using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class LapPhieuTra : Form
    {
        private Class1<PhieuTra> phieuTraManager;
        public LapPhieuTra()
        {
            InitializeComponent();
            CenterToScreen();
            phieuTraManager = new Class1<PhieuTra>();
        }

        private void LapPhieuTra_Load(object sender, EventArgs e)
        {
            FillComBoBox();
            FillComBoBoxStaff();
            LoadDataGrid();
        }
        private void FillComBoBox()
        {
            cbDocGia.SelectedIndexChanged -= cbDocGia_SelectedIndexChanged;

            using (Model1 context = new Model1())
            {
                var reader = context.DocGia.ToList();
                cbDocGia.DataSource = reader;
                cbDocGia.DisplayMember = "MaDocGia";
                cbDocGia.ValueMember = "MaDocGia";
                cbDocGia.SelectedIndex = -1;
            }
            cbDocGia.SelectedIndexChanged += cbDocGia_SelectedIndexChanged;
        }

        private void FillComBoBoxStaff()
        {
            cbDocGia.SelectedIndexChanged -= cbDocGia_SelectedIndexChanged;

            using (Model1 context = new Model1())
            {
                var Staff = context.NhanVien.Where(nv => nv.DangLamViec == true).ToList();
                cbNhanVien.DataSource = Staff;
                cbNhanVien.DisplayMember = "TenNV";
                cbNhanVien.ValueMember = "MaNV";
                cbNhanVien.SelectedIndex = -1;
            }
            cbDocGia.SelectedIndexChanged += cbDocGia_SelectedIndexChanged;
        }

        private void cbDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDocGia.SelectedIndex >= 0)
            {
                string selectedMaDocGia = cbDocGia.SelectedValue.ToString();
                using (Model1 context = new Model1())
                {
                    var theDocGia = context.TheDocGia.FirstOrDefault(t => t.MaDocGia == selectedMaDocGia);

                    if (theDocGia != null)
                    {
                        string maThe = theDocGia.MaThe;
                        var maPMs = phieuTraManager.GetMaPTsForMaThe(maThe);
                        cbMaPM.DataSource = maPMs;
                        cbMaPM.Refresh();
                        cbMaPM.SelectedIndex = -1;
                    }
                }
            }
        }

        private void LoadDataGrid()
        {
            Model1 context = new Model1();
            var ListPhieuTra = context.PhieuTra.ToList();
            BindGrid(ListPhieuTra);
        }
        private void BindGrid(List<PhieuTra> ListPhieuTra)
        {
            dgvPhieuTra.Rows.Clear();
            using (Model1 context = new Model1())
            {
                foreach (var item in ListPhieuTra)
                {
                    int index = dgvPhieuTra.Rows.Add();
                    dgvPhieuTra.Rows[index].Cells[0].Value = item.MaPT;
                    dgvPhieuTra.Rows[index].Cells[1].Value = item.NgayTra;
                    dgvPhieuTra.Rows[index].Cells[2].Value = item.GhiChu;
                    dgvPhieuTra.Rows[index].Cells[3].Value = item.TinhTrangSach;
                    dgvPhieuTra.Rows[index].Cells[4].Value = phieuTraManager.LayTenDocGiaTuMaPT(item.MaPT);
                    dgvPhieuTra.Rows[index].Cells[5].Value = item.NhanVien.TenNV;

                    string query = "SELECT MaPM FROM ChiTietPhieuTra WHERE MaPT = @MaPT";
                    SqlParameter paramMaPT = new SqlParameter("@MaPT", item.MaPT);
                    var maPhieuMuon = context.Database.SqlQuery<string>(query, paramMaPT).FirstOrDefault();

                    if (maPhieuMuon != null)
                    {
                        dgvPhieuTra.Rows[index].Cells[6].Value = maPhieuMuon;
                    }
                }
            }
        }

        private void cbMaPM_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedMaPM = cbMaPM.SelectedValue;
            if (selectedMaPM != null)
            {
                string maPM = selectedMaPM.ToString();
                var bookNames = phieuTraManager.GetBookNamesForMaPM(maPM);
                checkedListBook.Items.Clear();
                foreach (var bookName in bookNames)
                {
                    checkedListBook.Items.Add(bookName);
                }
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhieu.Text) || cbDocGia.SelectedIndex == -1 || cbNhanVien.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            bool isAnyItemChecked = false;
            foreach (var item in checkedListBook.Items)
            {
                if (checkedListBook.GetItemChecked(checkedListBook.Items.IndexOf(item)))
                {
                    isAnyItemChecked = true;
                    break;
                }
            }

            if (!isAnyItemChecked)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một cuốn sách trong danh sách.");
                return;
            }
            using (Model1 context = new Model1())
            {
                string maPhieu = txtMaPhieu.Text;
                DateTime ngayTra = dtpkNgayTra.Value;
                string maDocGia = cbDocGia.SelectedValue.ToString();
                string maPhieuMuon = cbMaPM.SelectedValue.ToString();
                string maNhanVien = cbNhanVien.SelectedValue.ToString();
                string ghiChu = txtGhiChu.Text;
                string tinhTrang = cbTinhTrang.Text;
                using (Model1 dbcontext = new Model1())
                {
                    bool maPTExists = context.PhieuTra.Any(pt => pt.MaPT == maPhieu);
                    if (maPTExists)
                    {
                        MessageBox.Show("Mã phiếu trả đã tồn tại trong bảng PhieuTra. Vui lòng sử dụng mã phiếu trả khác.");
                        return;
                    }
                    bool maPMExists = dbcontext.PhieuMuon.Any(pm => pm.MaPM == maPhieuMuon);
                    if (!maPMExists)
                    {
                        MessageBox.Show("Mã phiếu mượn không tồn tại trong bảng PhieuMuon.");
                        return;
                    }
                    foreach (var item in checkedListBook.CheckedItems)
                    {
                        string tenSach = item.ToString();
                        string updateQuery = "UPDATE ChiTietPhieuMuon SET TrangThaiSach = 1 WHERE MaPM = @MaPM AND MaSach = (SELECT MaSach FROM Sach WHERE TenSach = @TenSach)";
                        dbcontext.Database.ExecuteSqlCommand(updateQuery, new SqlParameter("@MaPM", maPhieuMuon), new SqlParameter("@TenSach", tenSach));
                    }
                    PhieuTra phieuTra = new PhieuTra
                    {
                        MaPT = maPhieu,
                        NgayTra = ngayTra,
                        GhiChu = ghiChu,
                        TinhTrangSach = tinhTrang,
                        MaNV = maNhanVien
                    };

                    Class1<PhieuTra> classPhieuTra = new Class1<PhieuTra>();
                    classPhieuTra.Them(phieuTra);
                    string insertQuery = "INSERT INTO ChiTietPhieuTra (MaPT, MaPM) VALUES (@MaPT, (SELECT TOP 1 MaPM FROM PhieuMuon WHERE MaPM = @MaPM))";
                    dbcontext.Database.ExecuteSqlCommand(insertQuery, new SqlParameter("@MaPT", maPhieu), new SqlParameter("@MaPM", maPhieuMuon));
                    // Cập nhật thông tin sách đã trả
                    foreach (var item in checkedListBook.CheckedItems)
                    {
                        string tenSach = item.ToString();
                        var sach = dbcontext.Sach.FirstOrDefault(s => s.TenSach == tenSach);

                        if (sach != null)
                        {
                            sach.SoLuong += 1;
                        }
                    }
                    MessageBox.Show("Thêm mới thành công");
                    dbcontext.SaveChanges();
                }

                txtMaPhieu.Text = string.Empty;
                cbDocGia.SelectedIndex = -1;
                cbMaPM.DataSource = null;
                cbNhanVien.SelectedIndex = -1;
                txtGhiChu.Text = string.Empty;
                cbTinhTrang.SelectedIndex = -1;
                checkedListBook.Items.Clear();

                LoadDataGrid();
            }
        }

        private List<PhieuTra> GetPhieuTraList(Model1 context)
        {
            return context.PhieuTra.ToList();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtTimKiem.Text.Trim().ToLower();

            using (Model1 context = new Model1())
            {
                List<PhieuTra> ListPhieuTra = GetPhieuTraList(context);
                List<PhieuTra> filteredList = ListPhieuTra.Where(pt =>
                    pt.MaPT.ToLower().Contains(searchText) ||
                    pt.NgayTra.ToString().ToLower().Contains(searchText) ||
                    pt.GhiChu.ToLower().Contains(searchText) ||
                    pt.TinhTrangSach.ToString().ToLower().Contains(searchText) ||
                    phieuTraManager.LayTenDocGiaTuMaPT(pt.MaPT).ToLower().Contains(searchText) ||
                    pt.NhanVien.TenNV.ToLower().Contains(searchText)
                ).ToList();
                BindGrid(filteredList);
            }
        }
        private void dgvPhieuTra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPhieuTra.Rows[e.RowIndex];
                string maPT = row.Cells[0].Value.ToString().Trim();
                string maPhieuMuon = row.Cells[6].Value.ToString().Trim();
                txtMaPhieur.Text = maPT;
                dtpkNgayTrar.Value = (DateTime)row.Cells[1].Value;
                txtGhiChur.Text = row.Cells[2].Value.ToString().Trim();
                txtTinhTrangr.Text = row.Cells[3].Value.ToString().Trim();
                string tenDocGia = row.Cells[4].Value.ToString().Trim();
                string tenNhanVien = row.Cells[5].Value.ToString().Trim();
                string maDocGia = phieuTraManager.GetMaDocGiaTuTenDocGia(tenDocGia).Trim();
                txtDocGiar.Text = maDocGia;
                txtNhanVienr.Text = tenNhanVien;
                string maPM = phieuTraManager.GetMaPMTuMaPT(maPT).Trim();
                txtMaPMr.Text = maPhieuMuon;
                var selectedMaPM = txtMaPMr.Text;
                if (selectedMaPM != null)
                {
                    string maPMr = selectedMaPM.ToString();
                    var bookNames = phieuTraManager.GetReturnedBookNamesForMaPM(maPMr);
                    lb_Bookr.Items.Clear();
                    foreach (var bookName in bookNames)
                    {
                        lb_Bookr.Items.Add(bookName);
                    }
                }
            }
        }
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
