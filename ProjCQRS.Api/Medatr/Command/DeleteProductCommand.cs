namespace ProjCQRS.Api.Medatr.Command
{
    using ProjCQRS.Api.Entity;
    using MediatR;

    public class DeleteProductCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
