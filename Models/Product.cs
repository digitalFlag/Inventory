namespace Inventory.Models
{
    public class Product : Order
    {
        public string? Tittle { get; set; }

        public string? Property { get; set; }

        public string? Size { get; set; }

        public DateTime? ExpirationDate { get; set; }

    }

}
