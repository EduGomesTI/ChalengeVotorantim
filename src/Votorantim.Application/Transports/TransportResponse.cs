using Votorantim.Application.Base;

namespace Votorantim.Application.Transports
{
    public class TransportResponse : IResponse
    {
        public string GreetingMessage { get; set; }
        public string LocationMessage { get; set; }
        public string DirectionMessage { get; set; }
    }
}
