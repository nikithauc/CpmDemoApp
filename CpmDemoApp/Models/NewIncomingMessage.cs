namespace CpmDemoApp.Models
{
    public class NewIncomingMessage
    {
        public string CustomerPhoneNumber { get; set; }

        public string MessageContent { get; set; }

        public AdvancedMessageAnalysisCompletedEventData Analysis { get; set; }

        public string AnalysisKeyword { get; set; }

        public DateTimeOffset ArrivalTime { get; set; }
    }
}
