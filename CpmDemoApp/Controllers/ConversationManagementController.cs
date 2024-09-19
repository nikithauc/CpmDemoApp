using Azure.Communication.Messages;
using CpmDemoApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CpmDemoApp.Controllers
{
    [Route("conversation")]
    public class ConversationManagementController : Controller
    {
        [Route("createform")]
        public ActionResult CreateForm(Message message)
        {
            return View("CreateConversation", new Conversation {
                IncomingMessage = message
            });
        }

        [Route("create")]
        [HttpPost]
        public ActionResult Create(Conversation model)
        {
            var result = "";
            if (true) 
            {
                result = "Successfully created the conversation. Coversation id is 123";

            }
            return View("Result", result);
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
        [HttpPost]
        public ActionResult Delete(string id)
        {
            return View("Result", "Successfully Deleted");
        }

        [Route("update")]
        [HttpPost]
        public ActionResult Update(Conversation model)
        {
            return View("Result");
        }

        [Route("AddEmployeePage")]
        public ActionResult AddEmployeePage(string id) 
        {
            return View("AddEmployee", id);
        }

        [Route("AddEmployee")]
        [HttpPost]
        public async Task<ActionResult> AddEmployee(string id, List<string> SelectedAgentIds)
        {
            //var payload = new RemoveEmployeesRequestPayload();

            ////foreach (var id in AgentIds)
            ////{
            ////}
            //var result = await LiveChat.ConversationManagementClient.RemoveAsync("", payload);
            return View("Result", "Successfully added employee");
        }

        [Route("RemoveEmployeePage")]
        public ActionResult RemoveEmployeePage(string id)
        {
            var conversationModel = new Conversation()
            {
                Id = "2323",
                IncomingMessage = new Message { From = "+2323", MessageContent = "hello message 2" },
                SelectedAgentIds = new List<string> { "00", "11" }
            };
            return View("RemoveEmployee", conversationModel);
        }

        [Route("RemoveEmployee")]
        [HttpPost]
        public ActionResult RemoveEmployee(string id, List<string> SelectedAgentIds)
        {
            return View("Result", "Employee successfully Removed");
        }
    }
}
