namespace CpmDemoApp.Models
{
    public class InboxItem
    {
        public DateTime ArrivalTime{ get; set; }

        public Message Message { get; set; } = new Message();

        public string AnalysisKeyword { get; set; } = "default";

        public string ConversationId { get; set; }
    }
}
