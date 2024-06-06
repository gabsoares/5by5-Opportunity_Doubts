using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace OpportunityApi.Data
{
    public class OpportunityApiContext : DbContext
    {
        public OpportunityApiContext (DbContextOptions<OpportunityApiContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Opportunity> Opportunity { get; set; } = default!;
    }
}
