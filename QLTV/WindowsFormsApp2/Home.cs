using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace WindowsFormsApp2
{
    public partial class Home : Form
    {
        private int userId;
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        public Home(int userId)
        {
            this.userId = userId;
            InitializeComponent();
            CenterToScreen();
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
            QuanLyNhanVien formQuanLyNhanVien = new QuanLyNhanVien();
            formQuanLyNhanVien.ShowDialog();
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timKiemSach formTimKiemSach = new timKiemSach();
            formTimKiemSach.ShowDialog();
        }

       private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dn = new DangNhap();
            dn.Closed += (s, args) => this.Close();
            dn.Show();
            wplayer.controls.stop();
            
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Ghi thông tin vào file XML
            string toTime = DateTime.Now.ToString("HH:mm");
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "ChamCong.xml");
            AppendToTimeToXml(path, toTime);
            Application.Exit();
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

        private void quảnLýThẻĐọcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TheDocGia dg = new TheDocGia();
            dg.ShowDialog();
        }

        private void lậpPhiếuTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LapPhieuTra pt = new LapPhieuTra();
            pt.ShowDialog();   
        }

        private void đăngKýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangKy dk = new DangKy();
            dk.ShowDialog();
        }
    }
}
