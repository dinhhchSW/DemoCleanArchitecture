//using MediatR;
//using Domain.Entities;
//using Domain.Repositories;
//using System.Threading;
//using System.Threading.Tasks;

//namespace Application.Gadgets.Queries
//{
//    public class GetGadgetQueryHandler : IRequestHandler<GetGadgetQuery, Gadget>
//    {
//        private readonly IGadgetRepository _repository;

//        public GetGadgetQueryHandler(IGadgetRepository repository)
//        {
//            _repository = repository;
//        }

//        public async Task<Gadget> Handle(GetGadgetQuery request, CancellationToken cancellationToken)
//        {
//            var gadget = await _repository.GetByIdAsync(request.Id);
//            if (gadget == null)
//            {
//                throw new Exception("Gadget not found");
//            }

//            return gadget;
//        }
//    }
//}
