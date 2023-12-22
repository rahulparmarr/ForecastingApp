using ForecastingApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace ForecastingApplication.Data
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ForecastModel>  Forecasts { get; set; }
    }
}
