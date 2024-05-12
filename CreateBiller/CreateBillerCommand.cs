using Omni.CQRS.Commands;

namespace MedProject.CreateBiller;

public record CreateBillerCommand()
    : CommandBase<NewBillerResponse>(Guid.NewGuid());

public record NewBillerResponse(Guid BillerId);