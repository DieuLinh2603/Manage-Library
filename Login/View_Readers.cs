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
    public partial class View_Readers : Form
    {
        public View_Readers()
        {
            InitializeComponent();
            LoadData ();
            Data.CellClick += Data_CellClick;
        }
        public void LoadData()
        {
            LVNDataContext  data = new LVNDataContext();
            Data.DataSource = from i in data.DocGias
                              select i;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoThe.Text))
            {
                MessageBox.Show("Vui lòng nhập số thẻ để tìm kiếm!");
                return;
            }

            try
            {
                int SoThe = int.Parse(txtSoThe.Text.Trim());
                LVNDataContext data = new LVNDataContext();

                var result = from dg in data.DocGias
                             where dg.SoThe == SoThe
                             select dg;

                if (result.Any())
                {
                    Data.DataSource = result;
                    txtSoThe.Clear();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin với số thẻ này!");
                }
            }
            catch
            {
                MessageBox.Show("Số thẻ phải là một số hợp lệ!");
            }

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
            txtSoThe.Clear ();
            panel2.Hide();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoThe2.Text))
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập số thẻ để xóa!");
                return;
            }

            try
            {
                int sothe = int.Parse(txtSoThe2.Text.Trim());
                LVNDataContext data = new LVNDataContext();
                var delete = data.DocGias.FirstOrDefault(i => i.SoThe == sothe);

                if (delete != null)
                {
                    var deleteLichSu = data.LichSuMuonTraSaches.Where(z => z.SoThe == sothe);
                    data.DocGias.DeleteOnSubmit(delete);
                    data.LichSuMuonTraSaches.DeleteAllOnSubmit(deleteLichSu);
                    data.SubmitChanges();
                    LoadData();
                    MessageBox.Show("Xóa thành công!");
                    clear();
                }
                else
                {
                    MessageBox.Show("Không tồn tại số thẻ này!");
                }
            }
            catch
            {
                MessageBox.Show("Số thẻ phải là một số hợp lệ!");
            }

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoThe2.Text))
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập số thẻ để cập nhật!");
                return;
            }

            try
            {
                int sothe = int.Parse(txtSoThe2.Text.Trim());
                LVNDataContext data = new LVNDataContext();
                var update = data.DocGias.FirstOrDefault(i => i.SoThe == sothe);

                if (update != null)
                {
                    update.HoTen = txtHoTen.Text.Trim();
                    update.Email = txtEmail.Text.Trim();
                    update.Khoa = txtNganh.Text.Trim(); 
                    update.SDT = txtsdt.Text.Trim();
                    data.SubmitChanges();
                    LoadData();
                    MessageBox.Show("Cập nhật thành công!");
                }
                else
                {
                    MessageBox.Show("Không tồn tại số thẻ này!");
                }
            }
            catch
            {
                MessageBox.Show("Số thẻ phải là một số hợp lệ!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var home = new Home();
            this.Close();
            
        }

        private void Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel2.Show();
            // Kiểm tra dòng hợp lệ
            if (e.RowIndex >= 0 && e.RowIndex < Data.Rows.Count)
            {
                DataGridViewRow row = Data.Rows[e.RowIndex];

                // Gán giá trị vào các TextBox
                txtSoThe2.Text = row.Cells["SoThe"].Value?.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                txtNganh.Text = row.Cells["Nganh"].Value?.ToString();
                txtsdt.Text = row.Cells["SDT"].Value?.ToString();
            }
        }

        private void clear()
        {
            txtSoThe2.Text = string.Empty;
            txtHoTen.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtsdt.Text = string.Empty;
            txtNganh.Text = string.Empty;
        }

        private void View_Readers_Load(object sender, EventArgs e)
        {
            panel2.Hide();
        }
    }

}
