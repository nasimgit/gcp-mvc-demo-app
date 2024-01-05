using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using gcp_mvc_demo_app.Models;

namespace gcp_mvc_demo_app.Data
{
    public class gcp_mvc_demo_appContext : DbContext
    {
        public gcp_mvc_demo_appContext (DbContextOptions<gcp_mvc_demo_appContext> options)
            : base(options)
        {
        }

        public DbSet<gcp_mvc_demo_app.Models.Movie> Movie { get; set; } = default!;
    }
}
