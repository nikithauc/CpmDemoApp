namespace CpmDemoApp.Models
{
    public class Conversation
    {
        public string Id { get; set; }
        public Message IncomingMessage { get; set; }

        public List<string> SelectedAgentIds { get; set; }

    }
}
