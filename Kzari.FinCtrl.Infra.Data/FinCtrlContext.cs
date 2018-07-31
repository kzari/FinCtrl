using System;
using Kzari.Finctrl.Domain.Entities;
using Kzari.FinCtrl.Domain;
using Microsoft.EntityFrameworkCore;

namespace Kzari.FinCtrl.Infra.Data
{
    public class FinCtrlContext : DbContext
    {
        public DbSet<Registro> Registros { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=FinCtrl;Trusted_Connection=True;");
        }
    }
}
