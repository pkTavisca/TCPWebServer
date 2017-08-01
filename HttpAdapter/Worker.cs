using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace HttpAdapter
{
    public class Worker:IWorker
    {
        public void Start(Socket connection)
        {
            byte[] b= new byte[100];
            connection.Receive(b);
            Console.WriteLine(b.ToString());
        }
    }
}
