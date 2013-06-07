using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.AspNet.SignalR.Tests.Common.Connections
{
    public class PreserializedJsonConnection : PersistentConnection
    {
        protected override Task OnConnected(IRequest request, string connectionId)
        {
            var jsonBytes = new ArraySegment<byte>(Encoding.UTF8.GetBytes("{\"preserialized\": true}"));

            Connection.Send(connectionId, jsonBytes);
            return base.OnConnected(request, connectionId);
        }
    }
}
