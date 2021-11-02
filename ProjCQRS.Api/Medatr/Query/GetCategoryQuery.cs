using ProjCQRS.Api.Entity;
using MediatR;
using System;
using System.Linq.Expressions;

namespace ProjCQRS.Api.Medatr.Query
{
    public class GetCategoryQuery : IRequest<Category>
    {
        public Expression<Func<Category, bool>> filter = null;
    }
}
