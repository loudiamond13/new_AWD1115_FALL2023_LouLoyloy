
using Microsoft.EntityFrameworkCore;

namespace TripLogs.Models
{
    public class TripLogsContext : DbContext
    {
        // Constructor
        public TripLogsContext(DbContextOptions<TripLogsContext> options) : base(options) { }

        public DbSet<Trip> Trips { get; set; }
    }
}
