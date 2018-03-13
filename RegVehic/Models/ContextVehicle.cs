using Microsoft.EntityFrameworkCore;

namespace RegVehic.Models
{
    public class ContextVehicle : DbContext
    {
        public ContextVehicle(DbContextOptions<ContextVehicle> options) : base(options)
        {
        }
        public DbSet<Vehicle> Vehicles { get; set; }

    }
}
