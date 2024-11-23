using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

                // Kiểm tra số thẻ phải là số
                if (!int.TryParse(txtSoThe.Text.Trim(), out int sothe))
                {
                    MessageBox.Show("Số thẻ phải là số nguyên hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra họ tên phải là chữ
                if (!IsAlphabetic(txtHoTen.Text.Trim()))
                {
                    MessageBox.Show("Họ tên chỉ được chứa chữ cái.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra ngành phải là chữ
                if (!IsAlphabetic(txtNganh.Text.Trim()))
                {
                    MessageBox.Show("Ngành chỉ được chứa chữ cái.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra số điện thoại phải là số
                if (!Regex.IsMatch(txtSdt.Text.Trim(), @"^\d+$"))
                {
                    MessageBox.Show("Số điện thoại chỉ được chứa số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra định dạng email
                if (!IsValidEmail(txtEmail.Text.Trim()))
                {
                    MessageBox.Show("Email không hợp lệ. Vui lòng nhập email đúng định dạng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private bool IsAlphabetic(string input)
        {
            // Kiểm tra chuỗi chỉ chứa chữ cái (bao gồm cả dấu cách)
            return Regex.IsMatch(input, @"^[a-zA-Z\s]+$");
        }

        private bool IsValidEmail(string email)
        {
            // Kiểm tra định dạng email
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
    }
}
