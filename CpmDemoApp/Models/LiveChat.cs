namespace CpmDemoApp.Models
{
    public class LiveChat
    {
        public static IList<Message> MessagesListStatic { get; set; } = new List<Message> { new Message { Text = "hello", IsFromReceiver = true}, new Message { Text = "hello" } };
    }
}
