using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRServer
{
    public class FaceHub : Hub
    {
        public async Task EnviarIdade(string idade) =>
            await Clients.All.SendAsync("IdentificarIdade", idade);
    }
}
