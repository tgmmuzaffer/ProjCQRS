using ProjCQRS.Api.Entity;
using MediatR;
using System;
using System.Linq.Expressions;

namespace ProjCQRS.Api.Medatr.Query
{
    public class GetProductQuery : IRequest<Product>
    {
        public Expression<Func<Product, bool>> filter = null;
    }
}
