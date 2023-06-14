using _2364_PhamAnhQuyet_DOANCANHAN.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2364_PhamAnhQuyet_DOANCANHAN.Controllers
{
    internal class QuestionController 
    {
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        public List<Question> GetQuestionsFromDatabase(int examId)
        {
            List<Question> questions = new List<Question>();
            using (SqlConnection connection = new SqlConnection(lopchung.StrConn))
            {
                connection.Open();

                // Truy vấn cơ sở dữ liệu để lấy danh sách câu hỏi
                string query = "SELECT question_id, question_text, answer_1, answer_2, answer_3, answer_4, correct_answer FROM Questions WHERE exam_id = @examId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@examId", examId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Question question = new Question();
                            question.QuestionId = (int)reader["question_id"];
                            question.QuestionText = (string)reader["question_text"];
                            question.Answer1 = (string)reader["answer_1"];
                            question.Answer2 = (string)reader["answer_2"];
                            question.Answer3 = (string)reader["answer_3"];
                            question.Answer4 = (string)reader["answer_4"];
                            question.CorrectAnswer = (int)reader["correct_answer"];

                            questions.Add(question);
                        }
                    }
                }
            }

            return questions;
        }
    }
}
