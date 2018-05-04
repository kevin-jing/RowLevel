using System.Collections.ObjectModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace RowLevel
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public ObservableCollection<Data> MonitorViews { get; } = new ObservableCollection<Data>();

        public MainPage()
        {
            this.InitializeComponent();

            MonitorViews.Add(new Data { Country = "India", Capital = "New Delhi" });
            MonitorViews.Add(new Data { Country = "South Africa", Capital = "Cape Town" });
            MonitorViews.Add(new Data { Country = "Nigeria", Capital = "Abuja" });
            MonitorViews.Add(new Data { Country = "Singapore", Capital = "Singapore" });
        }

        private void NewMonitor_Click(object sender, RoutedEventArgs e)
        {
            MonitorViews[0].Country = "China";
        }
    }
    public class Data : BindableBase
    {
        private string _country;
        public string Country
        {
            get => _country;
            set => SetProperty(ref _country, value);
        }

        public string Capital { get; set; }
    }
}
