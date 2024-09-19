namespace CpmDemoApp.Models
{
    public class Conversation
    {
        public string Id { get; set; }

        /// <summary>
        /// First inbound message from c2
        /// </summary>
        public Message IncomingMessage { get; set; }

        public List<string> SelectedAgentIds { get; set; }

        public List<Agent> SelectedAgents
        {
            get
            {
                return LiveChat.AgentLists.Where(agent => SelectedAgentIds.Contains(agent.Id)).ToList();
            }
        }

        /// <summary>
        /// Messages between C2 and agents
        /// </summary>
        public List<Message> Messages { get; set; } = new List<Message>();

    }
}
