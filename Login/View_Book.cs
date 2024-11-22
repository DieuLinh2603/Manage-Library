using System;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Login
{
    public partial class View_Book : Form
    {
        public View_Book()
        {
            InitializeComponent();
            LoadData();
            panel2.Visible = false;
        }
        public void LoadData()
        {
            LVNDataContext data = new LVNDataContext();
            DataGr.DataSource = from i in data.Saches
                                select i;

        }

       

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTenSach.Clear();
            LoadData();
            panel2.Visible = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
{
    string tenSach = txtTenSach2.Text.Trim();
    LVNDataContext data = new LVNDataContext();

    var sachToDelete = data.Saches.FirstOrDefault(s => s.TenSach == tenSach);

    if (sachToDelete != null)
    {
        // Thêm thông báo xác nhận xóa
        if (MessageBox.Show("Dữ liệu sẽ được xóa. Xác nhận?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
        {
            var lichSuToDelete = data.LichSuMuonTraSaches.Where(ls => ls.MaSach == sachToDelete.MaSach);

            data.LichSuMuonTraSaches.DeleteAllOnSubmit(lichSuToDelete);
            data.Saches.DeleteOnSubmit(sachToDelete);
            data.SubmitChanges();

            LoadData();
            panel2.Visible = false;

            MessageBox.Show("Sách và các bản ghi lịch sử mượn trả đã được xóa thành công!");
        }
    }
    else
    {
        MessageBox.Show("Không tồn tại sách với tên này!");
    }
}



        int bid;
        Int64 rowid;
        private void DataGr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGr.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                int bookId = int.Parse(DataGr.Rows[e.RowIndex].Cells[0].Value.ToString());
                LoadSelectedBookDetails(bookId);
                panel2.Visible = true;
            }

        }
        private void LoadSelectedBookDetails(int bookId)
        {
            using (var dataContext = new LVNDataContext())
            {
                var bookDetails = dataContext.Saches.FirstOrDefault(s => s.MaSach == bookId);

                if (bookDetails != null)
                {
                    txtTenSach.Text = bookDetails.TenSach;
                    txtTenSach2.Text = bookDetails.TenSach;
                    txtTacGia.Text = bookDetails.TacGia;
                    txtTheLoai.Text = bookDetails.TheLoai;
                    txtNamXuatBan.Text = bookDetails.NamXuatBan.ToString();
                    txtGiaSach.Text = bookDetails.GiaSach.ToString();
                    txtSoLuong.Text = bookDetails.SoLuong.ToString();

                    panel2.Visible = true;
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var home = new Home();
            panel2.Visible = false;
            this.Close();
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Dữ liệu sẽ được cập nhật. Xác nhận?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    string tenSach = txtTenSach.Text.Trim();
                    string tenSach2 = txtTenSach2.Text.Trim();
                    string tacGia = txtTacGia.Text.Trim();
                    string theLoai = txtTheLoai.Text.Trim();
                    int namXuatBan = int.Parse(txtNamXuatBan.Text.Trim());
                    long giaSach = long.Parse(txtGiaSach.Text.Trim());
                    int soLuong = int.Parse(txtSoLuong.Text.Trim());

                    using (var dataContext = new LVNDataContext())
                    {
                        var sachToUpdate = dataContext.Saches.FirstOrDefault(s => s.TenSach == tenSach);

                        if (sachToUpdate != null)
                        {
                            sachToUpdate.TenSach = tenSach2;
                            sachToUpdate.TacGia = tacGia;
                            sachToUpdate.TheLoai = theLoai;
                            sachToUpdate.NamXuatBan = namXuatBan;
                            sachToUpdate.GiaSach = giaSach;
                            sachToUpdate.SoLuong = soLuong;

                            dataContext.SubmitChanges();
                            MessageBox.Show("Cập nhật thành công!");
                            LoadData();
                            panel2.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sách có tên này.");
                        }
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Dữ liệu nhập không hợp lệ! Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string TenSach = txtTenSach.Text.Trim();
            LVNDataContext data = new LVNDataContext();
            var books = from s in data.Saches
                        where s.TenSach.Contains(TenSach)
                        select s;

            DataGr.DataSource = books.ToList();
            panel2.Visible = false;
        }

        private void txtTenSach_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtTenSach.Text.Trim();
            LVNDataContext data = new LVNDataContext();

            var books = from b in data.Saches
                        where b.TenSach.Contains(searchTerm)
                        select b;

            DataGr.DataSource = books.ToList();
            panel2.Visible = false;
        }
    }
}
