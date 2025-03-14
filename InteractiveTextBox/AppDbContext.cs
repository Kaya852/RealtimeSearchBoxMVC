using InteractiveTextBox.Models;
using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;

namespace InteractiveTextBox
{
    public class AppDbContext : DbContext
    {
        public DbSet<Word> Words { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
