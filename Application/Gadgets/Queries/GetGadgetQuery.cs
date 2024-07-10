using Domain.Entities;
using MediatR;

namespace Application.Gadgets.Queries
{
    public record GetGadgetQuery(int Id) : IRequest<Gadget>;
}
