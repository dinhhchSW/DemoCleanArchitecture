//using MediatR;
//using Domain.Entities;
//using Domain.Repositories;
//using System.Threading;
//using System.Threading.Tasks;

//namespace Application.Gadgets.Commands
//{
//    public class CreateGadgetCommandHandler : IRequestHandler<CreateGadgetCommand, int>
//    {
//        private readonly IGadgetRepository _repository;

//        public CreateGadgetCommandHandler(IGadgetRepository repository)
//        {
//            _repository = repository;
//        }

//        public async Task<int> Handle(CreateGadgetCommand request, CancellationToken cancellationToken)
//        {
//            var gadget = new Gadget
//            {
//                ProductName = request.ProductName,
//                Brand = request.Brand,
//                Cost = request.Cost,
//                ImageName = request.ImageName,
//                Type = request.Type,
//                CreatedDate = DateTime.UtcNow,
//                ModifiedDate = DateTime.UtcNow
//            };

//            _repository.AddAsync(gadget);
//            await _repository.SaveChangesAsync();
//            return gadget.Id;
//        }
//    }
//}
