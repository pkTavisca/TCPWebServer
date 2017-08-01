using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;

namespace Listener
{
    public class Listener
    {
        TcpListener listener;

        Queue<Socket> ClientRequestQueue;

        public Listener(Queue<Socket> ClientRequestQueue)
        {
            this.ClientRequestQueue = ClientRequestQueue;
            IPAddress myIp = GetOwnIPAddress();
            listener = new TcpListener(myIp, 80);
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
