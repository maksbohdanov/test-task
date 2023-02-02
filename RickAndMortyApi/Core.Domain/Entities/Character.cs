namespace Core.Domain.Entities
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string Species { get; set; } = string.Empty; 
        public string Type { get; set; } = string.Empty; 
        public string Gender { get; set; } = string.Empty; 
        public Location? Origin { get; set; }
        public List<string> Episode { get; set; } = new List<string>();
    }
}
