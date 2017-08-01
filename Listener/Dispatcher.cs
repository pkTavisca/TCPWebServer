using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace Listener
{
    class Dispatcher
    {
        Queue<Socket> ClientRequestQueue;

        public Dispatcher(Queue<Socket> ClientRequestQueue)
        {
            this.ClientRequestQueue = ClientRequestQueue;
        }

    }
}
