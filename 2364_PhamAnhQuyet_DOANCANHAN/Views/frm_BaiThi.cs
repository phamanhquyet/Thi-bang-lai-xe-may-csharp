using _2364_PhamAnhQuyet_DOANCANHAN.Models;
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
    public partial class frm_BaiThi : Form
    {
        private Exam exam;
        private int curentQuestionIndex = 0;
        private int selectedExamId;
        public frm_BaiThi(int examId)
        {
            InitializeComponent();
            selectedExamId = examId;
        }

        private void frm_BaiThi_Load(object sender, EventArgs e)
        {
            List<Question> questions = new List<Question>();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
