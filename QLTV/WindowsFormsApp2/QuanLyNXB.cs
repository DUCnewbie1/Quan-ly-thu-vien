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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class QuanLyNXB : Form
    {
        public QuanLyNXB()
        {
            InitializeComponent();
            LoadNXBDataGrid();
        }
        private void LoadNXBDataGrid()
        {
            Model1 context = new Model1();
            var NXBList = context.NhaXuatBan.ToList();
            BindGrid(NXBList);
        }
        private void BindGrid(List<NhaXuatBan> listNXB)
        {
            dgvNXB.Rows.Clear();
            foreach (var item in listNXB)
            {
                int index = dgvNXB.Rows.Add();
                dgvNXB.Rows[index].Cells[0].Value = item.MaNXB;
                dgvNXB.Rows[index].Cells[1].Value = item.TenNXB;
                dgvNXB.Rows[index].Cells[2].Value = item.DiaChi;
                dgvNXB.Rows[index].Cells[3].Value = item.Email;
                dgvNXB.Rows[index].Cells[4].Value = item.Sdt;
            }
        }
        Class1<NhaXuatBan> dal = new Class1<NhaXuatBan>();
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaNXB.Text) ||
                string.IsNullOrWhiteSpace(txt_TenNXB.Text) ||
                string.IsNullOrWhiteSpace(txt_DiaChi.Text) ||
                string.IsNullOrWhiteSpace(txt_Email.Text) ||
                string.IsNullOrWhiteSpace(txt_SDT.Text) 
                )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhà xuất bản.");
                return;
            }
            string maNXB = txt_MaNXB.Text.Trim();

            if (int.TryParse(maNXB, out int number))
            {
                string DinhDangSo = number.ToString("D2");

                string input = "NXB" + DinhDangSo;
                txt_MaNXB.Text = input;
            }
            else
            {
                if (!txt_MaNXB.Text.StartsWith("NXB"))
                {
                    MessageBox.Show("Cấu trúc mã không hợp lệ");
                    return;
                }
            }
            //string maNXBId;
            //if (txt_MaNXBtxt_MaNXB.Set<T>()XBId))
            //{
            //    if (dal.KiemTraMa(maNXBId))
            //    {
            //        MessageBox.Show("Mã sách đã tồn tại trong cơ sở dữ liệu.");
            //        return;
            //    }
            //}
            string tenNXB = txt_TenNXB.Text;
            string diaChi = txt_DiaChi.Text;
            string email = txt_Email.Text;
            string sdt = txt_SDT.Text;

            NhaXuatBan nxb = new NhaXuatBan
            {
                MaNXB = maNXB,
                TenNXB = tenNXB,
                DiaChi = diaChi,
                Email = email,
                Sdt = sdt
            };
            dal.Them(nxb);
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaNXB.Text) ||
                string.IsNullOrWhiteSpace(txt_TenNXB.Text) ||
                string.IsNullOrWhiteSpace(txt_DiaChi.Text) ||
                string.IsNullOrWhiteSpace(txt_Email.Text) ||
                string.IsNullOrWhiteSpace(txt_SDT.Text)
                )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhà xuất bản.");
                return;
            }
            string tenNXB = txt_TenNXB.Text;
            string diaChi = txt_DiaChi.Text;
            string email = txt_Email.Text;
            string sdt = txt_SDT.Text;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string maSach = txt_MaNXB.Text;

            if (!string.IsNullOrEmpty(maSach))
            {
                NhaXuatBan nxbXoa = dal.TimSachTheoMa(maSach);
                dal.Xoa(nxbXoa);

                    MessageBox.Show("Xóa sách thành công!");
                    txt_MaNXB.Text = "";
                    txt_TenNXB.Text = "";
                    txt_DiaChi.Text = "";
                    txt_Email.Text = "";
                    txt_SDT.Text = "";
                    LoadNXBDataGrid();
                //else
                //{
                //    MessageBox.Show("Không thể xóa nhà xuất bản. Mã nhà xuất bản không tồn tại!");
                //}
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã nhà xuất bản để xóa.");
            }
        }
        private void dgvNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvNXB.Rows[e.RowIndex];

                string maNXB = selectedRow.Cells["MaNXB"].Value.ToString();
                string tenNXB = selectedRow.Cells["TenNXB"].Value.ToString();
                string diaChi = selectedRow.Cells["DiaChi"].Value.ToString();
                string email = selectedRow.Cells["Email"].Value.ToString();
                string sdt = selectedRow.Cells["SDT"].Value.ToString();
                txt_MaNXB.Text = maNXB;
                txt_TenNXB.Text = tenNXB;
                txt_DiaChi.Text = diaChi;
                txt_Email.Text = email;
                txt_SDT.Text = sdt;
            }
        }
    }
}
