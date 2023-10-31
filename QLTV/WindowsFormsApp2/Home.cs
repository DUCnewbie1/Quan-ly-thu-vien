using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace WindowsFormsApp2
{
    public partial class Home : Form
    {
        public int userId;
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        
        public Home(int userId)
        {
            this.userId = userId;
            InitializeComponent();
            CenterToScreen();
            custommizeDesing();
            //wplayer.URL = "LMT.mp3";
            //wplayer.settings.autoStart = true;
            //wplayer.settings.setMode("loop", true);
        }
        private void Home_Load(object sender, EventArgs e)
        {

        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // cập nhật ngày tháng
        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Hôm nay là ngày " + DateTime.Now.ToString("dd/MM/yyyy") + " - Bây giờ là: " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLySach formQuanLySach = new QuanLySach();
            formQuanLySach.ShowDialog();
        }

        private void quảnLýĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyDocGia formQuanLyDocGia = new QuanLyDocGia();
            formQuanLyDocGia.ShowDialog();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Model1 context = new Model1())
            {
                string query = "SELECT LoaiTK FROM TaiKhoan WHERE id=@userId";
                string loaiTk = context.Database.SqlQuery<string>(query, new SqlParameter("userId", userId)).FirstOrDefault();
                if (loaiTk != "Admin")
                {
                    MessageBox.Show("Chỉ có admin mới có thể quản lý nhân viên", "Thông báo");
                }
                else
                {
                    QuanLyNhanVien formQuanLyNhanVien = new QuanLyNhanVien();
                    formQuanLyNhanVien.ShowDialog();
                    hideSubMenu();
                }
            }
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timKiemSach formTimKiemSach = new timKiemSach();
            formTimKiemSach.ShowDialog();
        }

       private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //wplayer.controls.stop();
            //this.Close();
            //DangNhap dangNhap = new DangNhap();
            //dangNhap.Show();
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất tài khoản không?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                wplayer.controls.stop();
                DangNhap dn = new DangNhap();
                dn.Show();
                this.Hide();
            }
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Ghi thông tin vào file XML
            string toTime = DateTime.Now.ToString("HH:mm");
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "ChamCong.xml");
            AppendToTimeToXml(path, toTime);

            Application.ExitThread();
        }

        public void AppendToTimeToXml(string path, string toTime)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            XmlNode root = doc.DocumentElement;

            // Lấy dòng cuối cùng trong file XML
            XmlNode lastRowNode = root.LastChild;

            // Thêm ToTime vào dòng cuối cùng
            XmlNode toTimeNode = doc.CreateElement("ToTime");
            toTimeNode.InnerText = toTime;
            lastRowNode.AppendChild(toTimeNode);

            doc.Save(path);
        }

        private void quảnLýNhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyNXB nxb = new QuanLyNXB();
            nxb.ShowDialog();
        }

        private void lậpPhiếuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LapPhieuMuon lpm = new LapPhieuMuon();
            lpm.ShowDialog();
        }

        private void quảnLýTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyTacGia tg = new QuanLyTacGia();
            tg.ShowDialog();
        }

        private void chấmcôngtoolStripMenuItem(object sender, EventArgs e)
        {
            ChamCong cc = new ChamCong();
            cc.ShowDialog();
        }

        private void lậpPhiếuTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LapPhieuTra pt = new LapPhieuTra();
            pt.ShowDialog();   
        }


        // ĐỨC CODE NGÀY 26/10/2023  RIÊNG CHO PHẦN GIAO DIỆN
        // CÓ GỌI TRONG HOME() PHƯƠNG THỨC  custommizeDesing() NỮA.
        // ĐẤNG DŨNG KCR GỘP LẠI NHỚ LƯU Ý
        #region Phuong thuc Thanh ben 
        // -----------------------------------------------phương thức thanh bên------------------------------------------------------------------ 
        private void custommizeDesing()
        {
            panelDanhMuc.Visible = false;
            panelMuonTraPhat.Visible = false;
            panelTimKiem.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelDanhMuc.Visible = true)
                panelDanhMuc.Visible = false;

            if (panelMuonTraPhat.Visible = true)
                panelMuonTraPhat.Visible = false;

            if (panelTimKiem.Visible = true)
                panelTimKiem.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        //----------------------------------------------- end phuong thuc thanh ben-------------------------------------------------------
        #endregion Thanh bên 
        
        #region thanh ben 'Danh muc'
        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDanhMuc);
        }

        private void btnQLSach_Click(object sender, EventArgs e)
        {
            QuanLySach formQuanLySach = new QuanLySach();
            formQuanLySach.ShowDialog();

            hideSubMenu();
        }

        private void btnQLdocgia_Click(object sender, EventArgs e)
        {
            QuanLyDocGia formQuanLyDocGia = new QuanLyDocGia();
            formQuanLyDocGia.ShowDialog();
            hideSubMenu();
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            using (Model1 context = new Model1())
            {
                string query = "SELECT LoaiTK FROM TaiKhoan WHERE id=@userId";
                string loaiTk = context.Database.SqlQuery<string>(query, new SqlParameter("userId", userId)).FirstOrDefault();
                if (loaiTk != "Admin")
                {
                    MessageBox.Show("Chỉ có admin mới có thể quản lý nhân viên", "Thông báo");
                }
                else
                {
                    QuanLyNhanVien formQuanLyNhanVien = new QuanLyNhanVien();
                    formQuanLyNhanVien.ShowDialog();
                    hideSubMenu();
                }
            }
        }

        private void btnQLNXB_Click(object sender, EventArgs e)
        {
            QuanLyNXB nxb = new QuanLyNXB();
            nxb.ShowDialog();
            hideSubMenu();
        }

        private void btnQLtacgia_Click(object sender, EventArgs e)
        {
            QuanLyTacGia tg = new QuanLyTacGia();
            tg.ShowDialog();
            hideSubMenu();
        }

        #endregion thanh ben 'Danh muc'

        #region thanh ben 'Muon tra phat'
        private void btnMuonTra_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMuonTraPhat);
        }

        private void btnPhieuMuon_Click(object sender, EventArgs e)
        {
            LapPhieuMuon lpm = new LapPhieuMuon();
            lpm.ShowDialog();
        }

        private void btnPhieuTra_Click(object sender, EventArgs e)
        {
            LapPhieuTra pt = new LapPhieuTra();
            pt.ShowDialog();
        }

        private void btnPhieuPhat_Click(object sender, EventArgs e)
        {
            LapPhieuPhat pp = new LapPhieuPhat();
            pp.ShowDialog();
        }




        #endregion thanh ben " Muon tra phat

        #region thanh ben 'Tim Kiem'
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTimKiem);
        }

        private void btnTimSach_Click(object sender, EventArgs e)
        {
            timKiemSach formTimKiemSach = new timKiemSach();
            formTimKiemSach.ShowDialog();
        }

        private void btnTimDocGia_Click(object sender, EventArgs e)
        {
            timKiemDocGia tk = new timKiemDocGia();
            tk.ShowDialog();
        }


        #endregion thanh ben 'Tim Kiem'

        #region thanh ben 'Thoat'
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion thanh ben 'Thoat'


        private void lậpPhiếuPhạtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LapPhieuPhat pp = new LapPhieuPhat();
            pp.ShowDialog();
        }

        private void thốngKêSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeSach thongKeSach = new ThongKeSach();
            thongKeSach.ShowDialog();
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Excel ex = new Excel();
            ex.ShowDialog();
        }

        private void độcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timKiemDocGia dg = new timKiemDocGia();
            dg.ShowDialog();
        }
    }
}
