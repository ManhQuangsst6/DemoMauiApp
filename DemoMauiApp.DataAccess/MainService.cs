using DemoMauiApp.DataAccess.Configurations;
using DemoMauiApp.DataAccess.Interfaces;
using DemoMauiApp.DataAccess.Models;
using Microsoft.Extensions.Configuration;

namespace DemoMauiApp.DataAccess
{
    public class MainService : BaseService, IMainService
    {
        private readonly IConfiguration _configuration;

        public MainService(MauiDbContext context, IConfiguration configuration) : base(context)
        {
            _configuration = configuration;
        }
        public List<PlayLists> GetPlayLists()
        {
            return new List<PlayLists>()
            {
                new PlayLists
                {
                    Id = 1,
                    Name = "Pop Hits",
                    Description = "Top pop songs",
                    LinkImage = "https://m.yodycdn.com/blog/anh-dep-3d-yodyvn4.jpg"
                },
                new PlayLists
                {
                    Id = 2,
                    Name = "Lo-Fi Chill",
                    Description = "Relaxing lofi music",
                    LinkImage = "https://m.yodycdn.com/blog/anh-dep-3d-yodyvn4.jpg"
                },
                new PlayLists
                {
                    Id = 3,
                    Name = "Workout Mix",
                    Description = "Energizing songs for workout",
                    LinkImage = "https://m.yodycdn.com/blog/anh-dep-3d-yodyvn4.jpg"
                },
                new PlayLists
                {
                    Id = 4,
                    Name = "Classical Essentials",
                    Description = "Best classical pieces",
                    LinkImage = "https://m.yodycdn.com/blog/anh-dep-3d-yodyvn4.jpg"
                },
            };

        }
        public List<Artist> GetArtist()
        {
            return new List<Artist>()
            {
                new Artist
                {
                    Id = 1,
                    Name = "Pop Hits",
                    Description = "Top ",
                    LinkImage = "https://m.yodycdn.com/blog/anh-dep-3d-yodyvn4.jpg"
                },
                new Artist
                {
                    Id = 2,
                    Name = "Lo-Fi Chill",
                    Description = "Relaxing ",
                    LinkImage = "https://m.yodycdn.com/blog/anh-dep-3d-yodyvn4.jpg"
                },
                new Artist
                {
                    Id = 3,
                    Name = "Workout Mix",
                    Description = "Energizing s",
                    LinkImage = "https://m.yodycdn.com/blog/anh-dep-3d-yodyvn4.jpg"
                },
                new Artist
                {
                    Id = 4,
                    Name = "Classical Essentials",
                    Description = "Best class",
                    LinkImage = "https://m.yodycdn.com/blog/anh-dep-3d-yodyvn4.jpg"
                },
                new Artist
                {
                    Id = 5,
                    Name = "Test",
                    Description = "Best class",
                    LinkImage = "https://m.yodycdn.com/blog/anh-dep-3d-yodyvn4.jpg"
                },
            };

        }
    }
}