using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_AiLaTrieuPhu.A_DAL;

namespace Game_AiLaTrieuPhu.B_BUS
{
    
    internal class GameServices
    {
        Repositorties repos;
        public GameServices()
        {
            repos = new Repositorties();
        }
        //1.hàm random câu hỏi để load vào form
        public Question RamdomQuestion(int level)
        {
            //b1 lấy danh sách câu hỏi
            var listQuestion = repos.GetAllQuestion();
            //b2 lấy ra những câu hỏi trong lv đó
            var questionLV = listQuestion.Where(x => x.Level == level).ToList();
            //random ra 1 câu hỏi trong lv đó
            Random r = new Random();
            int index = r.Next(questionLV.Count);//random trong khoảng số lượng câu hỏi lv
            return questionLV[index];
        }
        public int countNumber(int level)
        {
            return repos.GetAllQuestion().Where(x=>x.Level == level).Count();
        }
        //2.Check xen câu hỏi đã đúng hay chưa
        public bool checkDapan(int questionId, string ansewr) {
            //lấy câu hỏi theo id
            var question = repos.GetAllQuestion().FirstOrDefault(p=>p.Id == questionId);
            //kiểm tra xem cau trả lời đúng có giống với đáp án hay k
            return question.TrueAnswer == ansewr;
        }
        public string GetTrueAnswer(int QuestionId)
        {
            return repos.GetAllQuestion().FirstOrDefault(p => p.Id == QuestionId).TrueAnswer;
        }

    }
}
