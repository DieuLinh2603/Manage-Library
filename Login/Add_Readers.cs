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
    public partial class Add_Readers : Form
    {
        public Add_Readers()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var home = new Home();
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu nhập vào
                if (string.IsNullOrWhiteSpace(txtSoThe.Text) ||
                    string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtSdt.Text) ||
                    string.IsNullOrWhiteSpace(txtNganh.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin độc giả.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra số thẻ có hợp lệ hay không
                if (!int.TryParse(txtSoThe.Text.Trim(), out int sothe))
                {
                    MessageBox.Show("Số thẻ phải là số nguyên hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                // Kết nối với database
                LVNDataContext data = new LVNDataContext();

                // Kiểm tra số thẻ đã tồn tại chưa
                DocGia check = (from i in data.DocGias
                                where i.SoThe == sothe
                                select i).FirstOrDefault();

                if (check != null)
                {
                    MessageBox.Show("Số thẻ này đã tồn tại. Vui lòng nhập số thẻ khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo mới độc giả
                DocGia add = new DocGia
                {
                    SoThe = sothe,
                    HoTen = txtHoTen.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    SDT = txtSdt.Text.Trim(),
                    Khoa = txtNganh.Text.Trim()
                };

                // Thêm vào database
                data.DocGias.InsertOnSubmit(add);
                data.SubmitChanges();

                // Hiển thị thông báo thành công
                MessageBox.Show("Thêm độc giả thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Xóa trắng các ô nhập
                ClearInput();
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu xảy ra
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInput()
        {
            // Xóa dữ liệu trên các ô nhập
            txtSoThe.Text = string.Empty;
            txtHoTen.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSdt.Text = string.Empty;
            txtNganh.Text = string.Empty;
        }
    }
}
