using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace DoubtAPI.Data
{
    public class DoubtAPIContext : DbContext
    {
        public DoubtAPIContext (DbContextOptions<DoubtAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Doubt> Doubt { get; set; } = default!;
    }
}
