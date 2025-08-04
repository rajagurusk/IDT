using IDT.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using IDT.Models; // Replace with your actual namespace

namespace IDT.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
    }
}
