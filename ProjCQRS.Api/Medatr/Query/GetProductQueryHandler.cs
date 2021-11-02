using ProjCQRS.Api.Entity;
using ProjCQRS.Api.RepoCqrs.IRepoCqrs;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ProjCQRS.Api.Medatr.Query
{
    public class GetProductQueryHandler : IRequestHandler<GetProductQuery, Product>
    {
        private readonly IProductRepoCqrs _productRepo;
        public GetProductQueryHandler(IProductRepoCqrs productRepo)
        {
            _productRepo = productRepo;
        }
        public async Task<Product> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            return await _productRepo.Get(request.filter);
        }
    } 
}
