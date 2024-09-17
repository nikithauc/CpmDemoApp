namespace CpmDemoApp.Models
{
    public class Message
    {
        public bool IsFromReceiver{ get; set; }
        public string Text { get; set; } = null;
        public AdvancedMessageAnalysisCompletedEventData? Analysis { get; set; } = null;
    }
}