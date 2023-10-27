using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace WindowsFormsApp2
{
    public partial class TheDocGia : Form
    {
        public TheDocGia()
        {
            InitializeComponent();
        }

        private void frmTheDocGia_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            Model1 context = new Model1();
            var ListReadersCard = context.TheDocGia.ToList();
            //var ListReaders = context.DocGia.ToList();
            BindGrid(ListReadersCard);
        }
        private void BindGrid(List<DAL.Models.TheDocGia> ListReadersCard)
        {
            dgvTheDG.Rows.Clear();
            foreach (var item in ListReadersCard)
            {
                int index = dgvTheDG.Rows.Add();
                dgvTheDG.Rows[index].Cells[0].Value = item.MaThe;
                dgvTheDG.Rows[index].Cells[1].Value = item.MaDocGia;
                dgvTheDG.Rows[index].Cells[2].Value = item.NgayLapThe;
                dgvTheDG.Rows[index].Cells[3].Value = item.NgayHetHan;
            }
        }

        private void dgvTheDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow sr = dgvTheDG.Rows[e.RowIndex];
                txtMaThe.Text = sr.Cells[0].Value.ToString().Trim();
                txtMaDG.Text = sr.Cells[1].Value.ToString().Trim();
                dtpkNgayLap.Value = Convert.ToDateTime(sr.Cells[2].Value); ;
                dtpkNgayHetHan.Value = Convert.ToDateTime(sr.Cells[3].Value); ;
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string maThe = txtMaThe.Text;
            string maDG = txtMaDG.Text;
            DateTime ngayLapThe = dtpkNgayLap.Value;
            DateTime ngayHetHan = dtpkNgayHetHan.Value;

            if (string.IsNullOrWhiteSpace(maThe) || string.IsNullOrWhiteSpace(maDG))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin đọc giả và nhập đúng định dạng dữ liệu.", "Lỗi");
                return;
            }

            using (Model1 context = new Model1())
            {
                var existingReaderCard = context.TheDocGia.FirstOrDefault(dg => dg.MaThe == maThe);
                if (existingReaderCard != null)
                {
                    MessageBox.Show("Thẻ đọc giả đã tồn tại. Vui lòng nhập mã thẻ đọc giả khác.", "Lỗi");
                    return;
                }
                //var existingReader = context.DocGia.FirstOrDefault(dg => dg.MaDocGia == maDG);
                //if (existingReader != null)
                //{
                //    MessageBox.Show("Đọc giả này đã đăng ký thẻ. Vui lòng nhập mã đọc giả khác.", "Lỗi");
                //    return;
                //}

                DAL.Models.TheDocGia newReadersCard = new DAL.Models.TheDocGia
                {
                    MaThe = maThe,
                    MaDocGia = maDG,
                    NgayLapThe = ngayLapThe,
                    NgayHetHan = ngayHetHan,
                };

                Class1<DAL.Models.TheDocGia> TheDocGiaDataAccess = new Class1<DAL.Models.TheDocGia>();
                TheDocGiaDataAccess.Them(newReadersCard);
                MessageBox.Show("Đăng ký Thành công", "Thông báo");

            }
            LoadDataGrid();
        }

        private void btnExitDG_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteDG_Click(object sender, EventArgs e)
        {
            string maThe = txtMaThe.Text.Trim();
            Class1<DAL.Models.TheDocGia> TheDocGiaDataAccess = new Class1<DAL.Models.TheDocGia>();
            DAL.Models.TheDocGia TheDocGiaToDelete = TheDocGiaDataAccess.TimSachTheoMa(maThe);


            if (TheDocGiaToDelete != null)
            {
                var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa thẻ đọc giả này không?",
                                                     "Xác nhận xóa!!",
                                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    TheDocGiaDataAccess.Xoa(TheDocGiaToDelete);
                    MessageBox.Show("Xóa thành công. ", "Thông báo");
                    LoadDataGrid();
                }
                else
                {
                    MessageBox.Show("Thẻ đọc giả không được xóa.", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy thẻ đọc giả có mã " + maThe + "để xóa.", "Thông báo");
            }
        }
    }
}
