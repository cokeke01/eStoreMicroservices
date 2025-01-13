using MediatR;


namespace BuildingBlocks.CQRS
{
    public interface ICommand : ICommand<Unit>
    {
    }

    public interface ICommand<out TResponse> : IRequest<TResponse>
    {
    }
}

//the first is for the calls that will not require a response while the next would require a response
