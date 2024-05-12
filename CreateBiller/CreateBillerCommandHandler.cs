using Omni;
using Omni.CQRS.Commands;

namespace MedProject.CreateBiller;

public class CreateBillerCommandHandler
    : ICommandHandler<CreateBillerCommand, NewBillerResponse>
{
    public async Task<Result<NewBillerResponse>> Handle(
        CreateBillerCommand request,
        CancellationToken cancellationToken)
    {
        return new NewBillerResponse(Guid.NewGuid());
    }
}
