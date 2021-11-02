namespace ProjCQRS.Api.Entity
{
    using System.Collections.Generic;
    using ProjCQRS.Api.Entity.EntityBase;

    public class Category:IEntity
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public int MinStockquantity { get; set; }
        public List<Product> Products { get; set; }
    }
}
