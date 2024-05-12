using MediatR;
using Omni.CQRS.Commands;

namespace MedProject;

public sealed class CommandPipelineBehavior<TCommand, TResult> :
    IPipelineBehavior<TCommand, TResult> where TCommand : notnull, ICommand
{
    public async Task<TResult> Handle(TCommand request, RequestHandlerDelegate<TResult> next, CancellationToken cancellationToken)
    {
        Console.WriteLine("Initial Caller");

        var result = await next();

        Console.WriteLine("Calling last");

        return result;
    }
}
