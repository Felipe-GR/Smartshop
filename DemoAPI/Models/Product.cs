using System;
using System.Collections.Generic;

#nullable disable

namespace DemoAPI.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string CardId { get; set; }
        public string ProductName { get; set; }
        public float? ProductPrice { get; set; }
    }
}
