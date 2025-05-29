using DemoMauiApp.CoreMVVM.MVVM;
using DemoMauiApp.CoreMVVM.Navigation;
using DemoMauiApp.DataAccess.Models;
using System.Collections.ObjectModel;

namespace DemoMauiApp.Features.Pages.ViewModels
{
    public class DashboardViewModel : BaseViewModel
    {
        public DashboardViewModel(IAppNavigator appNavigator) : base(appNavigator)
        {
            this.Data = GetCategoricalData();
            this.TrafficSources = new ObservableCollection<TrafficSource>
                 {
                      new TrafficSource { Source = "website.net", Sessions = 4321, Change = "+84%" },
                      new TrafficSource { Source = "website.net", Sessions = 4033, Change = "-8%" },
                      new TrafficSource { Source = "website.net", Sessions = 3128, Change = "+2%" },
                      new TrafficSource { Source = "website.net", Sessions = 2104, Change = "+33%" },
                      new TrafficSource { Source = "website.net", Sessions = 2003, Change = "+30%" },
                      new TrafficSource { Source = "website.net", Sessions = 1894, Change = "+15%" },
                      new TrafficSource { Source = "website.net", Sessions = 405,  Change = "-12%" }
                 };
            this.TemporalDatas = GetDateTimeData(6);
            this.Emails = GetEmails();
        }
        public ObservableCollection<CategoricalData> Data { get; set; }
        public ObservableCollection<TrafficSource> TrafficSources { get; set; }
        public ObservableCollection<TemporalData> TemporalDatas { get; set; }
        public ObservableCollection<EmailModel> Emails { get; set; }

        private static ObservableCollection<CategoricalData> GetCategoricalData()
        {
            var monthlyData = new ObservableCollection<CategoricalData>
                {
                    new CategoricalData { Category = "Jan", Value = 1200 },
                    new CategoricalData { Category = "Feb", Value = 980 },
                    new CategoricalData { Category = "Mar", Value = 1350 },
                    new CategoricalData { Category = "Apr", Value = 1100 },
                    new CategoricalData { Category = "May", Value = 1450 },
                    new CategoricalData { Category = "Jun", Value = 1250 },
                    new CategoricalData { Category = "Jul", Value = 1380 },
                    new CategoricalData { Category = "Aug", Value = 1420 },
                    new CategoricalData { Category = "Sep", Value = 1190 },
                    new CategoricalData { Category = "Oct", Value = 1510 },
                    new CategoricalData { Category = "Nov", Value = 990 },
                    new CategoricalData { Category = "Dec", Value = 1600 },
                };

            return monthlyData;
        }
        private static ObservableCollection<TemporalData> GetDateTimeData(int itemsCount)
        {
            var startDate = new DateTime(2024, 03, 01);

            ObservableCollection<TemporalData> items = new ObservableCollection<TemporalData>();
            for (int i = 0; i < itemsCount; i++)
            {
                TemporalData data = new TemporalData();
                data.Date = startDate.AddDays(i);
                data.Value = Math.Sin(i);

                items.Add(data);
            }

            return items;
        }
        public ObservableCollection<EmailModel> GetEmails()
        {
            return new ObservableCollection<EmailModel>
        {
            new EmailModel { Id = 1, Name = "Alice Johnson", EmailAddress = "alice@example.com", ImageUrl = "https://example.com/images/alice.png" },
            new EmailModel { Id = 2, Name = "Bob Smith", EmailAddress = "bob@example.com", ImageUrl = "https://example.com/images/bob.png" },
            new EmailModel { Id = 3, Name = "Carol Davis", EmailAddress = "carol@example.com", ImageUrl = "https://example.com/images/carol.png" },
            new EmailModel { Id = 4, Name = "David Brown", EmailAddress = "david@example.com", ImageUrl = "https://example.com/images/david.png" },
            new EmailModel { Id = 5, Name = "Eva Green", EmailAddress = "eva@example.com", ImageUrl = "https://example.com/images/eva.png" }
        };
        }
    }
}
