using System;
using System.IO.Pipelines;
using System.Net.Sockets;
using System.Threading.Tasks;
using SuperSocket.Channel;
using SuperSocket.ProtoBase;
using Microsoft.AspNetCore.Server.Kestrel.Transport.Abstractions.Internal;

namespace SuperSocket.Server
{
    internal class ConnectionDispatcher : IConnectionDispatcher
    {
        public Task OnConnection(TransportConnection connection)
        {
            throw new NotImplementedException();
        }
    }
}