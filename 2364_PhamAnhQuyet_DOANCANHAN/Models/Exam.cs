using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2364_PhamAnhQuyet_DOANCANHAN.Models
{
    internal class Exam
    {
        public int ExamId { get; set; }
        public string ExamName { get; set; }
        public List<Question> Questions { get; set; }
    }
}
