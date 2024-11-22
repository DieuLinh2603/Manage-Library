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
        public History_Book()
        {
            InitializeComponent();
        }
        public void loadData()
        {
            LVNDataContext data = new LVNDataContext();
            dataGridView1.DataSource = from i in data.LichSuMuonTraSaches
                                       select i;
        }
        private void History_Book_Load(object sender, EventArgs e)
        {

        }
    }
}
