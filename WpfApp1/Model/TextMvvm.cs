using CommunityToolkit.Mvvm.ComponentModel;

namespace WpfApp1.Model
{
    public class TextMvvm : ObservableObject
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
    }
}
