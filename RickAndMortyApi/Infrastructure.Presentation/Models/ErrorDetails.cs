using Newtonsoft.Json;

namespace Infrastructure.Presentation.Models
{
    public class ErrorDetails
    {
        public string Status { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
