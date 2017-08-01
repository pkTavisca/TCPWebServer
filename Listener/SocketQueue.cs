using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace Listener
{
    public class SocketQueue
    {
        public Queue<Socket> ClientRequestQueue { get; set; }
    }
}
