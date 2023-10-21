using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
                var reader = context.TheDocGia.ToList();
                cbDocGia.DataSource = reader;
                // cbDocGia.DisplayMember = "MaTacGia";
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
                listBook.DataSource = books;
                listBook.DisplayMember = "TenSach";
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
                dgvPhieuMuon.Rows[index].Cells[5].Value = item.TheDocGia.DocGia.TenDocGia;
                dgvPhieuMuon.Rows[index].Cells[6].Value = item.NhanVien.TenNV;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maPhieu = txtMaPhieu.Text;
            DateTime ngayLap = dtpkNgayLap.Value;
            DateTime ngayTra = dtpkNgayTra.Value;
            string ghiChu = txtGhiChu.Text;
            string maDocGia = cbDocGia.SelectedValue.ToString();
            string maNhanVien = cbNhanVien.SelectedValue.ToString();
            List<Sach> danhSachSachDaChon = new List<Sach>();
            foreach (var selectedBook in listBook.SelectedItems)
            {
                Sach sach = (Sach)selectedBook;
                danhSachSachDaChon.Add(sach);
            }

            string maTheDocGia = string.Empty;
            using (var context = new Model1())
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

                    var chiTietPhieuMuon = context.PhieuMuon.FirstOrDefault(pm => pm.MaPM == txtMaPhieu.Text);
                    List<string> selectedBooks = new List<string>();
                    for (int i = 0; i < listBook.Items.Count; i++)
                    {
                        if (listBook.GetSelected(i))
                        {
                            selectedBooks.Add(listBook.Items[i].ToString());
                        }
                    }
                    foreach (var tenSach in selectedBooks)
                    {
                        var sach = context.Sach.FirstOrDefault(s => s.TenSach == tenSach);
                        if (sach != null)
                        {
                            chiTietPhieuMuon.Sach.Add(sach);
                        }
                    }
                    context.SaveChanges();
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
                    context.SaveChanges();
                    LoadDataGrid();
                }
            }
        }
    }
}

