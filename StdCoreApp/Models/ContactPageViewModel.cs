using StdCoreApp.Application.ViewModels.Common;

namespace StdCoreApp.Models
{
    public class ContactPageViewModel
    {
        public ContactViewModel Contact { set; get; }

        public FeedbackViewModel Feedback { set; get; }
    }
}