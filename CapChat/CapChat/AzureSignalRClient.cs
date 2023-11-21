using CapChat;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLibrary;

namespace ClientGUI
{
    public class AzureSignalRClient
    {
        private Profile profile;
        public AzureSignalRClient(Profile _profile)
        {
            profile = _profile;
        }
        private HubConnection connection;
        TaskScheduler uiTask = TaskScheduler.FromCurrentSynchronizationContext();

        public async void Initialize()
        {
            connection = new HubConnectionBuilder().WithUrl("https://capchat.service.signalr.net/", options =>
            {
                options.AccessTokenProvider = () => Task.FromResult("MKDVEG/tWO6VgnHxSmGjIks1riv4BYqwsCkVEoIgERQ=");
            })
            .Build();

            connection.On<string, string>("ReceiveData", (name, msg) =>
            {
                profile.Invoke((Action)(() => profile.chatBox.Items.Add($"{name}: {msg}")));
            });

            try
            {
                await connection.StartAsync();
            }
            catch (Exception ex)
            {
                profile.chatBox.Items.Add(ex.Message);
                profile.chatBox.Items.Add("Please logout and try again.");
            }
        }

        public async void SendData(User user, string message)
        {
            try
            {
                await connection.InvokeAsync("SendData", user.FirstName, message);
            }
            catch (Exception ex)
            {
                profile.chatBox.Items.Add(ex.Message);
            }
            
        }

        public async void Close()
        {
            await connection.StopAsync();
        }
    }
}
