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
                string maPhieuTra = cbMaPT.SelectedValue.ToString();
                string maNhanVien = cbNhanVien.SelectedValue.ToString();
                string noiDung = txtNoiDung.Text;
                double tienPhat = double.Parse(txt_TienPhat.Text.ToString());
                using (Model1 dbcontext = new Model1())
                {
                    bool maPTExists = dbcontext.PhieuTra.Any(pm => pm.MaPT == maPhieuTra);
                    if (!maPTExists)
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
                    string insertQuery = "INSERT INTO ChiTietPhieuPhat (MaPhat, MaPT) VALUES (@MaPhat, (SELECT TOP 1 MaPT FROM PhieuTra WHERE MaPT = @MaPT))";
                    dbcontext.Database.ExecuteSqlCommand(insertQuery, new SqlParameter("@MaPhat", maPhieu), new SqlParameter("@MaPT", maPhieuTra));
                    MessageBox.Show("Thêm mới thành công");
                    dbcontext.SaveChanges();
                }

                txtMaPhieu.Text = string.Empty;
                cbDocGia.SelectedIndex = -1;
                cbMaPT.DataSource = null;
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
                        cbMaPT.DataSource = maPTs;
                        cbMaPT.SelectedIndex = -1;
                    }
                }
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {

        }
    }
}
