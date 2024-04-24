using CommunityToolkit.Mvvm.ComponentModel;

namespace WpfApp1.Model
{
    public partial class TextAttr : ObservableObject
    {
        [ObservableProperty]
        private string title;
    }
}
