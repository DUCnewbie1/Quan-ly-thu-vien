using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.SqlServer;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp2
{
    public partial class QuanLyDocGia : Form
    {
        private Class1<DocGia> docGiaManager;
        public QuanLyDocGia()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnExitDG_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QuanLyDocGia_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            Model1 context = new Model1();
            var ListReaders = context.DocGia.ToList();
            BindGrid(ListReaders);
        }
        private void BindGrid(List<DocGia> ListReaders)
        {
            dgvQLDG.Rows.Clear();
            foreach (var item in ListReaders)
            {
                int index = dgvQLDG.Rows.Add();
                dgvQLDG.Rows[index].Cells[0].Value = item.MaDocGia;
                dgvQLDG.Rows[index].Cells[1].Value = item.TenDocGia;
                dgvQLDG.Rows[index].Cells[2].Value = item.DiaChi;
                dgvQLDG.Rows[index].Cells[3].Value = item.Sdt;
                dgvQLDG.Rows[index].Cells[4].Value = item.Email;
                dgvQLDG.Rows[index].Cells[5].Value = docGiaManager.LayNgayLapTuMaDG(item.MaDocGia);
            }
        }

        private void dgvQLDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow sr = dgvQLDG.Rows[e.RowIndex];
                txtMaDG.Text = sr.Cells[0].Value.ToString().Trim();
                txtTenDG.Text = sr.Cells[1].Value.ToString().Trim();
                txtDiaChi.Text = sr.Cells[2].Value.ToString().Trim();
                txtSDT.Text = sr.Cells[3].Value.ToString().Trim();
                txtEmail.Text = sr.Cells[4].Value.ToString().Trim();
                //dtpkNgayLap.Value = DateTime.Parse(sr.Cells[5].Value.ToString().Trim());
            }
        }

        private void btnAddDG_Click(object sender, EventArgs e)
        {
            string maDG = txtMaDG.Text;
            string tenDG = txtTenDG.Text;
            string diaChi = txtDiaChi.Text;
            string sDT = txtSDT.Text;
            string email = txtEmail.Text;

            if (string.IsNullOrWhiteSpace(maDG) || string.IsNullOrWhiteSpace(tenDG) || string.IsNullOrWhiteSpace(diaChi) || string.IsNullOrWhiteSpace(sDT) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin đọc giả và nhập đúng định dạng dữ liệu.", "Lỗi");
                return;
            }

            if (sDT.Length != 10)
            {
                MessageBox.Show("Số điện thoại gồm 10 số");
                txtSDT.Text = ""; // Xóa nội dung textbox
                return;
            }
            if (!DNKDR.EmailDung(txtEmail.Text))
            {
                MessageBox.Show("Cấu trúc Email không hợp lệ, mời nhập lại");
                return;
            }
            using (Model1 context = new Model1())
            {
                string newMaThe = GenerateNewMaThe();
                DateTime ngayLap = dtpkNgayLap.Value;
                DateTime ngayHetHan = ngayLap.AddYears(2);
                var existingReader = context.DocGia.FirstOrDefault(dg => dg.MaDocGia == maDG);
                if (existingReader != null)
                {
                    MessageBox.Show("Đọc giả đã tồn tại. Vui lòng nhập mã đọc giả khác.", "Lỗi");
                    return;
                }

                DocGia newReaders = new DocGia
                {
                    MaDocGia = maDG,
                    TenDocGia = tenDG,
                    DiaChi = diaChi,
                    Sdt = sDT,
                    Email = email
                };

                TheDocGia newCard = new TheDocGia
                {
                    MaThe = newMaThe,
                    NgayLapThe = ngayLap,
                    NgayHetHan = ngayHetHan,
                    MaDocGia = maDG
                };

                context.DocGia.Add(newReaders);
                context.TheDocGia.Add(newCard);
                context.SaveChanges();
                MessageBox.Show("Thêm Thành công", "Thông báo");
            }
            LoadDataGrid();
        }

        private string GenerateNewMaThe()
        {
            using (Model1 context = new Model1())
            {
                var maxIndex = context.TheDocGia
                    .Select(the => the.MaThe)
                    .Where(maThe => maThe.StartsWith("T"))
                    .Select(maThe => maThe.Substring(1, 2))
                    .DefaultIfEmpty("00")
                    .Max();

                int nextIndex = (int.Parse(maxIndex) + 1);
                string newMaThe = "T" + nextIndex.ToString("D2").PadLeft(2, '0');
                return newMaThe;
            }
        }


        private void btnEditDG_Click(object sender, EventArgs e)
        {
            string maDG = txtMaDG.Text;
            string tenDG = txtTenDG.Text;
            string diaChi = txtDiaChi.Text;
            string sDT = txtSDT.Text;
            string email = txtEmail.Text;

            if (string.IsNullOrWhiteSpace(maDG) || string.IsNullOrWhiteSpace(tenDG) || string.IsNullOrWhiteSpace(diaChi) || string.IsNullOrWhiteSpace(sDT) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin đọc giả và nhập đúng định dạng dữ liệu.", "Lỗi");
                return;
            }

            if (txtSDT.Text.Length != 10)
            {
                MessageBox.Show($"Số điện thoại phải có đúng 10 số! (kí tự hiện tại: " +
                                $"{txtSDT.Text.Length})");
                txtSDT.Text = "";
                return;
            }
            if (!DNKDR.EmailDung(txtEmail.Text))
            {
                MessageBox.Show("Cấu trúc Email không hợp lệ, mời nhập lại");
                return;
            }
            using (Model1 context = new Model1())
            {

                DocGia newReaders = new DocGia
                {
                    MaDocGia = maDG,
                    TenDocGia = tenDG,
                    DiaChi = diaChi,
                    Sdt = sDT,
                    Email = email
                };
                Class1<DocGia> DocGiaDataAccess = new Class1<DocGia>();
                DocGiaDataAccess.Sua(newReaders);
                MessageBox.Show("Sửa Thành công", "Thông báo");
                LoadDataGrid();
            }
        }

        private void btnDeleteDG_Click(object sender, EventArgs e)
        {
            string maDG = txtMaDG.Text.Trim();
            Class1<DAL.Models.DocGia> DocGiaDataAccess = new Class1<DAL.Models.DocGia>();
            Class1<DAL.Models.TheDocGia> TheDocGiaDataAccess = new Class1<DAL.Models.TheDocGia>();

            DAL.Models.DocGia docGiaToDelete = DocGiaDataAccess.TimSachTheoMa(maDG);

            if (docGiaToDelete != null)
            {
                DAL.Models.TheDocGia theDocGiaToDelete = TheDocGiaDataAccess.TimSachTheoMa(maDG);

                var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa đọc giả này không?",
                                                     "Xác nhận xóa!!",
                                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    using (var context = new Model1())
                    {
                        string deleteTheDocGiaQuery = @"DELETE FROM TheDocGia WHERE MaDocGia = @MaDG";

                        context.Database.ExecuteSqlCommand(deleteTheDocGiaQuery, new SqlParameter("@MaDG", maDG));

                        DocGiaDataAccess.Xoa(docGiaToDelete);
                    }
                    MessageBox.Show("Xóa thành công. ", "Thông báo");
                    LoadDataGrid();
                }
                else
                {
                    MessageBox.Show("Đọc giả không được xóa.", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy đọc giả có mã " + maDG + " để xóa.", "Thông báo");
            }
        }


        private void txtTenDG_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtTenDG.Text, "[^A-Za-zÀ-ỹ ]"))
            {
                MessageBox.Show("Vui lòng chỉ nhập chữ cái.");
                txtTenDG.Text = "";
            }
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtSDT.Text, "[^0-9]"))
            {
                MessageBox.Show("Chỉ được nhập số.");
                txtSDT.Text = "";
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string timKiem = txtTimKiem.Text.Trim().ToUpper();
            Model1 context = new Model1();
            var danhSachDocGia = context.DocGia
                .Where(dg => dg.MaDocGia.ToUpper().Contains(timKiem))
                .ToList();
            BindGrid(danhSachDocGia);
        }
    }
}
