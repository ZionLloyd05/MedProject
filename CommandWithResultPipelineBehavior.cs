using MediatR;
using Omni;
using Omni.CQRS.Commands;

namespace MedProject;

public sealed class CommandWithResultPipelineBehavior<TCommand, TResult>
    : IPipelineBehavior<TCommand, Result<TResult>> where TCommand
    : notnull, ICommand<TResult>
{
    public async Task<Result<TResult>> Handle(
        TCommand request,
        RequestHandlerDelegate<Result<TResult>> next,
        CancellationToken cancellationToken)
    {
        Console.WriteLine("Initial Caller");

        var result = await next();

        Console.WriteLine("Calling last");

        return result;
    }
}