namespace ProjCQRS.Api.Medatr.Command
{
    using System.Threading;
    using System.Threading.Tasks;
    using ProjCQRS.Api.Entity;
    using ProjCQRS.Api.RepoCqrs.IRepoCqrs;
    using MediatR;

    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, bool>
    {
        private readonly IProductRepoCqrs _productRepo;
        public DeleteProductCommandHandler(IProductRepoCqrs productRepo)
        {
            _productRepo = productRepo;
        }
        public async Task<bool> Handle(DeleteProductCommand deleteProductCommand, CancellationToken cancellationToken)
        {
            return await _productRepo.DeleteAsync(deleteProductCommand.Id);
        }
    }
}
