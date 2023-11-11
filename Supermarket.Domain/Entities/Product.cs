namespace Supermarket.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal IncomePrice { get; set; }
        public decimal SalePrice { get; set; }
        public DateTime ExpireDate { get; set; }

        public virtual ICollection<ProductCategory> Categories { get; set; }
        public virtual ICollection<SaleItem> SaleItems { get; set; }
    }
}
