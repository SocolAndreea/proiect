using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using proiect.Models;

namespace proiect.Data
{
    public class proiectContext : DbContext
    {
        public proiectContext (DbContextOptions<proiectContext> options)
            : base(options)
        {
        }

        public DbSet<proiect.Models.Client> Client { get; set; } = default!;

        public DbSet<proiect.Models.Stylist> Stylist { get; set; } = default!;

        public DbSet<proiect.Models.Appointment> Appointment { get; set; } = default!;
    }
}
