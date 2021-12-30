using RegPozApp.Data;
using RegPozApp.Models;

namespace RegPozApp.Repositories
{
    public class FormRepository : GenericRepository<Form>
    {
        public FormRepository(DataContext context) : base(context)
        {
        }
    }
}
