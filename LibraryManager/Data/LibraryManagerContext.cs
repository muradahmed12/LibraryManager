using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LibraryManager.Models;

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
        public DbSet<User> Users { get; set; } = default!;
    }
}
