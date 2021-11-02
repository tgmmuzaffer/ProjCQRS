namespace ProjCQRS.Api.Medatr.Command
{
    using System.Threading;
    using System.Threading.Tasks;
    using ProjCQRS.Api.Entity;
    using ProjCQRS.Api.RepoCqrs.IRepoCqrs;
    using MediatR;

    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand ,Product>
    {
        private readonly IProductRepoCqrs _productRepo;
        public CreateProductCommandHandler(IProductRepoCqrs productRepo)
        {
            _productRepo = productRepo;
        }
        public async Task<Product> Handle(CreateProductCommand  createProductCommand, CancellationToken cancellationToken)
        {
            return await _productRepo.AddAsync(createProductCommand.Product);
        }
    }
}
