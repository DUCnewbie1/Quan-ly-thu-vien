using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class LapPhieuMuon : Form
    {
        public LapPhieuMuon()
        {
            InitializeComponent();
        }

        private void LapPhieuMuon_Load(object sender, EventArgs e)
        {
            FillComBoBox();
            FillComBoBoxStaff();
            FillListBoxWithBooks();
            LoadDataGrid();
        }
        private void FillComBoBox()
        {
            using (Model1 context = new Model1())
            {
                var reader = context.DocGia.ToList();
                cbDocGia.DataSource = reader;
                cbDocGia.DisplayMember = "MaDocGia";
                cbDocGia.ValueMember = "MaDocGia";
                cbDocGia.SelectedIndex = -1;
            }
        }
        private void FillComBoBoxStaff()
        {
            using (Model1 context = new Model1())
            {
                var Staff = context.NhanVien.ToList();
                cbNhanVien.DataSource = Staff;
                cbNhanVien.DisplayMember = "TenNV";
                cbNhanVien.ValueMember = "MaNV";
                cbNhanVien.SelectedIndex = -1;
            }
        }
        private void FillListBoxWithBooks()
        {
            using (Model1 context = new Model1())
            {
                var books = context.Sach.ToList();
                checkedListBook.DataSource = books;
                checkedListBook.DisplayMember = "TenSach";
            }
        }
        private void LoadDataGrid()
        {
            Model1 context = new Model1();
            var ListPhieuMuon = context.PhieuMuon.ToList();
            BindGrid(ListPhieuMuon);
        }
        private void BindGrid(List<PhieuMuon> ListPhieuMuon)
        {
            dgvPhieuMuon.Rows.Clear();
            foreach (var item in ListPhieuMuon)
            {
                int index = dgvPhieuMuon.Rows.Add();
                dgvPhieuMuon.Rows[index].Cells[0].Value = item.MaPM;
                dgvPhieuMuon.Rows[index].Cells[1].Value = item.NgayLap;
                dgvPhieuMuon.Rows[index].Cells[2].Value = item.NgayTra;
                dgvPhieuMuon.Rows[index].Cells[3].Value = item.GhiChu;
                dgvPhieuMuon.Rows[index].Cells[4].Value = item.SoLuong;
                dgvPhieuMuon.Rows[index].Cells[5].Value = item.TheDocGia;
                dgvPhieuMuon.Rows[index].Cells[6].Value = item.NhanVien.TenNV;
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                string maPhieu = txtMaPhieu.Text;
                DateTime ngayLap = dtpkNgayLap.Value;
                DateTime ngayTra = dtpkNgayTra.Value;
                string ghiChu = txtGhiChu.Text;
                string maDocGia = cbDocGia.SelectedValue.ToString();
                string maNhanVien = cbNhanVien.SelectedValue.ToString();
                List<Sach> danhSachSachDaChon = new List<Sach>();
                foreach (var selectedBook in checkedListBook.CheckedItems)
                {
                    Sach sach = (Sach)selectedBook;
                    danhSachSachDaChon.Add(sach);
                }

                string maTheDocGia = string.Empty;
                using (Model1 context = new Model1())
                {
                    bool maPhieuDaTonTai = context.PhieuMuon.Any(pm => pm.MaPM == maPhieu);

                    if (maPhieuDaTonTai)
                    {
                        MessageBox.Show("Mã phiếu đã tồn tại trong cơ sở dữ liệu.");
                    }
                    else
                    {

                        maTheDocGia = context.TheDocGia
                            .Where(dg => dg.MaDocGia == maDocGia)
                            .Select(dg => dg.MaThe)
                            .FirstOrDefault();

                        PhieuMuon phieuMuon = new PhieuMuon
                        {
                            MaPM = maPhieu,
                            NgayLap = ngayLap,
                            NgayTra = ngayTra,
                            GhiChu = ghiChu,
                            MaThe = maTheDocGia,
                            MaNV = maNhanVien,
                            SoLuong = danhSachSachDaChon.Count
                        };
                        Class1<PhieuMuon> classPhieuMuon = new Class1<PhieuMuon>();
                        classPhieuMuon.Them(phieuMuon);
                        using (Model1 dbcontext = new Model1())
                        {
                            foreach (Sach selectedBook in danhSachSachDaChon)
                            {
                                string insertQuery = "INSERT INTO ChiTietPhieuMuon (MaPM, MaSach) VALUES (@MaPM, @MaSach)";
                                dbcontext.Database.ExecuteSqlCommand(insertQuery,
                                    new SqlParameter("MaPM", maPhieu),
                                    new SqlParameter("MaSach", selectedBook.MaSach)
                                );
                            }
                        }
                        // Giảm số lượng sách trong cơ sở dữ liệu
                        foreach (Sach selectedBook in danhSachSachDaChon)
                        {
                            Sach sachInDB = context.Sach.FirstOrDefault(s => s.MaSach == selectedBook.MaSach);
                            if (sachInDB != null)
                            {
                                sachInDB.SoLuong--;
                                context.Entry(sachInDB).State = EntityState.Modified;
                            }
                        }
                        context.SaveChanges();
                        LoadDataGrid();
                    }
                }
           
            }
            catch (DbEntityValidationException ex)
            {
                MessageBox.Show("Để mượn sách cần có thẻ đọc giả. Đọc giả này không có thẻ!");
                return;
            }
        }
        private void txtMaPhieu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtMaPhieu.Text.Length >= 10 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Mã phiếu không được quá 10 ký tự.");
            }
        }

        private void dgvPhieuMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPhieuMuon.Rows[e.RowIndex];
                txtMaPhieu.Text = row.Cells[0].Value.ToString();
                dtpkNgayLap.Value = Convert.ToDateTime(row.Cells[1].Value);
                dtpkNgayTra.Value = Convert.ToDateTime(row.Cells[2].Value);
                txtGhiChu.Text = row.Cells[3].Value.ToString();
                string tenDocGia = row.Cells[5].Value.ToString();
                foreach (var item in cbDocGia.Items)
                {
                    if (item is DocGia docGia && docGia.TenDocGia == tenDocGia)
                    {
                        cbDocGia.SelectedItem = item;
                        break;
                    }
                }
                cbNhanVien.Text = row.Cells[6].Value.ToString();
                string maPhieu = row.Cells[0].Value.ToString();
                using (Model1 context = new Model1())
                {
                    List<Sach> tatCaSach = context.Sach.ToList();

                    checkedListBook.DataSource = tatCaSach;
                    checkedListBook.DisplayMember = "TenSach";
                    for (int i = 0; i < checkedListBook.Items.Count; i++)
                    {
                        checkedListBook.SetItemChecked(i, false);
                    }

                    var chiTietPhieuMuonQuery = @"
                    SELECT Sach.*
                    FROM Sach
                    INNER JOIN ChiTietPhieuMuon ON Sach.MaSach = ChiTietPhieuMuon.MaSach
                    WHERE ChiTietPhieuMuon.MaPM = @MaPM";
                    List<Sach> chiTietPhieuMuon = context.Database.SqlQuery<Sach>(chiTietPhieuMuonQuery,
                        new SqlParameter("MaPM", maPhieu)).ToList();

                    foreach (var sach in chiTietPhieuMuon)
                    {
                        int index = tatCaSach.FindIndex(s => s.MaSach == sach.MaSach);
                        if (index != -1)
                        {
                            checkedListBook.SetItemChecked(index, true);
                        }
                    }
                }
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            string maPhieu = txtMaPhieu.Text;
            DateTime ngayLap = dtpkNgayLap.Value;
            DateTime ngayTra = dtpkNgayTra.Value;
            string ghiChu = txtGhiChu.Text;
            string maDocGia = cbDocGia.SelectedValue.ToString();
            string maNhanVien = cbNhanVien.SelectedValue.ToString();
            List<Sach> danhSachSachDaChon = new List<Sach>();

            using (Model1 context = new Model1())
            {
                var docGia = context.DocGia.FirstOrDefault(dg => dg.MaDocGia == maDocGia);

                if (docGia != null)
                {
                    string maTheDocGia = context.TheDocGia
                        .Where(tdg => tdg.MaDocGia == maDocGia)
                        .Select(tdg => tdg.MaThe)
                        .FirstOrDefault();

                    using (var dbContextTransaction = context.Database.BeginTransaction())
                    {
                        try
                        {
                            var phieuMuon = context.PhieuMuon.SingleOrDefault(pm => pm.MaPM == maPhieu);

                            if (phieuMuon == null)
                            {
                                MessageBox.Show("Không tìm thấy phiếu mượn có mã phiếu: " + maPhieu);
                                return;
                            }

                            // Lấy danh sách sách hiện tại trong chi tiết phiếu mượn
                            var sachHienTaiQuery = @"
                            SELECT Sach.*
                            FROM Sach
                            INNER JOIN ChiTietPhieuMuon ON Sach.MaSach = ChiTietPhieuMuon.MaSach
                            WHERE ChiTietPhieuMuon.MaPM = @MaPM";
                            List<Sach> sachHienTai = context.Database.SqlQuery<Sach>(sachHienTaiQuery,
                                new SqlParameter("MaPM", maPhieu)).ToList();

                            // Tăng SoLuong của sách hiện tại
                            foreach (var sach in sachHienTai)
                            {
                                var sachToUpdate = context.Sach.SingleOrDefault(s => s.MaSach == sach.MaSach);
                                if (sachToUpdate != null)
                                {
                                    sachToUpdate.SoLuong++;
                                }
                            }

                            string deleteQuery = "DELETE FROM ChiTietPhieuMuon WHERE MaPM = @MaPM";
                            context.Database.ExecuteSqlCommand(deleteQuery, new SqlParameter("MaPM", maPhieu));

                            foreach (var selectedBook in checkedListBook.CheckedItems)
                            {
                                Sach sach = (Sach)selectedBook;
                                danhSachSachDaChon.Add(sach);
                                string insertQuery = "INSERT INTO ChiTietPhieuMuon (MaPM, MaSach) VALUES (@MaPM, @MaSach)";
                                context.Database.ExecuteSqlCommand(insertQuery,
                                    new SqlParameter("MaPM", maPhieu),
                                    new SqlParameter("MaSach", sach.MaSach)
                                );

                                // Giảm SoLuong của sách mới
                                var sachToUpdate = context.Sach.SingleOrDefault(s => s.MaSach == sach.MaSach);
                                if (sachToUpdate != null)
                                {
                                    sachToUpdate.SoLuong--;
                                }
                            }

                            int soLuongSachMuon = danhSachSachDaChon.Count;

                            phieuMuon.NgayLap = ngayLap;
                            phieuMuon.NgayTra = ngayTra;
                            phieuMuon.GhiChu = ghiChu;
                            phieuMuon.MaThe = maTheDocGia;
                            phieuMuon.MaNV = maNhanVien;
                            phieuMuon.SoLuong = soLuongSachMuon;

                            context.SaveChanges();

                            dbContextTransaction.Commit();

                            MessageBox.Show("Cập nhật thông tin phiếu mượn thành công.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi: " + ex.Message);
                            dbContextTransaction.Rollback();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Giá trị MaDocGia không tồn tại trong bảng DocGia.");
                }
            }
            LoadDataGrid();
        }

        private List<PhieuMuon> GetPhieuMuonList(Model1 context)
        {
            return context.PhieuMuon.ToList();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtTimKiem.Text.Trim().ToLower();

            using (Model1 context = new Model1())
            {
                List<PhieuMuon> ListPhieuMuon = GetPhieuMuonList(context);
                List<PhieuMuon> filteredList = ListPhieuMuon.Where(pm =>
                    pm.MaPM.ToLower().Contains(searchText) ||
                    pm.NgayLap.ToString().ToLower().Contains(searchText) ||
                    pm.NgayTra.ToString().ToLower().Contains(searchText) ||
                    pm.GhiChu.ToLower().Contains(searchText) ||
                    pm.SoLuong.ToString().ToLower().Contains(searchText) ||
                    //Tam thoi bo, sua gap !!!!!!!!
                    //pm.TheDocGia.MaDocGia.TenDocGia.ToLower().Contains(searchText) ||
                    pm.NhanVien.TenNV.ToLower().Contains(searchText)
                ).ToList();
                BindGrid(filteredList);
            }
        }

    }
}