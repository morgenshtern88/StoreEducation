using DataLayer.Enteties;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.AppContext
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser, Role, long>
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PrintingEdition> PrintingEditions { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
                    : base(options)
        {
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<AuthorInPrintingEdition>()
        //        .HasKey(pt => new { pt.AuthorId, pt.PrintingEditionId });

        //    modelBuilder.Entity<AuthorInPrintingEdition>()
        //        .HasOne(pt => pt.Authors)
        //        .WithMany(p => p.AuthorPrintingEditions)
        //        .HasForeignKey(pt => pt.AuthorId);

        //    modelBuilder.Entity<AuthorInPrintingEdition>()
        //        .HasOne(pt => pt.PrintingEditions)
        //        .WithMany(t => t.AuthorInPrintingEditions)
        //        .HasForeignKey(pt => pt.PrintingEditionId);
        //}

       

    }
}
