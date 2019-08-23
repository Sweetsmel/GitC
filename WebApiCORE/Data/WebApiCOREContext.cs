using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApiCORE.Models
{
    public class WebApiCOREContext : DbContext
    {
        public WebApiCOREContext (DbContextOptions<WebApiCOREContext> options)
            : base(options)
        {
        }

        public DbSet<WebApiCORE.Models.Usuario> Usuario { get; set; }
    }
}
