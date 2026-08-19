using System.Windows;

namespace AlertModule
{
    public partial class AlertsWindow : Window
    {
        private readonly AlertManager _manager = new AlertManager();
        private int _sampleCounter = 1;

        public AlertsWindow()
        {
            InitializeComponent();
            _manager.SeedDemoAlerts();
            AlertsListBox.ItemsSource = _manager.Alerts;
        }

        private void AddHigh_Click(object sender, RoutedEventArgs e) => AddSampleAlert(AlertPriority.High);
        private void AddMedium_Click(object sender, RoutedEventArgs e) => AddSampleAlert(AlertPriority.Medium);
        private void AddLow_Click(object sender, RoutedEventArgs e) => AddSampleAlert(AlertPriority.Low);

        private void AddSampleAlert(AlertPriority priority)
        {
            var alert = new Alert($"Sample {priority} alert #{_sampleCounter++}", priority);
            _manager.AddAlert(alert);
        }

        private void ClearAll_Click(object sender, RoutedEventArgs e)
        {
            _manager.ClearAll();
        }
    }
}
