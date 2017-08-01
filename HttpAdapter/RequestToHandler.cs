using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpAdapter
{
    class RequestToHandler : IRequest
    {
        public string Request { get; set; }
    }
}
