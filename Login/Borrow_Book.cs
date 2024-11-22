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
            
                var kq = db.Saches.Select(l => l.TenSach).ToList();

                // Đổ dữ liệu vào ComboBox
                cbbTenSach.DataSource = kq;
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtSoThe_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Ban thuc su muon thoat khong?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (f == DialogResult.Yes)
            {
                this.Hide();
            }

        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Ban thuc su muon lam moi du lieu?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (f == DialogResult.Yes)
            {
                txtHoTen.Clear();
                txtKhoa.Clear();
                txtSDT.Clear();
                txtEmail.Clear();
            }

        }

        private void cbbTenSach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMuonSach_Click(object sender, EventArgs e)
        {
            
                string ten = cbbTenSach.Text;
                int sothe = int.Parse(txtSoThe.Text);
                DateTime ngayMuon = DateTime.Parse(dtNgayMuon.Text);

                // Lấy mã sách của cuốn sách mượn
                int kq = (from i in db.Saches
                          where i.TenSach.Equals(ten)
                          select i.MaSach).FirstOrDefault();

                // Kiểm tra nếu sách tồn tại trong bảng Saches
                var sach = db.Saches.FirstOrDefault(s => s.MaSach == kq);
                if (sach != null && sach.SoLuong > 0)
                {
                    // Giảm số lượng sách trong bảng Saches
                    sach.SoLuong -= 1;

                    // Lưu thay đổi vào bảng Saches
                    db.SubmitChanges();

                    // Thêm thông tin mượn sách vào bảng LichSuMuonTraSach
                    LichSuMuonTraSach ls = new LichSuMuonTraSach();
                    ls.SoThe = sothe;
                    ls.MaSach = kq;
                    ls.NgayMuon = ngayMuon;
                    ls.NgayTra = null;

                    db.LichSuMuonTraSaches.InsertOnSubmit(ls);
                    db.SubmitChanges();

                    MessageBox.Show("Đã thêm lịch sử mượn trả sách thành công.");
                }
                else
                {
                    MessageBox.Show("Sách mà bạn chọn hiện tại đã hết, vui lòng chọn sách khác!");
                }
            

        }
        }

    }
