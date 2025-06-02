using DemoMauiApp.CoreMVVM.MVVM;
using DemoMauiApp.CoreMVVM.Navigation;
using DemoMauiApp.DataAccess.Models;
using System.Collections.ObjectModel;

namespace DemoMauiApp.Features.Pages.ViewModels
{
    public class ChatViewModel : BaseViewModel
    {
        public ObservableCollection<UserChat> UserChats { get; set; }
        public ObservableCollection<MessageChat> MessageChats { get; set; }
        public ChatViewModel(IAppNavigator appNavigator) : base(appNavigator)
        {
            UserChats = new ObservableCollection<UserChat>() {
                 new UserChat { ID = 1, Name = "Alice", ContentData = "Hi there!", LinkImage = "https://example.com/img1.jpg" },
                 new UserChat { ID = 2, Name = "Bob", ContentData = "Hello!", LinkImage = "https://example.com/img2.jpg" },
                 new UserChat { ID = 3, Name = "Charlie", ContentData = "How's it going?", LinkImage = "https://example.com/img3.jpg" },
                 new UserChat { ID = 4, Name = "David", ContentData = "Good morning!", LinkImage = "https://example.com/img4.jpg" },
                 new UserChat { ID = 5, Name = "Eva", ContentData = "What's up?", LinkImage = "https://example.com/img5.jpg" },
                 new UserChat { ID = 6, Name = "Frank", ContentData = "Nice to meet you!", LinkImage = "https://example.com/img6.jpg" },
                 new UserChat { ID = 7, Name = "Grace", ContentData = "Long time no see.", LinkImage = "https://example.com/img7.jpg" },
                 new UserChat { ID = 8, Name = "Helen", ContentData = "Catch you later!", LinkImage = "https://example.com/img8.jpg" },
                 new UserChat { ID = 9, Name = "Ian", ContentData = "See you tomorrow.", LinkImage = "https://example.com/img9.jpg" },
                 new UserChat { ID = 10, Name = "Jane", ContentData = "Have a nice day!", LinkImage = "https://example.com/img10.jpg" }
            };
            MessageChats = new ObservableCollection<MessageChat>()
            {
                new MessageChat { Id = 1, Content = "Hello!", CreatedAt = DateTime.Now.AddMinutes(-50), UserChatId = 1 },
                new MessageChat { Id = 2, Content = "Hi, how are you?", CreatedAt = DateTime.Now.AddMinutes(-48), UserChatId = 2 },
                new MessageChat { Id = 3, Content = "I'm fine, thanks!", CreatedAt = DateTime.Now.AddMinutes(-45), UserChatId = 1 },
                new MessageChat { Id = 4, Content = "What about you?", CreatedAt = DateTime.Now.AddMinutes(-44), UserChatId = 1 },
                new MessageChat { Id = 5, Content = "Doing great!", CreatedAt = DateTime.Now.AddMinutes(-43), UserChatId = 2 },
                new MessageChat { Id = 6, Content = "Let's meet tomorrow.", CreatedAt = DateTime.Now.AddMinutes(-40), UserChatId = 1 },
                new MessageChat { Id = 7, Content = "Sure, what time?", CreatedAt = DateTime.Now.AddMinutes(-38), UserChatId = 2 },
                new MessageChat { Id = 8, Content = "At 10 AM.", CreatedAt = DateTime.Now.AddMinutes(-36), UserChatId = 1 },
                new MessageChat { Id = 9, Content = "Perfect, see you then!", CreatedAt = DateTime.Now.AddMinutes(-35), UserChatId = 2 },
                new MessageChat { Id = 10, Content = "See you!", CreatedAt = DateTime.Now.AddMinutes(-34), UserChatId = 1,IsNewTime=true }
            };
        }
    }
}
