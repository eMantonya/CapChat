using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Microsoft.Azure.WebJobs.Extensions.SignalRService;

namespace CapChatServer
{
    public static class SendMessage
    {
        [FunctionName("sendmessage")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "sendmessage")] HttpRequest req,
            ILogger log, [SignalR(HubName = "ChatHub")] IAsyncCollector<SignalRMessage> message)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            //receive json string of the message sent from Hub then deserialize
            var receivedContent = await new StreamReader(req.Body).ReadToEndAsync();
            var m = JsonConvert.DeserializeObject(receivedContent);
            //send to SignalR
            await message.AddAsync(
                new SignalRMessage
                {
                    Target = "newMessage",
                    Arguments = new[] { m }
                });

            return new OkResult();
        }
    }
}
