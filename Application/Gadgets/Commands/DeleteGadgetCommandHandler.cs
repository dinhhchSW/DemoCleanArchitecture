//using MediatR;
//using Domain.Repositories;
//using System.Threading;
//using System.Threading.Tasks;

//namespace Application.Gadgets.Commands
//{
//    public class DeleteGadgetCommandHandler : IRequestHandler<DeleteGadgetCommand>
//    {
//        private readonly IGadgetRepository _repository;

//        public DeleteGadgetCommandHandler(IGadgetRepository repository)
//        {
//            _repository = repository;
//        }

//        public async Task<Unit> Handle(DeleteGadgetCommand request, CancellationToken cancellationToken)
//        {
//            var gadget = await _repository.GetByIdAsync(request.Id);
//            if (gadget == null)
//            {
//                throw new Exception("Gadget not found");
//            }

//            _repository.Delete(gadget);
//            await _repository.SaveChangesAsync();
//            return Unit.Value;
//        }

//        Task IRequestHandler<DeleteGadgetCommand>.Handle(DeleteGadgetCommand request, CancellationToken cancellationToken)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
