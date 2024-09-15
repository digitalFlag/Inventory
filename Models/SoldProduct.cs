namespace Inventory.Models
{
    public class SoldProduct : Product
    {
        public int? Id { get; set; }

        public int? PurchaseCost { get; set; }

        public int? SoldCost { get; set; }

        public DateTime? SoldDate { get; set; }

        public string? Note { get; set; }

        public int? CustomerId { get; set; }

    }
}
