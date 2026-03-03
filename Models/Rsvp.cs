using System.Text.Json.Serialization;


namespace EventUserDashboard.Models
{
    public class Rsvp
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("fullName")]
        public string FullName { get; set; }

        [JsonPropertyName("transactionId")]
        public string TransactionId { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("guests")]
        public int Guests { get; set; }

        [JsonPropertyName("paymentMethod")]
        public string PaymentMethod { get; set; }

        [JsonPropertyName("ticketPrice")]
        public int TicketPrice { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("userId")]
        public string UserId { get; set; }

        [JsonPropertyName("registeredAt")]
        public DateTime? RegisteredAt { get; set; }

        [JsonPropertyName("eventId")]
        public string EventId { get; set; }
    }
}