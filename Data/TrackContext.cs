using Microsoft.EntityFrameworkCore;
using NET_Mom4.Models;

namespace NET_Mom4.Data {
    
    public class TrackContext : DbContext {
        
        public TrackContext(DbContextOptions<TrackContext> options) : base(options) {



        }

        public DbSet<Track> Tracks { get; set; } // Track DB

    }

}