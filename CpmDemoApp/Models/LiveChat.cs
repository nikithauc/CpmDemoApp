using Azure.Communication.Messages;
using CpmDemoApp.Util;
using System.Linq.Expressions;

namespace CpmDemoApp.Models
{
    public static class LiveChat
    {
        public static IList<NewIncomingMessage> NewIncomingMessagesListStatic { get; set; } = new List<NewIncomingMessage> 
        {
            new NewIncomingMessage
            {
                ArrivalTime = DateTime.Now,
                MessageContent = "How can I order more of the product?",
                AnalysisKeyword = IntentAnalysisUtil.KeywordForIntentAnalysis(new AdvancedMessageAnalysisCompletedEventData
                    {
                        IntentAnalysis = ("Support Request: The customer is expressing satisfaction with the product and is requesting assistance to place an additional order."),
                        KeyphraseExtraction = new List<string> { "love the product","order more"},
                    }),
                CustomerPhoneNumber = "+1234567",
                Analysis = new AdvancedMessageAnalysisCompletedEventData
                    {
                        IntentAnalysis = ("Support Request: The customer is expressing satisfaction with the product and is requesting assistance to place an additional order."),
                        KeyphraseExtraction = new List<string> { "love the product","order more"},
                    }
            },
            new NewIncomingMessage
            {
                ArrivalTime = DateTime.Now.AddDays(-2),
                MessageContent = "Happy with the product",
                AnalysisKeyword = IntentAnalysisUtil.KeywordForIntentAnalysis(new AdvancedMessageAnalysisCompletedEventData
                    {
                        IntentAnalysis = ("Positive feedback: The customer is expressing satisfaction with the product."),
                        KeyphraseExtraction = new List<string> { "not happy", "product" },
                    }),
                CustomerPhoneNumber = "+234568",
                Analysis = new AdvancedMessageAnalysisCompletedEventData
                    {
                        IntentAnalysis = ("Positive feedback: The customer is expressing satisfaction with the product."),
                        KeyphraseExtraction = new List<string> { "not happy", "product" },
                    }
            },
            new NewIncomingMessage
            {
                ArrivalTime = DateTime.Now.AddDays(-2),
                MessageContent = "I am unhappy with the product",
                AnalysisKeyword = IntentAnalysisUtil.KeywordForIntentAnalysis(new AdvancedMessageAnalysisCompletedEventData
                    {
                        IntentAnalysis = ("Complaint: The customer is expressing dissatisfaction with the product they received."),
                        KeyphraseExtraction = new List<string> { "not happy", "product" },
                    }),
                CustomerPhoneNumber = "+234568",
                Analysis = new AdvancedMessageAnalysisCompletedEventData
                    {
                        IntentAnalysis = ("Complaint: The customer is expressing dissatisfaction with the product they received."),
                        KeyphraseExtraction = new List<string> { "not happy", "product" },
                    }
            },
        };

        public static HashSet<string> ExistingPhoneNumbers { get; set; }

        public static List<Agent> AgentLists = new List<Agent>
        {
            new Agent { Id = "00", Name = "Agent0" },
            new Agent { Id = "11", Name = "Agent1" },
            new Agent { Id = "22", Name = "Agent2" },
            new Agent { Id = "33", Name = "Agent3" },
            new Agent { Id = "44", Name = "Agent4" },
            new Agent { Id = "55", Name = "Agent5" },
        };

        //public static ConversationManagementClient ConversationManagementClient { get; set; } = new ConversationManagementClient("endpoint=FakeEndpoint;accessKey=FakeAccess");

        //public static ConversationMessagesClient ConversationMessagesClient { get; set; } = new ConversationMessagesClient("endpoint=FakeEndpoint;accessKey=FakeAccess");
    }
}
