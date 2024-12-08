using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class History_Book : Form
    {
        LVNDataContext db = new LVNDataContext();
        const int Ngay_Han = 150;
        const double Phi_Phat = 2000;
        public History_Book()
        {
            InitializeComponent();
        }

        private void History_Book_Load(object sender, EventArgs e)
        {
            var rsm = from a in db.LichSuMuonTraSaches
                      from b in db.Saches
                      from c in db.DocGias
                      where a.NgayTra == null && a.SoThe == c.SoThe && a.MaSach == b.MaSach
                      select new{ 
                        a.id,
                        a.SoThe,
                        c.HoTen,
                        c.Email,
                        b.TenSach,
                        a.NgayMuon,
                        };
            dtgv_MuonSach.DataSource = rsm;

            var rst = from a in db.LichSuMuonTraSaches
                      from b in db.Saches
                      from c in db.DocGias
                      where a.NgayTra != null && a.SoThe == c.SoThe && a.MaSach == b.MaSach
                      select new
                      {
                          a.id,
                          a.SoThe,
                          c.HoTen,
                          c.Email,
                          b.TenSach,
                          a.NgayMuon,
                          a.NgayTra,
                          PhiPhat = (a.NgayTra - a.NgayMuon).Value.Days > Ngay_Han ? (a.NgayTra - a.NgayMuon).Value.Days * Phi_Phat : 0
                      };
            dtgv_TraSach.DataSource = rst;
        }

        private void btnTimKiem_Muon_Click(object sender, EventArgs e)
        {
            string txtsoThe = txtSoTheMuon.Text;
            string tenSach = txtTenSachMuon.Text;
            int soThe = txtsoThe != "" ? Convert.ToInt32(txtsoThe) : 0;
            DateTime ngayMuon = dtpMuon.Value;
            var rsm = from a in db.LichSuMuonTraSaches
                      from b in db.Saches
                      from c in db.DocGias
                      where a.NgayTra == null && a.SoThe == c.SoThe && a.MaSach == b.MaSach
                      && a.SoThe == (soThe != 0 ? soThe : a.SoThe)
                      && b.TenSach == (tenSach != "" ? tenSach : b.TenSach)
                      && a.NgayMuon == ngayMuon
                      select new
                      {
                          a.id,
                          a.SoThe,
                          c.HoTen,
                          c.Email,
                          b.TenSach,
                          a.NgayMuon,
                      };
            dtgv_MuonSach.DataSource = rsm;
        }

        private void btnLamMoiMuon_Click(object sender, EventArgs e)
        {
            var rsm = from a in db.LichSuMuonTraSaches
                      from b in db.Saches
                      from c in db.DocGias
                      where a.NgayTra == null && a.SoThe == c.SoThe && a.MaSach == b.MaSach
                      select new
                      {
                          a.id,
                          a.SoThe,
                          c.HoTen,
                          c.Email,
                          b.TenSach,
                          a.NgayMuon
                      };
            dtgv_MuonSach.DataSource = rsm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rst = from a in db.LichSuMuonTraSaches
                      from b in db.Saches
                      from c in db.DocGias
                      where a.NgayTra != null && a.SoThe == c.SoThe && a.MaSach == b.MaSach
                      select new
                      {
                          a.id,
                          a.SoThe,
                          c.HoTen,
                          c.Email,
                          b.TenSach,
                          a.NgayMuon,
                          a.NgayTra,
                          PhiPhat = (a.NgayTra - a.NgayMuon).Value.Days > Ngay_Han ? (a.NgayTra - a.NgayMuon).Value.Days * Phi_Phat : 0
                      };
            dtgv_TraSach.DataSource = rst;
        }

        private void btnTimKiem_Tra_Click(object sender, EventArgs e)
        {
            string txtSoThe = txtSoTheTra.Text;
            string tenSach = txtTenSachTra.Text;
            DateTime ngayMuon = dtpTra.Value;
            int soThe = txtSoThe != "" ? Convert.ToInt32(txtSoThe) : 0;
            var rsm = from a in db.LichSuMuonTraSaches
                      from b in db.Saches
                      from c in db.DocGias
                      where a.NgayTra != null && a.SoThe == c.SoThe && a.MaSach == b.MaSach
                      && a.SoThe == (soThe != 0 ? soThe : a.SoThe)
                      && b.TenSach == (tenSach != "" ? tenSach : b.TenSach)
                      && a.NgayMuon == ngayMuon
                      select new
                      {
                          a.id,
                          a.SoThe,
                          c.HoTen,
                          c.Email,
                          b.TenSach,
                          a.NgayMuon,
                          a.NgayTra,
                          PhiPhat = (a.NgayTra - a.NgayMuon).Value.Days > Ngay_Han ? (a.NgayTra - a.NgayMuon).Value.Days * Phi_Phat : 0
                      };
            dtgv_TraSach.DataSource = rsm;
        }
    }
}
