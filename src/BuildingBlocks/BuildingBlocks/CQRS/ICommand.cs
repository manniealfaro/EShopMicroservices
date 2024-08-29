using MediatR;

namespace BuildingBlocks.CQRS;

public interface ICommand<out TRespponse> : IRequest<TRespponse> { }

public interface ICommand : ICommand<Unit> { }
