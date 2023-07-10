namespace Domain.Domain
{
    public class Movie
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public float Rating { get; set; }
        public string Director { get; set; } = String.Empty;

        public Guid? TicketId { get; set; }
        public virtual Ticket? Ticket { get; set; }
    }
}
