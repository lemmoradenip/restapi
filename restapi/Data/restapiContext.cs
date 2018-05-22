using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace restapi.Models
{
    public class restapiContext : DbContext
    {
        public restapiContext (DbContextOptions<restapiContext> options)
            : base(options)
        {
        }

        public DbSet<restapi.Models.Malls> Malls { get; set; }
    }
}
