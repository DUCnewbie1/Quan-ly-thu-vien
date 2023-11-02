using BLL;
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
using System.Xml;
using System.IO;
using System.Xml.Linq;
using System.Reflection;

namespace WindowsFormsApp2
{
    public partial class ChamCong : Form
    {
        
        public ChamCong()
        {
            InitializeComponent();
            CenterToScreen();
            // Đặt giá trị mặc định của ComboBox là không hiển thị gì
            cmbCa.Text = "";
        }

        //private void LoadDataFromXml(string path)
        //{
        //    // Tạo một đối tượng XDocument để load dữ liệu từ file XML
        //    XDocument doc = XDocument.Load(path);

        //    // Sử dụng LINQ để truy vấn dữ liệu từ file XML
        //    var query = from row in doc.Descendants("Row")
        //                select new
        //                {
        //                    Date = (string)row.Element("Date"),
        //                    Name = (string)row.Element("Name"),
        //                    Ca = (string)row.Element("Ca"),
        //                    FromTime = (string)row.Element("FromTime")
        //                };

        //    // Đổ dữ liệu vào DataGridView
        //    dgvChamCong.DataSource = query.ToList();
        //}


        private bool isChamCong = false;

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            try
            {
                if (isChamCong)
                {
                    MessageBox.Show("Bạn chỉ được phép chấm công 1 lần!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(cmbCa.Text == "")
                {
                    MessageBox.Show("Mời chọn ca để chấm công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Tạo một dòng mới trong DataGridView
                int rowIndex = dgvChamCong.Rows.Add();

                // Lấy dòng vừa tạo
                DataGridViewRow row = dgvChamCong.Rows[rowIndex];

                // Đặt giá trị cho các cột tương ứng
                row.Cells[0].Value = txtNameCc.Text;
                row.Cells[1].Value = cmbCa.SelectedItem.ToString();
                row.Cells[2].Value = DateTime.Now.ToString("HH:mm");

                // Ghi thông tin vào file XML
                string path = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "ChamCong.xml");
                if (!File.Exists(path))
                {
                    XDocument doc = new XDocument(new XElement("ChamCong"));
                    doc.Save(path);
                }
                AppendToXml(path, dgvChamCong, dtpToday.Value);

                MessageBox.Show("Chấm công thành công!");

                isChamCong = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi là: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AppendToXml(string path, DataGridView dgv, DateTime date)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            XmlNode root = doc.DocumentElement;

            foreach (DataGridViewRow dgvRow in dgv.Rows)
            {
                XmlNode rowNode = doc.CreateElement("Row");

                // Thêm ngày vào file XML từ user control dtpToday
                XmlNode dateNode = doc.CreateElement("Date");
                dateNode.InnerText = date.ToString("dd/MM/yyyy");
                rowNode.AppendChild(dateNode);

                XmlNode nameNode = doc.CreateElement("Name");
                nameNode.InnerText = dgvRow.Cells[0].Value.ToString();
                rowNode.AppendChild(nameNode);

                XmlNode caNode = doc.CreateElement("Ca");
                caNode.InnerText = dgvRow.Cells[1].Value.ToString();
                rowNode.AppendChild(caNode);

                XmlNode timeNode = doc.CreateElement("FromTime"); // Đổi "Time" thành "FromTime"
                timeNode.InnerText = dgvRow.Cells[2].Value.ToString();
                rowNode.AppendChild(timeNode);



                root.AppendChild(rowNode);
            }

            doc.Save(path);
        }
        
        private void btnThoatCc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ChamCong_Load(object sender, EventArgs e)
        {
            string taiKhoan = BLL.XuLy.LayTaiKhoan();
            txtNameCc.Text = taiKhoan;
        }
        // Đức chỉ cho hiển thị combox là sáng khi từ 3 đến 12 giờ, từ 13 đên 17h hiển thị là chiều
        private void cmbCa_DropDown(object sender, EventArgs e)
        {
            // Lấy giờ hiện tại
            int hour = DateTime.Now.Hour;

            // Xóa tất cả các mục trong ComboBox
            cmbCa.Items.Clear();

            // Nếu giờ hiện tại từ 8 đến 12, chỉ cho phép chọn "Sáng"
            if (hour >= 3 && hour <= 12)
            {
                cmbCa.Items.Add("Sáng");
            }
            // Nếu giờ hiện tại từ 13 đến 17, chỉ cho phép chọn "Chiều"
            else if (hour >= 13 && hour <= 24)
            {
                cmbCa.Items.Add("Chiều");
            }
        }

        private void btnTKe_Click(object sender, EventArgs e)
        {
            // Đường dẫn đến file ChamCong.xml
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "ChamCong.xml");     
            //"E:\TAILIEUTRUONG\HK5\HK5A\LapTrinhWindow\chua sln winform\nhom 4 nguoi\DoAnMon\Quan-ly-thu-vien\QLTV\WindowsFormsApp2\ChamCong.xml"

            // Gọi hàm LoadDataFromXml để đổ dữ liệu vào dgvTKe
            LoadDataFromXml(path, dgvTke);
        }

        private void LoadDataFromXml(string path, DataGridView dgv)
        {
            // Tạo một đối tượng XDocument để load dữ liệu từ file XML
            XDocument doc = XDocument.Load(path);

            // Sử dụng LINQ để truy vấn dữ liệu từ file XML
            var query = from row in doc.Descendants("Row")
                        select new
                        {
                            Date = (string)row.Element("Date"),
                            Name = (string)row.Element("Name"),
                            Ca = (string)row.Element("Ca"),
                            FromTime = (string)row.Element("FromTime"),
                            ToTime = (string)row.Element("ToTime")
                        };

            // Đổ dữ liệu vào DataGridView
            dgv.DataSource = query.ToList();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgvChamCong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
