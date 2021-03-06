﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayerPattern.Presentation
{
    public class TicketPresentation
    {
        public string TicketId { get; set; }
        public string EventId { get; set; }
        public string Description { get; set; }
        public bool WasAbleToPurchaseTicket { get; set; }
    }
}
