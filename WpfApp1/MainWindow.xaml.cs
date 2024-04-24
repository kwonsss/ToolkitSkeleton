using CommunityToolkit.Mvvm.Input;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WpfApp1.Model;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public TextModel TextModel  { get; set; }
        public TextMvvm TextMvvm    { get; set; }


        public ICommand Button2Command { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            TextModel = new TextModel();
            TextMvvm = new TextMvvm();

            Button2Command = new RelayCommand<object>(Button2Run);

            this.DataContext = this;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Button2Run(object o)
        {
            MessageBox.Show("2");
        }

        [RelayCommand]
        private void Button(string user)
        {
            MessageBox.Show("3");
        }
    }
}