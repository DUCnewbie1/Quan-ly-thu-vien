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
                    results = context.DocGia.Where(dg => dg.TenDocGia.Contains(keyword)).ToList();
                }
                else if (rbFollowIDReader.Checked)
                {
                    results = context.DocGia.Where(dg => dg.MaDocGia.Contains(keyword)).ToList();
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

            dgvSReader.DataSource = results;
        }

        private void btnExitSReader_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
