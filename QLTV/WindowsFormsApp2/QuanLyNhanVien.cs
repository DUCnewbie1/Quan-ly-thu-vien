using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Đức code form này 
namespace WindowsFormsApp2
{
    public partial class QuanLyNhanVien : Form
    {
        public QuanLyNhanVien()
        {
            InitializeComponent();
            CenterToScreen();
        }
        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LoadDataGridNV();
        }

        private void btnExitNVf_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // đổ dữ liệu lên datagirview từ cơ sở dữ liệu bảng Nhân viên
        private void LoadDataGridNV()
        {
            Model1 context = new Model1();
            var ListNV = context.NhanVien.ToList();
            BindGridNV(ListNV);
        }
        private void BindGridNV(List<NhanVien> ListNV)
        {
            dgvQLNV.Rows.Clear();
            foreach (var item in ListNV)
            {
                int index = dgvQLNV.Rows.Add();
                dgvQLNV.Rows[index].Cells[0].Value = item.MaNV;
                dgvQLNV.Rows[index].Cells[1].Value = item.TenNV;
                dgvQLNV.Rows[index].Cells[2].Value = item.Sdt;
                dgvQLNV.Rows[index].Cells[3].Value = item.Email;
               
            }
        }

        private void dgvQLNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvQLNV.Rows[e.RowIndex];
                txtIdNV.Text = selectedRow.Cells[0].Value.ToString().Trim();
                txtNameNV.Text = selectedRow.Cells[1].Value.ToString().Trim();
                txtPhoneNV.Text = selectedRow.Cells[2].Value.ToString().Trim();
                txtEmailNV.Text = selectedRow.Cells[3].Value.ToString().Trim();
            }
        }

        // thêm sửa xóa nhân viên---------------------------------------------------------------------------------

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
           
        }
        // Thêm nhân viên
        private void btnAddNV_Click(object sender, EventArgs e)
        {
            string manv = txtIdNV.Text;
            string tennv = txtNameNV.Text;
            string sdtnv = txtPhoneNV.Text;
            string emailnv = txtEmailNV.Text;

            if (string.IsNullOrWhiteSpace(manv) || string.IsNullOrWhiteSpace(tennv)
                || string.IsNullOrWhiteSpace(sdtnv) || string.IsNullOrWhiteSpace(emailnv))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin nhân viên và nhập đúng định dạng dữ liệu.", "Lỗi");
                return;
            }

            if (txtPhoneNV.Text.Length != 10)
            {
                MessageBox.Show($"Số điện thoại phải có đúng 10 số! (Kí tự hiện tại: " +
                                $"{txtPhoneNV.Text.Length})");
                txtPhoneNV.Text = "";
                return;
            }

            using (Model1 context = new Model1())
            {
                // Tạo một List<NhanVien>
                List<NhanVien> listNhanVien = context.NhanVien.ToList();

                // Kiểm tra xem MaNV đã tồn tại trong listNhanVien hay chưa
                var existingReader = context.NhanVien.FirstOrDefault(nv => nv.MaNV == manv);
                if (existingReader != null)
                {
                    MessageBox.Show("Nhân viên đã tồn tại. Vui lòng nhập mã nhân viên khác.", "Lỗi");
                    return;
                }

                NhanVien newNhanVien = new NhanVien
                {
                    MaNV = manv,
                    TenNV = tennv,
                    Sdt = sdtnv,
                    Email = emailnv,
                };

                Class1<NhanVien> NhanVienDataAccess = new Class1<NhanVien>();
                NhanVienDataAccess.Them(newNhanVien);
            }
            LoadDataGridNV();
        }

        private void btnEditNV_Click(object sender, EventArgs e)
        {
            string manv = txtIdNV.Text;
            string tennv = txtNameNV.Text;
            string sdtnv = txtPhoneNV.Text;
            string emailnv = txtEmailNV.Text;


            if (string.IsNullOrWhiteSpace(manv) || string.IsNullOrWhiteSpace(tennv) || string.IsNullOrWhiteSpace(sdtnv) || string.IsNullOrWhiteSpace(emailnv))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin nhân viên và nhập đúng định dạng dữ liệu.", "Lỗi");
                return;
            }
            if (txtPhoneNV.Text.Length != 10)
            {
                MessageBox.Show($"Số điện thoại phải có đúng 10 số! (Kí tự hiện tại: " +
                                $"{txtPhoneNV.Text.Length})");
                txtPhoneNV.Text = "";
                return;
            }
            NhanVien NhanVienToEdit = new NhanVien
            {
                MaNV = manv,
                TenNV = tennv,
                Sdt = sdtnv,
                Email = emailnv,
            };

            Class1<NhanVien> NhanVienDataAccess = new Class1<NhanVien>();
            NhanVienDataAccess.Sua(NhanVienToEdit);
            LoadDataGridNV();
        }

        private void btnDeleteNV_Click(object sender, EventArgs e)
        {
            string manv = txtIdNV.Text.Trim();
            Class1<NhanVien> NhanVienDataAccess = new Class1<NhanVien>();
            NhanVien NhanVienToDelete = NhanVienDataAccess.TimSachTheoMa(manv);

            if (NhanVienToDelete != null)
            {
                var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?",
                                                     "Xác nhận xóa!!",
                                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    NhanVienDataAccess.Xoa(NhanVienToDelete);
                    MessageBox.Show("Xóa thành công. ", "Thông báo");
                    LoadDataGridNV();
                }
                else
                {
                    MessageBox.Show("Nhân viên không được xóa.", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên có mã " + manv + "để xóa.", "Thông báo");
            }
        }


        private void txtNameNV_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtNameNV.Text, "[^A-Za-zÀ-ỹ ]"))
            {
                MessageBox.Show("Vui lòng chỉ nhập chữ cái.");
                txtNameNV.Text = "";
            }
        }

        private void txtPhoneNV_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPhoneNV.Text, "[^0-9]"))
            {
                MessageBox.Show("Chỉ được nhập số.");
                txtPhoneNV.Text = "";
            }
            else if (txtPhoneNV.Text.Length > 10)
            {
                MessageBox.Show("Số điện thoại gồm 10 số.");
                txtPhoneNV.Text = "";
            }
        }

    }
}
