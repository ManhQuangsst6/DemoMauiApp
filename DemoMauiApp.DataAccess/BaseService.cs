using DemoMauiApp.DataAccess.Configurations;

namespace DemoMauiApp.DataAccess
{
    public abstract class BaseService
    {
        protected readonly MauiDbContext _context;

        protected BaseService(MauiDbContext context)
        {
            _context = context;
        }
    }
}
