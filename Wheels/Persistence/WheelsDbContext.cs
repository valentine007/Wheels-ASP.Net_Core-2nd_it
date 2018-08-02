using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wheels.Models;

namespace Wheels.Persistence
{
    public class WheelsDbContext : DbContext
    {
		public WheelsDbContext(DbContextOptions<WheelsDbContext> options) : base(options)
		{

		}

		public DbSet<Make> Makes { get; set; }
    }
}
