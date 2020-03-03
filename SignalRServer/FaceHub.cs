using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRServer
{
    public class FaceHub : Hub
    {
        public async Task EnviarPedido(Face face) =>
            await Clients.All.SendAsync("IdentificarFace", face);
    }
}
