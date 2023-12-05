using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Extensions.SignalRService;
using Microsoft.Azure.WebJobs.Host.Bindings;

namespace CapChatServer
{
    public static class SignalRFunc
    {
        [FunctionName("negotiate")]
        public static SignalRConnectionInfo Negotiate(
            [HttpTrigger(AuthorizationLevel.Anonymous, Route = "negotiate")] HttpRequest req,
            [SignalRConnectionInfo(HubName = "ChatHub")] SignalRConnectionInfo connectionInfo)
        {
            //returns a json string with a SignalR Hub URL and accessToken
            return connectionInfo;
        }
    }
}
