using DAL;
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
        public LapPhieuTra()
        {
            InitializeComponent();
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
                var Staff = context.NhanVien.ToList();
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
                        var phieuMuons = context.PhieuMuon.Where(p => p.MaThe == maThe).ToList();
                        cbMaPM.DataSource = phieuMuons;
                        cbMaPM.DisplayMember = "MaPM";
                        cbMaPM.ValueMember = "MaPM";
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
            foreach (var item in ListPhieuTra)
            {
                int index = dgvPhieuTra.Rows.Add();
                dgvPhieuTra.Rows[index].Cells[0].Value = item.MaPT;
                dgvPhieuTra.Rows[index].Cells[1].Value = item.NgayTra;
                dgvPhieuTra.Rows[index].Cells[2].Value = item.GhiChu;
                dgvPhieuTra.Rows[index].Cells[3].Value = item.TinhTrangSach;
                dgvPhieuTra.Rows[index].Cells[4].Value = LayTenDocGiaTuMaPT(item.MaPT);
                dgvPhieuTra.Rows[index].Cells[5].Value = item.NhanVien.TenNV;
            }
        }

        private string LayTenDocGiaTuMaPT(string maPT)
        {
            using (Model1 context = new Model1())
            {
                string query = "SELECT DG.TenDocGia FROM DocGia DG " +
                               "INNER JOIN TheDocGia TDG ON DG.MaDocGia = TDG.MaDocGia " +
                               "INNER JOIN PhieuMuon PM ON TDG.MaThe = PM.MaThe " +
                               "INNER JOIN ChiTietPhieuTra CPT ON PM.MaPM = CPT.MaPM " +
                               "WHERE CPT.MaPT = @MaPT";

                string tenDocGia = context.Database.SqlQuery<string>(query, new SqlParameter("MaPT", maPT)).FirstOrDefault();
                return tenDocGia;
            }
        }


        private void cbMaPM_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedMaPM = cbMaPM.SelectedValue;
            if (selectedMaPM != null)
            {
                string maPM = selectedMaPM.ToString();
                using (Model1 context = new Model1())
                {
                    string sqlQuery = "SELECT S.TenSach FROM Sach S " +
                                      "INNER JOIN ChiTietPhieuMuon CT ON S.MaSach = CT.MaSach " +
                                      "WHERE CT.MaPM = @MaPM";
                    var bookNames = context.Database.SqlQuery<string>(sqlQuery, new SqlParameter("MaPM", maPM));
                    checkedListBook.Items.Clear();
                    foreach (var bookName in bookNames)
                    {
                        checkedListBook.Items.Add(bookName);
                    }
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
                    bool maPMExists = dbcontext.PhieuMuon.Any(pm => pm.MaPM == maPhieuMuon);
                    if (!maPMExists)
                    {
                        MessageBox.Show("Mã phiếu mượn không tồn tại trong bảng PhieuMuon.");
                        return;
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
                    MessageBox.Show("Thêm mới thành công");
                    dbcontext.SaveChanges();
                }

                txtMaPhieu.Text = string.Empty;
                cbDocGia.SelectedIndex = -1;
                cbMaPM.DataSource = null;
                cbNhanVien.SelectedIndex = -1;
                txtGhiChu.Text = string.Empty;
                cbTinhTrang.SelectedIndex = -1;

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
                    LayTenDocGiaTuMaPT(pt.MaPT).ToLower().Contains(searchText) ||
                    pt.NhanVien.TenNV.ToLower().Contains(searchText)
                ).ToList();
                BindGrid(filteredList);
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {

        }
    }
}
