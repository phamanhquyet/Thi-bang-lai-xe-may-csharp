using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2364_PhamAnhQuyet_DOANCANHAN
{
    public partial class frm_Home : Form
    {
        public frm_Home()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frm_Home_Load(object sender, EventArgs e)
        {

        }

        private void btn_Deso1_Click(object sender, EventArgs e)
        {
            frm_BaiThi fBaiThi = new frm_BaiThi(1);
            fBaiThi.Show();

            this.Hide();
        }

        private void btn_Deso2_Click(object sender, EventArgs e)
        {
            frm_BaiThi fBaiThi = new frm_BaiThi(2);
            fBaiThi.Show();

            this.Hide();
        }

        private void btn_Deso3_Click(object sender, EventArgs e)
        {
            frm_BaiThi fBaiThi = new frm_BaiThi(3);
            fBaiThi.Show();

            this.Hide();
        }

        private void btn_Deso4_Click(object sender, EventArgs e)
        {
            frm_BaiThi fBaiThi = new frm_BaiThi(4);
            fBaiThi.Show();

            this.Hide();
        }
    }
}
