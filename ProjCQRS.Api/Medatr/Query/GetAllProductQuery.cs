namespace ProjCQRS.Api.Medatr.Query
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using ProjCQRS.Api.Entity;
    using MediatR;

    public class GetAllProductQuery : IRequest<ICollection<Product>>
    {
        public Expression<Func<Product, bool>> filter = null;
    }
}
