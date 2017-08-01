using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using HttpAdapter;

namespace Listener
{
    public class Dispatcher
    {
        private Queue<TcpClient> _socketQueue;

        public Dispatcher(Queue<TcpClient> socketQueue)
        {
            _socketQueue = socketQueue;
        }

        public void Start()
        {
            while (true)
            {
                if (_socketQueue.Count == 0)
                {
                    Task.Delay(100);
                    continue;
                }
                TcpClient client = _socketQueue.Dequeue();
                Task.Run(() =>
                {
                    IWorker worker = new Worker();
                    worker.Start(client);
                });
            }
        }
    }
}
