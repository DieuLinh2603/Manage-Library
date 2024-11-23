using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Return_Book : Form
    {
        public Return_Book()
        {
            InitializeComponent();
        }

        void loadData()
        {
            using (LVNDataContext ts = new LVNDataContext())
            {
                dgvTraSach.DataSource = from i in ts.Saches
                                        from y in ts.DocGias
                                        from z in ts.LichSuMuonTraSaches
                                        where i.MaSach == z.MaSach && y.SoThe == z.SoThe
                                        select new
                                        {
                                            z.id,
                                            z.SoThe,
                                            y.HoTen,
                                            y.Email,
                                            i.TenSach,
                                            z.NgayMuon,
                                            z.NgayTra,
                                        };
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            using(LVNDataContext dt = new LVNDataContext())
            {
                int soThe;
                if (int.TryParse(txtSoThe.Text, out soThe))
                {
                    var kq = dt.LichSuMuonTraSaches.FirstOrDefault(p => p.SoThe.Equals(soThe));
                    if (kq != null)
                    {
                        dgvTraSach.DataSource = from i in dt.Saches
                                                from y in dt.DocGias
                                                from z in dt.LichSuMuonTraSaches
                                                where i.MaSach == z.MaSach && y.SoThe == z.SoThe && z.SoThe == soThe && z.NgayTra == null
                                                select new
                                                {
                                                    z.id,
                                                    z.SoThe,
                                                    y.HoTen,
                                                    y.Email,
                                                    i.TenSach,
                                                    z.NgayMuon,
                                                    z.NgayTra,
                                                };
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy số thẻ độc giả.");
                    }
                }
                else
                {
                    MessageBox.Show("Số thẻ độc giả phải được nhập bằng số, Vui lòng thử lại!");
                    txtSoThe.Clear();
                }
            }
        }

        private void dgvTraSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Ban thuc su muon lam moi du lieu?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (f == DialogResult.Yes)
            {
                dgvTraSach.Rows.Clear();
                txtSoThe.Clear();
                panel2.Hide();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Ban thuc su muon thoat?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (f == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void txtSoThe_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbbListBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Return_Book_Load(object sender, EventArgs e)
        {
            panel2.Hide();
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            using (LVNDataContext dt = new LVNDataContext())
            {
                DateTime ngayTra = DateTime.Parse(dtNgayTra.Text);
                int sothe = int.Parse(txtSoThe.Text);  
                string tenSach = txtTenSach.Text; 

                int maSach = (from s in dt.Saches
                              where s.TenSach.Equals(tenSach)
                              select s.MaSach).FirstOrDefault();

                LichSuMuonTraSach ls = dt.LichSuMuonTraSaches
                                         .FirstOrDefault(l => l.SoThe == sothe && l.MaSach == maSach && l.NgayTra == null);

                if (ls != null)
                {
                    ls.NgayTra = ngayTra;
                    dt.SubmitChanges();

                    Sach sach = dt.Saches.FirstOrDefault(s => s.MaSach == maSach);
                    if (sach != null)
                    {
                        sach.SoLuong += 1;
                        dt.SubmitChanges();
                        MessageBox.Show("Đã trả sách thành công.");
                        dgvTraSach.Rows.Clear();
                        txtSoThe.Clear();
                        panel2.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sách trong cơ sở dữ liệu.");
                    }
                }
                else
                {
                    MessageBox.Show("Lịch sử mượn sách không tồn tại hoặc sách chưa được mượn.");
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTenSach_MouseClick(object sender, MouseEventArgs e)
        {
            txtTenSach.Text = dgvTraSach.CurrentRow.Cells[5].Value.ToString();
            txtNgayMuon.Text = dgvTraSach.CurrentRow.Cells[6].Value.ToString();
        }

        private void dgvTraSach_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void dgvTraSach_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            panel2.Show();
            txtTenSach.Text = dgvTraSach.CurrentRow.Cells[4].Value.ToString();
            txtNgayMuon.Text = dgvTraSach.CurrentRow.Cells[5].Value.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
