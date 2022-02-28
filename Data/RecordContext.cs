using Microsoft.EntityFrameworkCore;
using Moment32.Models;

namespace Moment32.Data {
    public class RecordContext : DbContext {
        
        // Constructor
        public RecordContext(DbContextOptions<RecordContext> options) : base(options) {

        }

        // Set DB Tables
        public DbSet<Record> Records { get; set; }

        public DbSet<Genre> Genres { get; set; }
    }
}