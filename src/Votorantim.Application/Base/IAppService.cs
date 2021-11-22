namespace Votorantim.Application.Base
{
    public interface IAppService<TRequest, TResponse> 
        where TRequest : IRequest 
        where TResponse: IResponse
    {
        Task <TResponse> AddAsync(TRequest request);
        Task<TResponse> FIndByIdAsync(string id);
        Task<IList<TResponse>> FindAllAsync();
    }
}
