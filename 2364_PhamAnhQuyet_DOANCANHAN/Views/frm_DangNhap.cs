using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2364_PhamAnhQuyet_DOANCANHAN
{
    public partial class frm_DangNhap : Form
    {
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string sql = $"SELECT COUNT(*) FROM Users WHERE username = '{txt_Username}' AND password = '{txt_password}'";
            int result = lopchung.ExecuteNonQuery(sql);
            if (result == 0)
            {
                MessageBox.Show("Đăng nhập thất bại.");
            }
            else
            {
                MessageBox.Show("Đăng nhập thành công");
                frm_Home home = new frm_Home();
                home.Show();
                this.Hide();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
