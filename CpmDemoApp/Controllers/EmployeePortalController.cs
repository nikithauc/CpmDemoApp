using Microsoft.AspNetCore.Mvc;

namespace CpmDemoApp.Controllers
{
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
    }
}
