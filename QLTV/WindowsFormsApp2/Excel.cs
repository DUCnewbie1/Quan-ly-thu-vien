﻿using System;
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
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
            saveFileDialog.FileName = "ThongKeDocGia.xlsx"; 
            saveFileDialog.InitialDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
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
                        //Lấy mã phiếu mượn từ phiếu trả
                        string query = "SELECT DISTINCT ctpt.MaPM FROM ChiTietPhieuTra ctpt " +
                                       "INNER JOIN PhieuTra pt ON ctpt.MaPT = pt.MaPT " +
                                       "INNER JOIN PHIEUMUON PM ON ctpt.MaPM = PM.MaPM " +
                                       "WHERE MONTH(PM.NgayLap) = MONTH(GETDATE()) AND YEAR(PM.NgayLap) = YEAR(GETDATE())";

                        var results = context.Database.SqlQuery<string>(query).ToList();

                        // Gửi dữ liệu vào excel
                        int row = 2;
                        foreach (var item in data)
                        {
                            worksheet.Cells["A" + row].Value = item.MaDocGia;
                            worksheet.Cells["B" + row].Value = item.TenDocGia;
                            worksheet.Cells["C" + row].Value = item.MaPhieuMuon;
                            var chiTietPhieuMuon = context.ChiTietPhieuMuon
                            .Where(ctpm => ctpm.MaPM == item.MaPhieuMuon).ToList();

                            bool trangThai = chiTietPhieuMuon.All(ctpm => (bool)ctpm.TrangThaiSach);


                            if (trangThai)
                            {
                                worksheet.Cells["D" + row].Value = "Đã trả sách";
                            }
                            else if (chiTietPhieuMuon.Any(ctpm => (bool)ctpm.TrangThaiSach))
                            {
                                worksheet.Cells["D" + row].Value = "Trả thiếu sách";
                            }
                            else
                            {
                                worksheet.Cells["D" + row].Value = "Chưa trả sách";
                            }
                            row++;
                        }
                        worksheet.Cells.AutoFitColumns();

                    }
                    package.SaveAs(new FileInfo(filePath));
                }
                MessageBox.Show("Tạo file excel thành công.");
            }
        }

        private void btn_ChonFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    using (var package = new ExcelPackage(new FileInfo(filePath)))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; 

                        int rowCount = worksheet.Dimension.Rows;
                        int colCount = worksheet.Dimension.Columns;

                        // Lấy dữ liệu từ Excel vào data grid view
                        dgv_Excel.Rows.Clear();
                        dgv_Excel.Columns.Clear();
                        for (int col = 1; col <= colCount; col++)
                        {
                            dgv_Excel.Columns.Add(worksheet.Cells[1, col].Text, worksheet.Cells[1, col].Text);
                        }

                        for (int row = 2; row <= rowCount; row++)
                        {
                            DataGridViewRow dataGridViewRow = new DataGridViewRow();
                            dataGridViewRow.CreateCells(dgv_Excel);
                            for (int col = 1; col <= colCount; col++)
                            {
                                dataGridViewRow.Cells[col - 1].Value = worksheet.Cells[row, col].Text;
                            }
                            dgv_Excel.Rows.Add(dataGridViewRow);
                        }
                    }
                }

            }
        }
    }
}
