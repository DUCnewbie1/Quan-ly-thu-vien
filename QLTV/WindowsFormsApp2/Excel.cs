using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;
using System.Reflection;
using System.Xml.Linq;
using DAL.Models;
using System.Runtime.Remoting.Contexts;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class Excel : Form
    {
        public Excel()
        {
            InitializeComponent();
        }

        private void btn_CreateExcel_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using (var package = new ExcelPackage())
            {
                // Tạo bảng tính
                var worksheet = package.Workbook.Worksheets.Add("ThongKeDocGia");

                // Tạo cột
                worksheet.Cells["A1"].Value = "Mã Độc Giả";
                worksheet.Cells["B1"].Value = "Độc Giả";
                worksheet.Cells["C1"].Value = "Mã Phiếu Mượn";
                worksheet.Cells["D1"].Value = "Trạng Thái";

                using (Model1 context = new Model1())
                {
                    var data = (from dg in context.DocGia
                                join tdg in context.TheDocGia on dg.MaDocGia equals tdg.MaDocGia
                                join pm in context.PhieuMuon on tdg.MaThe equals pm.MaThe into pmGroup
                                from pmData in pmGroup.DefaultIfEmpty()
                                where pmData != null && 
                                      pmData.NgayLap.Month == DateTime.Now.Month && 
                                      pmData.NgayLap.Year == DateTime.Now.Year
                                select new
                                {
                                    dg.MaDocGia,
                                    dg.TenDocGia,
                                    MaPhieuMuon = pmData == null ? "" : pmData.MaPM,
                                }).ToList();

                    // Gửi dữ liệu vào excel
                    int row = 2;
                    foreach (var item in data)
                    {
                        worksheet.Cells["A" + row].Value = item.MaDocGia;
                        worksheet.Cells["B" + row].Value = item.TenDocGia;
                        worksheet.Cells["C" + row].Value = item.MaPhieuMuon;
                        //worksheet.Cells["D" + row].Value = item.TinhTrangSach;
                        row++;
                    }
                    worksheet.Cells.AutoFitColumns();

                }


                // Save the Excel file to a specific location
                string path = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "ThongKeDocGia.xls");
                package.SaveAs(path);
            }

            MessageBox.Show("Tạo file excel thành công.");
        }

        private string GetTinhTrangSach(Model1 context, PhieuMuon pmData)
        {
            DateTime currentDate = DateTime.Now;

            string query = "SELECT DISTINCT ctpt.* FROM ChiTietPhieuTra ctpt " +
                "INNER JOIN PhieuTra pt ON ctpt.MaPT = pt.MaPT " +
                "INNER JOIN PHIEUMUON PM ON ctpt.MaPM = PM.MaPM " +
                "WHERE MONTH(PM.NgayLap) = MONTH(GETDATE()) AND YEAR(PM.NgayLap) = YEAR(GETDATE())";

            var results = context.Database.SqlQuery<string>(query);

            foreach (var result in results)
            {

            }
                if (daTraSach)
            {
                return "Đã trả sách";
            }
            else
            {
                return null;
            }
        }
    }
}
