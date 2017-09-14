﻿using BusTickets.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace BusTickets.DataAccess
{
    public interface IBusTicketDbContext
    {
        DbSet<CityNearby> CitiesNearby { get; set; }
    }
}