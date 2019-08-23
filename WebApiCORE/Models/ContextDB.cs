using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using WebApiCORE.Utils;

namespace WebApiCORE.Models
{
    public class ContextDB : Single<DbContext>
    {
        public DbSet<Usuario> usuarios { get; set; }
    }
}
