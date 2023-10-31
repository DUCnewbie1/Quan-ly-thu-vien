using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class LapPhieuPhat : Form
    {
        private Class1<PhieuPhat> phieuPhatManager;
        public LapPhieuPhat()
        {
            InitializeComponent();
            CenterToScreen();
            phieuPhatManager = new Class1<PhieuPhat>();
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
                string noiDung = txtNoiDung.Text;
                double tienPhat = double.Parse(txt_TienPhat.Text.ToString());
                using (Model1 dbcontext = new Model1())
                {
                    bool maPMExists = dbcontext.PhieuMuon.Any(pm => pm.MaPM == maPhieuMuon);
                    if (!maPMExists)
                    {
                        MessageBox.Show("Mã phiếu trả không tồn tại trong bảng PhieuTra.");
                        return;
                    }
                    PhieuPhat phieuPhat = new PhieuPhat
                    {
                        MaPhat = maPhieu,
                        NgayPhat = ngayTra,
                        NoiDungPhat = noiDung,
                        PhiPhat = tienPhat
                    };

                    Class1<PhieuPhat> classPhieuPhat = new Class1<PhieuPhat>();
                    classPhieuPhat.Them(phieuPhat);
                    string insertQuery = "INSERT INTO ChiTietPhieuPhat (MaPhat, MaPM) VALUES (@MaPhat, (SELECT TOP 1 MaPM FROM PhieuMuon WHERE MaPM = @MaPM))";
                    dbcontext.Database.ExecuteSqlCommand(insertQuery, new SqlParameter("@MaPhat", maPhieu), new SqlParameter("@MaPM", maPhieuMuon));
                    MessageBox.Show("Thêm mới thành công");
                    dbcontext.SaveChanges();
                }

                txtMaPhieu.Text = string.Empty;
                cbDocGia.SelectedIndex = -1;
                cbMaPM.DataSource = null;
                cbNhanVien.SelectedIndex = -1;
                txtNoiDung.Text = string.Empty;
                txt_TienPhat.Text = string.Empty;

                LoadDataGrid();
            }
        }

        private void LapPhieuPhat_Load(object sender, EventArgs e)
        {
            FillComBoBox();
            FillComBoBoxStaff();
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
        private void LoadDataGrid()
        {
            Model1 context = new Model1();
            var ListPhieuPhat = context.PhieuPhat.ToList();
            BindGrid(ListPhieuPhat);
        }
        private void BindGrid(List<PhieuPhat> ListPhieuPhat)
        {
            dgvPhieuPhat.Rows.Clear();
            using (Model1 context = new Model1())
            {
                foreach (var item in ListPhieuPhat)
                {
                    int index = dgvPhieuPhat.Rows.Add();
                    dgvPhieuPhat.Rows[index].Cells[0].Value = item.MaPhat;
                    dgvPhieuPhat.Rows[index].Cells[1].Value = item.NgayPhat;
                    dgvPhieuPhat.Rows[index].Cells[2].Value = item.NoiDungPhat;
                    dgvPhieuPhat.Rows[index].Cells[3].Value = item.PhiPhat;
                    dgvPhieuPhat.Rows[index].Cells[4].Value = phieuPhatManager.LayTenDocGiaTuMaPhat(item.MaPhat);
                    dgvPhieuPhat.Rows[index].Cells[5].Value = phieuPhatManager.LayTenNhanVienTuMaPhat(item.MaPhat);
                    dgvPhieuPhat.Rows[index].Cells[6].Value = phieuPhatManager.LayMaPhieuMuonTuMaPhat(item.MaPhat);
                }
            }
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
                        var maPTs = phieuPhatManager.GetMaPTsForMaThe(maThe);
                        cbMaPM.DataSource = maPTs;
                        cbMaPM.SelectedIndex = -1;
                    }
                }
            }
        }

        private void dgvPhieuPhat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPhieuPhat.Rows[e.RowIndex];

                txtMaPhieu.Text = row.Cells[0].Value.ToString();
                dtpkNgayTra.Value = Convert.ToDateTime(row.Cells[1].Value);
                txtNoiDung.Text = row.Cells[2].Value.ToString();
                txt_TienPhat.Text = row.Cells[3].Value.ToString();
                string tenDocGia = row.Cells[4].Value.ToString();
                foreach (var item in cbDocGia.Items)
                {
                    if (item is DocGia docGia && docGia.TenDocGia == tenDocGia)
                    {
                        cbDocGia.SelectedItem = item;
                        break;
                    }
                }
                cbNhanVien.Text = row.Cells[5].Value.ToString();
                cbMaPM.Text = row.Cells[6].Value.ToString();
            }
        }
    }
}
