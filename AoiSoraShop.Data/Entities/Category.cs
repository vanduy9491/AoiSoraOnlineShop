using AoiSoraShop.Data.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace AoiSoraShop.Data.Entities
{
    public class Category
    {
        public int Id { set; get; }
        public string CategoryName { get; set; }
        public int SortOrder { set; get; }
        public bool IsShowOnHome { set; get; }
        public int? ParentId { set; get; }
        public Status Status { set; get; }
        public string SeoDescription { get; set; }
        public string SeoTitle { get; set; }
        public string SeoAlias { get; set; }

        public List<ProductInCategory> ProductInCategories { get; set; }

    }
}
