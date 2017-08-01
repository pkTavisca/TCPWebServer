using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpAdapter
{
    interface IRequest
    {
        string path { get; }
    }
}
