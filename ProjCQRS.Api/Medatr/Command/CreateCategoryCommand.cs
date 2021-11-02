namespace ProjCQRS.Api.Medatr.Command
{
    using ProjCQRS.Api.Entity;
    using MediatR;

    public class CreateCategoryCommand: IRequest<Category>
    {
        public Category Category { get; set; }
    }
}
