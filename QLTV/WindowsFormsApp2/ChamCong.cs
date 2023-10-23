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
using System.Security.AccessControl;
using System.Security.Principal;

namespace WindowsFormsApp2
{
    public partial class ChamCong : Form
    {
        
        public ChamCong()
        {
            InitializeComponent();
            // Đặt giá trị mặc định của ComboBox là không hiển thị gì
            cmbCa.Text = "";
        }

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

                // Tạo một dòng mới trong DataGridView
                int rowIndex = dgvChamCong.Rows.Add();

                // Lấy dòng vừa tạo
                DataGridViewRow row = dgvChamCong.Rows[rowIndex];

                // Đặt giá trị cho các cột tương ứng
                row.Cells[0].Value = txtNameCc.Text;
                row.Cells[1].Value = cmbCa.SelectedItem.ToString();
                row.Cells[2].Value = DateTime.Now.ToString("HH:mm");

                // Ghi thông tin vào file XML
                string xmlFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ChamCong.xml");
                //Nếu như trong document không tồn tại ChamCong.xml thì sẽ tạo file đó
                if (!File.Exists(xmlFilePath))
                {
                    XDocument doc = new XDocument(new XElement("ChamCong"));
                    doc.Save(xmlFilePath);
                }
                AppendToXml(xmlFilePath, dgvChamCong, dtpToday.Value);

                MessageBox.Show("Chấm công thành công!");

                isChamCong = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi là: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void CreateWithFullAccess(string targetDirectory)
        {
            try
            {
                if (!Directory.Exists(targetDirectory))
                {
                    Directory.CreateDirectory(targetDirectory);
                }
                DirectoryInfo info = new DirectoryInfo(targetDirectory);
                SecurityIdentifier allUsersSid =
                new SecurityIdentifier(WellKnownSidType.LocalServiceSid,
                null);
                DirectorySecurity security = info.GetAccessControl();
                security.AddAccessRule(
                new FileSystemAccessRule(allUsersSid,
                FileSystemRights.FullControl,
                AccessControlType.Allow));
                info.SetAccessControl(security);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
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
            string taiKhoan = Class1.LayTaiKhoan();
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
            else if (hour >= 13 && hour <= 17)
            {
                cmbCa.Items.Add("Chiều");
            }
        }
    }
}
