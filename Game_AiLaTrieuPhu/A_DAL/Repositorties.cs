using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_AiLaTrieuPhu.A_DAL
{
    internal class Repositorties
    {
        //repo này để load câu hỏi
        GameDbContext context;
        public Repositorties()
        {
            context = new GameDbContext();
        }
        public List<Question> GetAllQuestion()
        {
            return context.Questions.ToList();
        }
    }
}
