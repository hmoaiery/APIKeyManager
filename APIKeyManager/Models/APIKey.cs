namespace APIKeyManager.Models
{
    public class APIKey
    {
        public Guid Id { get; set; } = Guid.NewGuid(); // Unique identifier
        public string Key { get; set; } = string.Empty; // API Key
        public string Owner { get; set; } = string.Empty; // Owner of the API Key (like Email)
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Creation date
        public DateTime? Expiration { get; set; } // Optional expiration date
        public bool IsActive { get; set; } // Is the API Key active?
    }
}
