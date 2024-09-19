using CpmDemoApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CpmDemoApp.Controllers
{
    [Route("EmployeePortal")]
    public class EmployeePortalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string Message)
        {
            //if (string.IsNullOrWhiteSpace(LiveChat.CurrentPhoneNumber)
            //    || (string.IsNullOrWhiteSpace(Message)))
            //{
            //    LiveChat.MessagesListStatic.Add(new Message
            //    {
            //        Text = "Please make sure you have put down phone number and either a text message or an image url.",
            //    });
            //    return View();
            //}

            //var recipientList = new List<string> { LiveChat.CurrentPhoneNumber };

            //try
            //{
            //    var textContent = new TextNotificationContent(_channelRegistrationId, recipientList, Message);
            //    await _notificationMessagesClient.SendAsync(textContent);
            //    LiveChat.MessagesListStatic.Add(new Message
            //    {
            //        Text = $"Sent a message to \"{LiveChat.CurrentPhoneNumber}\": \"{Message}\""
            //    });

            //}
            //catch (RequestFailedException e)
            //{
            //    LiveChat.MessagesListStatic.Add(new Message
            //    {
            //        Text = $"Message \"{Message}\" to \"{LiveChat.CurrentPhoneNumber}\" failed. Exception: {e.Message}"
            //    });
            //}

            ModelState.Remove(nameof(Message));

            return View();
        }

        [HttpPost]
        public IActionResult MessagesList()
        {
            return PartialView("ChatWindow");
        }

        [Route("list")]
        [HttpGet]
        public ActionResult List()
        {
            var list = new List<Conversation>();

            var conversation1 = new Conversation()
            {
                Id = "123",
                IncomingMessage = new Message { From = "+12323", MessageContent = "hello message" },
                SelectedAgentIds = new List<string> { "00", "11" }
            };
            var conversation2 = new Conversation()
            {
                Id = "2323",
                IncomingMessage = new Message { From = "+2323", MessageContent = "hello message 2" },
                SelectedAgentIds = new List<string> { "00", "11" }
            };

            list.Add(conversation1);
            list.Add(conversation2);

            return View("EmployeeConversationsList", list);
        }

        [Route("ConversationsPage")]
        public async Task<ActionResult> ConversationsPage(string id)
        {
            var conversation2 = new Conversation()
            {
                Id = "2323",
                IncomingMessage = new Message { From = "+2323", MessageContent = "hello message 2" },
                SelectedAgentIds = new List<string> { "00", "11" }
            };

            conversation2.Messages.Add(new Message { From = "+2323", MessageContent = "I am not happy" });
            conversation2.Messages.Add(new Message { From = "Agent1", MessageContent = "What is the issue" });
            conversation2.Messages.Add(new Message { From = "Me", MessageContent = "Are you still facing the issue?", IsSender = true });

            return View("ChatWindow", conversation2);
        }

        [Route("SendMessage")]
        [HttpPost]
        public async Task<ActionResult> ConversationsPage(string id, string message, string agentId)
        {
            //var payload = new RemoveEmployeesRequestPayload();

            ////foreach (var id in AgentIds)
            ////{
            ////}
            //var result = await LiveChat.ConversationManagementClient.RemoveAsync("", payload);
            return View("Result", "Successfully added employee");
        }

    }
}
