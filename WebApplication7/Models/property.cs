namespace WebApplication7.Models
{
    public class Property
    {
        public int PropertyId { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string ContactNumber { get; set; }
        public int OwnerUserId { get; set; }
        public User OwnerUser { get; set; }
    }
}