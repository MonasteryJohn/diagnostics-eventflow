﻿using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTrafficControl.Web
{
    internal interface IOwinAppBuilder
    {
        void Configuration(IAppBuilder appBuilder);
    }
}
