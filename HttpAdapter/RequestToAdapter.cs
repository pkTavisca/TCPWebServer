using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpAdapter
{
    class RequestToAdapter
    {
        public string HttpAdapterParseRequest(byte[] urlData)
        {
            return HttpParserAdapter.UrlParser(urlData);
        }
    }
}
