using CpmDemoApp.Util;
using System.Linq.Expressions;

namespace CpmDemoApp.Models
{
    public static class LiveChat
    {
        public static IList<Message> MessagesListStatic { get; set; } = new List<Message> { new Message { Text = "hello", IsFromReceiver = true}, new Message { Text = "hello" } };

        public static IList<InboxItem> InboxListStatic { get; set; } = new List<InboxItem> 
        {
            new InboxItem
            {
                ArrivalTime = DateTime.Now,
                ConversationId = "123",
                Message = new Message {
                    Text = "hello",
                }, 
                AnalysisKeyword = IntentAnalysisUtil.KeywordForIntentAnalysis(new AdvancedMessageAnalysisCompletedEventData
                    {
                        IntentAnalysis = ("Support Request: The customer is expressing satisfaction with the product and is requesting assistance to place an additional order."),
                        KeyphraseExtraction = new List<string> { "love the product","order more"},
                    })
            },
            new InboxItem
            {
                ArrivalTime = DateTime.Now.AddDays(-2),
                ConversationId = "345",
                Message = new Message {
                    Text = "hello",
                },
                AnalysisKeyword = IntentAnalysisUtil.KeywordForIntentAnalysis(new AdvancedMessageAnalysisCompletedEventData
                    {
                        IntentAnalysis = ("Positive feedback: The customer is expressing satisfaction with the product."),
                        KeyphraseExtraction = new List<string> { "not happy", "product" },
                    })
            },
            new InboxItem
            {
                ArrivalTime = DateTime.Now.AddDays(-4),
                ConversationId = "335",
                Message = new Message {
                    Text = "hello there",
                },
                AnalysisKeyword = IntentAnalysisUtil.KeywordForIntentAnalysis(new AdvancedMessageAnalysisCompletedEventData
                    {
                        IntentAnalysis = ("Complaint: The customer is expressing dissatisfaction with the product they received."),
                        KeyphraseExtraction = new List<string> { "not happy", "product" },
                    })
            },
        };

        public static string CurrentPhoneNumber { get; set; }

        public static void RefreshInbox() 
        {
        }

        public static void UpdateLiveChatWindow() 
        {

        }
    }
}
