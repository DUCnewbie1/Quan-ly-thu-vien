﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DAL.Models;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;

namespace DAL
{
    public class Class1<T> where T : class
    {
        private Model1 context;

        public Class1()
        {
            context = new Model1();
        }

        public void Them(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public void Sua(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Xoa(T entity)
        {
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }
        public T TimSachTheoMa(string maSach)
        {
            return context.Set<T>().Find(maSach);
        }

        //sách chưa trả
        public List<string> GetBookNamesForMaPM(string maPM)
        {
            using (Model1 context = new Model1())
            {
                string sqlQuery = "SELECT S.TenSach FROM Sach S " +
                                  "INNER JOIN ChiTietPhieuMuon CT ON S.MaSach = CT.MaSach " +
                                  "WHERE CT.MaPM = @MaPM AND CT.TrangThaiSach = 0";

                var bookNames = context.Database.SqlQuery<string>(sqlQuery, new SqlParameter("MaPM", maPM)).ToList();
                return bookNames;
            }
        }
        //Sách đã trả
        public List<string> GetReturnedBookNamesForMaPM(string maPM)
        {
            using (Model1 context = new Model1())
            {
                string sqlQuery = "SELECT S.TenSach FROM Sach S " +
                                  "INNER JOIN ChiTietPhieuMuon CT ON S.MaSach = CT.MaSach " +
                                  "WHERE CT.MaPM = @MaPM AND CT.TrangThaiSach = 1";

                var bookNames = context.Database.SqlQuery<string>(sqlQuery, new SqlParameter("MaPM", maPM)).ToList();
                return bookNames;
            }
        }
        public string GetMaPMTuMaPT(string maPT)
        {
            using (Model1 context = new Model1())
            {
                string query = "SELECT TOP 1 CPT.MaPM FROM ChiTietPhieuTra CPT WHERE CPT.MaPT = @MaPT";

                string maPM = context.Database.SqlQuery<string>(query, new SqlParameter("MaPT", maPT)).FirstOrDefault();
                return maPM;
            }
        }

        public string GetMaDocGiaTuTenDocGia(string tenDocGia)
        {
            using (Model1 context = new Model1())
            {
                string query = "SELECT DG.MaDocGia FROM DocGia DG WHERE DG.TenDocGia = @TenDocGia";

                string maDocGia = context.Database.SqlQuery<string>(query, new SqlParameter("TenDocGia", tenDocGia)).FirstOrDefault();
                return maDocGia;
            }
        }

        public string LayTenDocGiaTuMaPT(string maPT)
        {
            using (Model1 context = new Model1())
            {
                string query = "SELECT DG.TenDocGia FROM DocGia DG " +
                               "INNER JOIN TheDocGia TDG ON DG.MaDocGia = TDG.MaDocGia " +
                               "INNER JOIN PhieuMuon PM ON TDG.MaThe = PM.MaThe " +
                               "INNER JOIN ChiTietPhieuTra CPT ON PM.MaPM = CPT.MaPM " +
                               "WHERE CPT.MaPT = @MaPT";

                string tenDocGia = context.Database.SqlQuery<string>(query, new SqlParameter("MaPT", maPT)).FirstOrDefault();
                return tenDocGia;
            }
        }
        public List<string> GetMaPMsForMaThe(string maThe)
        {
            using (Model1 context = new Model1())
            {
                string sqlQuery = "SELECT PM.MaPM FROM PhieuMuon PM " +
                                  "WHERE PM.MaThe = @MaThe AND PM.MaPM NOT IN (" +
                                  "SELECT CPT.MaPM FROM ChiTietPhieuTra CPT " +
                                  "INNER JOIN PhieuTra PT ON CPT.MaPT = PT.MaPT " +
                                  "WHERE PT.TinhTrangSach = N'Trả đủ sách')";

                var maPMs = context.Database.SqlQuery<string>(sqlQuery, new SqlParameter("MaThe", maThe)).ToList();
                return maPMs;
            }
        }
        public List<string> GetMaPTsForMaThe(string maThe)
        {
            using (Model1 context = new Model1())
            {
                string query = @"SELECT PM.MaPM FROM PhieuMuon PM
                                 LEFT JOIN ChiTietPhieuMuon CTPM ON PM.MaPM = CTPM.MaPM
                                 WHERE PM.MaThe = @MaThe
                                 GROUP BY PM.MaPM 
                                 HAVING SUM(CAST(CTPM.TrangThaiSach AS INT)) < COUNT(*)";

                var maPMs = context.Database.SqlQuery<string>(query, new SqlParameter("MaThe", maThe)).ToList();
                return maPMs;
            }
        }
        public string LayTenDocGiaTuMaPhat(string maPhat)
        {
            using (Model1 context = new Model1())
            {
                string query = "SELECT DG.TenDocGia FROM DocGia DG " +
                               "INNER JOIN TheDocGia TDG ON DG.MaDocGia = TDG.MaDocGia " +
                               "INNER JOIN PhieuMuon PM ON TDG.MaThe = PM.MaThe " +
                               "INNER JOIN ChiTietPhieuPhat CPP ON PM.MaPM = CPP.MaPM " +
                               "WHERE CPP.MaPhat = @MaPhat";

                string tenDocGia = context.Database.SqlQuery<string>(query, new SqlParameter("MaPhat", maPhat)).FirstOrDefault();
                return tenDocGia;
            }
        }
        public string LayTenNhanVienTuMaPhat(string maPhat)
        {
            using (Model1 context = new Model1())
            {
                string query = "SELECT NV.TenNV FROM NhanVien NV " +
                               "INNER JOIN PhieuMuon PM ON NV.MaNV = PM.MaNV " +
                               "INNER JOIN ChiTietPhieuPhat CPP ON PM.MaPM = CPP.MaPM " +
                               "WHERE CPP.MaPhat = @MaPhat";

                string tenDocGia = context.Database.SqlQuery<string>(query, new SqlParameter("MaPhat", maPhat)).FirstOrDefault();
                return tenDocGia;
            }
        }
        public string LayMaPhieuMuonTuMaPhat(string maPhat)
        {
            using (Model1 context = new Model1())
            {
                string query = "SELECT PM.MaPM FROM PhieuMuon PM " +
                               "INNER JOIN ChiTietPhieuPhat CPP ON PM.MaPM = CPP.MaPM " +
                               "WHERE CPP.MaPhat = @MaPhat";

                string tenDocGia = context.Database.SqlQuery<string>(query, new SqlParameter("MaPhat", maPhat)).FirstOrDefault();
                return tenDocGia;
            }
        }
        public List<string> GetTrangThaiSach(string maPM)
        {
            using (Model1 context = new Model1())
            {
                string sqlQuery = "SELECT S.TenSach FROM Sach S " +
                                  "INNER JOIN ChiTietPhieuMuon CT ON S.MaSach = CT.MaSach " +
                                  "WHERE CT.MaPM = @MaPM AND CT.TrangThaiSach = 1";

                var bookNames = context.Database.SqlQuery<string>(sqlQuery, new SqlParameter("MaPM", maPM)).ToList();
                return bookNames;
            }
        }
        public void CapNhapMaTGTrongSach(string maTacGia, string maTGMoi)
        {
            using (Model1 context = new Model1())
            {
                var sachRecords = context.Sach.Where(s => s.MaTacGia == maTacGia).ToList();

                foreach (var sach in sachRecords)
                {
                    sach.MaTacGia = maTGMoi;
                    context.Entry(sach).State = EntityState.Modified;
                }
                context.SaveChanges();
            }
        }
        public bool TacGiaCoSach(string maTacGia)
        {
            return context.Set<Sach>().Any(s => s.MaTacGia == maTacGia);
        }
        public bool NXBCoSach(string maNXB)
        {
            return context.Set<Sach>().Any(s => s.NhaXuatBan.MaNXB == maNXB);
        }
    }
}
