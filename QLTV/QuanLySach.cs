using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DAL.Models;

namespace WindowsFormsApp2
{
    public partial class QuanLySach : Form
    {
        public QuanLySach()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnOutQLS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QuanLySach_Load(object sender, EventArgs e)
        {
            LoadAuthors();
            LoadPublishers();
            LoadDataGrid();
        }
        private void LoadDataGrid()
        {
            Model1 context = new Model1();
            var ListBook = context.Sach.ToList();
            BindGrid(ListBook);
        }
        private void BindGrid(List<Sach> ListBook)
        {
            dgvQLS.Rows.Clear();
            foreach (var item in ListBook)
            {
                int index = dgvQLS.Rows.Add();
                dgvQLS.Rows[index].Cells[0].Value = item.MaSach;
                dgvQLS.Rows[index].Cells[1].Value = item.TenSach;
                dgvQLS.Rows[index].Cells[2].Value = item.TheLoai;
                dgvQLS.Rows[index].Cells[3].Value = item.NamXB;
                dgvQLS.Rows[index].Cells[4].Value = item.GiaSach;
                dgvQLS.Rows[index].Cells[5].Value = item.SoLuong;
                dgvQLS.Rows[index].Cells[6].Value = item.NhaXuatBan.TenNXB;
                dgvQLS.Rows[index].Cells[7].Value = item.TacGia.TenTacGia;
            }
        }

        private void dgvQLS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvQLS.Rows[e.RowIndex];
                txtIdBook.Text = selectedRow.Cells[0].Value.ToString();
                txtNameBook.Text = selectedRow.Cells[1].Value.ToString();
                txtCategory.Text = selectedRow.Cells[2].Value.ToString();
                txtYearBook.Text = selectedRow.Cells[3].Value.ToString();
                txtPrice.Text = selectedRow.Cells[4].Value.ToString();
                txtQuantity.Text = selectedRow.Cells[5].Value.ToString();
                cbNXB.Text = selectedRow.Cells[6].Value.ToString(); 
                cbTacGia.Text = selectedRow.Cells[7].Value.ToString(); 
            }
        }


        private void LoadAuthors()
        {
            using (Model1 context = new Model1())
            {
                var authors = context.TacGia.ToList();
                cbTacGia.DataSource = authors;
                cbTacGia.DisplayMember = "TenTacGia";
                cbTacGia.ValueMember = "MaTacGia";
                cbTacGia.SelectedIndex = -1;
            }
        }

        private void LoadPublishers()
        {
            using (Model1 context = new Model1())
            {
                var publishers = context.NhaXuatBan.ToList();
                cbNXB.DataSource = publishers;
                cbNXB.DisplayMember = "TenNXB";
                cbNXB.ValueMember = "MaNXB";
                cbNXB.SelectedIndex = -1;
            }
        }
        private void txtSBookQLS_TextChanged(object sender, EventArgs e)
        {
            string bookTitle = txtSBookQLS.Text.Trim();
            using (Model1 context = new Model1())
            {
                if (string.IsNullOrWhiteSpace(bookTitle))
                {
                    LoadDataGrid();
                }
                else
                {
                    var booksByTitle = context.Sach
                        .Where(s => s.TenSach.Contains(bookTitle))
                        .ToList();

                    if (booksByTitle.Count > 0)
                    {
                        BindGrid(booksByTitle);
                    }
                    else
                    {
                        dgvQLS.Rows.Clear();
                        MessageBox.Show("Không tìm thấy sách có tên '" + bookTitle + "'.", "Thông báo");
                    }
                }
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string maSach = txtIdBook.Text;
            string tenSach = txtNameBook.Text;
            string theLoai = txtCategory.Text;
            int namXB;
            double giaSach;
            int soLuong;
            string maNXB = cbNXB.SelectedValue?.ToString(); 
            string maTacGia = cbTacGia.SelectedValue?.ToString(); 

            if (string.IsNullOrWhiteSpace(maSach) || string.IsNullOrWhiteSpace(tenSach) || string.IsNullOrWhiteSpace(theLoai) || string.IsNullOrWhiteSpace(maNXB) || string.IsNullOrWhiteSpace(maTacGia) || !int.TryParse(txtYearBook.Text, out namXB) || !double.TryParse(txtPrice.Text, out giaSach) || !int.TryParse(txtQuantity.Text, out soLuong))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin sách và nhập đúng định dạng dữ liệu.", "Lỗi");
                return; 
            }

            using (Model1 context = new Model1())
            {
                Sach newSach = new Sach
                {
                    MaSach = maSach,
                    TenSach = tenSach,
                    TheLoai = theLoai,
                    NamXB = namXB,
                    GiaSach = giaSach,
                    SoLuong = soLuong,
                    MaNXB = maNXB,
                    MaTacGia = maTacGia
                };

                Class1<Sach> sachDataAccess = new Class1<Sach>();
                sachDataAccess.Them(newSach);
            }
            LoadDataGrid();
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            string maSach = txtIdBook.Text;
            string tenSach = txtNameBook.Text;
            string theLoai = txtCategory.Text;
            int namXB;
            double giaSach;
            int soLuong;
            string maNXB = cbNXB.SelectedValue?.ToString(); 
            string maTacGia = cbTacGia.SelectedValue?.ToString(); 

            if (string.IsNullOrWhiteSpace(maSach) || string.IsNullOrWhiteSpace(tenSach) || string.IsNullOrWhiteSpace(theLoai) || string.IsNullOrWhiteSpace(maNXB) || string.IsNullOrWhiteSpace(maTacGia) || !int.TryParse(txtYearBook.Text, out namXB) || !double.TryParse(txtPrice.Text, out giaSach) || !int.TryParse(txtQuantity.Text, out soLuong))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin sách và nhập đúng định dạng dữ liệu.", "Lỗi");
                return; 
            }

            Sach sachToEdit = new Sach
            {
                MaSach = maSach,
                TenSach = tenSach,
                TheLoai = theLoai,
                NamXB = namXB,
                GiaSach = giaSach,
                SoLuong = soLuong,
                MaNXB = maNXB,
                MaTacGia = maTacGia
            };

            Class1<Sach> sachDataAccess = new Class1<Sach>();
            sachDataAccess.Sua(sachToEdit);
            LoadDataGrid();
        }



        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            string maSach = txtIdBook.Text.Trim(); 
            Class1<Sach> sachDataAccess = new Class1<Sach>();
            Sach sachToDelete = sachDataAccess.TimSachTheoMa(maSach);

            if (sachToDelete != null)
            {
                sachDataAccess.Xoa(sachToDelete);
                MessageBox.Show("Xóa thành công. ", "Thông báo");
                LoadDataGrid();
            }
            else
            {
                MessageBox.Show("Không tìm thấy sách có mã " + maSach + "để xóa.", "Thông báo");
            }
        }
    }
}
