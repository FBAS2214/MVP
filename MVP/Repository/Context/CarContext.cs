using Microsoft.EntityFrameworkCore;
using MVP.Models;

namespace MVP.Repository.Context
{
    public class CarContext : DbContext
    {
        private readonly string _conStr;

        public CarContext(string conStr)
        {
            _conStr = conStr;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_conStr);

            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Car> Cars { get; set; }
    }
}
