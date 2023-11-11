namespace Supermarket.Domain.Entities
{
    public class SupplyItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int SupplyId { get; set; }
        public Supply Supply { get; set; }
    }
}