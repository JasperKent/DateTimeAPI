namespace DateTimeAPI.Models
{
    public class DataItem
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public DateOnly Date{ get; set; }
        public TimeOnly Time { get; set; }
    }
}
