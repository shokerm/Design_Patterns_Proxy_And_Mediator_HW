﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Proxy_And_Mediator_HW
{
    internal interface IMember
    {
        void Publish(string message);

        void Receive(string message);
    }
}
