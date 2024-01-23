using ERP_APP.Contracts;
using ERP_APP.Data;

namespace ERP_APP.Repository
{
    public class LaborCategoriesRepository : GenericRepository<LaborCategory>, ILaborCategoriesRepository
    {
        public LaborCategoriesRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
