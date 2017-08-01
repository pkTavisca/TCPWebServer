using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpAdapter
{
    interface IHandler
    {
        IHttpResponse ProcessRequest(IRequest request);
    }
}
