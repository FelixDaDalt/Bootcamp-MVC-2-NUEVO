using Bootcamp_MVC_2_NUEVO.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Bootcamp_MVC_2_NUEVO.Datos
{
    public class AplicacionDbContext : DbContext
    {
       
            public AplicacionDbContext(DbContextOptions<AplicacionDbContext> options) : base(options)
            {

            }

        public DbSet<Unidades> unidades { get; set; }
        public DbSet<Home> home { get; set; }

    }
}
