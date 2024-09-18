using CpmDemoApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CpmDemoApp.Controllers
{
    [Route("conversation")]
    public class ConversationManagementController : Controller
    {
        [Route("createform")]
        public ActionResult CreateForm()
        {//string phoneNumber, string message

            return View("CreateConversation", new Conversation {
                IncomingMessage = new Message { From = "+12323", MessageContent = "hello message" }
            });
        }

        [Route("create")]
        [HttpPost]
        public ActionResult Create(Conversation model)
        {

            return View("CreateConversation", new Conversation
            {
                IncomingMessage = new Message { From = "+12323", MessageContent = "hello message" }
            });
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
                SelectedAgentIds = new List<string> { "00", "11"}
            };
            var conversation2 = new Conversation()
            {
                Id = "2323",
                IncomingMessage = new Message { From = "+2323", MessageContent = "hello message 2" },
                SelectedAgentIds = new List<string> { "00", "11" }
            };

            list.Add(conversation1);
            list.Add(conversation2);

            return View("ListConversation", list);
        }

        [Route("delete")]
        [HttpDelete]
        public ActionResult Delete(string id)
        {
            return View("List");
        }

        [Route("update")]
        [HttpPost]
        public ActionResult Update(Conversation model)
        {
            return RedirectToAction("Index");
        }

        [Route("AddEmployee")]
        [HttpPost]
        public ActionResult AddEmployee(Item item)
        {
            return RedirectToAction("Index");
        }

        [Route("RemoveEmployee")]
        [HttpPost]
        public ActionResult RemoveEmployee(Item item)
        {
            return RedirectToAction("Index");
        }
    }
}
