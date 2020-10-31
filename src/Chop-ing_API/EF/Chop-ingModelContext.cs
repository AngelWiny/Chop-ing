using Chop_ing_API.EF.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Chop_ing_API.EF
{
    public class Chop_ingModelContext : DbContext
    {
        public Chop_ingModelContext(DbContextOptions<Chop_ingModelContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

        }

        #region DbSets

        public DbSet<Articulo> Articulo { get; set; }

        #endregion
    }
}
