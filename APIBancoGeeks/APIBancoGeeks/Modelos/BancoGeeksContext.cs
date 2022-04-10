using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIBancoGeeks.Modelos.Complejos;
using System.Data.SqlClient;

namespace APIBancoGeeks.Modelos
{
    public class BancoGeeksContext : DbContext
    {
        public BancoGeeksContext()
        {
        }

        public BancoGeeksContext(DbContextOptions<BancoGeeksContext> options)
            : base(options)
        {
        }
        public static string GetConnectionString()
        {
            return Startup.BancoGeeksConnectionString;
        }

        
        public virtual DbSet<ValoresSumados_Result> ValoresSumados { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                if (!optionsBuilder.IsConfigured)
                {
                    var con = GetConnectionString();
                    optionsBuilder.UseSqlServer(con);
                }
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}

