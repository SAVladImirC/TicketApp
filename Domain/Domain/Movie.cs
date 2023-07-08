namespace Domain.Domain
{
#nullable disable
    public class Movie
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public float Rating { get; set; }
        public string Director { get; set; }

        public Guid TicketId { get; set; }
        public virtual Ticket Ticket { get; set; }
    }
}
