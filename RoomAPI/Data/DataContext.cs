using Microsoft.EntityFrameworkCore;

namespace RoomAPI.Data
{
    public class DataContext:DbContext
    {
        public DataContext()
        {

        }
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<RoomType> RoomTypes { get; set; }

        public DbSet<Status> Statuses { get; set; }

    }
}
