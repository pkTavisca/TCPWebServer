using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace Listener
{
    public class ConnectionQueue
    {
        public Queue<Socket> ClientRequestQueue { get; set; }

        public ConnectionQueue()
        {
            ClientRequestQueue = new Queue<Socket>();
        }
    }
}
