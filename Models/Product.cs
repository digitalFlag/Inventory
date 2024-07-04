namespace Inventory.Models
{
    public class Product : Order
    {
        public string? Tittle { get; set; }

        public string? Note { get; set; }

        public string? Size { get; set; }

        public DateTime? ExpirationDate { get; set; }

    }

}
