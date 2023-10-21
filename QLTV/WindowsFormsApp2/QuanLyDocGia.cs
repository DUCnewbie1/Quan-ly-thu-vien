using DAL;
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

namespace WindowsFormsApp2
{
    public partial class QuanLyDocGia : Form
    {
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

            }
        }

        private void dgvQLDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow sr = dgvQLDG.Rows[e.RowIndex];
                txtMaDG.Text = sr.Cells[0].Value.ToString().Trim();
                txtTenDG.Text = sr.Cells[1].Value.ToString().Trim();
                txtDiaChi.Text = sr.Cells[2].Value.ToString().Trim();
                txtSDT.Text = sr.Cells[3].Value.ToString().Trim();
                txtEmail.Text = sr.Cells[4].Value.ToString().Trim();
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

            if (txtSDT.Text.Length != 10)
            {
                MessageBox.Show($"Số điện thoại phải có đúng 10 số! (kí tự hiện tại: " +
                                $"{txtSDT.Text.Length})");
                txtSDT.Text = "";
                return;
            }

            using (Model1 context = new Model1())
            {
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

                Class1<DocGia> DocGiaDataAccess = new Class1<DocGia>();
                DocGiaDataAccess.Them(newReaders);
                MessageBox.Show("Thêm Thành công", "Thông báo");

            }
            LoadDataGrid();
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
            Class1<DocGia> DocGiaDataAccess = new Class1<DocGia>();
            DocGia docGIaToDelete = DocGiaDataAccess.TimSachTheoMa(maDG);

            if (docGIaToDelete != null)
            {
                var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa đọc giả này không?",
                                                     "Xác nhận xóa!!",
                                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    DocGiaDataAccess.Xoa(docGIaToDelete);
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
                MessageBox.Show("Không tìm thấy sách có mã " + maDG + "để xóa.", "Thông báo");
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
    }
}
