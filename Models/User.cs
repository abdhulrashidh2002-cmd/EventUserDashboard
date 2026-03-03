using System.Text.Json.Serialization;

namespace EventUserDashboard.Models
{
    public class User
    {
        [JsonPropertyName("uid")]
        public string Uid { get; set; }

        public string Email { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
    }
}