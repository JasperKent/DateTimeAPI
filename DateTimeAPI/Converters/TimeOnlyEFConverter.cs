using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DateTimeAPI.Converters
{
    public class TimeOnlyEFConverter : ValueConverter<TimeOnly, TimeSpan>
    {
        public TimeOnlyEFConverter() : base(
             t => t.ToTimeSpan(),
             ts => TimeOnly.FromTimeSpan(ts))
        { }
    }
}
