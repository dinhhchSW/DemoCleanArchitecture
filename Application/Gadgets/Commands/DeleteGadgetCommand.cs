using MediatR;

namespace Application.Gadgets.Commands
{
    public record DeleteGadgetCommand(int Id) : IRequest;
}
