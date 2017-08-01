using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listener
{
    public class StreamEventArgs : EventArgs
    {
        public byte[] Stream { get; set; }

        public StreamEventArgs(byte[] Stream)
        {
            this.Stream = Stream;
        }

    }
}
