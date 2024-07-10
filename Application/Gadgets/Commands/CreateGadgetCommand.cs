using MediatR;

namespace Application.Gadgets.Commands
{
    public record CreateGadgetCommand(string ProductName, string Brand, decimal Cost, string ImageName, string Type) : IRequest<int>;
}
