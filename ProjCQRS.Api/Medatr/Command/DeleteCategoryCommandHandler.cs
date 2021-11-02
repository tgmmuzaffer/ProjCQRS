namespace ProjCQRS.Api.Medatr.Command
{
    using System.Threading;
    using System.Threading.Tasks;
    using ProjCQRS.Api.Entity;
    using ProjCQRS.Api.RepoCqrs.IRepoCqrs;
    using MediatR;

    public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommand, bool>
    {
        private readonly ICategoryRepoCqrs _categoryRepo;
        public DeleteCategoryCommandHandler(ICategoryRepoCqrs categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }
        public async Task<bool> Handle(DeleteCategoryCommand deleteCategoryCommand, CancellationToken cancellationToken)
        {
            return await _categoryRepo.DeleteAsync(deleteCategoryCommand.Id);
        }

      
    }
}
