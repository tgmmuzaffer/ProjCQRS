using ProjCQRS.Api.Entity;
using ProjCQRS.Api.RepoCqrs.IRepoCqrs;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ProjCQRS.Api.Medatr.Query
{
    public class GetCategoryQueryHandler: IRequestHandler<GetCategoryQuery, Category>
    {
        private readonly ICategoryRepoCqrs _categoryRepo;
        public GetCategoryQueryHandler(ICategoryRepoCqrs categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }
        public async Task<Category> Handle(GetCategoryQuery request, CancellationToken cancellationToken)
        {
            return await _categoryRepo.Get(request.filter);
        }
    } 
}
