using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace goalsCSMVC.Models
{
    public class goalsCSMVCContext : DbContext
    {
        public goalsCSMVCContext (DbContextOptions<goalsCSMVCContext> options)
            : base(options)
        {
        }

        public DbSet<goalsCSMVC.Models.Moon1> Moon1 { get; set; }
    }
}
