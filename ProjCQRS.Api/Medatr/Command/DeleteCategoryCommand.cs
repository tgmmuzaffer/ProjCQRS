namespace ProjCQRS.Api.Medatr.Command
{
    using ProjCQRS.Api.Entity;
    using MediatR;

    public class DeleteCategoryCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
