using LibraryManager.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManager.Data
{
    public class LibraryManagerContext : DbContext
    {
        public LibraryManagerContext (DbContextOptions<LibraryManagerContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; } = default!;
        public DbSet<AuditTrail> AudsitTrail { get; set; } = default!;
        public DbSet<Borrowing> Borrowings { get; set; } = default!;
        public DbSet<Category> Categories { get; set; } = default!;
        public DbSet<Fine> Fines { get; set; } = default!;
        public DbSet<LibraryMember> LibraryMembers { get; set; } = default!;
        public DbSet<Reservation> Reservations { get; set; } = default!;
        public DbSet<SFine> SFines { get; set; } = default!;
        public DbSet<User> Users { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SFine>()
                .Property(s => s.FineAmount)
                .HasColumnType("decimal(18, 2)"); // Adjust precision and scale according to your needs

            // Your other model configurations...
        }
    }
}
