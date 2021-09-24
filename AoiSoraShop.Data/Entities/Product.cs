using System;
using System.Collections.Generic;
using System.Text;

namespace AoiSoraShop.Data.Entities
{
    public class Product
    {
        public int Id { set; get; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { set; get; }
        public decimal OriginalPrice { set; get; }
        public string Details { get; set; }
        public int Stock { set; get; }
        public string SeoDecription { get; set; }
        public string SeoTitle { get; set; }
        public string SeoAlias { get; set; }
        public int ViewCount { set; get; }
        public DateTime DateCreated { set; get; }

        public bool? IsFeatured { get; set; }

        public List<ProductInCategory> ProductInCategories { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        public List<Cart> Carts { get; set; }
        public List<ProductImage> ProductImages { get; set; }
    }
}
