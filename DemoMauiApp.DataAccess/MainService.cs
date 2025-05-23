using DemoMauiApp.DataAccess.Configurations;
using DemoMauiApp.DataAccess.Interfaces;

namespace DemoMauiApp.DataAccess
{
    public class MainService : BaseService, IMainService
    {
        public MainService(MauiDbContext context) : base(context)
        {
        }
    }
}