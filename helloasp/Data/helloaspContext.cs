using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace helloasp.Models
{
    public class helloaspContext : DbContext
    {
        public helloaspContext (DbContextOptions<helloaspContext> options)
            : base(options)
        {
        }

        public DbSet<helloasp.Models.Movie> Movie { get; set; }
    }
}
