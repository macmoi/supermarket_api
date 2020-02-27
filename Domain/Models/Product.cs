namespace supermarket_api.Domain.Models
{
    public class Product
    {
        // ID of the Product
        public int Id { get; set; }
        // Name of the product
        public string Name { get; set; }
        // QuantityInPackage: Number of elements that a product can have inside it. IE: a package of oreo's can have 6 or 8 cookies inside
        public short QuantityInPackage { get; set; }
        // Enum type that indicates the Measurement unit of product (UN, KG, LT, ...)
        public EUnitOfMeasurement UnitOfMeasurement { get; set; }

        // Foreign Key used by EF Core ORM to create relationships between Product and Cateogry
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}