using CpmDemoApp.Models;

namespace CpmDemoApp.Util
{
    public static class IntentAnalysisUtil
    {
        public static string KeywordForIntentAnalysis(AdvancedMessageAnalysisCompletedEventData analysis)
        {
            string result = "unknown";
            switch (analysis.IntentAnalysis.ToLower())
            {
                case string intent when intent.Contains("positive"):
                    // Handle positive intent
                    result = "reviews";
                    Console.WriteLine("Positive intent detected.");
                    break;
                case string intent when intent.Contains("complaint"):
                    // Handle complaint intent
                    result = "reviews";
                    Console.WriteLine("Complaint intent detected.");
                    break;
                case string intent when intent.Contains("request") || intent.Contains("order"):
                    // Handle request intent
                    Console.WriteLine("Request intent detected.");
                    result = "order";
                    break;
                default:
                    // Handle unknown intent
                    result = "unknown";
                    Console.WriteLine("Unknown intent detected.");
                    break;
            }

            return result;
        }
    }
}
