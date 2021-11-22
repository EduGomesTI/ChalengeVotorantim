namespace Votorantim.Domain.Aggregates.Transports.Entities
{
    public record Transport : BaseEntity<string>
    {
        public string TicketId { get; set; }
        public string DeviceId { get; set; }
        public string GreetingMessage { get; set; }
        public string LocationMessage { get; set; }
        public string DirectionMessage { get; set; }
    }
}
