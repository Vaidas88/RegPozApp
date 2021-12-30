using RegPozApp.Data;
using RegPozApp.Models;

namespace RegPozApp.Repositories
{
    public class AnswerRepository : GenericRepository<Answer>
    {
        public AnswerRepository(DataContext context) : base(context)
        {
        }
    }
}
