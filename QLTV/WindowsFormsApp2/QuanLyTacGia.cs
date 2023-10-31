using DAL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class QuanLyTacGia : Form
    {
        public QuanLyTacGia()
        {
            InitializeComponent();
            CenterToScreen();
            LoadDataGrid();
        }
        private void LoadDataGrid()
        {
            Model1 context = new Model1();
            var TGList = context.TacGia.ToList();
            BindGrid(TGList);
        }
        private void BindGrid(List<TacGia> listTG)
        {
            dgvTG.Rows.Clear();
            foreach (var item in listTG)
            {
                int index = dgvTG.Rows.Add();
                dgvTG.Rows[index].Cells[0].Value = item.MaTacGia;
                dgvTG.Rows[index].Cells[1].Value = item.TenTacGia;
            }
        }
        private void dgvTG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvTG.Rows[e.RowIndex];

                string maNXB = selectedRow.Cells["MaTG"].Value.ToString();
                string tenNXB = selectedRow.Cells["TenTG"].Value.ToString();
                txt_MaTG.Text = maNXB;
                txt_TenTG.Text = tenNXB;
            }
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaTG.Text) ||
                string.IsNullOrWhiteSpace(txt_TenTG.Text)
                )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhà xuất bản.");
                return;
            }
            string maTG = txt_MaTG.Text.Trim();
            string tenTG = txt_TenTG.Text;

            if (!maTG.StartsWith("TG"))
            {
                maTG = "TG" + maTG;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(maTG, @"^TG[1-9]$"))
            {
                maTG = "TG0" + maTG.Substring(2);
            }

            using (Model1 context = new Model1())
            {
                var existingReader = context.TacGia.FirstOrDefault(dg => dg.MaTacGia == maTG);
                if (existingReader != null)
                {
                    MessageBox.Show("Mã tác giả đã tồn tại. Vui lòng nhập mã nhà xuất bản khác.", "Lỗi");
                    return;
                }

                TacGia tg = new TacGia
                {
                    MaTacGia = maTG,
                    TenTacGia = tenTG
                };
                Class1<TacGia> tgDataAccess = new Class1<TacGia>();
                tgDataAccess.Them(tg);
                MessageBox.Show("Thêm Thành công", "Thông báo");
                LoadDataGrid();
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaTG.Text) ||
                string.IsNullOrWhiteSpace(txt_TenTG.Text)
                )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tác giả.");
                return;
            }
            string maTG = txt_MaTG.Text;
            string tenTG = txt_TenTG.Text;

            if (!maTG.StartsWith("TG"))
            {
                maTG = "TG" + maTG;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(maTG, @"^TG[1-9]$"))
            {
                maTG = "TG0" + maTG.Substring(2);
            }

            using (Model1 context = new Model1())
            {

                TacGia tg = new TacGia
                {
                    MaTacGia = maTG,
                    TenTacGia = tenTG
                };
                Class1<TacGia> tgDataAccess = new Class1<TacGia>();
                tgDataAccess.Sua(tg);
                MessageBox.Show("Sửa Thành công", "Thông báo");
                LoadDataGrid();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string maTG = txt_MaTG.Text.Trim();
            Class1<TacGia> tgDataAccess = new Class1<TacGia>();

            if (!maTG.StartsWith("TG"))
            {
                maTG = "TG" + maTG;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(maTG, @"^TG[1-9]$"))
            {
                maTG = "TG0" + maTG.Substring(2);
            }
            TacGia tgBiXoa = tgDataAccess.TimSachTheoMa(maTG);
            if (tgBiXoa != null)
            {
                var confirmResult = MessageBox.Show($"Tác giả {txt_MaTG.Text} {txt_TenTG.Text} sẽ bị xóa!",
                                                        "Xác nhận xóa!!",
                                                        MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    tgDataAccess.Xoa(tgBiXoa);
                    MessageBox.Show("Xóa thành công. ", "Thông báo");
                    LoadDataGrid();
                }
                else
                {
                    MessageBox.Show("Không xóa được tác giả này.", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy tác giả có mã " + maTG + "để xóa.", "Thông báo");
            }
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

