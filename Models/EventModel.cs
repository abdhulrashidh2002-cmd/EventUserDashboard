using System.Text.Json.Serialization;
namespace EventUserDashboard.Models;

public class EventModel
{
    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("category")]
    public string Category { get; set; }

    [JsonPropertyName("capacity")]
    public int Capacity { get; set; }

    [JsonPropertyName("date")]
    public DateTime Date { get; set; }

    [JsonPropertyName("location")]
    public string Location { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; }
    [JsonPropertyName("price")]
    public int Price {  get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("imageUrl")]
    public string ImageUrl { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }
}