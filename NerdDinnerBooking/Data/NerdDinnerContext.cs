using System;
using NerdDinner.Models;
using Microsoft.EntityFrameworkCore;

namespace NerdDinner.Data
{
    public class NerdDinnerContext : DbContext
    {
        public NerdDinnerContext(DbContextOptions<NerdDinnerContext> options)
            : base(options)
        {
        }
        public DbSet<BookDinner> BookDinner { get; set; }
        public DbSet<Rsvp> Rsvp { get; set; }
        public DbSet<LoginViewModel>LoginViewModel { get; set; }
        public DbSet<UserDetails> UserDetails { get; set; }
        public DbSet<RegistrationModel> RegistrationModel { get; set; }
    }
}
