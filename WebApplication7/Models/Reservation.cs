namespace WebApplication7.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int PropertyId { get; set; }
        public Property Property { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
    }
}
