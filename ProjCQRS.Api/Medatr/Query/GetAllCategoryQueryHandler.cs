namespace ProjCQRS.Api.Medatr.Query
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using ProjCQRS.Api.Entity;
    using ProjCQRS.Api.RepoCqrs.IRepoCqrs;
    using MediatR;

    public class GetAllCategoryQueryHandler:IRequestHandler<GetAllCategoryQuery, ICollection<Category>>
    {
        private readonly ICategoryRepoCqrs _categoryRepo;
        public GetAllCategoryQueryHandler(ICategoryRepoCqrs categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }

        public async Task<ICollection<Category>> Handle(GetAllCategoryQuery request, CancellationToken cancellationToken)
        {
            return await _categoryRepo.GetListAsync();
        }
    }
}
