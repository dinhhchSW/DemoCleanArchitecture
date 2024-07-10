//using MediatR;
//using Domain.Repositories;
//using System.Threading;
//using System.Threading.Tasks;

//namespace Application.Gadgets.Commands
//{
//    public class UpdateGadgetCommandHandler : IRequestHandler<UpdateGadgetCommand>
//    {
//        private readonly IGadgetRepository _repository;

//        public UpdateGadgetCommandHandler(IGadgetRepository repository)
//        {
//            _repository = repository;
//        }

//        public async Task<Unit> Handle(UpdateGadgetCommand request, CancellationToken cancellationToken)
//        {
//            var gadget = await _repository.GetByIdAsync(request.Id);
//            if (gadget == null)
//            {
//                throw new Exception("Gadget not found");
//            }

//            gadget.ProductName = request.ProductName;
//            gadget.Brand = request.Brand;
//            gadget.Cost = request.Cost;
//            gadget.ImageName = request.ImageName;
//            gadget.Type = request.Type;
//            gadget.ModifiedDate = DateTime.UtcNow;

//            _repository.Update(gadget);
//            await _repository.SaveChangesAsync();
//            return Unit.Value;
//        }

//        Task IRequestHandler<UpdateGadgetCommand>.Handle(UpdateGadgetCommand request, CancellationToken cancellationToken)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
