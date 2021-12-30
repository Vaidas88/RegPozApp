using Microsoft.EntityFrameworkCore;
using RegPozApp.Data;
using RegPozApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace RegPozApp.Repositories
{
    public class QuestionRepository : GenericRepository<Question>
    {
        public QuestionRepository(DataContext context) : base(context)
        {
        }

        public override List<Question> GetAll()
        {
            return _dbSet.Include(q => q.Answers).ToList();
        }
    }
}
