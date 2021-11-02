namespace ProjCQRS.Api.Medatr.Query
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using ProjCQRS.Api.Entity;
    using ProjCQRS.Api.RepoCqrs.IRepoCqrs;
    using MediatR;

    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, ICollection<Product>>
    {
        private readonly IProductRepoCqrs _productRepo;
        public GetAllProductQueryHandler(IProductRepoCqrs productRepo )
        {
            _productRepo = productRepo;
        }

        public async Task<ICollection<Product>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            return await _productRepo.GetListAsync(request.filter);
        }
    }
}
