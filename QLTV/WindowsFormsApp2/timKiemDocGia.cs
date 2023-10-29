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
    public partial class timKiemDocGia : Form
    {
        public timKiemDocGia()
        {
            InitializeComponent();
        }

        private void timKiemDocGia_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSReader_Click(object sender, EventArgs e)
        {
            string keyword = txtSReader.Text.Trim();

            if (string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.", "Lỗi");
                return;
            }

            List<DocGia> results = new List<DocGia>();

            using (Model1 context = new Model1())
            {
                if (rbFollowName.Checked)
                {
                    foreach (var item in context.DocGia)
                    {
                        if (keyword == item.TenDocGia || item.TenDocGia.Contains(keyword))
                        {
                            results.Add(item);
                        }
                    }
                    BindGrid(results);
                }
                else if (rbFollowIDReader.Checked)
                {
                    foreach (var item in context.DocGia)
                    {
                        if (keyword == item.MaDocGia || item.MaDocGia.Contains(keyword))
                        {
                            results.Add(item);
                        }
                    }
                    BindGrid(results);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn loại tìm kiếm.", "Lỗi");
                    return;
                }
            }

            if (results.Count == 0)
            {
                MessageBox.Show("Không tìm thấy đọc giả nào khớp với từ khóa.", "Thông báo");
                return;
            }

        }

        
        private void BindGrid(List<DocGia> results)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Đọc Giả");
            dt.Columns.Add("Tên Đọc Giả");
            dt.Columns.Add("Địa Chỉ");
            dt.Columns.Add("SĐT");
            dt.Columns.Add("Email");
            foreach (var item in results)
            {
                DataRow dr = dt.NewRow();
                dr["Mã Đọc Giả"] = item.MaDocGia;
                dr["Tên Đọc Giả"] = item.TenDocGia;
                dr["Địa Chỉ"] = item.DiaChi;
                dr["SĐT"] = item.Sdt;
                dr["Email"] = item.Email;
                dt.Rows.Add(dr);
            }
            dgvSReader.DataSource = dt;
        }


        private void btnExitSReader_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
