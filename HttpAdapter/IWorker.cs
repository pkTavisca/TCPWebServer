﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace HttpAdapter
{
    public interface IWorker
    {
        void Start(Socket connection);
    }
}
