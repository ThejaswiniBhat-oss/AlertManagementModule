using System.Collections.ObjectModel;

namespace AlertModule
{
    public enum AlertPriority
    {
        High,
        Medium,
        Low
    }

    public class Alert
    {
        public string Message { get; }
        public AlertPriority Priority { get; }

        public Alert(string message, AlertPriority priority)
        {
            Message = message;
            Priority = priority;
        }
    }

    public class AlertManager
    {
        public const int Capacity = 7;

        public ObservableCollection<Alert> Alerts { get; } = new ObservableCollection<Alert>();

        public void SeedDemoAlerts()
        {
            Alerts.Add(new Alert("Server CPU usage above 95%", AlertPriority.High));
            Alerts.Add(new Alert("Database replication lag critical", AlertPriority.High));
            Alerts.Add(new Alert("Payment service unresponsive", AlertPriority.High));
            Alerts.Add(new Alert("Disk usage above 80%", AlertPriority.Medium));
            Alerts.Add(new Alert("API latency elevated", AlertPriority.Medium));
            Alerts.Add(new Alert("New software update available", AlertPriority.Low));
            Alerts.Add(new Alert("Scheduled maintenance reminder", AlertPriority.Low));
        }

        
        public void AddAlert(Alert newAlert)
        {
            Alerts.Insert(0, newAlert);

            if (Alerts.Count > Capacity)
            {
                Alerts.RemoveAt(Alerts.Count - 1);
            }
        }

        public void ClearAll()
        {
            Alerts.Clear();
        }
    }
}
