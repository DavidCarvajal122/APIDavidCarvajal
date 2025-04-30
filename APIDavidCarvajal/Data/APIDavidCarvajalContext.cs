using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using APIDavidCarvajal.Models;

namespace APIDavidCarvajal.Data
{
    public class APIDavidCarvajalContext : DbContext
    {
        public APIDavidCarvajalContext (DbContextOptions<APIDavidCarvajalContext> options)
            : base(options)
        {
        }

        public DbSet<APIDavidCarvajal.Models.PlanRecompensa> PlanRecompensa { get; set; } = default!;
    }
}
