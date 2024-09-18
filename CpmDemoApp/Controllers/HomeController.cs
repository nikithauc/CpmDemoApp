using Azure;
using Azure.Communication.Messages;
using CpmDemoApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace CpmDemoApp.Controllers
{
    public class HomeController : Controller
    {
        private static bool _clientInitialized;
        private static NotificationMessagesClient _notificationMessagesClient;
        private static Guid _channelRegistrationId;

        public HomeController(IOptions<ClientOptions> options)
        {
            if (!_clientInitialized)
            {
                _channelRegistrationId = Guid.Parse(options.Value.ChannelRegistrationId);
                _notificationMessagesClient = new NotificationMessagesClient(options.Value.ConnectionString);
                _clientInitialized = true;
            }
        }

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
    }
}