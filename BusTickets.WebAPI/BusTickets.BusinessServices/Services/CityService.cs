﻿using System.Collections.Generic;
using System.Linq;
using BusTickets.BusinessServices.Interfices;
using BusTickets.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace BusTickets.BusinessServices.Services
{
    public class CityService : BaseService, ICityService
    {
        public CityService(IBusTicketDbContext contetx)
            : base(contetx)
        {
        }

        public IList<Ticket> GetCitiseNearby(int cityId)
        {
            return this.Context.CitiesNearbys
                .AsNoTracking()
                .Where(s => s.JourneyID == cityId)
                .ToList();
        }
    }
}
