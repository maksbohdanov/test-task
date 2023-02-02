namespace Core.Domain.Entities
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; } = "unknown";
        public string Type { get; set; } = "unknown";
        public string Dimension { get; set; } = "unknown";
        public string Url { get; set; } = string.Empty;
    }
}
