using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;

namespace Listener
{
    public class Listener
    {
        TcpListener listener;

        Queue<TcpClient> ClientRequestQueue;

        public Listener(Queue<TcpClient> ClientRequestQueue)
        {
            this.ClientRequestQueue = ClientRequestQueue;
            IPAddress myIp = GetOwnIPAddress();
            listener = new TcpListener(myIp, 80);
        }

        public void Start()
        {
            listener.Start();
            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                ClientRequestQueue.Enqueue(client);
            }
        }

        public static IPAddress GetOwnIPAddress()
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip;
                }
            }
            return null;
        }
    }
}
