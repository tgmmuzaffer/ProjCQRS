namespace ProjCQRS.Api.Medatr.Command
{
    using System.Threading;
    using System.Threading.Tasks;
    using ProjCQRS.Api.Entity;
    using ProjCQRS.Api.RepoCqrs.IRepoCqrs;
    using MediatR;

    public class CreateCategoryCommandHandler:IRequestHandler<CreateCategoryCommand ,Category>
    {
        private readonly ICategoryRepoCqrs _categoryRepo;
        public CreateCategoryCommandHandler(ICategoryRepoCqrs categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }
        public async Task<Category> Handle(CreateCategoryCommand createCategoryCommand, CancellationToken cancellationToken)
        {
            return await _categoryRepo.AddAsync(createCategoryCommand.Category);
        }

      
    }
}
