namespace ProjCQRS.Api.Medatr.Query
{
    using System.Collections.Generic;
    using ProjCQRS.Api.Entity;
    using MediatR;

    public class GetAllCategoryQuery : IRequest<ICollection<Category>>
    {
    }
}
