using MvvmCross.Core.ViewModels;

namespace BasicApp.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private string _title = "Hello MainViewModel";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
    }
}
