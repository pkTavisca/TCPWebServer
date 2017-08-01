using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpAdapter
{
    interface IHttpResponse
    {
        string Status { get; set; }
        string Content { get; set; } //TODO...define a list
        uint Length { get; set; }
        string EntityBody { get; set; } 
    }
}
