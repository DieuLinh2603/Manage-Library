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
        int MaxNgayMuon = 90;
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
                        a.NgayTra
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
                          PhiPhat = (a.NgayTra - a.NgayMuon).Value.Days > MaxNgayMuon ? b.GiaSach : 0
                      };
            dtgv_TraSach.DataSource = rst;
        }
    }
}
