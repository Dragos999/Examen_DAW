using Microsoft.EntityFrameworkCore;
using Test_Laborator_DAW.Models;

namespace Test_Laborator_DAW.Data
{
    public class myContext:DbContext
    {
        public DbSet<Utilizator> Utilizator { get; set; }
        public DbSet<Produs> Produs { get; set; }
        public DbSet<Comanda> Comanda { get; set; }
        public DbSet<ComandaProdus> ComandaProdus { get; set; }
        public myContext(DbContextOptions<myContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //m-m
            modelBuilder.Entity<ComandaProdus>().HasKey(o => new { o.id_comanda, o.id_produs });
            //1-m for m-m
            modelBuilder.Entity<ComandaProdus>()
                      .HasOne(o => o.comanda)
                      .WithMany(c => c.produse)
                      .HasForeignKey(o => o.id_comanda);

            modelBuilder.Entity<ComandaProdus>()
                        .HasOne(o => o.produs)
                        .WithMany(p => p.comenzi)
                        .HasForeignKey(o => o.id_produs);

            //1-m
            modelBuilder.Entity<Utilizator>()
                        .HasMany(d => d.comenzi)
                        .WithOne(c => c.utilizator);

            base.OnModelCreating(modelBuilder);
        }
    }
}

