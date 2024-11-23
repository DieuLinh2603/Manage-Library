using System;
using System.Linq;
using System.Windows.Forms;

namespace Login
{
    public partial class Add_Book : Form
    {
        public Add_Book()
        {
            InitializeComponent();
            // Đặt giá trị mặc định cho ô số lượng là 1 khi form được khởi tạo
            txtSoLuong.Text = "1";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra các ô nhập liệu không rỗng
            if (txtTenSach.Text != "" && txtTacGia.Text != "" && txtTheLoai.Text != "" && txtNamXuatBan.Text != "" && txtGiaSach.Text != "")
            {
                string tensach = txtTenSach.Text;
                string tacgia = txtTacGia.Text;
                string theloai = txtTheLoai.Text;

                // Kiểm tra định dạng năm xuất bản
                if (!int.TryParse(txtNamXuatBan.Text, out int namxuatban))
                {
                    MessageBox.Show("Năm xuất bản không hợp lệ. Vui lòng nhập lại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra định dạng giá sách
                if (!long.TryParse(txtGiaSach.Text, out long gia))
                {
                    MessageBox.Show("Giá sách không hợp lệ. Vui lòng nhập lại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra định dạng số lượng, nếu không nhập thì mặc định là 1
                int soluong;
                if (!int.TryParse(txtSoLuong.Text, out soluong) || soluong <= 0)
                {
                    MessageBox.Show("Số lượng phải là số và lớn hơn 0.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSoLuong.Text = "1"; // Nếu không hợp lệ, gán lại giá trị mặc định
                    return;
                }

                using (var dataContext = new LVNDataContext())
                {
                    // Kiểm tra xem sách đã có trong kho chưa
                    var existingBook = dataContext.Saches.FirstOrDefault(s => s.TenSach == tensach && s.TacGia == tacgia);

                    if (existingBook != null)
                    {
                        // Sách đã tồn tại, cộng thêm số lượng
                        existingBook.SoLuong += soluong;
                        MessageBox.Show("Sách đã có trong kho. Đã cộng thêm số lượng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Tạo đối tượng sách mới
                        Sach newBook = new Sach
                        {
                            TenSach = tensach,
                            TacGia = tacgia,
                            TheLoai = theloai,
                            NamXuatBan = namxuatban,
                            GiaSach = gia,
                            SoLuong = soluong
                        };

                        // Thêm sách mới vào bảng
                        dataContext.Saches.InsertOnSubmit(newBook);
                        MessageBox.Show("Dữ liệu đã được lưu.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    dataContext.SubmitChanges();
                }
            }
            else
            {
                MessageBox.Show("Không được để trống các ô nhập liệu.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var home = new Home();
            this.Close();
        }
    }
}
