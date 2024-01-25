using Microsoft.EntityFrameworkCore;
namespace Test_Laborator_DAW.Data
{
    public class myContext:DbContext
    {
        public myContext(DbContextOptions<myContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           

            base.OnModelCreating(modelBuilder);
        }
    }
}

