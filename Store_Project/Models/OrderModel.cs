﻿namespace Store_Project.Models
{
    public class OrderModel
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string? CustomerName { get; set; }
        public List<Product>? Products { get; set; }
    }
}
