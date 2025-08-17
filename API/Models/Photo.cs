using System.Text.Json.Serialization;

namespace API.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public required string url { get; set; }
        public string? PublicId { get; set; }

        //Navigation property
        [JsonIgnore]
        public Member Member { get; set; } = null!;
        public string MemberId { get; set; } = null!;
    }
}