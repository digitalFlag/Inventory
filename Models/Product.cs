﻿namespace Inventory.Models
{
    class Product : Order
    {
        public string? Tittle { get; set; }

        public float Price { get; set; }

        public DateOnly ExpirationDate { get; set; }

        public string? Location { get; set; }
    }
}