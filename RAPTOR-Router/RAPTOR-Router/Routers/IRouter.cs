﻿using RAPTOR_Router.RAPTORStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAPTOR_Router.Routers
{
    internal interface IRouter
    {
        SearchResult FindConnection(string fromStopId, string toStopId, DateTime departureTime);
    }
}
