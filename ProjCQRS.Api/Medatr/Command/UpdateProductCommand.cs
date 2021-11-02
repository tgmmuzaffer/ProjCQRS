namespace ProjCQRS.Api.Medatr.Command
{
    using ProjCQRS.Api.Entity;
    using MediatR;

    public class UpdateProductCommand : IRequest<Product>
    {
        public Product Product { get; set; }
    }
}
