using DateTimeAPI.Converters;
using Microsoft.EntityFrameworkCore;

namespace DateTimeAPI.Models
{
    public class DateTimeContext : DbContext
    {
        public DateTimeContext(DbContextOptions<DateTimeContext> options)
        : base(options)
        {

        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);

            configurationBuilder.Properties<DateOnly>()
                                .HaveConversion<DateOnlyEFConverter>()
                                .HaveColumnType("date");

            configurationBuilder.Properties<TimeOnly>()
                      .HaveConversion<TimeOnlyEFConverter>()
                      .HaveColumnType("time");
        }

        public DbSet<DataItem> Items { get; set; } = null!;

    }
}
