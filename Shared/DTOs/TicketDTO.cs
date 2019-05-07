﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.DTos
{
    public class TicketDTO
    {
        public int Id { get; set; }

        public double Price { get; set; }

        public int FlightNumber { get; set; }
    }
}
