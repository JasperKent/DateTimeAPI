using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DateTimeAPI.Converters
{
    public class DateOnlyEFConverter : ValueConverter<DateOnly, DateTime>
    {
        public DateOnlyEFConverter() : base(
             d => d.ToDateTime(TimeOnly.MinValue),
             dt => DateOnly.FromDateTime(dt))
        { }
    }
}
