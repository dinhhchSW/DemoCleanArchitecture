using MediatR;

namespace Application.Gadgets.Commands
{
    public record UpdateGadgetCommand(int Id, string ProductName, string Brand, decimal Cost, string ImageName, string Type) : IRequest;
}
