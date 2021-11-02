namespace ProjCQRS.Api.Medatr.Command
{
    using System.Threading;
    using System.Threading.Tasks;
    using ProjCQRS.Api.Entity;
    using ProjCQRS.Api.RepoCqrs.IRepoCqrs;
    using MediatR;

    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, Product>
    {
        private readonly IProductRepoCqrs _productRepo;
        public UpdateProductCommandHandler(IProductRepoCqrs productRepo)
        {
            _productRepo = productRepo;
        }
        public async Task<Product> Handle(UpdateProductCommand updateProductCommand, CancellationToken cancellationToken)
        {
            return await _productRepo.UpdateAsync(updateProductCommand.Product);
        }
    }
}
