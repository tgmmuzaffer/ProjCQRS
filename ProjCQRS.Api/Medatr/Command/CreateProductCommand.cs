namespace ProjCQRS.Api.Medatr.Command
{
    using ProjCQRS.Api.Entity;
    using MediatR;

    public class CreateProductCommand : IRequest<Product>
    {
        public Product Product { get; set; }
    }
}
