using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Login
{
    public partial class Borrow_Book : Form
    {
        LVNDataContext db = new LVNDataContext();
        public Borrow_Book()
        {
            InitializeComponent();
        }


        private void Borrow_Book_Load(object sender, EventArgs e)
        {
            using (LVNDataContext dt = new LVNDataContext())
            {
                var kq = dt.Saches
                           .OrderBy(l => l.TenSach)
                           .Select(l => l.TenSach)
                           .ToList();

                cbbTenSach.DataSource = kq;
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
                using (LVNDataContext dt = new LVNDataContext())
                {
                    int soThe;
                    if (int.TryParse(txtSoThe.Text, out soThe))
                    {
                        var kq = db.DocGias.FirstOrDefault(p => p.SoThe.Equals(soThe));
                        if (kq != null)
                        {
                            txtHoTen.Text = kq.HoTen;
                            txtKhoa.Text = kq.Khoa;
                            txtSDT.Text = kq.SDT;
                            txtEmail.Text = kq.Email;
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy độc giả!");
                            txtHoTen.Clear();
                            txtKhoa.Clear();
                            txtSDT.Clear();
                            txtEmail.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Số thẻ độc giả phải được nhập bằng số, Vui lòng thử lại!");
                    }
                }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Ban thuc su muon thoat khong?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (f == DialogResult.Yes)
            {
                this.Hide();
            }

        }

        private void cbbTenSach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMuonSach_Click_1(object sender, EventArgs e)
        {
            using (LVNDataContext dt = new LVNDataContext())
            {
                string ten = cbbTenSach.Text;
                int sothe = int.Parse(txtSoThe.Text);
                DateTime ngayMuon = DateTime.Parse(dtNgayMuon.Text);

                int kq = (from i in dt.Saches
                          where i.TenSach.Equals(ten)
                          select i.MaSach).FirstOrDefault();

                var sach = dt.Saches.FirstOrDefault(s => s.MaSach == kq);

                if (sach != null && sach.SoLuong > 0)
                {
                    int soSachDaMuon = dt.LichSuMuonTraSaches
                        .Where(ls => ls.SoThe == sothe && ls.NgayTra == null)
                        .Count();

                    if (soSachDaMuon >= 3)
                    {
                        MessageBox.Show("Bạn đã mượn tối đa 3 cuốn sách, không thể mượn thêm.");
                    }
                    else
                    {
                        sach.SoLuong -= 1;
                        dt.SubmitChanges();

                        LichSuMuonTraSach ls = new LichSuMuonTraSach
                        {
                            SoThe = sothe,
                            MaSach = kq,
                            NgayMuon = ngayMuon,
                            NgayTra = null
                        };

                        dt.LichSuMuonTraSaches.InsertOnSubmit(ls);
                        dt.SubmitChanges();

                        MessageBox.Show("Đã thêm lịch sử mượn trả sách thành công.");
                    }
                }
                else
                {
                    MessageBox.Show("Sách mà bạn chọn hiện tại đã hết, vui lòng chọn sách khác!");
                }
            }
        }

        private void btnRefesh_Click_1(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Ban thuc su muon lam moi du lieu?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (f == DialogResult.Yes)
            {
                txtSoThe.Clear();
                txtHoTen.Clear();
                txtKhoa.Clear();
                txtSDT.Clear();
                txtEmail.Clear();
            }
        }
    }
}