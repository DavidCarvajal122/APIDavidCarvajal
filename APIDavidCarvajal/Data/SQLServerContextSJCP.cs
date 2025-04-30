using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using APIDavidCarvajal.Models;

    public class SQLServerContextSJCP : DbContext
    {
        public SQLServerContextSJCP (DbContextOptions<SQLServerContextSJCP> options)
            : base(options)
        {
        }

        public DbSet<APIDavidCarvajal.Models.Cliente> Cliente { get; set; } = default!;
    }
