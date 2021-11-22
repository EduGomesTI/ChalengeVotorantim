namespace Votorantim.Application.Base
{
    public interface ITransportAppService<TRequest, TResponse>
        where TRequest : IRequest
        where TResponse : IResponse
    {
        Task<TResponse> ShowRoute(TRequest request);
    }
}
