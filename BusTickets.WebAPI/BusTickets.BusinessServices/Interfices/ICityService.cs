﻿using System.Collections.Generic;
using BusTickets.DataAccess;

namespace BusTickets.BusinessServices.Interfices
{
    public interface ICityService
    {
        IList<Ticket> GetCitiseNearby(int cityId);
    }
}