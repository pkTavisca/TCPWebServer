using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace HttpAdapter
{
    public class Worker : IWorker
    {
        public void Start(TcpClient client)
        {
            byte[] b = new byte[100];
            var stream = client.GetStream();
            stream.Read(b, 0, b.Length);
            Console.WriteLine(b.ToString());
        }
    }
}
