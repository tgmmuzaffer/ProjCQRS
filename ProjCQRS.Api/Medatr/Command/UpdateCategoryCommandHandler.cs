namespace ProjCQRS.Api.Medatr.Command
{
    using System.Threading;
    using System.Threading.Tasks;
    using ProjCQRS.Api.Entity;
    using ProjCQRS.Api.RepoCqrs.IRepoCqrs;
    using MediatR;

    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand, Category>
    {
        private readonly ICategoryRepoCqrs _categoryRepo;
        public UpdateCategoryCommandHandler(ICategoryRepoCqrs categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }
        public async Task<Category> Handle(UpdateCategoryCommand updateCategoryCommand, CancellationToken cancellationToken)
        {
            return await _categoryRepo.UpdateAsync(updateCategoryCommand.Category);
        }

      
    }
}
