using ControllerMonitor.Utils.Encrypted;
using DemoMauiApp.DataAccess.Models;
using DemoMauiApp.Utils.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Serilog;

namespace DemoMauiApp.DataAccess.Configurations
{
    public class MauiDbContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public MauiDbContext(DbContextOptions<MauiDbContext> options)
            : base(options)
        {

        }
        public MauiDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                var databaseSettings = _configuration.GetSection("DatabaseSettings").Get<DatabaseSettingModel>();
                string password = databaseSettings.DatabasePassword;
                if (!string.IsNullOrEmpty(databaseSettings.DatabaseEncryptPassword))
                {
                    password = EncryptionHelper.AesDecrypt(databaseSettings.DatabaseEncryptPassword, Consts.EncryptKey, Consts.EncryptIV);
                }
                var connectionString = $"Server={databaseSettings.ServerName},{databaseSettings.Port};" +
                                           $"Database={databaseSettings.DatabaseName};" +
                                           $"User Id={databaseSettings.DatabaseUser};" +
                                           $"Password={password};" +
                                           $"TrustServerCertificate=true";
                optionsBuilder.UseSqlServer(connectionString);
            }
            catch (Exception exception)
            {
                Log.Error(exception.StackTrace);
            }
        }
    }
}
