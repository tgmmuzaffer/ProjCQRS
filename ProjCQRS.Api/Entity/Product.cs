namespace ProjCQRS.Api.Entity
{
    using ProjCQRS.Api.Entity.EntityBase;

    public class Product:IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public Category Category { get; set; }
    }
}
