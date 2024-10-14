namespace Inventory.Models
{
    public class WarehouseProduct : Product
    {
        public int? Id { get; set; }

        public string? Location { get; set; }

        public int? PurchaseCost { get; set; }

        public int? FullPriseCost { get; set; }

        public string? Note { get; set; }

    }
}