using System;
using System.Net.Sockets;

namespace Listener
{
    public class Listener
    {
        Queue<Socket> ClientRequestQueue;

        public Listener(Queue<Socket> ClientRequestQueue)
        {
            this.ClientRequestQueue = ClientRequestQueue;
        }
    }
}
