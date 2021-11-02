namespace ProjCQRS.Api.Medatr.Command
{
    using ProjCQRS.Api.Entity;
    using MediatR;

    public class UpdateCategoryCommand : IRequest<Category>
    {
        public Category Category { get; set; }
    }
}
