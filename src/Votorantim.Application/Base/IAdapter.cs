namespace Votorantim.Application.Base
{
    internal interface IAdapter<in TResquest, out TResponse, TRecord>
        where TResquest: IRequest
        where TResponse : IResponse
    {
        TRecord Adapt(TResquest request);
        TResponse Adapt(TRecord record);
    }
}
