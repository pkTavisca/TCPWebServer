using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace Listener
{
    class Dispatcher
    {
        public event EventHandler<StreamEventArgs> ClientRequestHandlers;

        Queue<Socket> ClientRequestQueue;

        public Dispatcher(Queue<Socket> ClientRequestQueue)
        {
            this.ClientRequestQueue = ClientRequestQueue;
        }

        public void Start()
        {
            while (true)
            {
                if (ClientRequestQueue.Count == 0)
                {
                    continue;
                }
                byte[] stream = new byte[2048];
                ClientRequestQueue.Dequeue().Receive(stream);
                StreamEventArgs eventArgs = new StreamEventArgs(stream);
                ClientRequestHandlers(this, eventArgs);
            }
        }
    }
}
