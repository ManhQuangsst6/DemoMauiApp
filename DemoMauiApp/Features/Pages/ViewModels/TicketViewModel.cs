using DemoMauiApp.CoreMVVM.MVVM;
using DemoMauiApp.CoreMVVM.Navigation;
using DemoMauiApp.DataAccess.Models;
using System.Collections.ObjectModel;

namespace DemoMauiApp.Features.Pages.ViewModels
{
    public class TicketViewModel : BaseViewModel
    {
        public TicketViewModel(IAppNavigator appNavigator) : base(appNavigator)
        {
            Tasks = new ObservableCollection<TaskItem>
                {
                    new TaskItem { Id = "FIG-123", Title = "Task 1", Project = "Project 1", Priority = "High", Date = new DateTime(2023, 12, 5) },
                    new TaskItem { Id = "FIG-122", Title = "Task 2", Project = "Acme GTM", Priority = "Low", Date = new DateTime(2023, 12, 5) },
                    new TaskItem { Id = "FIG-121", Title = "Write blog post for demo day", Project = "Acme GTM", Priority = "High", Date = new DateTime(2023, 12, 5) },
                    new TaskItem { Id = "FIG-120", Title = "Publish blog page", Project = "Website launch", Priority = "Low", Date = new DateTime(2023, 12, 5) },
                    new TaskItem { Id = "FIG-119", Title = "Add gradients to design system", Project = "Design backlog", Priority = "Medium", Date = new DateTime(2023, 12, 5) },
                    new TaskItem { Id = "FIG-118", Title = "Responsive behavior doesn’t work on Android", Project = "Bug fixes", Priority = "Medium", Date = new DateTime(2023, 12, 5) },
                    new TaskItem { Id = "FIG-117", Title = "Confirmation states not rendering properly", Project = "Bug fixes", Priority = "Medium", Date = new DateTime(2023, 12, 5) },
                    new TaskItem { Id = "FIG-116", Title = "Text wrapping is awkward on older iPhones", Project = "Bug fixes", Priority = "Low", Date = new DateTime(2023, 12, 5) },
                    new TaskItem { Id = "FIG-115", Title = "Revise copy on About page", Project = "Website launch", Priority = "Low", Date = new DateTime(2023, 12, 5) },
                    new TaskItem { Id = "FIG-114", Title = "Publish HackerNews post", Project = "Acme GTM", Priority = "Low", Date = new DateTime(2023, 12, 5) },
                    new TaskItem { Id = "FIG-113", Title = "Review image licensing for header section images", Project = "Website launch", Priority = "High", Date = new DateTime(2023, 12, 5) },
                    new TaskItem { Id = "FIG-112", Title = "Accessibility focused state for input fields", Project = "Design backlog", Priority = "High", Date = new DateTime(2023, 12, 5) },
                    new TaskItem { Id = "FIG-111", Title = "Header IA revision to support addition of blog page", Project = "Design backlog", Priority = "High", Date = new DateTime(2023, 12, 5) },
                    new TaskItem { Id = "FIG-110", Title = "Press outbound", Project = "Acme GTM", Priority = "Medium", Date = new DateTime(2023, 12, 5) }
                };

        }
        public ObservableCollection<TaskItem> Tasks { get; set; }

    }
}
