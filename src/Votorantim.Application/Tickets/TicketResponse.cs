using Votorantim.Application.Base;

namespace Votorantim.Application.Tickets
{
    public struct TicketResponse : IResponse
    {
        public string Drivername { get; set; }
        public string LicensePlate { get; set; }
        public string DockName { get; set; }
        public DateTime Entrance { get; set; }
    }
}
